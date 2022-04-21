using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Globalization;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Newtonsoft.Json;
using System.Net.Http;

namespace ExpressTranslate
{
    public partial class MainForm : Form
    {
        readonly string[] Modes = new string[]
        {
            "EN > ZH",
            "ZH > EN",
            // "ZH > Pinyin"
        };

        /*
        public string Translate(string word, string fromLanguage, string toLanguage)
        {
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)");
            var result = webClient.DownloadString(url);
            return result;
            // [[["你好世界！”","Hello \"world!\"",null,null,10]],null,"en",null,null,null,null,[]]
            //JsonObject obj
        }
        */

        public string TranslateText(string input, string from, string to)
        {
            // Set the language from/to in the url (or pass it into this function)
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
            from, to, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            // Get all json data
            var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);
            // Extract just the first array element (This is the only data we are interested in)
            var translationItems = jsonData[0];
            // Translation Data
            string translation = "";
            // Loop through the collection extracting the translated objects
            foreach (object item in translationItems)
            {
                // Convert the item array to IEnumerable
                var translationLineObject = item as IEnumerable;
                // Convert the IEnumerable translationLineObject to a IEnumerator
                var translationLineString = translationLineObject.GetEnumerator();
                // Get first object in IEnumerator
                translationLineString.MoveNext();
                // Save its value (translated text)
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };
            // Return translation
            return translation;
        }

        private void Speak(string text, string language)
        {
            var synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            var builder = new PromptBuilder();
            builder.StartVoice(new CultureInfo(language));
            builder.AppendText(text);
            builder.EndVoice();
            synth.SpeakAsync(builder);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            modeBox.Items.AddRange(Modes);
            modeBox.SelectedIndex = 0;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {

            string from = "", to = "";

            switch (modeBox.SelectedIndex)
            {
                case 0:
                    from = "en";
                    to = "zh-CN";
                    break;
                case 1:
                    from = "zh";
                    to = "en";
                    break;
                case 2:
                    /*
                    from = "zh";
                    to = "zh-CN";
                    */
                    break;
                default:
                    MessageBox.Show("Invalid mode selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            string result = TranslateText(userInputBox.Text, from, to);

            if (modeBox.SelectedIndex != 2)
                userOutputBox.Text = result;
            else
                userOutputBox.Text = result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userInputBox.Text = "";
            userOutputBox.Text = "";
        }

        private void speakInputButton_Click(object sender, EventArgs e)
        {
            switch (modeBox.SelectedIndex)
            {
                case 0:
                    Speak(userInputBox.Text, "en-GB");
                    break;
                case 1:
                    Speak(userInputBox.Text, "zh-CN");
                    break;
                case 2:
                    Speak(userInputBox.Text, "zh-CN");
                    break;
                default:
                    MessageBox.Show("Invalid mode selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void speakResultButton_Click(object sender, EventArgs e)
        {
            switch (modeBox.SelectedIndex)
            {
                case 0:
                    Speak(userOutputBox.Text, "zh-CN");
                    break;
                case 1:
                    Speak(userOutputBox.Text, "en-GB");
                    break;
                case 2:
                    SystemSounds.Beep.Play();
                    break;
                default:
                    MessageBox.Show("Invalid mode selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(userOutputBox.Text);
        }
    }
}

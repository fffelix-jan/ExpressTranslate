using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace ExpressTranslateWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly string[] Modes = new string[]
        {
            "EN > ZH",
            "ZH > EN",
            // "ZH > Pinyin"
        };

        public ICommand TranslateCommand { get; private set; }
        public ICommand SpeakInputCommand { get; private set; }
        public ICommand SpeakResultCommand { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeCommands();
            Loaded += MainWindow_Loaded;
        }

        private void InitializeCommands()
        {
            // Create commands for keyboard shortcuts
            TranslateCommand = new RelayCommand(param => TranslateButton_Click(this, new RoutedEventArgs()));
            SpeakInputCommand = new RelayCommand(param => SpeakInputButton_Click(this, new RoutedEventArgs()));
            SpeakResultCommand = new RelayCommand(param => SpeakResultButton_Click(this, new RoutedEventArgs()));

            // Set DataContext to self for command binding
            this.DataContext = this;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var mode in Modes)
            {
                modeBox.Items.Add(mode);
            }
            modeBox.SelectedIndex = 0;
        }

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
            if (translation.Length > 1) { translation = translation.Substring(1); }
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

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
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
                    MessageBox.Show("Invalid mode selection!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }

            string result = TranslateText(userInputBox.Text, from, to);

            if (modeBox.SelectedIndex != 2)
                userOutputBox.Text = result;
            else
                userOutputBox.Text = result;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            userInputBox.Text = "";
            userOutputBox.Text = "";
        }

        private void SpeakInputButton_Click(object sender, RoutedEventArgs e)
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
                    MessageBox.Show("Invalid mode selection!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }

        private void SpeakResultButton_Click(object sender, RoutedEventArgs e)
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
                    MessageBox.Show("Invalid mode selection!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(userOutputBox.Text);
        }

        private void TranslateMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TranslateButton_Click(sender, e);
        }

        private void SpeakInputMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SpeakInputButton_Click(sender, e);
        }

        private void SpeakResultMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SpeakResultButton_Click(sender, e);
        }

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ClearButton_Click(sender, e);
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Express Chinese Translator\r\nCopyright © 2022 Félix An\r\nLicensed under the MIT License", "About Express Chinese Translator", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    // Helper class for implementing ICommand
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
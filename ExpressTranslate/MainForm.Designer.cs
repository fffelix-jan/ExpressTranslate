
namespace ExpressTranslate
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.speakInputButton = new System.Windows.Forms.Button();
            this.speakResultButton = new System.Windows.Forms.Button();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.userOutputBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(271, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Express Chinese Translator";
            // 
            // userInputBox
            // 
            this.userInputBox.Location = new System.Drawing.Point(15, 41);
            this.userInputBox.Multiline = true;
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userInputBox.Size = new System.Drawing.Size(695, 184);
            this.userInputBox.TabIndex = 1;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(165, 231);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(92, 25);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // speakInputButton
            // 
            this.speakInputButton.Location = new System.Drawing.Point(380, 231);
            this.speakInputButton.Name = "speakInputButton";
            this.speakInputButton.Size = new System.Drawing.Size(91, 25);
            this.speakInputButton.TabIndex = 3;
            this.speakInputButton.Text = "Speak Input";
            this.speakInputButton.UseVisualStyleBackColor = true;
            this.speakInputButton.Click += new System.EventHandler(this.speakInputButton_Click);
            // 
            // speakResultButton
            // 
            this.speakResultButton.Location = new System.Drawing.Point(477, 231);
            this.speakResultButton.Name = "speakResultButton";
            this.speakResultButton.Size = new System.Drawing.Size(104, 25);
            this.speakResultButton.TabIndex = 4;
            this.speakResultButton.Text = "Speak Result";
            this.speakResultButton.UseVisualStyleBackColor = true;
            this.speakResultButton.Click += new System.EventHandler(this.speakResultButton_Click);
            // 
            // modeBox
            // 
            this.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Location = new System.Drawing.Point(15, 231);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(144, 25);
            this.modeBox.TabIndex = 5;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(587, 231);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(123, 25);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy Translation";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // userOutputBox
            // 
            this.userOutputBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userOutputBox.Location = new System.Drawing.Point(15, 263);
            this.userOutputBox.Multiline = true;
            this.userOutputBox.Name = "userOutputBox";
            this.userOutputBox.ReadOnly = true;
            this.userOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userOutputBox.Size = new System.Drawing.Size(695, 184);
            this.userOutputBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(263, 231);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 25);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 460);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.userOutputBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.speakResultButton);
            this.Controls.Add(this.speakInputButton);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.userInputBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Express Chinese Translator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Button speakInputButton;
        private System.Windows.Forms.Button speakResultButton;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox userOutputBox;
        private System.Windows.Forms.Button clearButton;
    }
}


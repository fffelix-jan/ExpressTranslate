
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.speakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 33);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(271, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Express Chinese Translator";
            // 
            // userInputBox
            // 
            this.userInputBox.Location = new System.Drawing.Point(15, 67);
            this.userInputBox.Multiline = true;
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userInputBox.Size = new System.Drawing.Size(695, 184);
            this.userInputBox.TabIndex = 1;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(165, 257);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(92, 25);
            this.translateButton.TabIndex = 3;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // speakInputButton
            // 
            this.speakInputButton.Location = new System.Drawing.Point(380, 257);
            this.speakInputButton.Name = "speakInputButton";
            this.speakInputButton.Size = new System.Drawing.Size(91, 25);
            this.speakInputButton.TabIndex = 5;
            this.speakInputButton.Text = "Speak Input";
            this.speakInputButton.UseVisualStyleBackColor = true;
            this.speakInputButton.Click += new System.EventHandler(this.speakInputButton_Click);
            // 
            // speakResultButton
            // 
            this.speakResultButton.Location = new System.Drawing.Point(477, 257);
            this.speakResultButton.Name = "speakResultButton";
            this.speakResultButton.Size = new System.Drawing.Size(104, 25);
            this.speakResultButton.TabIndex = 6;
            this.speakResultButton.Text = "Speak Result";
            this.speakResultButton.UseVisualStyleBackColor = true;
            this.speakResultButton.Click += new System.EventHandler(this.speakResultButton_Click);
            // 
            // modeBox
            // 
            this.modeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Location = new System.Drawing.Point(15, 257);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(144, 25);
            this.modeBox.TabIndex = 2;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(587, 257);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(123, 25);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy Translation";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // userOutputBox
            // 
            this.userOutputBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userOutputBox.Location = new System.Drawing.Point(15, 289);
            this.userOutputBox.Multiline = true;
            this.userOutputBox.Name = "userOutputBox";
            this.userOutputBox.ReadOnly = true;
            this.userOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userOutputBox.Size = new System.Drawing.Size(695, 184);
            this.userOutputBox.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(263, 257);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 25);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translateToolStripMenuItem,
            this.speakToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.translateToolStripMenuItem.Text = "Translate";
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.translateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // speakToolStripMenuItem
            // 
            this.speakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speakInputToolStripMenuItem,
            this.speakResultToolStripMenuItem});
            this.speakToolStripMenuItem.Name = "speakToolStripMenuItem";
            this.speakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speakToolStripMenuItem.Text = "Speak";
            // 
            // speakInputToolStripMenuItem
            // 
            this.speakInputToolStripMenuItem.Name = "speakInputToolStripMenuItem";
            this.speakInputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.speakInputToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.speakInputToolStripMenuItem.Text = "Speak Input";
            this.speakInputToolStripMenuItem.Click += new System.EventHandler(this.speakInputToolStripMenuItem_Click);
            // 
            // speakResultToolStripMenuItem
            // 
            this.speakResultToolStripMenuItem.Name = "speakResultToolStripMenuItem";
            this.speakResultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.speakResultToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.speakResultToolStripMenuItem.Text = "Speak Result";
            this.speakResultToolStripMenuItem.Click += new System.EventHandler(this.speakResultToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 485);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.userOutputBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.speakResultButton);
            this.Controls.Add(this.speakInputButton);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.userInputBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Express Chinese Translator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


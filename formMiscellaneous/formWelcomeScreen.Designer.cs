namespace Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous
{
    partial class formWelcomeScreen
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formWelcomeScreen));
            richTextBoxWelcomeScreen_QuickSetup = new RichTextBox();
            labelWelcomeScreen_Header = new Label();
            labelWelcomeScreen_QuickSetupGuide = new Label();
            labelWelcomeScreen_LatestNews = new Label();
            richTextBoxWelcomeScreen_LatestNewst = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxWelcomeScreen_QuickSetup
            // 
            richTextBoxWelcomeScreen_QuickSetup.BackColor = Color.FromArgb(60, 60, 60);
            richTextBoxWelcomeScreen_QuickSetup.BorderStyle = BorderStyle.None;
            richTextBoxWelcomeScreen_QuickSetup.ForeColor = Color.FromArgb(224, 224, 224);
            richTextBoxWelcomeScreen_QuickSetup.Location = new Point(10, 100);
            richTextBoxWelcomeScreen_QuickSetup.Margin = new Padding(0);
            richTextBoxWelcomeScreen_QuickSetup.Name = "richTextBoxWelcomeScreen_QuickSetup";
            richTextBoxWelcomeScreen_QuickSetup.ReadOnly = true;
            richTextBoxWelcomeScreen_QuickSetup.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxWelcomeScreen_QuickSetup.Size = new Size(320, 250);
            richTextBoxWelcomeScreen_QuickSetup.TabIndex = 0;
            richTextBoxWelcomeScreen_QuickSetup.Text = "";
            // 
            // labelWelcomeScreen_Header
            // 
            labelWelcomeScreen_Header.BackColor = Color.Transparent;
            labelWelcomeScreen_Header.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcomeScreen_Header.ForeColor = Color.Chocolate;
            labelWelcomeScreen_Header.Location = new Point(0, 0);
            labelWelcomeScreen_Header.Margin = new Padding(0);
            labelWelcomeScreen_Header.Name = "labelWelcomeScreen_Header";
            labelWelcomeScreen_Header.Size = new Size(680, 50);
            labelWelcomeScreen_Header.TabIndex = 1;
            labelWelcomeScreen_Header.Text = "Welcome to Jivaro's OSRS Bot Manager!";
            labelWelcomeScreen_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcomeScreen_QuickSetupGuide
            // 
            labelWelcomeScreen_QuickSetupGuide.BackColor = Color.Transparent;
            labelWelcomeScreen_QuickSetupGuide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcomeScreen_QuickSetupGuide.ForeColor = Color.FromArgb(224, 224, 224);
            labelWelcomeScreen_QuickSetupGuide.Location = new Point(10, 50);
            labelWelcomeScreen_QuickSetupGuide.Margin = new Padding(0);
            labelWelcomeScreen_QuickSetupGuide.Name = "labelWelcomeScreen_QuickSetupGuide";
            labelWelcomeScreen_QuickSetupGuide.Size = new Size(320, 50);
            labelWelcomeScreen_QuickSetupGuide.TabIndex = 2;
            labelWelcomeScreen_QuickSetupGuide.Text = "Quick Setup Guide";
            labelWelcomeScreen_QuickSetupGuide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcomeScreen_LatestNews
            // 
            labelWelcomeScreen_LatestNews.BackColor = Color.Transparent;
            labelWelcomeScreen_LatestNews.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcomeScreen_LatestNews.ForeColor = Color.FromArgb(224, 224, 224);
            labelWelcomeScreen_LatestNews.Location = new Point(355, 50);
            labelWelcomeScreen_LatestNews.Margin = new Padding(0);
            labelWelcomeScreen_LatestNews.Name = "labelWelcomeScreen_LatestNews";
            labelWelcomeScreen_LatestNews.Size = new Size(320, 50);
            labelWelcomeScreen_LatestNews.TabIndex = 3;
            labelWelcomeScreen_LatestNews.Text = "Latest News";
            labelWelcomeScreen_LatestNews.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxWelcomeScreen_LatestNewst
            // 
            richTextBoxWelcomeScreen_LatestNewst.BackColor = Color.FromArgb(60, 60, 60);
            richTextBoxWelcomeScreen_LatestNewst.BorderStyle = BorderStyle.None;
            richTextBoxWelcomeScreen_LatestNewst.ForeColor = Color.FromArgb(224, 224, 224);
            richTextBoxWelcomeScreen_LatestNewst.Location = new Point(355, 102);
            richTextBoxWelcomeScreen_LatestNewst.Margin = new Padding(0);
            richTextBoxWelcomeScreen_LatestNewst.Name = "richTextBoxWelcomeScreen_LatestNewst";
            richTextBoxWelcomeScreen_LatestNewst.ReadOnly = true;
            richTextBoxWelcomeScreen_LatestNewst.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxWelcomeScreen_LatestNewst.Size = new Size(320, 250);
            richTextBoxWelcomeScreen_LatestNewst.TabIndex = 4;
            richTextBoxWelcomeScreen_LatestNewst.Text = "";
            // 
            // formWelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(684, 361);
            Controls.Add(richTextBoxWelcomeScreen_LatestNewst);
            Controls.Add(labelWelcomeScreen_LatestNews);
            Controls.Add(labelWelcomeScreen_QuickSetupGuide);
            Controls.Add(labelWelcomeScreen_Header);
            Controls.Add(richTextBoxWelcomeScreen_QuickSetup);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(224, 224, 224);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formWelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome Screen";
            TopMost = true;
            Load += formWelcomeScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox richTextBoxWelcomeScreen_QuickSetup;
        public Label labelWelcomeScreen_Header;
        public Label labelWelcomeScreen_QuickSetupGuide;
        public Label labelWelcomeScreen_LatestNews;
        public RichTextBox richTextBoxWelcomeScreen_LatestNewst;
    }
}
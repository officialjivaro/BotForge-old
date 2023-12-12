namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    partial class formScriptProfilesHerbloreCleanHerbs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScriptProfilesHerbloreCleanHerbs));
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel = new TextBox();
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel = new Label();
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping = new CheckBox();
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking = new CheckBox();
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot = new CheckBox();
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern = new CheckBox();
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond = new CheckBox();
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler = new CheckBox();
            labelScriptProfiles_HerbloreCleanHerbs_Title = new Label();
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile = new Button();
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb = new Label();
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb = new ComboBox();
            labelScriptProfiles_HerbloreCleanHerbs_Header = new Label();
            label1 = new Label();
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed = new ComboBox();
            SuspendLayout();
            // 
            // textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel
            // 
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Location = new Point(600, 275);
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Margin = new Padding(0);
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Name = "textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel";
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Size = new Size(40, 22);
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.TabIndex = 210;
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Text = "99";
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // labelScriptProfiles_HerbloreCleanHerbs_StopLevel
            // 
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.AutoSize = true;
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.Location = new Point(450, 275);
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.Margin = new Padding(0);
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.Name = "labelScriptProfiles_HerbloreCleanHerbs_StopLevel";
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.Size = new Size(77, 18);
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.TabIndex = 204;
            labelScriptProfiles_HerbloreCleanHerbs_StopLevel.Text = "Stop Level";
            // 
            // checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping
            // 
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.AutoSize = true;
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.Location = new Point(250, 275);
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.Margin = new Padding(0);
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.Name = "checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping";
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.Size = new Size(126, 22);
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.TabIndex = 194;
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.Text = "World Hopping";
            checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking
            // 
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.AutoSize = true;
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.Location = new Point(250, 125);
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.Margin = new Padding(0);
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.Name = "checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking";
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.Size = new Size(102, 22);
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.TabIndex = 193;
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.Text = "Restocking";
            checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot
            // 
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.AutoSize = true;
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.Location = new Point(250, 200);
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.Margin = new Padding(0);
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.Name = "checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot";
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.Size = new Size(85, 22);
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.TabIndex = 192;
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.Text = "Sell Loot";
            checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern
            // 
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.AutoSize = true;
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.Location = new Point(50, 275);
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.Margin = new Padding(0);
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.Name = "checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern";
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.Size = new Size(96, 22);
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.TabIndex = 191;
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.Text = "Antipattern";
            checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond
            // 
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.AutoSize = true;
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.Location = new Point(50, 200);
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.Margin = new Padding(0);
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.Name = "checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond";
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.Size = new Size(112, 22);
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.TabIndex = 190;
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.Text = "Renew Bond";
            checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler
            // 
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.AutoSize = true;
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.Location = new Point(50, 125);
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.Margin = new Padding(0);
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.Name = "checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler";
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.Size = new Size(121, 22);
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.TabIndex = 189;
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.Text = "Death Handler";
            checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler.UseVisualStyleBackColor = true;
            // 
            // labelScriptProfiles_HerbloreCleanHerbs_Title
            // 
            labelScriptProfiles_HerbloreCleanHerbs_Title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_HerbloreCleanHerbs_Title.Location = new Point(0, 50);
            labelScriptProfiles_HerbloreCleanHerbs_Title.Margin = new Padding(0);
            labelScriptProfiles_HerbloreCleanHerbs_Title.Name = "labelScriptProfiles_HerbloreCleanHerbs_Title";
            labelScriptProfiles_HerbloreCleanHerbs_Title.Size = new Size(780, 25);
            labelScriptProfiles_HerbloreCleanHerbs_Title.TabIndex = 184;
            labelScriptProfiles_HerbloreCleanHerbs_Title.Text = "Herblore: Clean Herbs";
            labelScriptProfiles_HerbloreCleanHerbs_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_HerbloreCleanHerbs_SaveProfile
            // 
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Cursor = Cursors.Hand;
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.ForeColor = Color.FromArgb(64, 64, 64);
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Location = new Point(325, 350);
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Margin = new Padding(0);
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Name = "btnScriptProfiles_HerbloreCleanHerbs_SaveProfile";
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Size = new Size(125, 50);
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.TabIndex = 182;
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Text = "Save Profile";
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.UseVisualStyleBackColor = true;
            btnScriptProfiles_HerbloreCleanHerbs_SaveProfile.Click += btnScriptProfiles_HerbloreCleanHerbs_SaveButton_Click;
            // 
            // labelScriptProfiles_HerbloreCleanHerbs_SelectHerb
            // 
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.AutoSize = true;
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.Location = new Point(450, 125);
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.Margin = new Padding(0);
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.Name = "labelScriptProfiles_HerbloreCleanHerbs_SelectHerb";
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.Size = new Size(85, 18);
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.TabIndex = 253;
            labelScriptProfiles_HerbloreCleanHerbs_SelectHerb.Text = "Select Herb";
            // 
            // comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb
            // 
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.AutoCompleteCustomSource.AddRange(new string[] { "Progressive", "Chickens", "Giant Frogs", "Hill Giants", "Sand Crabs", "Chaos Druids", "Undead Druids" });
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.FlatStyle = FlatStyle.Flat;
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.FormattingEnabled = true;
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.Items.AddRange(new object[] { "Progressive", "GuamLeaf", "Marrentill", "Tarromin", "Harralander", "RanarrWeed", "Toadflax", "IritLeaf", "Avantoe", "Kwuarm", "Snapdragon", "Cadantine", "Lantadyme", "DwarfWeed", "Torstol" });
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.Location = new Point(600, 125);
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.Margin = new Padding(0);
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.Name = "comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb";
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.Size = new Size(150, 26);
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.TabIndex = 254;
            // 
            // labelScriptProfiles_HerbloreCleanHerbs_Header
            // 
            labelScriptProfiles_HerbloreCleanHerbs_Header.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScriptProfiles_HerbloreCleanHerbs_Header.Location = new Point(0, 0);
            labelScriptProfiles_HerbloreCleanHerbs_Header.Margin = new Padding(0);
            labelScriptProfiles_HerbloreCleanHerbs_Header.Name = "labelScriptProfiles_HerbloreCleanHerbs_Header";
            labelScriptProfiles_HerbloreCleanHerbs_Header.Size = new Size(780, 50);
            labelScriptProfiles_HerbloreCleanHerbs_Header.TabIndex = 255;
            labelScriptProfiles_HerbloreCleanHerbs_Header.Text = "Script Profiles";
            labelScriptProfiles_HerbloreCleanHerbs_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(450, 200);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 256;
            label1.Text = "Cleaning Speed";
            // 
            // comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed
            // 
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.AutoCompleteCustomSource.AddRange(new string[] { "Random", "Slow", "Fast" });
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.FlatStyle = FlatStyle.Flat;
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.FormattingEnabled = true;
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.Items.AddRange(new object[] { "Progressive", "Gnome", "Draynor", "Varrock", "Falador", "Seers", "Fremennik", "Ardougne" });
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.Location = new Point(600, 192);
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.Margin = new Padding(0);
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.Name = "comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed";
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.Size = new Size(150, 26);
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.TabIndex = 257;
            // 
            // formScriptProfilesHerbloreCleanHerbs
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(784, 436);
            Controls.Add(comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed);
            Controls.Add(label1);
            Controls.Add(labelScriptProfiles_HerbloreCleanHerbs_Header);
            Controls.Add(comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb);
            Controls.Add(labelScriptProfiles_HerbloreCleanHerbs_SelectHerb);
            Controls.Add(textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel);
            Controls.Add(labelScriptProfiles_HerbloreCleanHerbs_StopLevel);
            Controls.Add(checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping);
            Controls.Add(checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking);
            Controls.Add(checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot);
            Controls.Add(checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern);
            Controls.Add(checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond);
            Controls.Add(checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler);
            Controls.Add(labelScriptProfiles_HerbloreCleanHerbs_Title);
            Controls.Add(btnScriptProfiles_HerbloreCleanHerbs_SaveProfile);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formScriptProfilesHerbloreCleanHerbs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Script Profiles: Herblore - Clean Herbs";
            Load += formScriptProfiles_HerbloreCleanHerbs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel;
        public Label labelScriptProfiles_HerbloreCleanHerbs_StopLevel;
        public CheckBox checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping;
        public CheckBox checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking;
        public CheckBox checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot;
        public CheckBox checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern;
        public CheckBox checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond;
        public CheckBox checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler;
        public Label labelScriptProfiles_HerbloreCleanHerbs_Title;
        public Button btnScriptProfiles_HerbloreCleanHerbs_SaveProfile;
        public Label labelScriptProfiles_HerbloreCleanHerbs_SelectHerb;
        public ComboBox comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb;
        public Label labelScriptProfiles_HerbloreCleanHerbs_Header;
        public Label label1;
        public ComboBox comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed;
    }
}
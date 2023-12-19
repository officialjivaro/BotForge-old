namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    partial class formScriptProfilesPrayerGildedAltar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScriptProfilesPrayerGildedAltar));
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel = new TextBox();
            labelScriptProfiles_PrayerGildedAltar_TrainAgility = new Label();
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping = new CheckBox();
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking = new CheckBox();
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot = new CheckBox();
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern = new CheckBox();
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond = new CheckBox();
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler = new CheckBox();
            labelScriptProfiles_PrayerGildedAltar_Title = new Label();
            btnScriptProfiles_PrayerGildedAltar_SaveProfile = new Button();
            labelScriptProfiles_PrayerGildedAltar_SelectOrb = new Label();
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone = new ComboBox();
            labelScriptProfiles_PrayerGildedAltar_Header = new Label();
            SuspendLayout();
            // 
            // textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel
            // 
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Location = new Point(600, 200);
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Margin = new Padding(0);
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Name = "textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel";
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Size = new Size(40, 22);
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.TabIndex = 210;
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Text = "99";
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // labelScriptProfiles_PrayerGildedAltar_TrainAgility
            // 
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.AutoSize = true;
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.Location = new Point(450, 200);
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.Margin = new Padding(0);
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.Name = "labelScriptProfiles_PrayerGildedAltar_TrainAgility";
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.Size = new Size(124, 18);
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.TabIndex = 204;
            labelScriptProfiles_PrayerGildedAltar_TrainAgility.Text = "Prayer Stop Level";
            // 
            // checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping
            // 
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.AutoSize = true;
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.Location = new Point(250, 225);
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.Margin = new Padding(0);
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.Name = "checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping";
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.Size = new Size(126, 22);
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.TabIndex = 194;
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.Text = "World Hopping";
            checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_PrayerGildedAltar_Restocking
            // 
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.AutoSize = true;
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.Location = new Point(250, 125);
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.Margin = new Padding(0);
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.Name = "checkBoxScriptProfiles_PrayerGildedAltar_Restocking";
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.Size = new Size(102, 22);
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.TabIndex = 193;
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.Text = "Restocking";
            checkBoxScriptProfiles_PrayerGildedAltar_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_PrayerGildedAltar_SellLoot
            // 
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.AutoSize = true;
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.Location = new Point(250, 175);
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.Margin = new Padding(0);
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.Name = "checkBoxScriptProfiles_PrayerGildedAltar_SellLoot";
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.Size = new Size(85, 22);
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.TabIndex = 192;
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.Text = "Sell Loot";
            checkBoxScriptProfiles_PrayerGildedAltar_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_PrayerGildedAltar_Antipattern
            // 
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.AutoSize = true;
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.Location = new Point(50, 225);
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.Margin = new Padding(0);
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.Name = "checkBoxScriptProfiles_PrayerGildedAltar_Antipattern";
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.Size = new Size(96, 22);
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.TabIndex = 191;
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.Text = "Antipattern";
            checkBoxScriptProfiles_PrayerGildedAltar_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_PrayerGildedAltar_RenewBond
            // 
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.AutoSize = true;
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.Location = new Point(50, 175);
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.Margin = new Padding(0);
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.Name = "checkBoxScriptProfiles_PrayerGildedAltar_RenewBond";
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.Size = new Size(112, 22);
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.TabIndex = 190;
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.Text = "Renew Bond";
            checkBoxScriptProfiles_PrayerGildedAltar_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler
            // 
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.AutoSize = true;
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.Location = new Point(50, 125);
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.Margin = new Padding(0);
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.Name = "checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler";
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.Size = new Size(121, 22);
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.TabIndex = 189;
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.Text = "Death Handler";
            checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler.UseVisualStyleBackColor = true;
            // 
            // labelScriptProfiles_PrayerGildedAltar_Title
            // 
            labelScriptProfiles_PrayerGildedAltar_Title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_PrayerGildedAltar_Title.Location = new Point(0, 50);
            labelScriptProfiles_PrayerGildedAltar_Title.Margin = new Padding(0);
            labelScriptProfiles_PrayerGildedAltar_Title.Name = "labelScriptProfiles_PrayerGildedAltar_Title";
            labelScriptProfiles_PrayerGildedAltar_Title.Size = new Size(780, 25);
            labelScriptProfiles_PrayerGildedAltar_Title.TabIndex = 184;
            labelScriptProfiles_PrayerGildedAltar_Title.Text = "Prayer: Gilded Altar";
            labelScriptProfiles_PrayerGildedAltar_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_PrayerGildedAltar_SaveProfile
            // 
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Cursor = Cursors.Hand;
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.ForeColor = Color.FromArgb(64, 64, 64);
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Location = new Point(330, 300);
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Margin = new Padding(0);
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Name = "btnScriptProfiles_PrayerGildedAltar_SaveProfile";
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Size = new Size(125, 50);
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.TabIndex = 182;
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Text = "Save Profile";
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.UseVisualStyleBackColor = true;
            btnScriptProfiles_PrayerGildedAltar_SaveProfile.Click += btnScriptProfiles_PrayerGildedAltar_SaveButton_Click;
            // 
            // labelScriptProfiles_PrayerGildedAltar_SelectOrb
            // 
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.AutoSize = true;
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.Location = new Point(450, 125);
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.Margin = new Padding(0);
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.Name = "labelScriptProfiles_PrayerGildedAltar_SelectOrb";
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.Size = new Size(88, 18);
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.TabIndex = 253;
            labelScriptProfiles_PrayerGildedAltar_SelectOrb.Text = "Select Bone";
            // 
            // comboBoxScriptProfiles_PrayerGildedAltar_SelectBone
            // 
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.AutoCompleteCustomSource.AddRange(new string[] { "BigBones", "DragonBones", "LavaDragonBones", "SuperiorDragonBones" });
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.FlatStyle = FlatStyle.Flat;
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.FormattingEnabled = true;
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.Items.AddRange(new object[] { "BigBones", "DragonBones", "LavaDragonBones", "SuperiorDragonBones" });
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.Location = new Point(550, 125);
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.Margin = new Padding(0);
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.Name = "comboBoxScriptProfiles_PrayerGildedAltar_SelectBone";
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.Size = new Size(150, 26);
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.TabIndex = 254;
            // 
            // labelScriptProfiles_PrayerGildedAltar_Header
            // 
            labelScriptProfiles_PrayerGildedAltar_Header.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScriptProfiles_PrayerGildedAltar_Header.Location = new Point(0, 0);
            labelScriptProfiles_PrayerGildedAltar_Header.Margin = new Padding(0);
            labelScriptProfiles_PrayerGildedAltar_Header.Name = "labelScriptProfiles_PrayerGildedAltar_Header";
            labelScriptProfiles_PrayerGildedAltar_Header.Size = new Size(780, 50);
            labelScriptProfiles_PrayerGildedAltar_Header.TabIndex = 255;
            labelScriptProfiles_PrayerGildedAltar_Header.Text = "Script Profiles";
            labelScriptProfiles_PrayerGildedAltar_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formScriptProfilesPrayerGildedAltar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(784, 386);
            Controls.Add(labelScriptProfiles_PrayerGildedAltar_Header);
            Controls.Add(comboBoxScriptProfiles_PrayerGildedAltar_SelectBone);
            Controls.Add(labelScriptProfiles_PrayerGildedAltar_SelectOrb);
            Controls.Add(textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel);
            Controls.Add(labelScriptProfiles_PrayerGildedAltar_TrainAgility);
            Controls.Add(checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping);
            Controls.Add(checkBoxScriptProfiles_PrayerGildedAltar_Restocking);
            Controls.Add(checkBoxScriptProfiles_PrayerGildedAltar_SellLoot);
            Controls.Add(checkBoxScriptProfiles_PrayerGildedAltar_Antipattern);
            Controls.Add(checkBoxScriptProfiles_PrayerGildedAltar_RenewBond);
            Controls.Add(checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler);
            Controls.Add(labelScriptProfiles_PrayerGildedAltar_Title);
            Controls.Add(btnScriptProfiles_PrayerGildedAltar_SaveProfile);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formScriptProfilesPrayerGildedAltar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Script Profiles: Prayer - Gilded Altar";
            Load += formScriptProfiles_PrayerGildedAltar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel;
        public Label labelScriptProfiles_PrayerGildedAltar_TrainAgility;
        public CheckBox checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping;
        public CheckBox checkBoxScriptProfiles_PrayerGildedAltar_Restocking;
        public CheckBox checkBoxScriptProfiles_PrayerGildedAltar_SellLoot;
        public CheckBox checkBoxScriptProfiles_PrayerGildedAltar_Antipattern;
        public CheckBox checkBoxScriptProfiles_PrayerGildedAltar_RenewBond;
        public CheckBox checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler;
        public Label labelScriptProfiles_PrayerGildedAltar_Title;
        public Button btnScriptProfiles_PrayerGildedAltar_SaveProfile;
        public Label labelScriptProfiles_PrayerGildedAltar_SelectOrb;
        public ComboBox comboBoxScriptProfiles_PrayerGildedAltar_SelectBone;
        public Label labelScriptProfiles_PrayerGildedAltar_Header;
    }
}
namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    partial class formScriptProfilesFarmingTitheFarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScriptProfilesFarmingTitheFarm));
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel = new TextBox();
            labelScriptProfiles_FarmingTitheFarm_StopLevel = new Label();
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping = new CheckBox();
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking = new CheckBox();
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot = new CheckBox();
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern = new CheckBox();
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond = new CheckBox();
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler = new CheckBox();
            labelScriptProfiles_FarmingTitheFarm_Title = new Label();
            btnScriptProfiles_FarmingTitheFarm_SaveProfile = new Button();
            labelScriptProfiles_FarmingTitheFarm_Header = new Label();
            SuspendLayout();
            // 
            // textBoxScriptProfiles_FarmingTitheFarm_StopLevel
            // 
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.BackColor = Color.FromArgb(224, 224, 224);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Location = new Point(150, 225);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Margin = new Padding(0);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Name = "textBoxScriptProfiles_FarmingTitheFarm_StopLevel";
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Size = new Size(40, 22);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.TabIndex = 210;
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Text = "99";
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // labelScriptProfiles_FarmingTitheFarm_StopLevel
            // 
            labelScriptProfiles_FarmingTitheFarm_StopLevel.AutoSize = true;
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Location = new Point(50, 225);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Margin = new Padding(0);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Name = "labelScriptProfiles_FarmingTitheFarm_StopLevel";
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Size = new Size(77, 18);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.TabIndex = 204;
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Text = "Stop Level";
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Location = new Point(400, 175);
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Margin = new Padding(0);
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Name = "checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping";
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Size = new Size(126, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.TabIndex = 194;
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Text = "World Hopping";
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_Restocking
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Location = new Point(225, 125);
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Margin = new Padding(0);
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Name = "checkBoxScriptProfiles_FarmingTitheFarm_Restocking";
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Size = new Size(102, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.TabIndex = 193;
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Text = "Restocking";
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_SellLoot
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Location = new Point(225, 175);
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Margin = new Padding(0);
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Name = "checkBoxScriptProfiles_FarmingTitheFarm_SellLoot";
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Size = new Size(85, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.TabIndex = 192;
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Text = "Sell Loot";
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_Antipattern
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Location = new Point(400, 125);
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Margin = new Padding(0);
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Name = "checkBoxScriptProfiles_FarmingTitheFarm_Antipattern";
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Size = new Size(96, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.TabIndex = 191;
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Text = "Antipattern";
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_RenewBond
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Location = new Point(50, 175);
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Margin = new Padding(0);
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Name = "checkBoxScriptProfiles_FarmingTitheFarm_RenewBond";
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Size = new Size(112, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.TabIndex = 190;
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Text = "Renew Bond";
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.Location = new Point(50, 125);
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.Margin = new Padding(0);
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.Name = "checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler";
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.Size = new Size(121, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.TabIndex = 189;
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.Text = "Death Handler";
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.UseVisualStyleBackColor = true;
            // 
            // labelScriptProfiles_FarmingTitheFarm_Title
            // 
            labelScriptProfiles_FarmingTitheFarm_Title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_FarmingTitheFarm_Title.Location = new Point(0, 50);
            labelScriptProfiles_FarmingTitheFarm_Title.Margin = new Padding(0);
            labelScriptProfiles_FarmingTitheFarm_Title.Name = "labelScriptProfiles_FarmingTitheFarm_Title";
            labelScriptProfiles_FarmingTitheFarm_Title.Size = new Size(555, 25);
            labelScriptProfiles_FarmingTitheFarm_Title.TabIndex = 184;
            labelScriptProfiles_FarmingTitheFarm_Title.Text = "Farming: Tithe Farm";
            labelScriptProfiles_FarmingTitheFarm_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_FarmingTitheFarm_SaveProfile
            // 
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Cursor = Cursors.Hand;
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.ForeColor = Color.FromArgb(64, 64, 64);
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Location = new Point(215, 275);
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Margin = new Padding(0);
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Name = "btnScriptProfiles_FarmingTitheFarm_SaveProfile";
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Size = new Size(125, 50);
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.TabIndex = 182;
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Text = "Save Profile";
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.UseVisualStyleBackColor = true;
            btnScriptProfiles_FarmingTitheFarm_SaveProfile.Click += btnScriptProfiles_FarmingTitheFarm_SaveButton_Click;
            // 
            // labelScriptProfiles_FarmingTitheFarm_Header
            // 
            labelScriptProfiles_FarmingTitheFarm_Header.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScriptProfiles_FarmingTitheFarm_Header.Location = new Point(0, 0);
            labelScriptProfiles_FarmingTitheFarm_Header.Margin = new Padding(0);
            labelScriptProfiles_FarmingTitheFarm_Header.Name = "labelScriptProfiles_FarmingTitheFarm_Header";
            labelScriptProfiles_FarmingTitheFarm_Header.Size = new Size(555, 50);
            labelScriptProfiles_FarmingTitheFarm_Header.TabIndex = 255;
            labelScriptProfiles_FarmingTitheFarm_Header.Text = "Script Profiles";
            labelScriptProfiles_FarmingTitheFarm_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formScriptProfilesFarmingTitheFarm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(559, 361);
            Controls.Add(labelScriptProfiles_FarmingTitheFarm_Header);
            Controls.Add(textBoxScriptProfiles_FarmingTitheFarm_StopLevel);
            Controls.Add(labelScriptProfiles_FarmingTitheFarm_StopLevel);
            Controls.Add(checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping);
            Controls.Add(checkBoxScriptProfiles_FarmingTitheFarm_Restocking);
            Controls.Add(checkBoxScriptProfiles_FarmingTitheFarm_SellLoot);
            Controls.Add(checkBoxScriptProfiles_FarmingTitheFarm_Antipattern);
            Controls.Add(checkBoxScriptProfiles_FarmingTitheFarm_RenewBond);
            Controls.Add(checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler);
            Controls.Add(labelScriptProfiles_FarmingTitheFarm_Title);
            Controls.Add(btnScriptProfiles_FarmingTitheFarm_SaveProfile);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formScriptProfilesFarmingTitheFarm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Script Profiles: Farming - Tithe Farm";
            Load += formScriptProfiles_FarmingTitheFarm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxScriptProfiles_FarmingTitheFarm_StopLevel;
        public Label labelScriptProfiles_FarmingTitheFarm_StopLevel;
        public CheckBox checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping;
        public CheckBox checkBoxScriptProfiles_FarmingTitheFarm_Restocking;
        public CheckBox checkBoxScriptProfiles_FarmingTitheFarm_SellLoot;
        public CheckBox checkBoxScriptProfiles_FarmingTitheFarm_Antipattern;
        public CheckBox checkBoxScriptProfiles_FarmingTitheFarm_RenewBond;
        public CheckBox checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler;
        public Label labelScriptProfiles_FarmingTitheFarm_Title;
        public Button btnScriptProfiles_FarmingTitheFarm_SaveProfile;
        public Label labelScriptProfiles_FarmingTitheFarm_Header;
    }
}
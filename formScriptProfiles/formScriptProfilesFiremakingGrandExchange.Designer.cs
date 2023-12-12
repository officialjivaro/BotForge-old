namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    partial class formScriptProfilesFiremakingGrandExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScriptProfilesFiremakingGrandExchange));
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel = new TextBox();
            labelScriptProfiles_FiremakingGrandExchange_StopLevel = new Label();
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping = new CheckBox();
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking = new CheckBox();
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot = new CheckBox();
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern = new CheckBox();
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond = new CheckBox();
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler = new CheckBox();
            labelScriptProfiles_FiremakingGrandExchange_Title = new Label();
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile = new Button();
            labelScriptProfiles_FiremakingGrandExchange_Header = new Label();
            SuspendLayout();
            // 
            // textBoxScriptProfiles_FiremakingGrandExchange_StopLevel
            // 
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Location = new Point(400, 222);
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Margin = new Padding(0);
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Name = "textBoxScriptProfiles_FiremakingGrandExchange_StopLevel";
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Size = new Size(40, 22);
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.TabIndex = 206;
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Text = "99";
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_FiremakingGrandExchange_StopLevel.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // labelScriptProfiles_FiremakingGrandExchange_StopLevel
            // 
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.AutoSize = true;
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.Location = new Point(300, 225);
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.Margin = new Padding(0);
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.Name = "labelScriptProfiles_FiremakingGrandExchange_StopLevel";
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.Size = new Size(77, 18);
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.TabIndex = 200;
            labelScriptProfiles_FiremakingGrandExchange_StopLevel.Text = "Stop Level";
            // 
            // checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping
            // 
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.AutoSize = true;
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.Location = new Point(50, 275);
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.Margin = new Padding(0);
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.Name = "checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping";
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.Size = new Size(126, 22);
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.TabIndex = 190;
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.Text = "World Hopping";
            checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FiremakingGrandExchange_Restocking
            // 
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.AutoSize = true;
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.Location = new Point(300, 125);
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.Margin = new Padding(0);
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.Name = "checkBoxScriptProfiles_FiremakingGrandExchange_Restocking";
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.Size = new Size(102, 22);
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.TabIndex = 189;
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.Text = "Restocking";
            checkBoxScriptProfiles_FiremakingGrandExchange_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot
            // 
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.AutoSize = true;
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.Location = new Point(300, 175);
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.Margin = new Padding(0);
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.Name = "checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot";
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.Size = new Size(85, 22);
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.TabIndex = 188;
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.Text = "Sell Loot";
            checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern
            // 
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.AutoSize = true;
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.Location = new Point(50, 225);
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.Margin = new Padding(0);
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.Name = "checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern";
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.Size = new Size(96, 22);
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.TabIndex = 187;
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.Text = "Antipattern";
            checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond
            // 
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.AutoSize = true;
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.Location = new Point(50, 175);
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.Margin = new Padding(0);
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.Name = "checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond";
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.Size = new Size(112, 22);
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.TabIndex = 186;
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.Text = "Renew Bond";
            checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler
            // 
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.AutoSize = true;
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.Location = new Point(50, 125);
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.Margin = new Padding(0);
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.Name = "checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler";
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.Size = new Size(121, 22);
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.TabIndex = 185;
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.Text = "Death Handler";
            checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler.UseVisualStyleBackColor = true;
            // 
            // labelScriptProfiles_FiremakingGrandExchange_Title
            // 
            labelScriptProfiles_FiremakingGrandExchange_Title.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_FiremakingGrandExchange_Title.Location = new Point(0, 50);
            labelScriptProfiles_FiremakingGrandExchange_Title.Margin = new Padding(0);
            labelScriptProfiles_FiremakingGrandExchange_Title.Name = "labelScriptProfiles_FiremakingGrandExchange_Title";
            labelScriptProfiles_FiremakingGrandExchange_Title.Size = new Size(480, 25);
            labelScriptProfiles_FiremakingGrandExchange_Title.TabIndex = 180;
            labelScriptProfiles_FiremakingGrandExchange_Title.Text = "Firemaking: Grand Exchange";
            labelScriptProfiles_FiremakingGrandExchange_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_FiremakingGrandExchange_SaveProfile
            // 
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Cursor = Cursors.Hand;
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.ForeColor = Color.FromArgb(64, 64, 64);
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Location = new Point(180, 325);
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Margin = new Padding(0);
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Name = "btnScriptProfiles_FiremakingGrandExchange_SaveProfile";
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Size = new Size(125, 50);
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.TabIndex = 178;
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Text = "Save Profile";
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.UseVisualStyleBackColor = true;
            btnScriptProfiles_FiremakingGrandExchange_SaveProfile.Click += btnScriptProfiles_FiremakingGrandExchange_SaveButton_Click;
            // 
            // labelScriptProfiles_FiremakingGrandExchange_Header
            // 
            labelScriptProfiles_FiremakingGrandExchange_Header.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScriptProfiles_FiremakingGrandExchange_Header.Location = new Point(0, 0);
            labelScriptProfiles_FiremakingGrandExchange_Header.Margin = new Padding(0);
            labelScriptProfiles_FiremakingGrandExchange_Header.Name = "labelScriptProfiles_FiremakingGrandExchange_Header";
            labelScriptProfiles_FiremakingGrandExchange_Header.Size = new Size(480, 50);
            labelScriptProfiles_FiremakingGrandExchange_Header.TabIndex = 235;
            labelScriptProfiles_FiremakingGrandExchange_Header.Text = "Script Profiles";
            labelScriptProfiles_FiremakingGrandExchange_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formScriptProfilesFiremakingGrandExchange
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(484, 411);
            Controls.Add(labelScriptProfiles_FiremakingGrandExchange_Header);
            Controls.Add(textBoxScriptProfiles_FiremakingGrandExchange_StopLevel);
            Controls.Add(labelScriptProfiles_FiremakingGrandExchange_StopLevel);
            Controls.Add(checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping);
            Controls.Add(checkBoxScriptProfiles_FiremakingGrandExchange_Restocking);
            Controls.Add(checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot);
            Controls.Add(checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern);
            Controls.Add(checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond);
            Controls.Add(checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler);
            Controls.Add(labelScriptProfiles_FiremakingGrandExchange_Title);
            Controls.Add(btnScriptProfiles_FiremakingGrandExchange_SaveProfile);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formScriptProfilesFiremakingGrandExchange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Script Profiles: Firemaking - Grand Exchange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label labelScriptProfiles_FiremakingGrandExchange_Header;
        public Label labelScriptProfiles_FiremakingGrandExchange_Title;
        public TextBox textBoxScriptProfiles_FiremakingGrandExchange_StopLevel;
        public Label labelScriptProfiles_FiremakingGrandExchange_StopLevel;
        public CheckBox checkBoxScriptProfiles_FiremakingGrandExchange_WorldHopping;
        public CheckBox checkBoxScriptProfiles_FiremakingGrandExchange_Restocking;
        public CheckBox checkBoxScriptProfiles_FiremakingGrandExchange_SellLoot;
        public CheckBox checkBoxScriptProfiles_FiremakingGrandExchange_Antipattern;
        public CheckBox checkBoxScriptProfiles_FiremakingGrandExchange_RenewBond;
        public CheckBox checkBoxScriptProfiles_FiremakingGrandExchange_DeathHandler;
        public Button btnScriptProfiles_FiremakingGrandExchange_SaveProfile;
    }
}
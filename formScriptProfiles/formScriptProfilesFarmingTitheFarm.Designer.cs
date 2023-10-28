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
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles = new Button();
            labelScriptProfiles_FarmingTitheFarm_Header = new Label();
            SuspendLayout();
            // 
            // textBoxScriptProfiles_FarmingTitheFarm_StopLevel
            // 
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Location = new Point(350, 375);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Name = "textBoxScriptProfiles_FarmingTitheFarm_StopLevel";
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Size = new Size(50, 22);
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.TabIndex = 210;
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Text = "99";
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_FarmingTitheFarm_StopLevel.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // labelScriptProfiles_FarmingTitheFarm_StopLevel
            // 
            labelScriptProfiles_FarmingTitheFarm_StopLevel.AutoSize = true;
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Location = new Point(250, 375);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Name = "labelScriptProfiles_FarmingTitheFarm_StopLevel";
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Size = new Size(77, 18);
            labelScriptProfiles_FarmingTitheFarm_StopLevel.TabIndex = 204;
            labelScriptProfiles_FarmingTitheFarm_StopLevel.Text = "Stop Level";
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Location = new Point(650, 300);
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Name = "checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping";
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Size = new Size(126, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.TabIndex = 194;
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.Text = "World Hopping";
            checkBoxScriptProfiles_FarmingTitheFarm_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_Restocking
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Location = new Point(450, 225);
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Name = "checkBoxScriptProfiles_FarmingTitheFarm_Restocking";
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Size = new Size(102, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.TabIndex = 193;
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.Text = "Restocking";
            checkBoxScriptProfiles_FarmingTitheFarm_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_SellLoot
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Location = new Point(450, 300);
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Name = "checkBoxScriptProfiles_FarmingTitheFarm_SellLoot";
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Size = new Size(85, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.TabIndex = 192;
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.Text = "Sell Loot";
            checkBoxScriptProfiles_FarmingTitheFarm_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_Antipattern
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Location = new Point(650, 225);
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Name = "checkBoxScriptProfiles_FarmingTitheFarm_Antipattern";
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Size = new Size(96, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.TabIndex = 191;
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.Text = "Antipattern";
            checkBoxScriptProfiles_FarmingTitheFarm_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_RenewBond
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Location = new Point(250, 300);
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Name = "checkBoxScriptProfiles_FarmingTitheFarm_RenewBond";
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Size = new Size(112, 22);
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.TabIndex = 190;
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.Text = "Renew Bond";
            checkBoxScriptProfiles_FarmingTitheFarm_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler
            // 
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.AutoSize = true;
            checkBoxScriptProfiles_FarmingTitheFarm_DeathHandler.Location = new Point(250, 225);
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
            labelScriptProfiles_FarmingTitheFarm_Title.Name = "labelScriptProfiles_FarmingTitheFarm_Title";
            labelScriptProfiles_FarmingTitheFarm_Title.Size = new Size(1015, 25);
            labelScriptProfiles_FarmingTitheFarm_Title.TabIndex = 184;
            labelScriptProfiles_FarmingTitheFarm_Title.Text = "Farming: Tithe Farm";
            labelScriptProfiles_FarmingTitheFarm_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_FarmingTitheFarm_SaveToProfiles
            // 
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.BackgroundImageLayout = ImageLayout.Stretch;
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Cursor = Cursors.Hand;
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.ForeColor = Color.FromArgb(64, 64, 64);
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Location = new Point(450, 550);
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Name = "btnScriptProfiles_FarmingTitheFarm_SaveToProfiles";
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Size = new Size(120, 68);
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.TabIndex = 182;
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Text = "Save to Profiles";
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.UseVisualStyleBackColor = true;
            btnScriptProfiles_FarmingTitheFarm_SaveToProfiles.Click += btnScriptProfiles_FarmingTitheFarm_SaveButton_Click;
            // 
            // labelScriptProfiles_FarmingTitheFarm_Header
            // 
            labelScriptProfiles_FarmingTitheFarm_Header.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScriptProfiles_FarmingTitheFarm_Header.Location = new Point(0, 0);
            labelScriptProfiles_FarmingTitheFarm_Header.Name = "labelScriptProfiles_FarmingTitheFarm_Header";
            labelScriptProfiles_FarmingTitheFarm_Header.Size = new Size(1015, 50);
            labelScriptProfiles_FarmingTitheFarm_Header.TabIndex = 255;
            labelScriptProfiles_FarmingTitheFarm_Header.Text = "Script Profiles";
            labelScriptProfiles_FarmingTitheFarm_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formScriptProfilesFarmingTitheFarm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1014, 641);
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
            Controls.Add(btnScriptProfiles_FarmingTitheFarm_SaveToProfiles);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formScriptProfilesFarmingTitheFarm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formScriptProfilesFarmingTitheFarm";
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
        public Button btnScriptProfiles_FarmingTitheFarm_SaveToProfiles;
        public Label labelScriptProfiles_FarmingTitheFarm_Header;
    }
}
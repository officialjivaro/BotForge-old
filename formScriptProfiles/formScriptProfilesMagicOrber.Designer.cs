namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    partial class formScriptProfilesMagicOrber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScriptProfilesMagicOrber));
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape = new System.Windows.Forms.CheckBox();
            this.textBoxScriptProfiles_MagicOrber_TrainAgility = new System.Windows.Forms.TextBox();
            this.textBoxScriptProfiles_MagicOrber_TrainMelee = new System.Windows.Forms.TextBox();
            this.labelScriptProfiles_MagicOrber_TrainMelee = new System.Windows.Forms.Label();
            this.labelScriptProfiles_MagicOrber_TrainAgility = new System.Windows.Forms.Label();
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptProfiles_MagicOrber_Restocking = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptProfiles_MagicOrber_SellLoot = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptProfiles_MagicOrber_Antipattern = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptProfiles_MagicOrber_RenewBond = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler = new System.Windows.Forms.CheckBox();
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas = new System.Windows.Forms.CheckBox();
            this.labelScriptProfiles_MagicOrber_Title = new System.Windows.Forms.Label();
            this.btnScriptProfiles_MagicOrber_SaveToProfiles = new System.Windows.Forms.Button();
            this.labelScriptProfiles_MagicOrber_SelectOrb = new System.Windows.Forms.Label();
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb = new System.Windows.Forms.ComboBox();
            this.labelScriptProfiles_MagicOrber_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxScriptProfiles_MagicOrber_UseRandomCape
            // 
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.Location = new System.Drawing.Point(375, 375);
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.Name = "checkBoxScriptProfiles_MagicOrber_UseRandomCape";
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.Size = new System.Drawing.Size(154, 22);
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.TabIndex = 251;
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.Text = "Use Random Cape";
            this.checkBoxScriptProfiles_MagicOrber_UseRandomCape.UseVisualStyleBackColor = true;
            // 
            // textBoxScriptProfiles_MagicOrber_TrainAgility
            // 
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.Location = new System.Drawing.Point(700, 275);
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.Name = "textBoxScriptProfiles_MagicOrber_TrainAgility";
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.Size = new System.Drawing.Size(30, 22);
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.TabIndex = 210;
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.Text = "1";
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress);
            this.textBoxScriptProfiles_MagicOrber_TrainAgility.Validating += new System.ComponentModel.CancelEventHandler(this.GlobalMethod_RequireInput_Validating);
            // 
            // textBoxScriptProfiles_MagicOrber_TrainMelee
            // 
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.Location = new System.Drawing.Point(700, 325);
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.Name = "textBoxScriptProfiles_MagicOrber_TrainMelee";
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.Size = new System.Drawing.Size(30, 22);
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.TabIndex = 209;
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.Text = "1";
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress);
            this.textBoxScriptProfiles_MagicOrber_TrainMelee.Validating += new System.ComponentModel.CancelEventHandler(this.GlobalMethod_RequireInput_Validating);
            // 
            // labelScriptProfiles_MagicOrber_TrainMelee
            // 
            this.labelScriptProfiles_MagicOrber_TrainMelee.AutoSize = true;
            this.labelScriptProfiles_MagicOrber_TrainMelee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelScriptProfiles_MagicOrber_TrainMelee.Location = new System.Drawing.Point(600, 325);
            this.labelScriptProfiles_MagicOrber_TrainMelee.Name = "labelScriptProfiles_MagicOrber_TrainMelee";
            this.labelScriptProfiles_MagicOrber_TrainMelee.Size = new System.Drawing.Size(85, 18);
            this.labelScriptProfiles_MagicOrber_TrainMelee.TabIndex = 205;
            this.labelScriptProfiles_MagicOrber_TrainMelee.Text = "Train Melee";
            // 
            // labelScriptProfiles_MagicOrber_TrainAgility
            // 
            this.labelScriptProfiles_MagicOrber_TrainAgility.AutoSize = true;
            this.labelScriptProfiles_MagicOrber_TrainAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelScriptProfiles_MagicOrber_TrainAgility.Location = new System.Drawing.Point(600, 275);
            this.labelScriptProfiles_MagicOrber_TrainAgility.Name = "labelScriptProfiles_MagicOrber_TrainAgility";
            this.labelScriptProfiles_MagicOrber_TrainAgility.Size = new System.Drawing.Size(82, 18);
            this.labelScriptProfiles_MagicOrber_TrainAgility.TabIndex = 204;
            this.labelScriptProfiles_MagicOrber_TrainAgility.Text = "Train Agility";
            // 
            // checkBoxScriptProfiles_MagicOrber_WorldHopping
            // 
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.Location = new System.Drawing.Point(175, 375);
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.Name = "checkBoxScriptProfiles_MagicOrber_WorldHopping";
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.Size = new System.Drawing.Size(126, 22);
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.TabIndex = 194;
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.Text = "World Hopping";
            this.checkBoxScriptProfiles_MagicOrber_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_Restocking
            // 
            this.checkBoxScriptProfiles_MagicOrber_Restocking.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_Restocking.Location = new System.Drawing.Point(375, 225);
            this.checkBoxScriptProfiles_MagicOrber_Restocking.Name = "checkBoxScriptProfiles_MagicOrber_Restocking";
            this.checkBoxScriptProfiles_MagicOrber_Restocking.Size = new System.Drawing.Size(102, 22);
            this.checkBoxScriptProfiles_MagicOrber_Restocking.TabIndex = 193;
            this.checkBoxScriptProfiles_MagicOrber_Restocking.Text = "Restocking";
            this.checkBoxScriptProfiles_MagicOrber_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_SellLoot
            // 
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.Location = new System.Drawing.Point(375, 275);
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.Name = "checkBoxScriptProfiles_MagicOrber_SellLoot";
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.Size = new System.Drawing.Size(85, 22);
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.TabIndex = 192;
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.Text = "Sell Loot";
            this.checkBoxScriptProfiles_MagicOrber_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_Antipattern
            // 
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.Location = new System.Drawing.Point(175, 325);
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.Name = "checkBoxScriptProfiles_MagicOrber_Antipattern";
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.Size = new System.Drawing.Size(96, 22);
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.TabIndex = 191;
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.Text = "Antipattern";
            this.checkBoxScriptProfiles_MagicOrber_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_RenewBond
            // 
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.Location = new System.Drawing.Point(175, 275);
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.Name = "checkBoxScriptProfiles_MagicOrber_RenewBond";
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.Size = new System.Drawing.Size(112, 22);
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.TabIndex = 190;
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.Text = "Renew Bond";
            this.checkBoxScriptProfiles_MagicOrber_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_DeathHandler
            // 
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.Location = new System.Drawing.Point(175, 225);
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.Name = "checkBoxScriptProfiles_MagicOrber_DeathHandler";
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.Size = new System.Drawing.Size(121, 22);
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.TabIndex = 189;
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.Text = "Death Handler";
            this.checkBoxScriptProfiles_MagicOrber_DeathHandler.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_UseStaminas
            // 
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.AutoSize = true;
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.Location = new System.Drawing.Point(375, 325);
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.Name = "checkBoxScriptProfiles_MagicOrber_UseStaminas";
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.Size = new System.Drawing.Size(159, 22);
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.TabIndex = 186;
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.Text = "Use Stamina Potion";
            this.checkBoxScriptProfiles_MagicOrber_UseStaminas.UseVisualStyleBackColor = true;
            // 
            // labelScriptProfiles_MagicOrber_Title
            // 
            this.labelScriptProfiles_MagicOrber_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScriptProfiles_MagicOrber_Title.Location = new System.Drawing.Point(0, 50);
            this.labelScriptProfiles_MagicOrber_Title.Name = "labelScriptProfiles_MagicOrber_Title";
            this.labelScriptProfiles_MagicOrber_Title.Size = new System.Drawing.Size(1015, 25);
            this.labelScriptProfiles_MagicOrber_Title.TabIndex = 184;
            this.labelScriptProfiles_MagicOrber_Title.Text = "Magic: Orber";
            this.labelScriptProfiles_MagicOrber_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_MagicOrber_SaveToProfiles
            // 
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Location = new System.Drawing.Point(450, 550);
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Name = "btnScriptProfiles_MagicOrber_SaveToProfiles";
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Size = new System.Drawing.Size(120, 68);
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.TabIndex = 182;
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Text = "Save to Profiles";
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.UseVisualStyleBackColor = true;
            this.btnScriptProfiles_MagicOrber_SaveToProfiles.Click += new System.EventHandler(this.btnScriptProfiles_MagicOrber_SaveButton_Click);
            // 
            // labelScriptProfiles_MagicOrber_SelectOrb
            // 
            this.labelScriptProfiles_MagicOrber_SelectOrb.AutoSize = true;
            this.labelScriptProfiles_MagicOrber_SelectOrb.Location = new System.Drawing.Point(600, 225);
            this.labelScriptProfiles_MagicOrber_SelectOrb.Name = "labelScriptProfiles_MagicOrber_SelectOrb";
            this.labelScriptProfiles_MagicOrber_SelectOrb.Size = new System.Drawing.Size(78, 18);
            this.labelScriptProfiles_MagicOrber_SelectOrb.TabIndex = 253;
            this.labelScriptProfiles_MagicOrber_SelectOrb.Text = "Select Orb";
            // 
            // comboBoxScriptProfiles_MagicOrber_SelectOrb
            // 
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.AutoCompleteCustomSource.AddRange(new string[] {
            "Progressive",
            "Chickens",
            "Giant Frogs",
            "Hill Giants",
            "Sand Crabs",
            "Chaos Druids",
            "Undead Druids"});
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.FormattingEnabled = true;
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.Items.AddRange(new object[] {
            "Earth",
            "Air"});
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.Location = new System.Drawing.Point(700, 225);
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.Name = "comboBoxScriptProfiles_MagicOrber_SelectOrb";
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.Size = new System.Drawing.Size(150, 26);
            this.comboBoxScriptProfiles_MagicOrber_SelectOrb.TabIndex = 254;
            // 
            // labelScriptProfiles_MagicOrber_Header
            // 
            this.labelScriptProfiles_MagicOrber_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelScriptProfiles_MagicOrber_Header.Location = new System.Drawing.Point(0, 0);
            this.labelScriptProfiles_MagicOrber_Header.Name = "labelScriptProfiles_MagicOrber_Header";
            this.labelScriptProfiles_MagicOrber_Header.Size = new System.Drawing.Size(1015, 50);
            this.labelScriptProfiles_MagicOrber_Header.TabIndex = 255;
            this.labelScriptProfiles_MagicOrber_Header.Text = "Script Profiles";
            this.labelScriptProfiles_MagicOrber_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formScriptProfilesMagicOrber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.labelScriptProfiles_MagicOrber_Header);
            this.Controls.Add(this.comboBoxScriptProfiles_MagicOrber_SelectOrb);
            this.Controls.Add(this.labelScriptProfiles_MagicOrber_SelectOrb);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_UseRandomCape);
            this.Controls.Add(this.textBoxScriptProfiles_MagicOrber_TrainAgility);
            this.Controls.Add(this.textBoxScriptProfiles_MagicOrber_TrainMelee);
            this.Controls.Add(this.labelScriptProfiles_MagicOrber_TrainMelee);
            this.Controls.Add(this.labelScriptProfiles_MagicOrber_TrainAgility);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_WorldHopping);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_Restocking);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_SellLoot);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_Antipattern);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_RenewBond);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_DeathHandler);
            this.Controls.Add(this.checkBoxScriptProfiles_MagicOrber_UseStaminas);
            this.Controls.Add(this.labelScriptProfiles_MagicOrber_Title);
            this.Controls.Add(this.btnScriptProfiles_MagicOrber_SaveToProfiles);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formScriptProfilesMagicOrber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formScriptProfilesMagicOrber";
            this.Load += new System.EventHandler(this.formScriptProfiles_MagicOrber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CheckBox checkBoxScriptProfiles_MagicOrber_UseRandomCape;
        public TextBox textBoxScriptProfiles_MagicOrber_TrainAgility;
        public TextBox textBoxScriptProfiles_MagicOrber_TrainMelee;
        public Label labelScriptProfiles_MagicOrber_TrainMelee;
        public Label labelScriptProfiles_MagicOrber_TrainAgility;
        public CheckBox checkBoxScriptProfiles_MagicOrber_WorldHopping;
        public CheckBox checkBoxScriptProfiles_MagicOrber_Restocking;
        public CheckBox checkBoxScriptProfiles_MagicOrber_SellLoot;
        public CheckBox checkBoxScriptProfiles_MagicOrber_Antipattern;
        public CheckBox checkBoxScriptProfiles_MagicOrber_RenewBond;
        public CheckBox checkBoxScriptProfiles_MagicOrber_DeathHandler;
        public CheckBox checkBoxScriptProfiles_MagicOrber_UseStaminas;
        public Label labelScriptProfiles_MagicOrber_Title;
        public Button btnScriptProfiles_MagicOrber_SaveToProfiles;
        public Label labelScriptProfiles_MagicOrber_SelectOrb;
        public ComboBox comboBoxScriptProfiles_MagicOrber_SelectOrb;
        public Label labelScriptProfiles_MagicOrber_Header;
    }
}
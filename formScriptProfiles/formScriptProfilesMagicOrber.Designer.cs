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
            checkBoxScriptProfiles_MagicOrber_UseRandomCape = new CheckBox();
            textBoxScriptProfiles_MagicOrber_TrainAgility = new TextBox();
            textBoxScriptProfiles_MagicOrber_TrainMelee = new TextBox();
            labelScriptProfiles_MagicOrber_TrainMelee = new Label();
            labelScriptProfiles_MagicOrber_TrainAgility = new Label();
            checkBoxScriptProfiles_MagicOrber_WorldHopping = new CheckBox();
            checkBoxScriptProfiles_MagicOrber_Restocking = new CheckBox();
            checkBoxScriptProfiles_MagicOrber_SellLoot = new CheckBox();
            checkBoxScriptProfiles_MagicOrber_Antipattern = new CheckBox();
            checkBoxScriptProfiles_MagicOrber_RenewBond = new CheckBox();
            checkBoxScriptProfiles_MagicOrber_DeathHandler = new CheckBox();
            checkBoxScriptProfiles_MagicOrber_UseStaminas = new CheckBox();
            labelScriptProfiles_MagicOrber_Title = new Label();
            btnScriptProfiles_MagicOrber_SaveToProfiles = new Button();
            labelScriptProfiles_MagicOrber_SelectOrb = new Label();
            comboBoxScriptProfiles_MagicOrber_SelectOrb = new ComboBox();
            labelScriptProfiles_MagicOrber_Header = new Label();
            SuspendLayout();
            // 
            // checkBoxScriptProfiles_MagicOrber_UseRandomCape
            // 
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.Location = new Point(250, 275);
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.Name = "checkBoxScriptProfiles_MagicOrber_UseRandomCape";
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.Size = new Size(154, 22);
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.TabIndex = 251;
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.Text = "Use Random Cape";
            checkBoxScriptProfiles_MagicOrber_UseRandomCape.UseVisualStyleBackColor = true;
            // 
            // textBoxScriptProfiles_MagicOrber_TrainAgility
            // 
            textBoxScriptProfiles_MagicOrber_TrainAgility.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_MagicOrber_TrainAgility.Location = new Point(575, 175);
            textBoxScriptProfiles_MagicOrber_TrainAgility.Margin = new Padding(0);
            textBoxScriptProfiles_MagicOrber_TrainAgility.Name = "textBoxScriptProfiles_MagicOrber_TrainAgility";
            textBoxScriptProfiles_MagicOrber_TrainAgility.Size = new Size(40, 22);
            textBoxScriptProfiles_MagicOrber_TrainAgility.TabIndex = 210;
            textBoxScriptProfiles_MagicOrber_TrainAgility.Text = "1";
            textBoxScriptProfiles_MagicOrber_TrainAgility.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_MagicOrber_TrainAgility.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxScriptProfiles_MagicOrber_TrainMelee
            // 
            textBoxScriptProfiles_MagicOrber_TrainMelee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxScriptProfiles_MagicOrber_TrainMelee.Location = new Point(575, 225);
            textBoxScriptProfiles_MagicOrber_TrainMelee.Margin = new Padding(0);
            textBoxScriptProfiles_MagicOrber_TrainMelee.Name = "textBoxScriptProfiles_MagicOrber_TrainMelee";
            textBoxScriptProfiles_MagicOrber_TrainMelee.Size = new Size(40, 22);
            textBoxScriptProfiles_MagicOrber_TrainMelee.TabIndex = 209;
            textBoxScriptProfiles_MagicOrber_TrainMelee.Text = "1";
            textBoxScriptProfiles_MagicOrber_TrainMelee.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxScriptProfiles_MagicOrber_TrainMelee.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // labelScriptProfiles_MagicOrber_TrainMelee
            // 
            labelScriptProfiles_MagicOrber_TrainMelee.AutoSize = true;
            labelScriptProfiles_MagicOrber_TrainMelee.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_MagicOrber_TrainMelee.Location = new Point(475, 225);
            labelScriptProfiles_MagicOrber_TrainMelee.Margin = new Padding(0);
            labelScriptProfiles_MagicOrber_TrainMelee.Name = "labelScriptProfiles_MagicOrber_TrainMelee";
            labelScriptProfiles_MagicOrber_TrainMelee.Size = new Size(85, 18);
            labelScriptProfiles_MagicOrber_TrainMelee.TabIndex = 205;
            labelScriptProfiles_MagicOrber_TrainMelee.Text = "Train Melee";
            // 
            // labelScriptProfiles_MagicOrber_TrainAgility
            // 
            labelScriptProfiles_MagicOrber_TrainAgility.AutoSize = true;
            labelScriptProfiles_MagicOrber_TrainAgility.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_MagicOrber_TrainAgility.Location = new Point(475, 175);
            labelScriptProfiles_MagicOrber_TrainAgility.Margin = new Padding(0);
            labelScriptProfiles_MagicOrber_TrainAgility.Name = "labelScriptProfiles_MagicOrber_TrainAgility";
            labelScriptProfiles_MagicOrber_TrainAgility.Size = new Size(82, 18);
            labelScriptProfiles_MagicOrber_TrainAgility.TabIndex = 204;
            labelScriptProfiles_MagicOrber_TrainAgility.Text = "Train Agility";
            // 
            // checkBoxScriptProfiles_MagicOrber_WorldHopping
            // 
            checkBoxScriptProfiles_MagicOrber_WorldHopping.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_WorldHopping.Location = new Point(50, 275);
            checkBoxScriptProfiles_MagicOrber_WorldHopping.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_WorldHopping.Name = "checkBoxScriptProfiles_MagicOrber_WorldHopping";
            checkBoxScriptProfiles_MagicOrber_WorldHopping.Size = new Size(126, 22);
            checkBoxScriptProfiles_MagicOrber_WorldHopping.TabIndex = 194;
            checkBoxScriptProfiles_MagicOrber_WorldHopping.Text = "World Hopping";
            checkBoxScriptProfiles_MagicOrber_WorldHopping.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_Restocking
            // 
            checkBoxScriptProfiles_MagicOrber_Restocking.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_Restocking.Location = new Point(250, 125);
            checkBoxScriptProfiles_MagicOrber_Restocking.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_Restocking.Name = "checkBoxScriptProfiles_MagicOrber_Restocking";
            checkBoxScriptProfiles_MagicOrber_Restocking.Size = new Size(102, 22);
            checkBoxScriptProfiles_MagicOrber_Restocking.TabIndex = 193;
            checkBoxScriptProfiles_MagicOrber_Restocking.Text = "Restocking";
            checkBoxScriptProfiles_MagicOrber_Restocking.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_SellLoot
            // 
            checkBoxScriptProfiles_MagicOrber_SellLoot.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_SellLoot.Location = new Point(250, 175);
            checkBoxScriptProfiles_MagicOrber_SellLoot.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_SellLoot.Name = "checkBoxScriptProfiles_MagicOrber_SellLoot";
            checkBoxScriptProfiles_MagicOrber_SellLoot.Size = new Size(85, 22);
            checkBoxScriptProfiles_MagicOrber_SellLoot.TabIndex = 192;
            checkBoxScriptProfiles_MagicOrber_SellLoot.Text = "Sell Loot";
            checkBoxScriptProfiles_MagicOrber_SellLoot.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_Antipattern
            // 
            checkBoxScriptProfiles_MagicOrber_Antipattern.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_Antipattern.Location = new Point(50, 225);
            checkBoxScriptProfiles_MagicOrber_Antipattern.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_Antipattern.Name = "checkBoxScriptProfiles_MagicOrber_Antipattern";
            checkBoxScriptProfiles_MagicOrber_Antipattern.Size = new Size(96, 22);
            checkBoxScriptProfiles_MagicOrber_Antipattern.TabIndex = 191;
            checkBoxScriptProfiles_MagicOrber_Antipattern.Text = "Antipattern";
            checkBoxScriptProfiles_MagicOrber_Antipattern.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_RenewBond
            // 
            checkBoxScriptProfiles_MagicOrber_RenewBond.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_RenewBond.Location = new Point(50, 175);
            checkBoxScriptProfiles_MagicOrber_RenewBond.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_RenewBond.Name = "checkBoxScriptProfiles_MagicOrber_RenewBond";
            checkBoxScriptProfiles_MagicOrber_RenewBond.Size = new Size(112, 22);
            checkBoxScriptProfiles_MagicOrber_RenewBond.TabIndex = 190;
            checkBoxScriptProfiles_MagicOrber_RenewBond.Text = "Renew Bond";
            checkBoxScriptProfiles_MagicOrber_RenewBond.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_DeathHandler
            // 
            checkBoxScriptProfiles_MagicOrber_DeathHandler.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_DeathHandler.Location = new Point(50, 125);
            checkBoxScriptProfiles_MagicOrber_DeathHandler.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_DeathHandler.Name = "checkBoxScriptProfiles_MagicOrber_DeathHandler";
            checkBoxScriptProfiles_MagicOrber_DeathHandler.Size = new Size(121, 22);
            checkBoxScriptProfiles_MagicOrber_DeathHandler.TabIndex = 189;
            checkBoxScriptProfiles_MagicOrber_DeathHandler.Text = "Death Handler";
            checkBoxScriptProfiles_MagicOrber_DeathHandler.UseVisualStyleBackColor = true;
            // 
            // checkBoxScriptProfiles_MagicOrber_UseStaminas
            // 
            checkBoxScriptProfiles_MagicOrber_UseStaminas.AutoSize = true;
            checkBoxScriptProfiles_MagicOrber_UseStaminas.Location = new Point(250, 225);
            checkBoxScriptProfiles_MagicOrber_UseStaminas.Margin = new Padding(0);
            checkBoxScriptProfiles_MagicOrber_UseStaminas.Name = "checkBoxScriptProfiles_MagicOrber_UseStaminas";
            checkBoxScriptProfiles_MagicOrber_UseStaminas.Size = new Size(159, 22);
            checkBoxScriptProfiles_MagicOrber_UseStaminas.TabIndex = 186;
            checkBoxScriptProfiles_MagicOrber_UseStaminas.Text = "Use Stamina Potion";
            checkBoxScriptProfiles_MagicOrber_UseStaminas.UseVisualStyleBackColor = true;
            // 
            // labelScriptProfiles_MagicOrber_Title
            // 
            labelScriptProfiles_MagicOrber_Title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_MagicOrber_Title.Location = new Point(0, 50);
            labelScriptProfiles_MagicOrber_Title.Margin = new Padding(0);
            labelScriptProfiles_MagicOrber_Title.Name = "labelScriptProfiles_MagicOrber_Title";
            labelScriptProfiles_MagicOrber_Title.Size = new Size(780, 25);
            labelScriptProfiles_MagicOrber_Title.TabIndex = 184;
            labelScriptProfiles_MagicOrber_Title.Text = "Magic: Orber";
            labelScriptProfiles_MagicOrber_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScriptProfiles_MagicOrber_SaveToProfiles
            // 
            btnScriptProfiles_MagicOrber_SaveToProfiles.BackgroundImageLayout = ImageLayout.Stretch;
            btnScriptProfiles_MagicOrber_SaveToProfiles.Cursor = Cursors.Hand;
            btnScriptProfiles_MagicOrber_SaveToProfiles.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnScriptProfiles_MagicOrber_SaveToProfiles.ForeColor = Color.FromArgb(64, 64, 64);
            btnScriptProfiles_MagicOrber_SaveToProfiles.Location = new Point(330, 350);
            btnScriptProfiles_MagicOrber_SaveToProfiles.Margin = new Padding(0);
            btnScriptProfiles_MagicOrber_SaveToProfiles.Name = "btnScriptProfiles_MagicOrber_SaveToProfiles";
            btnScriptProfiles_MagicOrber_SaveToProfiles.Size = new Size(125, 50);
            btnScriptProfiles_MagicOrber_SaveToProfiles.TabIndex = 182;
            btnScriptProfiles_MagicOrber_SaveToProfiles.Text = "Save Profile";
            btnScriptProfiles_MagicOrber_SaveToProfiles.UseVisualStyleBackColor = true;
            btnScriptProfiles_MagicOrber_SaveToProfiles.Click += btnScriptProfiles_MagicOrber_SaveButton_Click;
            // 
            // labelScriptProfiles_MagicOrber_SelectOrb
            // 
            labelScriptProfiles_MagicOrber_SelectOrb.AutoSize = true;
            labelScriptProfiles_MagicOrber_SelectOrb.Location = new Point(475, 125);
            labelScriptProfiles_MagicOrber_SelectOrb.Margin = new Padding(0);
            labelScriptProfiles_MagicOrber_SelectOrb.Name = "labelScriptProfiles_MagicOrber_SelectOrb";
            labelScriptProfiles_MagicOrber_SelectOrb.Size = new Size(78, 18);
            labelScriptProfiles_MagicOrber_SelectOrb.TabIndex = 253;
            labelScriptProfiles_MagicOrber_SelectOrb.Text = "Select Orb";
            // 
            // comboBoxScriptProfiles_MagicOrber_SelectOrb
            // 
            comboBoxScriptProfiles_MagicOrber_SelectOrb.AutoCompleteCustomSource.AddRange(new string[] { "Progressive", "Chickens", "Giant Frogs", "Hill Giants", "Sand Crabs", "Chaos Druids", "Undead Druids" });
            comboBoxScriptProfiles_MagicOrber_SelectOrb.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxScriptProfiles_MagicOrber_SelectOrb.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxScriptProfiles_MagicOrber_SelectOrb.FlatStyle = FlatStyle.Flat;
            comboBoxScriptProfiles_MagicOrber_SelectOrb.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxScriptProfiles_MagicOrber_SelectOrb.FormattingEnabled = true;
            comboBoxScriptProfiles_MagicOrber_SelectOrb.Items.AddRange(new object[] { "Earth", "Air" });
            comboBoxScriptProfiles_MagicOrber_SelectOrb.Location = new Point(575, 125);
            comboBoxScriptProfiles_MagicOrber_SelectOrb.Margin = new Padding(0);
            comboBoxScriptProfiles_MagicOrber_SelectOrb.Name = "comboBoxScriptProfiles_MagicOrber_SelectOrb";
            comboBoxScriptProfiles_MagicOrber_SelectOrb.Size = new Size(150, 26);
            comboBoxScriptProfiles_MagicOrber_SelectOrb.TabIndex = 254;
            // 
            // labelScriptProfiles_MagicOrber_Header
            // 
            labelScriptProfiles_MagicOrber_Header.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelScriptProfiles_MagicOrber_Header.Location = new Point(0, 0);
            labelScriptProfiles_MagicOrber_Header.Margin = new Padding(0);
            labelScriptProfiles_MagicOrber_Header.Name = "labelScriptProfiles_MagicOrber_Header";
            labelScriptProfiles_MagicOrber_Header.Size = new Size(780, 50);
            labelScriptProfiles_MagicOrber_Header.TabIndex = 255;
            labelScriptProfiles_MagicOrber_Header.Text = "Script Profiles";
            labelScriptProfiles_MagicOrber_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formScriptProfilesMagicOrber
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(784, 436);
            Controls.Add(labelScriptProfiles_MagicOrber_Header);
            Controls.Add(comboBoxScriptProfiles_MagicOrber_SelectOrb);
            Controls.Add(labelScriptProfiles_MagicOrber_SelectOrb);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_UseRandomCape);
            Controls.Add(textBoxScriptProfiles_MagicOrber_TrainAgility);
            Controls.Add(textBoxScriptProfiles_MagicOrber_TrainMelee);
            Controls.Add(labelScriptProfiles_MagicOrber_TrainMelee);
            Controls.Add(labelScriptProfiles_MagicOrber_TrainAgility);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_WorldHopping);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_Restocking);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_SellLoot);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_Antipattern);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_RenewBond);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_DeathHandler);
            Controls.Add(checkBoxScriptProfiles_MagicOrber_UseStaminas);
            Controls.Add(labelScriptProfiles_MagicOrber_Title);
            Controls.Add(btnScriptProfiles_MagicOrber_SaveToProfiles);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(224, 224, 224);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formScriptProfilesMagicOrber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Script Profiles - Magic - Orber";
            Load += formScriptProfiles_MagicOrber_Load;
            ResumeLayout(false);
            PerformLayout();
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
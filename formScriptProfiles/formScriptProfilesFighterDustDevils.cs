using System.ComponentModel;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterDustDevils : Form
    {

        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesFighterDustDevils(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        //Initialize Variables//
        string pc_username = Environment.UserName;
        string folderpathProfiles = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        //Form Load//
        public void formScriptProfilesFighterDustDevils_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_FighterDustDevils_SelectArea.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterDustDevils_SelectPotion.SelectedIndex = 0;
        }

        //Require Input On Textbox//
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                // Ensure the textbox always has an input
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("This field is required");
                    e.Cancel = true;
                }
            }
            else
            {
            }
        }

        //Button Click - Save Profile//
        public void btnScriptProfiles_FighterDustDevils_SaveButton_Click(object sender, EventArgs e)
        {

            //Initialize Variables//
            string filepathProfileFighterDustDevils = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-DustDevils.txt");
            string boolEnableHighAlching = "<Find>boolEnableHighAlching:false</Find><Replace>boolEnableHighAlching:false</Replace>";
            string selectArea = "<Find>SmokeDungeon/*/CatacombsOfKourend</Find><Replace>" + comboBoxScriptProfiles_FighterDustDevils_SelectArea.SelectedItem.ToString() + "</Replace>";
            string selectPotion = "<Find>None/*/CombatPotion/*/SuperCombatPotion</Find><Replace>" + comboBoxScriptProfiles_FighterDustDevils_SelectPotion.SelectedItem.ToString() + "</Replace>";
            string meleeGearArrow = "<Find>None</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeArrow.Text + "</Replace>";
            string meleeGearCape = "<Find>Zamorak cloak</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeCape.Text + "</Replace>";
            string meleeGearChest = "<Find>Obsidian platebody</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeChest.Text + "</Replace>";
            string meleeGearFeet = "<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeFeet.Text + "</Replace>";
            string meleeGearHands = "<Find>Granite gloves</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeHands.Text + "</Replace>";
            string meleeGearHead = "<Find>Obsidian helmet</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeHead.Text + "</Replace>";
            string meleeGearLegs = "<Find>Obsidian platelegs</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeLegs.Text + "</Replace>";
            string meleeGearRing = "<Find>Warrior ring</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeRing.Text + "</Replace>";
            string meleeGearWeapon = "<Find>Abyssal whip</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeWeapon.Text + "</Replace>";
            string miscGearAmulet = "<Find>Amulet of glory</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MiscAmulet.Text + "</Replace>";
            string miscGearShield = "<Find>Toktz-ket-xil</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MiscShield.Text + "</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            //Set HighAlchemy Variable//
            if (checkBoxScriptProfiles_FighterDustDevils_HighAlching.Checked)
            {
                boolEnableHighAlching = "<Find>boolEnableHighAlching:false</Find><Replace>boolEnableHighAlching:true</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileFighterDustDevils))
            {
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(boolEnableHighAlching);
                writer.WriteLine(selectArea);
                writer.WriteLine(selectPotion);
                writer.WriteLine("-----------");
                writer.WriteLine("Custom Gear");
                writer.WriteLine("-----------");
                writer.WriteLine(meleeGearArrow);
                writer.WriteLine(meleeGearCape);
                writer.WriteLine(meleeGearChest);
                writer.WriteLine(meleeGearFeet);
                writer.WriteLine(meleeGearHands);
                writer.WriteLine(meleeGearHead);
                writer.WriteLine(meleeGearLegs);
                writer.WriteLine(meleeGearRing);
                writer.WriteLine(meleeGearWeapon);
                writer.WriteLine(miscGearAmulet);
                writer.WriteLine(miscGearShield);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

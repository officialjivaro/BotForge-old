using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;


namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterKurasks : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterKurasks(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string pc_username = Environment.UserName;
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form Load
        public void formScriptProfilesFighterKurasks_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Kurasks_SelectMode.SelectedIndex = 0;
            comboBoxScriptProfiles_Kurasks_SelectPotion.SelectedIndex = 0;
        }

        // Require Input on textboxes
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_Kurasks_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize variables
            string filepathProfileKurasks = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-Kurasks.txt");
            string boolEnableHighAlching = "<Find>boolEnableHighAlching:false</Find><Replace>boolEnableHighAlching:false</Replace>";
            string selectMode = "<Find>Ranged/*/Melee</Find><Replace>" + comboBoxScriptProfiles_Kurasks_SelectMode.SelectedItem.ToString() + "</Replace>";
            string selectPotion = "<Find>None/*/RangingPotion/*/CombatPotion/*/SuperCombatPotion</Find><Replace>" + comboBoxScriptProfiles_Kurasks_SelectPotion.SelectedItem.ToString() + "</Replace>";
            string rangedGearArrow = "<Find>Broad bolts</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedArrow.Text + "</Replace>";
            string rangedGearCape = "<Find>Ava's</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedCape.Text + "</Replace>";
            string rangedGearChest = "<Find>Black d'hide body</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedChest.Text + "</Replace>";
            string rangedGearFeet = "<Find>Snakeskin boots</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedFeet.Text + "</Replace>";
            string rangedGearHands = "<Find>Black d'hide vambraces</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedHands.Text + "</Replace>";
            string rangedGearHead = "<Find>Snakeskin bandana</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedHead.Text + "</Replace>";
            string rangedGearLegs = "<Find>Black d'hide chaps</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedLegs.Text + "</Replace>";
            string rangedGearRing = "<Find>Ring of wealth</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedRing.Text + "</Replace>";
            string rangedGearWeapon = "<Find>Rune crossbow</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedWeapon.Text + "</Replace>";
            string meleeGearArrow = "<Find>None</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeArrow.Text + "</Replace>";
            string meleeGearCape = "<Find>Zamorak cloak</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeCape.Text + "</Replace>";
            string meleeGearChest = "<Find>Obsidian platebody</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeChest.Text + "</Replace>";
            string meleeGearFeet = "<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeFeet.Text + "</Replace>";
            string meleeGearHands = "<Find>Granite gloves</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeHands.Text + "</Replace>";
            string meleeGearHead = "<Find>Obsidian helmet</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeHead.Text + "</Replace>";
            string meleeGearLegs = "<Find>Obsidian platelegs</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeLegs.Text + "</Replace>";
            string meleeGearRing = "<Find>Warrior ring</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeRing.Text + "</Replace>";
            string meleeGearWeapon = "<Find>Abyssal whip</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeWeapon.Text + "</Replace>";
            string miscGearAmulet = "<Find>Amulet of glory</Find><Replace>" + textBoxScriptProfiles_Kurasks_MiscAmulet.Text + "</Replace>";
            string miscGearShield = "<Find>Mirror shield</Find><Replace>" + textBoxScriptProfiles_Kurasks_MiscShield.Text + "</Replace>";


            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_Kurasks_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_Kurasks_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_Kurasks_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_Kurasks_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_Kurasks_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable// checked
            if (checkBoxScriptProfiles_Kurasks_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Enable High Alching checked
            if (checkBoxScriptProfiles_Kurasks_HighAlching.Checked)
            {
                boolEnableHighAlching = "<Find>boolEnableHighAlching:false</Find><Replace>boolEnableHighAlching:true</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileKurasks))
            {
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(boolEnableHighAlching);
                writer.WriteLine(selectMode);
                writer.WriteLine(selectPotion);
                writer.WriteLine(rangedGearArrow);
                writer.WriteLine(rangedGearCape);
                writer.WriteLine(rangedGearChest);
                writer.WriteLine(rangedGearFeet);
                writer.WriteLine(rangedGearHands);
                writer.WriteLine(rangedGearHead);
                writer.WriteLine(rangedGearLegs);
                writer.WriteLine(rangedGearRing);
                writer.WriteLine(rangedGearWeapon);
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

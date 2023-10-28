namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesProgressiveFighterRanged : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesProgressiveFighterRanged(formMainForm mainForm)
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

        // Form load
        public void formScriptProfiles_ProgressiveFighterRanged_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ProgressiveFighterRanged_SelectNPC.SelectedIndex = 0;
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_ProgressiveFighterRanged_SaveButton_Click(object sender, EventArgs e)
        {
            // Intialize variables
            string filepathProfileProgressiveFighterRanged = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxProgressiveFighter-Ranged.txt");
            string selectNpc = "<Find>Progressive/*/Cows/*/ElementalWizards/*/Goblins/*/HillGiants/*/Monks/*/MossGiants/*/RockCrabs</Find><Replace>" + comboBoxScriptProfiles_ProgressiveFighterRanged_SelectNPC.SelectedItem.ToString() + "</Replace>";
            string boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:false</Replace>";
            string boolEnableLootArrows = "<Find>boolEnableLootArrows:true</Find><Replace>boolEnableLootArrows:false</Replace>";
            string boolEnableLongRangeTraining = "<Find>boolEnableLongRangeTraining:false</Find><Replace>boolEnableLongRangeTraining:false</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable//
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Enable bury bones checkbox
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_BuryBigBones.Checked)
            {
                boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:true</Replace>";
            }

            // Disable loot arrows
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_DontLootArrows.Checked)
            {
                boolEnableLootArrows = "<Find>boolEnableLootArrows:true</Find><Replace>boolEnableLootArrows:true</Replace>";
            }

            // Enable long range training
            if (checkBoxScriptProfiles_ProgressiveFighterRanged_LongRangeMode.Checked)
            {
                boolEnableLongRangeTraining = "<Find>boolEnableLongRangeTraining:false</Find><Replace>boolEnableLongRangeTraining:true</Replace>\r\n";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileProgressiveFighterRanged))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableLootArrows);
                writer.WriteLine(boolEnableLongRangeTraining);
                writer.WriteLine(selectNpc);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesLOTRAragorn : Form
    {
        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesLOTRAragorn(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables
        string pc_username = Environment.UserName;
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form Load
        public void formScriptProfiles_Aragorn_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Aragorn_SelectNpc.SelectedIndex = 0;
        }

        //Button Click - Save Script Profile//
        public void btnScriptProfiles_Aragorn_SaveButton_Click(object sender, EventArgs e)
        {

            //Initialize Variables//
            string filepathProfileAragorn = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxLOTR-Aragorn.txt");
            string boolDisableGearChecks = "<Find>boolDisableGearChecks:false</Find><Replace>boolDisableGearChecks:false</Replace>";
            string boolEnableFightObor = "<Find>boolEnableFightObor:false</Find><Replace>boolEnableFightObor:false</Replace>";
            string boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:false</Replace>";
            string boolEnableProgressiveTraining = "<Find>boolEnableProgressiveTraining:false</Find><Replace>boolEnableProgressiveTraining:false</Replace>";
            string slectNpc = "<Find>Progressive/*/Chickens/*/Giant Frogs/*/Hill Giants/*/Sand Crabs/*/Chaos Druids</Find><Replace>" + comboBoxScriptProfiles_Aragorn_SelectNpc.SelectedItem.ToString() + "</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_Aragorn_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_Aragorn_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_Aragorn_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_Aragorn_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_Aragorn_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable// checked
            if (checkBoxScriptProfiles_Aragorn_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Disable gear checks checked
            if (checkBoxScriptProfiles_Aragorn_UseOwnGear.Checked)
            {
                boolDisableGearChecks = "<Find>boolDisableGearChecks:false</Find><Replace>boolDisableGearChecks:true</Replace>";
            }

            // Enable fight Obor checked
            if (checkBoxScriptProfiles_Aragorn_FightObor.Checked)
            {
                boolEnableFightObor = "<Find>boolEnableFightObor:false</Find><Replace>boolEnableFightObor:true</Replace>";
            }

            // Enable bury bones checked
            if (checkBoxScriptProfiles_Aragorn_BuryBigBones.Checked)
            {
                boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:true</Replace>";
            }

            // Enable progressive training checked
            if (checkBoxScriptProfiles_Aragorn_TrainStatsEvenly.Checked)
            {
                boolEnableProgressiveTraining = "<Find>boolEnableProgressiveTraining:false</Find><Replace>boolEnableProgressiveTraining:true</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileAragorn))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("Progressive Melee Trainer Settings");
                writer.WriteLine(boolDisableGearChecks);
                writer.WriteLine(boolEnableFightObor);
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableProgressiveTraining);
                writer.WriteLine(slectNpc);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

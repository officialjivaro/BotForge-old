namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesThievingMasterFarmers : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesThievingMasterFarmers(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        public string pc_username = Environment.UserName;
        public string folderpathProfiles = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\";
        public string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        public string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        public string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        public string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        public string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        public string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form Load
        public void formScriptProfiles_ThievingMasterFarmers_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingMasterFarmers_SelectLocation.SelectedIndex = 0;
        }

        // Button Click - Save Script Profile
        public void btnScriptProfiles_ThievingMasterFarmers_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize variables
            string filepathProfileThievingMasterFarmers = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-MasterFarmers.txt");
            string selectLocation = "<Find>Random Sector/*/Varrock/*/Hosidius South/*/Hosidius North</Find><Replace>" + comboBoxScriptProfiles_ThievingMasterFarmers_SelectLocation.SelectedItem.ToString() + "</Replace>";
            string boolEnableUseRoguesOutfit = "<Find>boolEnableUseRogueOutfit:false</Find><Replace>boolEnableUseRogueOutfit:false</Replace>";

            //Set Checkbox Variables//
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ThievingMasterFarmers_DeathHandler},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ThievingMasterFarmers_RenewBond},
                {"boolEnableAntipattern", checkBoxScriptProfiles_ThievingMasterFarmers_Antipattern},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ThievingMasterFarmers_WorldHopping},
                {"boolEnableRestocking", checkBoxScriptProfiles_ThievingMasterFarmers_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ThievingMasterFarmers_SellLoot},
                {"boolEnableUseRoguesOutfit", checkBoxScriptProfiles_ThievingMasterFarmers_UseRoguesOutfit}
            };
            //Dictionary To Store Booleans//
            var checkBoxMappingResults = new Dictionary<string, string>();
            //Loop Through Dictionary & Generate Output//
            foreach (var checkboxPair in checkBoxMappings)
            {
                if (checkboxPair.Value.Checked)
                {
                    checkBoxMappingResults[checkboxPair.Key] = $"<Find>{checkboxPair.Key}:false</Find><Replace>{checkboxPair.Key}:true</Replace>";
                }
            }

            //Check & Update Variables//
            if (checkBoxMappingResults.ContainsKey("boolEnableDeathHandler"))
                boolEnableDeathHandler = checkBoxMappingResults["boolEnableDeathHandler"];

            if (checkBoxMappingResults.ContainsKey("boolEnableRenewBond"))
                boolEnableRenewBond = checkBoxMappingResults["boolEnableRenewBond"];

            if (checkBoxMappingResults.ContainsKey("boolEnableAntipattern"))
                boolEnableAntipattern = checkBoxMappingResults["boolEnableAntipattern"];

            if (checkBoxMappingResults.ContainsKey("boolEnableHopWorlds"))
                boolEnableHopWorlds = checkBoxMappingResults["boolEnableHopWorlds"];

            if (checkBoxMappingResults.ContainsKey("boolEnableRestocking"))
                boolEnableRestocking = checkBoxMappingResults["boolEnableRestocking"];

            if (checkBoxMappingResults.ContainsKey("boolEnableSellLoot"))
                boolEnableSellLoot = checkBoxMappingResults["boolEnableSellLoot"];

            if (checkBoxMappingResults.ContainsKey("boolEnableUseRoguesOutfit"))
                boolEnableUseRoguesOutfit = checkBoxMappingResults["boolEnableUseRoguesOutfit"];

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingMasterFarmers))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("Master Farmer Settings");
                writer.WriteLine(boolEnableUseRoguesOutfit);
                writer.WriteLine(selectLocation);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

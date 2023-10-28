namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesGeneric : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesGeneric(formMainForm mainForm)
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
        public void formScriptProfiles_Generic_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Generic_SelectScript.SelectedIndex = 0;
        }

        // Button Click - Save Script Profile
        public void btnScriptProfiles_Generic_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize variables
            string filepathProfileGeneric = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\" + comboBoxScriptProfiles_Generic_SelectScript.SelectedItem.ToString());

            //Set Checkbox Variables//
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableDeathHandler", checkBoxScriptProfiles_Generic_DeathHandler},
                {"boolEnableRenewBond", checkBoxScriptProfiles_Generic_RenewBond},
                {"boolEnableAntipattern", checkBoxScriptProfiles_Generic_Antipattern},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_Generic_WorldHopping},
                {"boolEnableRestocking", checkBoxScriptProfiles_Generic_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_Generic_SellLoot}
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

            //Write To File//
            using (StreamWriter writer = new StreamWriter(filepathProfileGeneric))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

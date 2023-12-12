using System.Reflection;

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

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableAvoidPlayers = "<Find>boolEnableAvoidPlayers:false</Find><Replace>boolEnableAvoidPlayers:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableUseRoguesOutfit = "<Find>boolEnableUseRogueOutfit:false</Find><Replace>boolEnableUseRogueOutfit:false</Replace>";
        string filepathProfileThievingMasterFarmers = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-MasterFarmers.txt");


        // Form Load
        public void formScriptProfiles_ThievingMasterFarmers_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingMasterFarmers_SelectLocation.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ThievingMasterFarmers_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ThievingMasterFarmers_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ThievingMasterFarmers_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ThievingMasterFarmers_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ThievingMasterFarmers_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ThievingMasterFarmers_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ThievingMasterFarmers_SellLoot},
                {"boolEnableUseRoguesOutfit", checkBoxScriptProfiles_ThievingMasterFarmers_UseRoguesOutfit},
                {"boolEnableAvoidPlayers", checkBoxScriptProfiles_ThievingMasterFarmers_AvoidPlayers}
            };

            foreach (var checkboxPair in checkBoxMappings)
            {
                if (checkboxPair.Value.Checked)
                {
                    var variableName = checkboxPair.Key;
                    var variableValue = $"<Find>{variableName}:false</Find><Replace>{variableName}:true</Replace>";

                    // Using reflection to dynamically set field values
                    this.GetType().GetField(variableName, BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(this, variableValue);
                }
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingMasterFarmers))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nMaster Farmer Settings");
                writer.WriteLine(boolEnableAvoidPlayers);
                writer.WriteLine(boolEnableUseRoguesOutfit);
                writer.WriteLine("<Find>Random Sector/*/Ardougne/*/Hosidius North/*/Hosidius South/*/Varrock</Find><Replace>" + comboBoxScriptProfiles_ThievingMasterFarmers_SelectLocation.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

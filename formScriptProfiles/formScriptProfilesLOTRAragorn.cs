using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesLOTRAragorn : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesLOTRAragorn(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolDisableGearChecks = "<Find>boolDisableGearChecks:false</Find><Replace>boolDisableGearChecks:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableFightObor = "<Find>boolEnableFightObor:false</Find><Replace>boolEnableFightObor:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableProgressiveTraining = "<Find>boolEnableProgressiveTraining:false</Find><Replace>boolEnableProgressiveTraining:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileAragorn = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxLOTR-Aragorn.txt");

        // Form Load
        public void formScriptProfiles_Aragorn_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Aragorn_SelectNpc.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_Aragorn_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolDisableGearChecks", checkBoxScriptProfiles_Aragorn_DisableGearChecks},
                {"boolEnableAntipattern", checkBoxScriptProfiles_Aragorn_Antipattern},
                {"boolEnableBuryBones", checkBoxScriptProfiles_Aragorn_BuryBigBones},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_Aragorn_DeathHandler},
                {"boolEnableFightObor", checkBoxScriptProfiles_Aragorn_FightObor},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_Aragorn_WorldHopping},
                {"boolEnableProgressiveTraining", checkBoxScriptProfiles_Aragorn_TrainStatsEvenly},
                {"boolEnableRenewBond", checkBoxScriptProfiles_Aragorn_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_Aragorn_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_Aragorn_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileAragorn))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nAragorn Settings");
                writer.WriteLine(boolDisableGearChecks);
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableFightObor);
                writer.WriteLine(boolEnableProgressiveTraining);
                writer.WriteLine("<Find>Progressive/*/Chickens/*/Giant Frogs/*/Hill Giants/*/Sand Crabs/*/Chaos Druids</Find><Replace>" + comboBoxScriptProfiles_Aragorn_SelectNpc.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

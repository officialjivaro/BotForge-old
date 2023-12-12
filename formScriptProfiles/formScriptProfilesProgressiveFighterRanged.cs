using System.Reflection;

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
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableLongRangeTraining = "<Find>boolEnableLongRangeTraining:false</Find><Replace>boolEnableLongRangeTraining:false</Replace>";
        string boolEnableLootArrows = "<Find>boolEnableLootArrows:true</Find><Replace>boolEnableLootArrows:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileProgressiveFighterRanged = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxProgressiveFighter-Ranged.txt");

        // Form load
        public void formScriptProfiles_ProgressiveFighterRanged_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ProgressiveFighterRanged_SelectNPC.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ProgressiveFighterRanged_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ProgressiveFighterRanged_Antipattern},
                {"boolEnableBuryBones", checkBoxScriptProfiles_ProgressiveFighterRanged_BuryBigBones},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ProgressiveFighterRanged_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ProgressiveFighterRanged_WorldHopping},
                {"boolEnableLongRangeTraining", checkBoxScriptProfiles_ProgressiveFighterRanged_LongRangeMode},
                {"boolEnableLootArrows", checkBoxScriptProfiles_ProgressiveFighterRanged_DontLootArrows},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ProgressiveFighterRanged_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ProgressiveFighterRanged_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ProgressiveFighterRanged_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileProgressiveFighterRanged))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nProgressive Fighter Settings");
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableLongRangeTraining);
                writer.WriteLine(boolEnableLootArrows);
                writer.WriteLine("<Find>Progressive/*/Cows/*/ElementalWizards/*/Goblins/*/HillGiants/*/Monks/*/MossGiants/*/RockCrabs</Find><Replace>" + comboBoxScriptProfiles_ProgressiveFighterRanged_SelectNPC.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

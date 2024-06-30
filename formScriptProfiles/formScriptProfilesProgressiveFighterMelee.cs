using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesProgressiveFighterMelee : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesProgressiveFighterMelee(formMainForm mainForm)
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
        string filepathProfileAragorn = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxProgressiveFighter-Melee.txt");

        // Form Load
        public void formScriptProfiles_ProgressiveFighterMelee_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ProgressiveFighterMelee_SelectNpc.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ProgressiveFighterMelee_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolDisableGearChecks", checkBoxScriptProfiles_ProgressiveFighterMelee_DisableGearChecks},
                {"boolEnableAntipattern", checkBoxScriptProfiles_ProgressiveFighterMelee_Antipattern},
                {"boolEnableBuryBones", checkBoxScriptProfiles_ProgressiveFighterMelee_BuryBigBones},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ProgressiveFighterMelee_DeathHandler},
                {"boolEnableFightObor", checkBoxScriptProfiles_ProgressiveFighterMelee_FightObor},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ProgressiveFighterMelee_WorldHopping},
                {"boolEnableProgressiveTraining", checkBoxScriptProfiles_ProgressiveFighterMelee_TrainStatsEvenly},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ProgressiveFighterMelee_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ProgressiveFighterMelee_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ProgressiveFighterMelee_SellLoot}
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
                writer.WriteLine("\nProgressive Fighter Settings");
                writer.WriteLine(boolDisableGearChecks);
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableFightObor);
                writer.WriteLine(boolEnableProgressiveTraining);
                writer.WriteLine("<Find>Progressive/*/ChaosDruids/*/Chickens/*/FireGiants/*/GiantFrogs/*/Goblins/*/GreaterDemons/*/Guards/*/HillGiants/*/Hobgoblins/*/IceGiants/*/MossGiants/*/Pirates/*/Seagulls/*/Skeletons/*/Zombies</Find><Replace>" + comboBoxScriptProfiles_ProgressiveFighterMelee_SelectNpc.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

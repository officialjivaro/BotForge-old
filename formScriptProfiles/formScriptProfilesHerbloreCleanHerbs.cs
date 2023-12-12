using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesHerbloreCleanHerbs : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesHerbloreCleanHerbs(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileHerbloreCleanHerbs = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxHerblore-CleanHerbs.txt");

        // Form load
        public void formScriptProfiles_HerbloreCleanHerbs_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.SelectedIndex = 0;
            comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.SelectedIndex = 0;
        }

        // Cancel Non Numbers & Set Limit To 99 From Textbox
        public void GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(sender, e);
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_HerbloreCleanHerbs_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_HerbloreCleanHerbs_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_HerbloreCleanHerbs_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_HerbloreCleanHerbs_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_HerbloreCleanHerbs_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_HerbloreCleanHerbs_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_HerbloreCleanHerbs_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileHerbloreCleanHerbs))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nHerblore Clean Herbs Settings");
                writer.WriteLine("<Find>Progressive/*/GuamLeaf/*/Marrentill/*/Tarromin/*/Harralander/*/RanarrWeed/*/Toadflax/*/IritLeaf/*/Avantoe/*/Kwuarm/*/Snapdragon/*/Cadantine/*/Lantadyme/*/DwarfWeed/*/Torstol</Find><Replace>" + comboBoxScriptProfiles_HerbloreCleanHerbs_SelectHerb.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("Random/*/Slow/*/Fast" + comboBoxScriptProfiles_HerbloreCleanHerbs_CleaningSpeed.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>11111111</Find><Replace>" + textBoxScriptProfiles_HerbloreCleanHerbs_StopLevel.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;


namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesAgilityRooftops : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesAgilityRooftops(formMainForm mainForm)
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
        string filepathProfileAgilityRooftops = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxAgility-Rooftops.txt");

        // Form load
        public void formScriptProfiles_AgilityRooftops_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_AgilityRooftops_SelectRooftopCourse.SelectedIndex = 0;
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
        public void btnScriptProfiles_AgilityRooftops_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_AgilityRooftops_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_AgilityRooftops_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_AgilityRooftops_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_AgilityRooftops_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_AgilityRooftops_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_AgilityRooftops_SellLoot},
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
            using (StreamWriter writer = new StreamWriter(filepathProfileAgilityRooftops))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nRooftops Settings");
                writer.WriteLine("<Find>Progressive/*/Gnome/*/Draynor/*/Varrock/*/Falador/*/Seers/*/Fremennik/*/Ardougne</Find><Replace>" + comboBoxScriptProfiles_AgilityRooftops_SelectRooftopCourse.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>10101010</Find><Replace>" + textBoxScriptProfiles_AgilityRooftops_TrainAgility.Text + "</Replace>");
            }

            MessageBox.Show("Profile successfully created.");

        }
    }
}

using System.Reflection;

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

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form Load
        public void formScriptProfiles_Generic_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Generic_SelectScript.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_Generic_SaveButton_Click(object sender, EventArgs e)
        {
            // Initialize Variables
            string filepathProfileGeneric = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\" + comboBoxScriptProfiles_Generic_SelectScript.SelectedItem.ToString());

            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_Generic_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_Generic_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_Generic_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_Generic_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_Generic_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_Generic_SellLoot}
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

            // Write To File
            using (StreamWriter writer = new StreamWriter(filepathProfileGeneric))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

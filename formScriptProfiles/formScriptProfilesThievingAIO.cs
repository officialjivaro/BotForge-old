using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesThievingAIO : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesThievingAIO(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileThievingPickpocket = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-AIO.txt");

        // Form Load
        public void formScriptProfiles_ThievingAIO_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingAIO_SelectNpc.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ThievingAIO_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ThievingAIO_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ThievingAIO_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ThievingAIO_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ThievingAIO_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ThievingAIO_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ThievingAIO_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingPickpocket))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nThieving AIO Settings");
                writer.WriteLine("<Find>Progressive/*/Man/*/Warrior/*/Guard/*/ArdougneKnight/*/Paladin</Find><Replace>" + comboBoxScriptProfiles_ThievingAIO_SelectNpc.SelectedItem.ToString() + "</Replace>");

            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

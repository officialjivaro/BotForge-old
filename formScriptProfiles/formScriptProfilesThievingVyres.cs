using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesThievingVyres : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesThievingVyres(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableShadowVeil = "<Find>boolEnableShadowVeil:false</Find><Replace>boolEnableShadowVeil:false</Replace>";
        string filepathProfileThievingVyres = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-Vyres.txt");

        // Form load
        public void formScriptProfiles_ThievingVyres_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingVyres_SelectNpc.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ThievingVyres_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ThievingVyres_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ThievingVyres_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ThievingVyres_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ThievingVyres_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ThievingVyres_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ThievingVyres_SellLoot},
                {"boolEnableShadowVeil", checkBoxScriptProfiles_ThievingVyres_ShadowVeil}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingVyres))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nThieving Vyres Settings");
                writer.WriteLine(boolEnableShadowVeil);
                writer.WriteLine("<Find>Random/*/Vallessia von Pitt/*/Vlad Diaemus/*/Vonnetta Varnis</Find><Replace>" + comboBoxScriptProfiles_ThievingVyres_SelectNpc.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

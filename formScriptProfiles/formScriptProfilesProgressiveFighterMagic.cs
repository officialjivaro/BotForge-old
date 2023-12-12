using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesProgressiveFighterMagic : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesProgressiveFighterMagic(formMainForm mainForm)
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
        string filepathProfileProgressiveFighterMagic = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxProgressiveFighter-Magic.txt");

        // Form load
        public void formScriptProfiles_ProgressiveFighterMagic_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ProgressiveFighterMagic_SelectNPC.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ProgressiveFighterMagic_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ProgressiveFighterMagic_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ProgressiveFighterMagic_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ProgressiveFighterMagic_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ProgressiveFighterMagic_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ProgressiveFighterMagic_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ProgressiveFighterMagic_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileProgressiveFighterMagic))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nProgressive Fighter Settings");
                writer.WriteLine("<Find>Random/*/CyclopsAndJogres/*/Hobgoblins/*/LesserDemons/*/Ogres</Find><Replace>" + comboBoxScriptProfiles_ProgressiveFighterMagic_SelectNPC.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

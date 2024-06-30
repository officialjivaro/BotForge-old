using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterLavaDragons : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterLavaDragons(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableFireBolt = "<Find>boolEnableFireBolt:false</Find><Replace>boolEnableFireBolt:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnablePlayerIsSkulledHopWorlds = "<Find>boolEnablePlayerIsSkulledHopWorlds:false</Find><Replace>boolEnablePlayerIsSkulledHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileGandalf = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-LavaDragons.txt");

        // Form load
        public void formScriptProfiles_Gandalf_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Gandalf_SelectMode.SelectedIndex = 0;
            comboBoxScriptProfiles_Gandalf_LavaDragonsArea.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_Gandalf_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_Gandalf_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_Gandalf_DeathHandler},
                {"boolEnableFireBolt", checkBoxScriptProfiles_Gandalf_UseFireBolt},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_Gandalf_WorldHopping},
                {"boolEnablePlayerIsSkulledHopWorlds", checkBoxScriptProfiles_Gandalf_HopWorldsIfPlayerIsSkulled},
                {"boolEnableRenewBond", checkBoxScriptProfiles_Gandalf_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_Gandalf_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_Gandalf_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileGandalf))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("Gandalf Settings");
                writer.WriteLine(boolEnableFireBolt);
                writer.WriteLine(boolEnablePlayerIsSkulledHopWorlds);
                writer.WriteLine("<Find>Splashing/*/Lava Dragons</Find><Replace>" + comboBoxScriptProfiles_Gandalf_SelectMode.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Random/*/North/*/West/*/East</Find><Replace>" + comboBoxScriptProfiles_Gandalf_LavaDragonsArea.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

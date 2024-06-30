using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesThievingVyrewatchSentinels : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesThievingVyrewatchSentinels(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDiscordWebhooks = "<Find>boolEnableDiscordWebhooks:false</Find><Replace>boolEnableDiscordWebhooks:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableRoguesOutfit = "<Find>boolEnableRoguesOutfit:false</Find><Replace>boolEnableRoguesOutfit:false</Replace>";
        string boolEnableShadowVeil = "<Find>boolEnableShadowVeil:false</Find><Replace>boolEnableShadowVeil:false</Replace>";
        string filepathProfileThievingVyrewatchSentinels = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-VyrewatchSentinels.txt");

        // Form load
        public void formScriptProfiles_ThievingVyrewatchSentinels_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingVyrewatchSentinels_SelectNpc.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ThievingVyrewatchSentinels_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ThievingVyrewatchSentinels_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ThievingVyrewatchSentinels_DeathHandler},
                {"boolEnableDiscordWebhooks", checkBoxScriptProfiles_ThievingVyrewatchSentinels_DiscordWebhooks},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ThievingVyrewatchSentinels_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ThievingVyrewatchSentinels_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ThievingVyrewatchSentinels_Restocking},
                {"boolEnableRoguesOutfit", checkBoxScriptProfiles_ThievingVyrewatchSentinels_RoguesOutfit},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ThievingVyrewatchSentinels_SellLoot},
                {"boolEnableShadowVeil", checkBoxScriptProfiles_ThievingVyrewatchSentinels_ShadowVeil}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingVyrewatchSentinels))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableDiscordWebhooks);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nThieving VyrewatchSentinels Settings");
                writer.WriteLine(boolEnableRoguesOutfit);
                writer.WriteLine(boolEnableShadowVeil);
                writer.WriteLine("<Find>Random/*/Vallessia von Pitt/*/Vlad Diaemus/*/Vonnetta Varnis</Find><Replace>" + comboBoxScriptProfiles_ThievingVyrewatchSentinels_SelectNpc.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

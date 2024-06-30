using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesThievingElves : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesThievingElves(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableAvoidPlayers = "<Find>boolEnableAvoidPlayers:false</Find><Replace>boolEnableAvoidPlayers:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDiscordWebhooks = "<Find>boolEnableDiscordWebhooks:false</Find><Replace>boolEnableDiscordWebhooks:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableRoguesOutfit = "<Find>boolEnableRoguesOutfit:false</Find><Replace>boolEnableRoguesOutfit:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableShadowVeil = "<Find>boolEnableShadowVeil:false</Find><Replace>boolEnableShadowVeil:false</Replace>";
        string filepathProfileThievingElves = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-Elves.txt");

        // Form load
        public void formScriptProfiles_ThievingElves_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingElves_SelectNpc.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_ThievingElves_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_ThievingElves_Antipattern},
                {"boolEnableAvoidPlayers", checkBoxScriptProfiles_ThievingElves_AvoidPlayers},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_ThievingElves_DeathHandler},
                {"boolEnableDiscordWebhooks", checkBoxScriptProfiles_ThievingElves_DiscordWebhooks},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_ThievingElves_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_ThievingElves_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_ThievingElves_Restocking},
                {"boolEnableRoguesOutfit", checkBoxScriptProfiles_ThievingElves_RoguesOutfit},
                {"boolEnableSellLoot", checkBoxScriptProfiles_ThievingElves_SellLoot},
                {"boolEnableShadowVeil", checkBoxScriptProfiles_ThievingElves_ShadowVeil}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingElves))
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
                writer.WriteLine(boolEnableAvoidPlayers);
                writer.WriteLine(boolEnableRoguesOutfit);
                writer.WriteLine(boolEnableShadowVeil);
                writer.WriteLine("<Find>Random/*/Aranwe/*/Enel/*/Enelye/*/Findis/*/Hendor/*/Lenwe/*/Nerdanel/*/Nimloth/*/Turgon</Find><Replace>" + comboBoxScriptProfiles_ThievingElves_SelectNpc.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesSmithingAIO : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesSmithingAIO(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDiscordWebhooks = "<Find>boolEnableDiscordWebhooks:false</Find><Replace>boolEnableDiscordWebhooks:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileSmithingAIO = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxSmithing-AIO.txt");

        // Form load
        public void formScriptProfiles_SmithingAIO_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_SmithingAIO_SelectBar.SelectedIndex = 0;
            comboBoxScriptProfiles_SmithingAIO_SelectMode.SelectedIndex = 0;
            comboBoxScriptProfiles_SmithingAIO_SelectItem.SelectedIndex = 0;
            comboBoxScriptProfiles_SmithingAIO_SelectArea.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_SmithingAIO_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_SmithingAIO_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_SmithingAIO_DeathHandler},
                {"boolEnableDiscordWebhooks", checkBoxScriptProfiles_SmithingAIO_DiscordWebhooks},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_SmithingAIO_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_SmithingAIO_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_SmithingAIO_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_SmithingAIO_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileSmithingAIO))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableDiscordWebhooks);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nSmithing AIO Settings");
                writer.WriteLine("<Find>Cannonballs/*/Smelting/*/Smithing</Find><Replace>" + comboBoxScriptProfiles_SmithingAIO_SelectMode.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Progressive/*/Bronze/*/IronBar/*/Silver/*/Steel/*/Gold/*/Mithril/*/Adamantite/*/Runite</Find><Replace>" + comboBoxScriptProfiles_SmithingAIO_SelectBar.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>SmithingAioItem</Find><Replace>" + comboBoxScriptProfiles_SmithingAIO_SelectItem.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Random/*/AnvilSeersVillage/*/AnvilVarrockEast/*/AnvilVarrockWest/*/FurnaceAlKharid/*/FurnaceArdougne/*/FurnaceEdgeville/*/FurnaceFalador</Find><Replace>" + comboBoxScriptProfiles_SmithingAIO_SelectArea.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

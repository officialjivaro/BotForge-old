using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMiniGamesRoguesDen : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesMiniGamesRoguesDen(formMainForm mainForm)
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
        string boolEnableStopOnOutfit = "<Find>boolEnableStopOnOutfit:false</Find><Replace>boolEnableStopOnOutfit:false</Replace>";
        string filepathProfileMiniGamesRoguesDen = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMiniGames-RoguesDen.txt");


        // Btn Click - Save Profile
        public void btnScriptProfiles_MiniGamesRoguesDen_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_MiniGamesRoguesDen_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_MiniGamesRoguesDen_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_MiniGamesRoguesDen_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_MiniGamesRoguesDen_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_MiniGamesRoguesDen_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_MiniGamesRoguesDen_SellLoot},
                {"boolEnableStopOnOutfit", checkBoxScriptProfiles_MiniGamesRoguesDen_StopOnFiveCrates}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileMiniGamesRoguesDen))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nRogues Den Settings");
                writer.WriteLine(boolEnableStopOnOutfit);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

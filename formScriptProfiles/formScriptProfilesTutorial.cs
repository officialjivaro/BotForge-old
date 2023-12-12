using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesTutorial : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesTutorial(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableFastDialogue = "<Find><Boolean>boolEnableFastDialogue:false</Find><Replace><Boolean>boolEnableFastDialogue:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableNoNpcInteractions = "<Find><Boolean>boolEnableNoNpcInteractions:false</Find><Replace><Boolean>boolEnableNoNpcInteractions:false</Replace>";
        string boolEnableNoObjectInteractions = "<Find><Boolean>boolEnableNoObjectInteractions:false</Find><Replace><Boolean>boolEnableNoObjectInteractions:false</Replace>";
        string boolEnableNoWalkInteractions = "<Find><Boolean>boolEnableNoWalkInteractions:false</Find><Replace><Boolean>boolEnableNoWalkInteractions:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableStopAfterTutorial = "<Find><Boolean>boolEnableStopAfterTutorial:false>/Find><Replace><Boolean>boolEnableStopAfterTutorial:false</Replace>";
        string boolEnableWalkToRandomArea = "<Find><Boolean>boolEnableWalkToRandomArea:false</Find><Replace><Boolean>boolEnableWalkToRandomArea:false</Replace>";
        string filepathProfileTutorialIsland = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxTutorial.txt");

        // Form load
        public void formScriptProfilesTutorial_Load(object sender, EventArgs e)
        {

        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_TutorialIsland_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_TutorialIsland_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_TutorialIsland_DeathHandler},
                {"boolEnableFastDialogue", checkBoxScriptProfiles_TutorialIsland_FastDialogue},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_TutorialIsland_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_TutorialIsland_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_TutorialIsland_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_TutorialIsland_SellLoot},
                {"boolEnableStopAfterTutorial", checkBoxScriptProfiles_TutorialIsland_StopImmediately},
                {"boolEnableWalkToRandomArea", checkBoxScriptProfiles_TutorialIsland_WalkToRandom}
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

            // Set Interaction Variables
            if (listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> f2pQuestsMap = new Dictionary<string, Action>
                {
                    {"Disable NPC Interactions", () => boolEnableNoNpcInteractions = "<Find><Boolean>boolEnableNoNpcInteractions:false</Find><Replace><Boolean>boolEnableNoNpcInteractions:true</Replace>"},
                    {"Disable Object Interactions", () => boolEnableNoObjectInteractions = "<Find><Boolean>boolEnableNoObjectInteractions:false</Find><Replace><Boolean>boolEnableNoObjectInteractions:true</Replace>"},
                    {"Disable Walk Interactions", () => boolEnableNoWalkInteractions = "<Find><Boolean>boolEnableNoWalkInteractions:false</Find><Replace><Boolean>boolEnableNoWalkInteractions:true</Replace>"},
                };

                // Loop Through Dictionary & Generate Output
                foreach (var selectedF2pItem in listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItems)
                {
                    string selectedF2pQuest = selectedF2pItem.ToString();

                    foreach (var f2PQuest in f2pQuestsMap)
                    {
                        if (selectedF2pQuest.Contains(f2PQuest.Key))
                        {
                            f2PQuest.Value.Invoke();
                        }
                    }
                }
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileTutorialIsland))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("Tutorial Island Settings");
                writer.WriteLine(boolEnableFastDialogue);
                writer.WriteLine(boolEnableNoNpcInteractions);
                writer.WriteLine(boolEnableNoObjectInteractions);
                writer.WriteLine(boolEnableNoWalkInteractions);
                writer.WriteLine(boolEnableStopAfterTutorial);
                writer.WriteLine(boolEnableWalkToRandomArea);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

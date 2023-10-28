using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesAccountBuilder : Form
    {

        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesAccountBuilder(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string pc_username = Environment.UserName;
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form Load
        public void formScriptProfiles_AccountBuilder_Load(object sender, EventArgs e)
        {

        }

        // Cancel Non Numbers From Textbox
        public void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_KeyPress(sender, e);
        }

        //Cancel Non Numbers & Set Limit To 99 From Textbox//
        public void GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(sender, e);
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        //Button Click - Save Profile//
        public void btnScriptProfiles_AccountBuilder_SaveButton_Click(object sender, EventArgs e)
        {

            //Initialize Variables//
            string filepathProfileAccountBuilder = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxAccountBuilder.txt");
            string boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:false</Replace>";
            string boolEnableBankCoal = "<Find>boolEnableBankCoal:false</Find><Replace>boolEnableBankCoal:false</Replace>";
            string boolEnableRooftops = "<Find>boolEnableRooftops:false</Find><Replace>boolEnableRooftops:false</Replace>";
            string boolEnableNoGpStart = "<Find>boolEnableNoGpStart:false</Find><Replace>boolEnableNoGpStart:false</Replace>";
            string boolEnableLongRangeTraining = "<Find>boolEnableLongRangeTraining:false</Find><Replace>boolEnableLongRangeTraining:false</Replace>";
            string boolEnableJugsOfWine = "<Find>boolEnableJugsOfWine:false</Find><Replace>boolEnableJugsOfWine:false</Replace>";
            string boolEnableCooksAssistant = "<Find>boolEnableCooksAssistant:false</Find><Replace>boolEnableCooksAssistant:false</Replace>";
            string boolEnableGoblinDiplomacy = "<Find>boolEnableGoblinDiplomacy:false</Find><Replace>boolEnableGoblinDiplomacy:false</Replace>";
            string boolEnableRomeoAndJuliet = "<Find>boolEnableRomeoAndJuliet:false</Find><Replace>boolEnableRomeoAndJuliet:false</Replace>";
            string boolEnableRuneMysteries = "<Find>boolEnableRuneMysteries:false</Find><Replace>boolEnableRuneMysteries:false</Replace>";
            string boolEnableSheepShearer = "<Find>boolEnableSheepShearer:false</Find><Replace>boolEnableSheepShearer:false</Replace>";
            string boolEnableTheRestlessGhost = "<Find>boolEnableTheRestlessGhost:false</Find><Replace>boolEnableTheRestlessGhost:false</Replace>";
            string boolEnableVampyreSlayer = "<Find>boolEnableVampyreSlayer:false</Find><Replace>boolEnableVampyreSlayer:false</Replace>";
            string boolEnableXMarksTheSpot = "<Find>boolEnableXMarksTheSpot:false</Find><Replace>boolEnableXMarksTheSpot:false</Replace>";
            string boolEnableDruidicRitual = "<Find>boolEnableDruidicRitual:false</Find><Replace>boolEnableDruidicRitual:false</Replace>";
            string boolEnableLostCity = "<Find>boolEnableLostCity:false</Find><Replace>boolEnableLostCity:false</Replace>";
            string boolMageArenaOne = "<Find>boolEnableMageArenaOne:false</Find><Replace>boolEnableMageArenaOne:false</Replace>";
            string boolEnableRoguesDen = "<Find>boolEnableRoguesDen:false</Find><Replace>boolEnableRoguesDen:false</Replace>";
            string activityDuration;
            string activityDurationVariation;
            string goldFarmingDuration;
            int intGoldFarmingDuration;
            int intActivityDuration;
            int intActivityDurationVariation;

            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableDeathHandler", checkBoxScriptProfiles_AccountBuilder_DeathHandler},
                {"boolEnableRenewBond", checkBoxScriptProfiles_AccountBuilder_RenewBond},
                {"boolEnableAntipattern", checkBoxScriptProfiles_AccountBuilder_Antipattern},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_AccountBuilder_WorldHopping},
                {"boolEnableRestocking", checkBoxScriptProfiles_AccountBuilder_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_AccountBuilder_SellLoot},
                {"boolEnableBuryBones", checkBoxScriptProfiles_AccountBuilder_BuryBigBones},
                {"boolEnableBankCoal", checkBoxScriptProfiles_AccountBuilder_BankCoal},
                {"boolEnableRooftops", checkBoxScriptProfiles_AccountBuilder_EnableRooftops},
                {"boolEnableLongRangeTraining", checkBoxScriptProfiles_AccountBuilder_EnableLongrangeTraining},
                {"boolEnableJugsOfWine", checkBoxScriptProfiles_AccountBuilder_EnableJugsOfWine},
                {"boolEnableNoGpStart", checkBoxScriptProfiles_AccountBuilder_EnableNoGpStart}
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

            // Set F2pQuests Variables
            if (listBoxScriptProfiles_AccountBuilder_F2PQuests.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> f2pQuestsMap = new Dictionary<string, Action>
                {
                    {"Cooks Assistant", () => boolEnableCooksAssistant = "<Find>boolEnableCooksAssistant:false</Find><Replace>boolEnableCooksAssistant:true</Replace>"},
                    {"Goblin Diplomacy", () => boolEnableGoblinDiplomacy = "<Find>boolEnableGoblinDiplomacy:false</Find><Replace>boolEnableGoblinDiplomacy:true</Replace>"},
                    {"Romeo & Juliet", () => boolEnableRomeoAndJuliet = "<Find>boolEnableRomeoAndJuliet:false</Find><Replace>boolEnableRomeoAndJuliet:true</Replace>"},
                    {"Rune Mysteries", () => boolEnableRuneMysteries = "<Find>boolEnableRuneMysteries:false</Find><Replace>boolEnableRuneMysteries:true</Replace>"},
                    {"Sheep Shearer", () => boolEnableSheepShearer = "<Find>boolEnableSheepShearer:false</Find><Replace>boolEnableSheepShearer:true</Replace>"},
                    {"The Restless Ghost", () => boolEnableTheRestlessGhost = "<Find>boolEnableTheRestlessGhost:false</Find><Replace>boolEnableTheRestlessGhost:true</Replace>"},
                    {"Vampyre Slayer", () => boolEnableVampyreSlayer = "<Find>boolEnableVampyreSlayer:false</Find><Replace>boolEnableVampyreSlayer:true</Replace>"},
                    {"X Marks The Spot", () => boolEnableXMarksTheSpot = "<Find>boolEnableXMarksTheSpot:false</Find><Replace>boolEnableXMarksTheSpot:true</Replace>"},
                };

                // Loop Through Dictionary & Generate Output
                foreach (var selectedF2pItem in listBoxScriptProfiles_AccountBuilder_F2PQuests.SelectedItems)
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

            // Set P2pQuests Variables
            if (listBoxScriptProfiles_AccountBuilder_P2PQuests.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> p2pQuestsMap = new Dictionary<string, Action>
                {
                    {"Druidic Ritual", () => boolEnableDruidicRitual = "<Find>boolEnableDruidicRitual:false</Find><Replace>boolEnableDruidicRitual:true</Replace>"},
                    {"Lost City", () => boolEnableLostCity = "<Find>boolEnableLostCity:false</Find><Replace>boolEnableLostCity:true</Replace>"},
                };
                // Loop Through Dictionary & Generate Output 
                foreach (var selectedP2pItem in listBoxScriptProfiles_AccountBuilder_P2PQuests.SelectedItems)
                {
                    string selectedP2pQuest = selectedP2pItem.ToString();

                    foreach (var p2pQuest in p2pQuestsMap)
                    {
                        if (selectedP2pQuest.Contains(p2pQuest.Key))
                        {
                            p2pQuest.Value.Invoke();
                        }
                    }
                }
            }

            // Set MiniQuests Variables 
            if (listBoxScriptProfiles_AccountBuilder_MiniQuests.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> miniQuestsMap = new Dictionary<string, Action>
                {
                    {"Mage Arena I", () => boolMageArenaOne = "<Find>boolEnableMageArenaOne:false</Find><Replace>boolEnableMageArenaOne:true</Replace>"},
                };

                // Loop Through Dictionary & Generate Output 
                foreach (var selectedMiniItem in listBoxScriptProfiles_AccountBuilder_MiniQuests.SelectedItems)
                {
                    string selectedMiniQuest = selectedMiniItem.ToString();

                    foreach (var miniQuest in miniQuestsMap)
                    {
                        if (selectedMiniQuest.Contains(miniQuest.Key))
                        {
                            miniQuest.Value.Invoke();
                        }
                    }
                }
            }

            // Set MiniQuests Variables 
            if (listBoxScriptProfiles_AccountBuilder_MiniGames.SelectedItems.Count > 0)
            {
                foreach (var selectedItem in listBoxScriptProfiles_AccountBuilder_MiniGames.SelectedItems)
                {
                    string selectedQuest = selectedItem.ToString();

                    // Mare Arena I quest data to string
                    if (selectedQuest.Contains("Rogues Den"))
                    {
                        boolEnableRoguesDen = "<Find>boolEnableRoguesDen:false</Find><Replace>boolEnableRoguesDen:true</Replace>";
                    }
                }
            }

            // Activity Time Min To Ms Converter 
            int.TryParse(textBoxScriptProfiles_AccountBuilder_ActivityDuration.Text, out int intActivityDurationMs);
            {
                intActivityDuration = intActivityDurationMs * 60000;
                activityDuration = intActivityDuration.ToString();
            }

            // Convert activity time variation mins to ms
            int.TryParse(textBoxScriptProfiles_AccountBuilder_AcivityDurationVariation.Text, out int intActivityDurationVariationMs);
            {
                intActivityDurationVariation = intActivityDurationVariationMs * 60000;
                activityDurationVariation = intActivityDurationVariation.ToString();
            }

            // Convert gold farming duration mins to ms
            int.TryParse(textBoxScriptProfiles_AccountBuilder_GoldFarmingDuration.Text, out int intGoldFarmingDurationMs);
            {
                intGoldFarmingDuration = intGoldFarmingDurationMs * 60000;
                goldFarmingDuration = intGoldFarmingDuration.ToString();
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileAccountBuilder))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableBankCoal);
                writer.WriteLine(boolEnableRooftops);
                writer.WriteLine(boolEnableLongRangeTraining);
                writer.WriteLine(boolEnableJugsOfWine);
                writer.WriteLine(boolEnableNoGpStart);
                writer.WriteLine("Quests");
                writer.WriteLine(boolEnableCooksAssistant);
                writer.WriteLine(boolEnableGoblinDiplomacy);
                writer.WriteLine(boolEnableRomeoAndJuliet);
                writer.WriteLine(boolEnableRuneMysteries);
                writer.WriteLine(boolEnableSheepShearer);
                writer.WriteLine(boolEnableVampyreSlayer);
                writer.WriteLine(boolEnableTheRestlessGhost);
                writer.WriteLine(boolEnableXMarksTheSpot);
                writer.WriteLine(boolEnableDruidicRitual);
                writer.WriteLine(boolEnableLostCity);
                writer.WriteLine(boolMageArenaOne);
                writer.WriteLine(boolEnableRoguesDen);
                writer.WriteLine("Agility");
                writer.WriteLine("<Find>10101010</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Agility.Text + "</Replace>");
                writer.WriteLine("Construction");
                writer.WriteLine("<Find>98989898</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Construction.Text + "</Replace>");
                writer.WriteLine("Cooking");
                writer.WriteLine("<Find>20202020</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Cooking.Text + "</Replace>");
                writer.WriteLine("Crafting");
                writer.WriteLine("<Find>13131313</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Crafting.Text + "</Replace>");
                writer.WriteLine("Farming");
                writer.WriteLine("<Find>23232323</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Farming.Text + "</Replace>");
                writer.WriteLine("Firemaking");
                writer.WriteLine("<Find>21212121</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Firemaking.Text + "</Replace>");
                writer.WriteLine("Fishing");
                writer.WriteLine("<Find>19191919</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Fishing.Text + "</Replace>");
                writer.WriteLine("Fletching");
                writer.WriteLine("<Find>14141414</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Fletching.Text + "</Replace>");
                writer.WriteLine("Herblore");
                writer.WriteLine("<Find>11111111</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Herblore.Text + "</Replace>");
                writer.WriteLine("Hunter");
                writer.WriteLine("<Find>16161616</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Hunter.Text + "</Replace>");
                writer.WriteLine("Magic");
                writer.WriteLine("<Find>96969696</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Magic.Text + "</Replace>");
                writer.WriteLine("Melee");
                writer.WriteLine("<Find>93939393</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Melee.Text + "</Replace>");
                writer.WriteLine("Mining");
                writer.WriteLine("<Find>17171717</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Mining.Text + "</Replace>");
                writer.WriteLine("Prayer");
                writer.WriteLine("<Find>95959595</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Prayer.Text + "</Replace>");
                writer.WriteLine("Ranged");
                writer.WriteLine("<Find>94949494</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Ranged.Text + "</Replace>");
                writer.WriteLine("Runecrafting");
                writer.WriteLine("<Find>97979797</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Runecrafting.Text + "</Replace>");
                writer.WriteLine("Slayer");
                writer.WriteLine("<Find>15151515</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Slayer.Text + "</Replace>");
                writer.WriteLine("Smithing");
                writer.WriteLine("<Find>18181818</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Smithing.Text + "</Replace>");
                writer.WriteLine("Thieving");
                writer.WriteLine("<Find>12121212</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Thieving.Text + "</Replace>");
                writer.WriteLine("Woodcutting");
                writer.WriteLine("<Find>22222222</Find><Replace>" + textBoxScriptProfiles_AccountBuilder_Woodcutting.Text + "</Replace>");
                writer.WriteLine("Activity Duration");
                writer.WriteLine("<Find>5400000,true,1800000,true</Find><Replace>" + activityDuration + ",true," + activityDurationVariation + ",true</Replace>");
                writer.WriteLine("<Find>12600000</Find><Replace>" + goldFarmingDuration + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

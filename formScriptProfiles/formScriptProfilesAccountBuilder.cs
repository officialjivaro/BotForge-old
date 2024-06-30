using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesAccountBuilder : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesAccountBuilder(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        int intMainActivityDuration;
        int intMainActivityDurationVariation;
        int intGoldFarmingActivityDuration;
        int intGoldFarmingActivityDurationVariation;
        int intGoldFarmingDuration;
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBankOre = "<Find>boolEnableBankOre:false</Find><Replace>boolEnableBankOre:false</Replace>";
        string boolEnableBuryBones = "<Find>boolEnableBuryBones:false</Find><Replace>boolEnableBuryBones:false</Replace>";
        string boolEnableChaosTemple = "<Find>boolEnableChaosTemple:false</Find><Replace>boolEnableChaosTemple:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDiscordWebhooks = "<Find>boolEnableDiscordWebhooks:false</Find><Replace>boolEnableDiscordWebhooks:false</Replace>";
        string boolEnableGoldFarmingBuyBronzeBars = "<Find>boolEnableGoldFarmingBuyBronzeBars:false</Find><Replace>boolEnableGoldFarmingBuyBronzeBars:false</Replace>";
        string boolEnableGoldFarmingCastBonesToBananas = "<Find>boolEnableGoldFarmingCastBonesToBananas:false</Find><Replace>boolEnableGoldFarmingCastBonesToBananas:false</Replace>";
        string boolEnableGoldFarmingCollectBones = "<Find>boolEnableGoldFarmingCollectBones:false</Find><Replace>boolEnableGoldFarmingCollectBones:false</Replace>";
        string boolEnableGoldFarmingCollectFishFood = "<Find>boolEnableGoldFarmingCollectFishFood:false</Find><Replace>boolEnableGoldFarmingCollectFishFood:false</Replace>";
        string boolEnableGoldFarmingCollectMonksRobes = "<Find>boolEnableGoldFarmingCollectMonksRobes:false</Find><Replace>boolEnableGoldFarmingCollectMonksRobes:false</Replace>";
        string boolEnableGoldFarmingCollectPotatoes = "<Find>boolEnableGoldFarmingCollectPotatoes:false</Find><Replace>boolEnableGoldFarmingCollectPotatoes:false</Replace>";
        string boolEnableGoldFarmingCollectRedSpidersEggs = "<Find>boolEnableGoldFarmingCollectRedSpidersEggs:false</Find><Replace>boolEnableGoldFarmingCollectRedSpidersEggs:false</Replace>";
        string boolEnableGoldFarmingCollectTinderboxes = "<Find>boolEnableGoldFarmingCollectTinderboxes:false</Find><Replace>boolEnableGoldFarmingCollectTinderboxes:false</Replace>";
        string boolEnableGoldFarmingKillCows = "<Find>boolEnableGoldFarmingKillCows:false</Find><Replace>boolEnableGoldFarmingKillCows:false</Replace>";
        string boolEnableGoldFarmingMakeBowstrings = "<Find>boolEnableGoldFarmingMakeBowstrings:false</Find><Replace>boolEnableGoldFarmingMakeBowstrings:false</Replace>";
        string boolEnableGoldFarmingTanHides = "<Find>boolEnableGoldFarmingTanHides:false</Find><Replace>boolEnableGoldFarmingTanHides:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableJugsOfWine = "<Find>boolEnableJugsOfWine:false</Find><Replace>boolEnableJugsOfWine:false</Replace>";
        string boolEnableLongRangeTraining = "<Find>boolEnableLongRangeTraining:false</Find><Replace>boolEnableLongRangeTraining:false</Replace>";
        string boolEnableFailedRestockGoldFarming = "<Find>boolEnableFailedRestockGoldFarming:false</Find><Replace>boolEnableFailedRestockGoldFarming:false</Replace>";
        string boolEnableQuestAPorcineOfInterest = "<Find>boolEnableQuestAPorcineOfInterest:false</Find><Replace>boolEnableQuestAPorcineOfInterest:false</Replace>";
        string boolEnableQuestCooksAssistant = "<Find>boolEnableQuestCooksAssistant:false</Find><Replace>boolEnableQuestCooksAssistant:false</Replace>";
        string boolEnableQuestDoricsQuest = "<Find>boolEnableQuestDoricsQuest:false</Find><Replace>boolEnableQuestDoricsQuest:false</Replace>";
        string boolEnableQuestDruidicRitual = "<Find>boolEnableQuestDruidicRitual:false</Find><Replace>boolEnableQuestDruidicRitual:false</Replace>";
        string boolEnableQuestDwarfCannon = "<Find>boolEnableQuestDwarfCannon:false</Find><Replace>boolEnableQuestDwarfCannon:false</Replace>";
        string boolEnableQuestErnestTheChicken = "<Find>boolEnableQuestErnestTheChicken:false</Find><Replace>boolEnableQuestErnestTheChicken:false</Replace>";
        string boolEnableQuestGoblinDiplomacy = "<Find>boolEnableQuestGoblinDiplomacy:false</Find><Replace>boolEnableQuestGoblinDiplomacy:false</Replace>";
        string boolEnableQuestImpCatcher = "<Find>boolEnableQuestImpCatcher:false</Find><Replace>boolEnableQuestImpCatcher:false</Replace>";
        string boolEnableQuestInSearchOfTheMyreque = "<Find>boolEnableQuestInSearchOfTheMyreque:false</Find><Replace>boolEnableQuestInSearchOfTheMyreque:false</Replace>";
        string boolEnableQuestLostCity = "<Find>boolEnableQuestLostCity:false</Find><Replace>boolEnableQuestLostCity:false</Replace>";
        string boolEnableQuestMageArenaOne = "<Find>boolEnableQuestMageArenaOne:false</Find><Replace>boolEnableQuestMageArenaOne:false</Replace>";
        string boolEnableQuestNaturesSpirit = "<Find>boolEnableQuestNaturesSpirit:false</Find><Replace>boolEnableQuestNaturesSpirit:false</Replace>";
        string boolEnableQuestPriestInPeril = "<Find>boolEnableQuestPriestInPeril:false</Find><Replace>boolEnableQuestPriestInPeril:false</Replace>";
        string boolEnableQuestRomeoAndJuliet = "<Find>boolEnableQuestRomeoAndJuliet:false</Find><Replace>boolEnableQuestRomeoAndJuliet:false</Replace>";
        string boolEnableQuestRuneMysteries = "<Find>boolEnableQuestRuneMysteries:false</Find><Replace>boolEnableQuestRuneMysteries:false</Replace>";
        string boolEnableQuestSheepShearer = "<Find>boolEnableQuestSheepShearer:false</Find><Replace>boolEnableQuestSheepShearer:false</Replace>";
        string boolEnableQuestTheKnightsSword = "<Find>boolEnableQuestTheKnightsSword:false</Find><Replace>boolEnableQuestTheKnightsSword:false</Replace>";
        string boolEnableQuestTheRestlessGhost = "<Find>boolEnableQuestTheRestlessGhost:false</Find><Replace>boolEnableQuestTheRestlessGhost:false</Replace>";
        string boolEnableQuestVampyreSlayer = "<Find>boolEnableQuestVampyreSlayer:false</Find><Replace>boolEnableQuestVampyreSlayer:false</Replace>";
        string boolEnableQuestXMarksTheSpot = "<Find>boolEnableQuestXMarksTheSpot:false</Find><Replace>boolEnableQuestXMarksTheSpot:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableRoguesDen = "<Find>boolEnableRoguesDen:false</Find><Replace>boolEnableRoguesDen:false</Replace>";
        string boolEnableRooftops = "<Find>boolEnableRooftops:false</Find><Replace>boolEnableRooftops:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string goldFarmingActivityDuration;
        string goldFarmingActivityDurationVariation;
        string goldFarmingDuration;
        string mainActivityDuration;
        string mainActivityDurationVariation;

        string filepathProfileAccountBuilder = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxAccountBuilder.txt");

        // Form Load
        public void formScriptProfiles_AccountBuilder_Load(object sender, EventArgs e)
        {

        }

        // Cancel Non Numbers From Textbox
        public void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_KeyPress(sender, e);
        }

        // Cancel Non Numbers & Set Limit To 99 From Textbox
        public void GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(sender, e);
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_AccountBuilder_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_AccountBuilder_Antipattern},
                {"boolEnableBankOre", checkBoxScriptProfiles_AccountBuilder_BankOre},
                {"boolEnableBuryBones", checkBoxScriptProfiles_AccountBuilder_BuryBones},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_AccountBuilder_DeathHandler},
                {"boolEnableDiscordWebhooks", checkBoxScriptProfiles_AccountBuilder_DiscordWebhooks},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_AccountBuilder_WorldHopping},
                {"boolEnableJugsOfWine", checkBoxScriptProfiles_AccountBuilder_EnableJugsOfWine},
                {"boolEnableLongRangeTraining", checkBoxScriptProfiles_AccountBuilder_EnableLongrangeTraining},
                {"boolEnableFailedRestockGoldFarming", checkBoxScriptProfiles_AccountBuilder_EnableNoGpStart},
                {"boolEnableRenewBond", checkBoxScriptProfiles_AccountBuilder_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_AccountBuilder_Restocking},
                {"boolEnableRooftops", checkBoxScriptProfiles_AccountBuilder_EnableRooftops},
                {"boolEnableSellLoot", checkBoxScriptProfiles_AccountBuilder_SellLoot}
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
                    {"Cooks Assistant", () => boolEnableQuestCooksAssistant = "<Find>boolEnableQuestCooksAssistant:false</Find><Replace>boolEnableQuestCooksAssistant:true</Replace>"},
                    {"Doric's Quest", () => boolEnableQuestDoricsQuest = "<Find>boolEnableQuestDoricsQuest:false</Find><Replace>boolEnableQuestDoricsQuest:true</Replace>"},
                    {"Ernest the Chicken", () => boolEnableQuestErnestTheChicken = "<Find>boolEnableQuestErnestTheChicken:false</Find><Replace>boolEnableQuestErnestTheChicken:true</Replace>"},
                    {"Goblin Diplomacy", () => boolEnableQuestGoblinDiplomacy = "<Find>boolEnableQuestGoblinDiplomacy:false</Find><Replace>boolEnableQuestGoblinDiplomacy:true</Replace>"},
                    {"Imp Catcher", () => boolEnableQuestImpCatcher = "<Find>boolEnableQuestImpCatcher:false</Find><Replace>boolEnableQuestImpCatcher:true</Replace>"},
                    {"Romeo & Juliet", () => boolEnableQuestRomeoAndJuliet = "<Find>boolEnableQuestRomeoAndJuliet:false</Find><Replace>boolEnableQuestRomeoAndJuliet:true</Replace>"},
                    {"Rune Mysteries", () => boolEnableQuestRuneMysteries = "<Find>boolEnableQuestRuneMysteries:false</Find><Replace>boolEnableQuestRuneMysteries:true</Replace>"},
                    {"Sheep Shearer", () => boolEnableQuestSheepShearer = "<Find>boolEnableQuestSheepShearer:false</Find><Replace>boolEnableQuestSheepShearer:true</Replace>"},
                    {"The Knight's Sword", () => boolEnableQuestTheKnightsSword = "<Find>boolEnableQuestTheKnightsSword:false</Find><Replace>boolEnableQuestTheKnightsSword:true</Replace>"},
                    {"The Restless Ghost", () => boolEnableQuestTheRestlessGhost = "<Find>boolEnableQuestTheRestlessGhost:false</Find><Replace>boolEnableQuestTheRestlessGhost:true</Replace>"},
                    {"Vampyre Slayer", () => boolEnableQuestVampyreSlayer = "<Find>boolEnableQuestVampyreSlayer:false</Find><Replace>boolEnableQuestVampyreSlayer:true</Replace>"},
                    {"X Marks The Spot", () => boolEnableQuestXMarksTheSpot = "<Find>boolEnableQuestXMarksTheSpot:false</Find><Replace>boolEnableQuestXMarksTheSpot:true</Replace>"}
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
                    {"A Porcine of Interest", () => boolEnableQuestDruidicRitual = "<Find>boolEnableQuestAPorcineOfInterest:false</Find><Replace>boolEnableQuestAPorcineOfInterest:true</Replace>"},
                    {"Druidic Ritual", () => boolEnableQuestDruidicRitual = "<Find>boolEnableQuestDruidicRitual:false</Find><Replace>boolEnableQuestDruidicRitual:true</Replace>"},
                    {"Dwarf Cannon", () => boolEnableQuestDwarfCannon = "<Find>boolEnableQuestDwarfCannon:false</Find><Replace>boolEnableQuestDwarfCannon:true</Replace>"},
                    {"In Search of the Myreque", () => boolEnableQuestInSearchOfTheMyreque = "<Find>boolEnableQuestInSearchOfTheMyreque:false</Find><Replace>boolEnableQuestInSearchOfTheMyreque:true</Replace>"},
                    {"Lost City", () => boolEnableQuestLostCity = "<Find>boolEnableQuestLostCity:false</Find><Replace>boolEnableQuestLostCity:true</Replace>"},
                    {"Nature's Spirit", () => boolEnableQuestNaturesSpirit = "<Find>boolEnableQuestNaturesSpirit:false</Find><Replace>boolEnableQuestNaturesSpirit:true</Replace>"},
                    {"Priest in Peril", () => boolEnableQuestPriestInPeril = "<Find>boolEnableQuestPriestInPeril:false</Find><Replace>boolEnableQuestPriestInPeril:true</Replace>"}
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
                    {"Mage Arena I", () => boolEnableQuestMageArenaOne = "<Find>boolEnableQuestMageArenaOne:false</Find><Replace>boolEnableQuestMageArenaOne:true</Replace>"},
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

            // Set Misc Variables 
            if (listBoxScriptProfiles_AccountBuilder_MiscActivities.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> miniQuestsMap = new Dictionary<string, Action>
                {
                    {"Elder Chaos Druids", () => boolEnableChaosTemple = "<Find>boolEnableChaosTemple:false</Find><Replace>boolEnableChaosTemple:true</Replace>"},
                    {"Rogues Den", () => boolEnableRoguesDen = "<Find>boolEnableRoguesDen:false</Find><Replace>boolEnableRoguesDen:true</Replace>"},
                };

                // Loop Through Dictionary & Generate Output 
                foreach (var selectedMiniItem in listBoxScriptProfiles_AccountBuilder_MiscActivities.SelectedItems)
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


            // Set GoldFarming Variables
            if (listBoxScriptProfiles_AccountBuilder_GoldFarmingActivities.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> goldFarmingAcitivitiesMap = new Dictionary<string, Action>
                {
                    {"Buy Bronze Bars", () => boolEnableGoldFarmingBuyBronzeBars = "<Find>boolEnableGoldFarmingBuyBronzeBars:false</Find><Replace>boolEnableGoldFarmingBuyBronzeBars:true</Replace>"},
                    {"Cast Bones to Bananas", () => boolEnableGoldFarmingCastBonesToBananas = "<Find>boolEnableGoldFarmingCastBonesToBananas:false</Find><Replace>boolEnableGoldFarmingCastBonesToBananas:true</Replace>"},
                    {"Collect Bones", () => boolEnableGoldFarmingCollectBones = "<Find>boolEnableGoldFarmingCollectBones:false</Find><Replace>boolEnableGoldFarmingCollectBones:true</Replace>"},
                    {"Collect Fish Food", () => boolEnableGoldFarmingCollectFishFood = "<Find>boolEnableGoldFarmingCollectFishFood:false</Find><Replace>boolEnableGoldFarmingCollectFishFood:true</Replace>"},
                    {"Collect Monk's Robes", () => boolEnableGoldFarmingCollectMonksRobes = "<Find>boolEnableGoldFarmingCollectMonksRobes:false</Find><Replace>boolEnableGoldFarmingCollectMonksRobes:true</Replace>"},
                    {"Collect Potatoes", () => boolEnableGoldFarmingCollectPotatoes = "<Find>boolEnableGoldFarmingCollectPotatoes:false</Find><Replace>boolEnableGoldFarmingCollectPotatoes:true</Replace>"},
                    {"Collect Red Spiders' Eggs", () => boolEnableGoldFarmingCollectRedSpidersEggs = "<Find>boolEnableGoldFarmingCollectRedSpidersEggs:false</Find><Replace>boolEnableGoldFarmingCollectRedSpidersEggs:true</Replace>"},
                    {"Collect Tinderboxes", () => boolEnableGoldFarmingCollectTinderboxes = "<Find>boolEnableGoldFarmingCollectTinderboxes:false</Find><Replace>boolEnableGoldFarmingCollectTinderboxes:true</Replace>"},
                    {"Kill Cows", () => boolEnableGoldFarmingKillCows = "<Find>boolEnableGoldFarmingKillCows:false</Find><Replace>boolEnableGoldFarmingKillCows:true</Replace>"},
                    {"Make Bowstrings", () => boolEnableGoldFarmingMakeBowstrings = "<Find>boolEnableGoldFarmingMakeBowstrings:false</Find><Replace>boolEnableGoldFarmingMakeBowstrings:true</Replace>"},
                    {"Tan Hides", () => boolEnableGoldFarmingTanHides = "<Find>boolEnableGoldFarmingTanHides:false</Find><Replace>boolEnableGoldFarmingTanHides:true</Replace>"}
                };

                // Loop Through Dictionary & Generate Output 
                foreach (var selectedGoldFarmingItem in listBoxScriptProfiles_AccountBuilder_GoldFarmingActivities.SelectedItems)
                {
                    string selectedGoldFarmingActivity = selectedGoldFarmingItem.ToString();

                    foreach (var goldFarmingActivitiy in goldFarmingAcitivitiesMap)
                    {
                        if (selectedGoldFarmingActivity.Contains(goldFarmingActivitiy.Key))
                        {
                            goldFarmingActivitiy.Value.Invoke();
                        }
                    }
                }
            }

            // Main Activity Time Min To Ms Converter 
            int.TryParse(textBoxScriptProfiles_AccountBuilder_MainActivityDuration.Text, out int intMainActivityDurationMs);
            {
                intMainActivityDuration = intMainActivityDurationMs * 60000;
                mainActivityDuration = intMainActivityDuration.ToString();
            }

            // Main Activity Time Variation Min To Ms Converter 
            int.TryParse(textBoxScriptProfiles_AccountBuilder_MainAcivityDurationVariation.Text, out int intMainActivityDurationVariationMs);
            {
                intMainActivityDurationVariation = intMainActivityDurationVariationMs * 60000;
                mainActivityDurationVariation = intMainActivityDurationVariation.ToString();
            }

            // Gold Farming Activity Time Min To Ms Converter 
            int.TryParse(textBoxScriptProfiles_AccountBuilder_GoldFarmingActivityDuration.Text, out int intGoldFarmingActivityDurationMs);
            {
                intGoldFarmingActivityDuration = intGoldFarmingActivityDurationMs * 60000;
                goldFarmingActivityDuration = intGoldFarmingActivityDuration.ToString();
            }

            // Gold Farming Activity Time Variation Min To Ms Converter 
            int.TryParse(textBoxScriptProfiles_AccountBuilder_GoldFarmingAcivityDurationVariation.Text, out int intGoldFarmingActivityDurationVariationMs);
            {
                intGoldFarmingActivityDurationVariation = intGoldFarmingActivityDurationVariationMs * 60000;
                goldFarmingActivityDurationVariation = intGoldFarmingActivityDurationVariation.ToString();
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileAccountBuilder))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableDiscordWebhooks);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nAccount Builder Settings");
                writer.WriteLine(boolEnableBankOre);
                writer.WriteLine(boolEnableBuryBones);
                writer.WriteLine(boolEnableJugsOfWine);
                writer.WriteLine(boolEnableLongRangeTraining);
                writer.WriteLine(boolEnableFailedRestockGoldFarming);
                writer.WriteLine(boolEnableRooftops);
                writer.WriteLine("\nF2p Quest Settings");
                writer.WriteLine(boolEnableQuestCooksAssistant);
                writer.WriteLine(boolEnableQuestDoricsQuest);
                writer.WriteLine(boolEnableQuestErnestTheChicken);
                writer.WriteLine(boolEnableQuestGoblinDiplomacy);
                writer.WriteLine(boolEnableQuestImpCatcher);
                writer.WriteLine(boolEnableQuestRomeoAndJuliet);
                writer.WriteLine(boolEnableQuestRuneMysteries);
                writer.WriteLine(boolEnableQuestSheepShearer);
                writer.WriteLine(boolEnableQuestVampyreSlayer);
                writer.WriteLine(boolEnableQuestTheKnightsSword);
                writer.WriteLine(boolEnableQuestTheRestlessGhost);
                writer.WriteLine(boolEnableQuestXMarksTheSpot);
                writer.WriteLine("\nP2p Quest Settings");
                writer.WriteLine(boolEnableQuestAPorcineOfInterest);
                writer.WriteLine(boolEnableQuestDruidicRitual);
                writer.WriteLine(boolEnableQuestDwarfCannon);
                writer.WriteLine(boolEnableQuestInSearchOfTheMyreque);
                writer.WriteLine(boolEnableQuestLostCity);
                writer.WriteLine(boolEnableQuestNaturesSpirit);
                writer.WriteLine(boolEnableQuestPriestInPeril);
                writer.WriteLine("\nMini Quest Settings");
                writer.WriteLine(boolEnableQuestMageArenaOne);
                writer.WriteLine("\nMiscellaneous Activity Settings");
                writer.WriteLine(boolEnableChaosTemple);
                writer.WriteLine(boolEnableRoguesDen);
                writer.WriteLine("\nGold Farming Settings");
                writer.WriteLine(boolEnableGoldFarmingBuyBronzeBars);
                writer.WriteLine(boolEnableGoldFarmingCastBonesToBananas);
                writer.WriteLine(boolEnableGoldFarmingCollectBones);
                writer.WriteLine(boolEnableGoldFarmingCollectFishFood);
                writer.WriteLine(boolEnableGoldFarmingCollectMonksRobes);
                writer.WriteLine(boolEnableGoldFarmingCollectPotatoes);
                writer.WriteLine(boolEnableGoldFarmingCollectRedSpidersEggs);
                writer.WriteLine(boolEnableGoldFarmingCollectTinderboxes);
                writer.WriteLine(boolEnableGoldFarmingKillCows);
                writer.WriteLine(boolEnableGoldFarmingMakeBowstrings);
                writer.WriteLine(boolEnableGoldFarmingTanHides);
                writer.WriteLine("\nGold Farming Activity Duration Settings");
                writer.WriteLine("<Find>14400000,true,5400000,true</Find><Replace>" + goldFarmingActivityDuration + ",true," + goldFarmingActivityDurationVariation + ",true</Replace>");
                writer.WriteLine("\nSkill Settings");
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
                writer.WriteLine("\nMain Activity Duration Settings");
                writer.WriteLine("<Find>7200000,true,3600000,true</Find><Replace>" + mainActivityDuration + ",true," + mainActivityDurationVariation + ",true</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

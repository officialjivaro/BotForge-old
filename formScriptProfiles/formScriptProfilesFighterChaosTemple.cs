using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterChaosTemple : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterChaosTemple(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableAvoidCannon = "<Find>boolEnableAvoidCannon:false</Find><Replace>boolEnableAvoidCannon:false</Replace>";
        string boolEnableAvoidPlayers = "<Find>boolEnableAvoidPlayers:false</Find><Replace>boolEnableAvoidPlayers:false</Replace>";
        string boolEnablePrayersOffensive = "<Find>boolEnablePrayersOffensive:false</Find><Replace>boolEnablePrayersOffensive:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDiscordWebhooks = "<Find>boolEnableDiscordWebhooks:false</Find><Replace>boolEnableDiscordWebhooks:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableLootArrows = "<Find>boolEnableLootArrows:false</Find><Replace>boolEnableLootArrows:false</Replace>";
        string boolEnableProgressiveTraining = "<Find>boolEnableProgressiveTraining:false</Find><Replace>boolEnableProgressiveTraining:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableTeleportFromPkers = "<Find>boolEnableTeleportFromPkers:false</Find><Replace>boolEnableTeleportFromPkers:false</Replace>";
        string filepathProfileFighterChaosTemple = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-ChaosTemple.txt");

        // Form Load
        public void formScriptProfilesFighterChaosTemple_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_FighterChaosTemple_SelectCape.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterChaosTemple_SelectGear.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterChaosTemple_SelectBoots.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterChaosTemple_SelectHeadgear.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterChaosTemple_SelectWeapon.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_FighterChaosTemple_SaveButton_Click(object sender, EventArgs e)
        {

            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterChaosTemple_Antipattern},
                {"boolEnableAvoidCannon", checkBoxScriptProfiles_FighterChaosTemple_AvoidCannon},
                {"boolEnableAvoidPlayers", checkBoxScriptProfiles_FighterChaosTemple_AvoidPlayers},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterChaosTemple_DeathHandler},
                {"boolEnableDiscordWebhooks", checkBoxScriptProfiles_FighterChaosTemple_DiscordWebhooks},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterChaosTemple_WorldHopping},
                {"boolEnableLootArrows", checkBoxScriptProfiles_FighterChaosTemple_LootArrows},
                {"boolEnablePrayersOffensive", checkBoxScriptProfiles_FighterChaosTemple_UseOffensivePrayers},
                {"boolEnableProgressiveTraining", checkBoxScriptProfiles_FighterChaosTemple_ProgressiveTraining},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterChaosTemple_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterChaosTemple_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterChaosTemple_SellLoot},
                {"boolEnableTeleportFromPkers", checkBoxScriptProfiles_FighterChaosTemple_AvoidPkers}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileFighterChaosTemple))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nElder Chaos Druids Settings");
                writer.WriteLine(boolEnableAvoidCannon);
                writer.WriteLine(boolEnableAvoidPlayers);
                writer.WriteLine(boolEnablePrayersOffensive);
                writer.WriteLine(boolEnableLootArrows);
                writer.WriteLine(boolEnableProgressiveTraining);
                writer.WriteLine(boolEnableTeleportFromPkers);
                writer.WriteLine("\nGear Settings");
                writer.WriteLine("<Find>BothNpcs/*/ElderChaosDruids/*/ZombiePirates</Find><Replace>" + comboBoxScriptProfiles_FighterChaosTemple_SelectNpc.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/BestEquipable/*/ClimbingBoots/*/RuneBoots/*/DragonBoots/*/SnakeskinBoots</Find><Replace>" + comboBoxScriptProfiles_FighterChaosTemple_SelectBoots.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Random/*/GuthixCloak/*/ZamorakCloak/*/SaradominCloak</Find><Replace>" + comboBoxScriptProfiles_FighterChaosTemple_SelectCape.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Random/*/MonksRobe/*/ZamorakMonksRobe</Find><Replace>" + comboBoxScriptProfiles_FighterChaosTemple_SelectGear.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Random/*/GuthixMitre/*/SaradominMitre/*/ZamorakMitre</Find><Replace>" + comboBoxScriptProfiles_FighterChaosTemple_SelectHeadgear.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Random/*/MeleeProgressive/*/RangedProgressive/*/DragonWarhammer/*/AbyssalWhip</Find><Replace>" + comboBoxScriptProfiles_FighterChaosTemple_SelectWeapon.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

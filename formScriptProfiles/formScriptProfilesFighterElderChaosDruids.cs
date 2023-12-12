using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterElderChaosDruids : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterElderChaosDruids(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableAvoidCannon = "<Find>boolEnableAvoidCannon:false</Find><Replace>boolEnableAvoidCannon:false</Replace>";
        string boolEnableAvoidPlayers = "<Find>boolEnableAvoidPlayers:false</Find><Replace>boolEnableAvoidPlayers:false</Replace>";
        string boolEnableDamagePrayers = "<Find>boolEnableDamagePrayers:false</Find><Replace>boolEnableDamagePrayers:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableLootArrows = "<Find>boolEnableLootArrows:false</Find><Replace>boolEnableLootArrows:false</Replace>";
        string boolEnableProgressiveTraining = "<Find>boolEnableProgressiveTraining:false</Find><Replace>boolEnableProgressiveTraining:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableTeleportFromPkers = "<Find>boolEnableTeleportFromPkers:false</Find><Replace>boolEnableTeleportFromPkers:false</Replace>";
        string filepathProfileFighterElderChaosDruids = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-ElderChaosDruids.txt");

        // Form Load
        public void formScriptProfilesFighterElderChaosDruids_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_FighterElderChaosDruids_SelectCape.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterElderChaosDruids_SelectGear.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterElderChaosDruids_SelectBoots.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterElderChaosDruids_SelectHeadgear.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterElderChaosDruids_SelectWeapon.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_FighterElderChaosDruids_SaveButton_Click(object sender, EventArgs e)
        {

            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterElderChaosDruids_Antipattern},
                {"boolEnableAvoidCannon", checkBoxScriptProfiles_FighterElderChaosDruids_AvoidCannon},
                {"boolEnableAvoidPlayers", checkBoxScriptProfiles_FighterElderChaosDruids_AvoidPlayers},
                {"boolEnableDamagePrayers", checkBoxScriptProfiles_FighterElderChaosDruids_UseOffensivePrayers},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterElderChaosDruids_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterElderChaosDruids_WorldHopping},
                {"boolEnableLootArrows", checkBoxScriptProfiles_FighterElderChaosDruids_LootArrows},
                {"boolEnableProgressiveTraining", checkBoxScriptProfiles_FighterElderChaosDruids_ProgressiveTraining},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterElderChaosDruids_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterElderChaosDruids_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterElderChaosDruids_SellLoot},
                {"boolEnableTeleportFromPkers", checkBoxScriptProfiles_FighterElderChaosDruids_AvoidPkers}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileFighterElderChaosDruids))
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
                writer.WriteLine(boolEnableDamagePrayers);
                writer.WriteLine(boolEnableLootArrows);
                writer.WriteLine(boolEnableProgressiveTraining);
                writer.WriteLine(boolEnableTeleportFromPkers);
                writer.WriteLine("\nGear Settings");
                writer.WriteLine("<Find>None/*/BestEquipable/*/ClimbingBoots/*/RuneBoots/*/DragonBoots/*/SnakeskinBoots</Find><Replace>" + comboBoxScriptProfiles_FighterElderChaosDruids_SelectBoots.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Random/*/GuthixCloak/*/ZamorakCloak/*/SaradominCloak</Find><Replace>" + comboBoxScriptProfiles_FighterElderChaosDruids_SelectCape.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Random/*/MonksRobe/*/ZamorakMonksRobe</Find><Replace>" + comboBoxScriptProfiles_FighterElderChaosDruids_SelectGear.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Random/*/GuthixMitre/*/SaradominMitre/*/ZamorakMitre</Find><Replace>" + comboBoxScriptProfiles_FighterElderChaosDruids_SelectHeadgear.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Random/*/Melee/*/Ranged/*/AbyssalWhip/*/MagicShortbow</Find><Replace>" + comboBoxScriptProfiles_FighterElderChaosDruids_SelectWeapon.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

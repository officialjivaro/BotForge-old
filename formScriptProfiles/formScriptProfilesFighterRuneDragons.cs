using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterRuneDragons : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterRuneDragons(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDiscordWebhooks = "<Find>boolEnableDiscordWebhooks:false</Find><Replace>boolEnableDiscordWebhooks:false</Replace>";
        string boolEnableEvadeGroundAttack = "<Find>boolEnableEvadeGroundAttack:false</Find><Replace>boolEnableEvadeGroundAttack:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableSpecialAttack = "<Find>boolEnableSpecialAttack:false</Find><Replace>boolEnableSpecialAttack:false</Replace>";
        string filepathProfileRuneDragons = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-RuneDragons.txt");

        // Form Load
        public void formScriptProfilesFighterRuneDragons_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_RuneDragons_SelectMode.SelectedIndex = 0;
            comboBoxScriptProfiles_RuneDragons_SelectAntifirePotion.SelectedIndex = 0;
            comboBoxScriptProfiles_RuneDragons_SelectCombatPotion.SelectedIndex = 0;
        }

        // Require Input on textboxes
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_RuneDragons_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterRuneDragons_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterRuneDragons_DeathHandler},
                {"boolEnableDiscordWebhooks", checkBoxScriptProfiles_FighterRuneDragons_DiscordWebhooks},
                {"boolEnableEvadeGroundAttack", checkBoxScriptProfiles_FighterRuneDragons_EvadeGroundAttack},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterRuneDragons_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterRuneDragons_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterRuneDragons_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterRuneDragons_SellLoot},
                {"boolEnableSpecialAttack", checkBoxScriptProfiles_FighterRuneDragons_UseSpecialAttack}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileRuneDragons))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableDiscordWebhooks);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nRuneDragons Settings");
                writer.WriteLine(boolEnableEvadeGroundAttack);
                writer.WriteLine(boolEnableSpecialAttack);
                writer.WriteLine("<Find>Melee/*/Ranged</Find><Replace>" + comboBoxScriptProfiles_RuneDragons_SelectMode.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>ExtendedAntifire/*/ExtendedSuperAntifire</Find><Replace>" + comboBoxScriptProfiles_RuneDragons_SelectAntifirePotion.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/CombatPotion/*/SuperCombatPotion/*/RangingPotion</Find><Replace>" + comboBoxScriptProfiles_RuneDragons_SelectCombatPotion.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("\nMelee Gear Settings");
                writer.WriteLine("<Find>None</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Zamorak cloak</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeCape.Text + "</Replace>");
                writer.WriteLine("<Find>Justiciar chestguard</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeChest.Text + "</Replace>");
                writer.WriteLine("<Find>Regen bracelet</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeHands.Text + "</Replace>");
                writer.WriteLine("<Find>Justiciar faceguard</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeHead.Text + "</Replace>");
                writer.WriteLine("<Find>Justiciar Legguards</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Dragonfire shield</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeShield.Text + "</Replace>");
                writer.WriteLine("<Find>Zamorakian hasta</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MeleeWeapon.Text + "</Replace>");
                writer.WriteLine("\nRanged Gear Settings");
                writer.WriteLine("<Find>Diamond bolts (e)</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Ava's</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedCape.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide body</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedChest.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide vambraces</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedHands.Text + "</Replace>");
                writer.WriteLine("<Find>Guthix coif</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedHead.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide chaps</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Dragonfire ward</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedShield.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon crossbow</Find><Replace>" + textBoxScriptProfiles_RuneDragons_RangedWeapon.Text + "</Replace>");
                writer.WriteLine("\nMiscellaneous Gear Settings");
                writer.WriteLine("<Find>Amulet of fury</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MiscAmulet.Text + "</Replace>");
                writer.WriteLine("<Find>Brimstone ring</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MiscRing.Text + "</Replace>");
                writer.WriteLine("<Find>Insulated boots</Find><Replace>" + textBoxScriptProfiles_RuneDragons_MiscFeet.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

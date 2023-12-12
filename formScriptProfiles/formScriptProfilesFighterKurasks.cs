using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterKurasks : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterKurasks(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHighAlching = "<Find>boolEnableHighAlching:false</Find><Replace>boolEnableHighAlching:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileKurasks = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-Kurasks.txt");

        // Form Load
        public void formScriptProfilesFighterKurasks_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_Kurasks_SelectMode.SelectedIndex = 0;
            comboBoxScriptProfiles_Kurasks_SelectPotion.SelectedIndex = 0;
        }

        // Require Input on textboxes
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_Kurasks_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterKurasks_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterKurasks_DeathHandler},
                {"boolEnableHighAlching", checkBoxScriptProfiles_FighterKurasks_HighAlching},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterKurasks_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterKurasks_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterKurasks_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterKurasks_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileKurasks))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nKurasks Settings");
                writer.WriteLine(boolEnableHighAlching);
                writer.WriteLine("<Find>Ranged/*/Melee</Find><Replace>" + comboBoxScriptProfiles_Kurasks_SelectMode.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/RangingPotion/*/CombatPotion/*/SuperCombatPotion</Find><Replace>" + comboBoxScriptProfiles_Kurasks_SelectPotion.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("\nMelee Gear Settings");
                writer.WriteLine("<Find>None</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Zamorak cloak</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeCape.Text + "</Replace>");
                writer.WriteLine("<Find>Obsidian platebody</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeChest.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeFeet.Text + "</Replace>");
                writer.WriteLine("<Find>Granite gloves</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeHands.Text + "</Replace>");
                writer.WriteLine("<Find>Obsidian helmet</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeHead.Text + "</Replace>");
                writer.WriteLine("<Find>Obsidian platelegs</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Warrior ring</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeRing.Text + "</Replace>");
                writer.WriteLine("<Find>Abyssal whip</Find><Replace>" + textBoxScriptProfiles_Kurasks_MeleeWeapon.Text + "</Replace>");
                writer.WriteLine("\nRanged Gear Settings");
                writer.WriteLine("<Find>Broad bolts</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Ava's</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedCape.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide body</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedChest.Text + "</Replace>");
                writer.WriteLine("<Find>Snakeskin boots</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedFeet.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide vambraces</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedHands.Text + "</Replace>");
                writer.WriteLine("<Find>Snakeskin bandana</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedHead.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide chaps</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Ring of wealth</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedRing.Text + "</Replace>");
                writer.WriteLine("<Find>Rune crossbow</Find><Replace>" + textBoxScriptProfiles_Kurasks_RangedWeapon.Text + "</Replace>");
                writer.WriteLine("\nMiscellaneous Gear Settings");
                writer.WriteLine("<Find>Amulet of glory</Find><Replace>" + textBoxScriptProfiles_Kurasks_MiscAmulet.Text + "</Replace>");
                writer.WriteLine("<Find>Mirror shield</Find><Replace>" + textBoxScriptProfiles_Kurasks_MiscShield.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

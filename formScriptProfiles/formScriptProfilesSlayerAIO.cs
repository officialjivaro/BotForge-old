using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesSlayerAIO : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesSlayerAIO(formMainForm mainForm)
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
        string filepathProfileSlayerAIO = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxSlayer-AIO.txt");

        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_SlayerAIO_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_SlayerAIO_GeneralSettings_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_SlayerAIO_GeneralSettings_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_SlayerAIO_GeneralSettings_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_SlayerAIO_GeneralSettings_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_SlayerAIO_GeneralSettings_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_SlayerAIO_GeneralSettings_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileSlayerAIO))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nMagic Gear Settings");
                writer.WriteLine("<Find>Mystic robe top</Find><Replace>" + textboxScriptProfiles_SlayerAIO_GearMagic_Chest.Text + "</Replace>");
                writer.WriteLine("<Find>Mystic hat</Find><Replace>" + textboxScriptProfiles_SlayerAIO_GearMagic_Headgear.Text + "</Replace>");
                writer.WriteLine("<Find>Mystic robe bottom</Find><Replace>" + textboxScriptProfiles_SlayerAIO_GearMagic_Legs.Text + "</Replace>");
                writer.WriteLine("<Find>Mystic lava staff</Find><Replace>" + textboxScriptProfiles_SlayerAIO_GearMagic_Weapon.Text + "</Replace>");
                writer.WriteLine("\nMelee Gear Settings");
                writer.WriteLine("<Find>Rune chainbody</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_Chest.Text + "</Replace>");
                writer.WriteLine("<Find>Rune boots</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_FeetOne.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_FeetTwo.Text + "</Replace>");
                writer.WriteLine("<Find>Black mask</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_Headgear.Text + "</Replace>");
                writer.WriteLine("<Find>Rune platelegs</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_Legs.Text + "</Replace>");
                writer.WriteLine("<Find>Rune kiteshield</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_Shield.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon sword</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_WeaponOne.Text + "</Replace>");
                writer.WriteLine("<Find>Abyssal whip</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearMelee_WeaponTwo.Text + "</Replace>");
                writer.WriteLine("\nRanged Gear Settings");
                writer.WriteLine("<Find>Blue d'hide body</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_ChestOne.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide body</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_ChestTwo.Text + "</Replace>");
                writer.WriteLine("<Find>Snakeskin boots</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_Feet.Text + "</Replace>");
                writer.WriteLine("<Find>Blue d'hide vambraces</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_HandsOne.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide vambraces</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_HandsTwo.Text + "</Replace>");
                writer.WriteLine("<Find>Snakeskin bandana</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_Headgear.Text + "</Replace>");
                writer.WriteLine("<Find>Blue d'hide chaps</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_LegsOne.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide chaps</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_LegsTwo.Text + "</Replace>");
                writer.WriteLine("<Find>Blue d'hide shield</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_ShieldOne.Text + "</Replace>");
                writer.WriteLine("<Find>Black d'hide shield</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_ShieldTwo.Text + "</Replace>");
                writer.WriteLine("<Find>Adamant crossbow</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_WeaponOne.Text + "</Replace>");
                writer.WriteLine("<Find>Rune crossbow</Find><Replace>" + textBoxScriptProfiles_SlayeAIO_GearRanged_WeaponTwo.Text + "</Replace>");
                writer.WriteLine("\nMiscellaneous Gear Settings");
                writer.WriteLine("<Find>Armadyl cloak</Find><Replace>" + textboxScriptProfiles_SlayerAIO_GearMisc_Cape.Text + "</Replace>");
                writer.WriteLine("<Find>Combat bracelet</Find><Replace>" + textboxScriptProfiles_SlayerAIO_GearMisc_Hands.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

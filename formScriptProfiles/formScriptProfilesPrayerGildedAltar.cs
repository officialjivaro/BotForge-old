using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesPrayerGildedAltar : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesPrayerGildedAltar(formMainForm mainForm)
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
        string filepathProfilePrayerGildedAltar = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxPrayer-GildedAltar.txt");

        // Form Load 
        public void formScriptProfiles_PrayerGildedAltar_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.SelectedIndex = 0;
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
        public void btnScriptProfiles_PrayerGildedAltar_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_PrayerGildedAltar_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_PrayerGildedAltar_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_PrayerGildedAltar_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_PrayerGildedAltar_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_PrayerGildedAltar_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_PrayerGildedAltar_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfilePrayerGildedAltar))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nGilded Altar Settings");
                writer.WriteLine("<Find>BigBones/*/DragonBones/*/LavaDragonBones/*/SuperiorDragonBones</Find><Replace>" + comboBoxScriptProfiles_PrayerGildedAltar_SelectBone.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>95959595</Find><Replace>" + textBoxScriptProfiles_PrayerGildedAltar_PrayerStopLevel.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMagicOrber : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesMagicOrber(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableStaminaPotions = "<Find>boolEnableStaminaPotions:false</Find><Replace>boolEnableStaminaPotions:false</Replace>";
        string boolEnableUseRandomCape = "<Find>boolEnableUseRandomCape:false</Find><Replace>boolEnableUseRandomCape:false</Replace>";
        string filepathProfileMagicOrber = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMagic-Orber.txt");

        // Form load
        public void formScriptProfiles_MagicOrber_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_MagicOrber_SelectOrb.SelectedIndex = 0;
        }

        // Cancel non number input and set the limit to 99 on textchange
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
        public void btnScriptProfiles_MagicOrber_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_MagicOrber_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_MagicOrber_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_MagicOrber_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_MagicOrber_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_MagicOrber_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_MagicOrber_SellLoot},
                {"boolEnableStaminaPotions", checkBoxScriptProfiles_MagicOrber_UseStaminas},
                {"boolEnableUseRandomCape", checkBoxScriptProfiles_MagicOrber_UseRandomCape}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileMagicOrber))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nMagic Orber Settings");
                writer.WriteLine(boolEnableStaminaPotions);
                writer.WriteLine(boolEnableUseRandomCape);
                writer.WriteLine("<Find>Earth/*/Air</Find><Replace>" + comboBoxScriptProfiles_MagicOrber_SelectOrb.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>10101010</Find><Replace>" + textBoxScriptProfiles_MagicOrber_TrainAgility.Text + "</Replace>");
                writer.WriteLine("<Find>93939393</Find><Replace>" + textBoxScriptProfiles_MagicOrber_TrainMelee.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

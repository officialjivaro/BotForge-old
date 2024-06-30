using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesAccountBuilderMasterFarmer : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesAccountBuilderMasterFarmer(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        int intGoldFarmingDuration;
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableFarmMasterFarmers = "<Find>boolEnableFarmMasterFarmers:false</Find><Replace>boolEnableFarmMasterFarmers:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableFailedRestockGoldFarming = "<Find>boolEnableFailedRestockGoldFarming:false</Find><Replace>boolEnableFailedRestockGoldFarming:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableRooftops = "<Find>boolEnableRooftops:false</Find><Replace>boolEnableRooftops:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileAccountBuilderMasterFarmer = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxAccountBuilder-MasterFarmer.txt");
        string goldFarmingDuration;



        // Cancel Non Numbers From Textbox
        public void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                // Ensure the textbox always has an input
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("This field is required");
                    e.Cancel = true;
                }
            }
            else
            {
            }
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_AccountBuilderMasterFarmer_SaveButton_Click(object sender, EventArgs e)
        {

            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_AccountBuilderMasterFarmer_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_AccountBuilderMasterFarmer_DeathHandler},
                {"boolEnableFarmMasterFarmers", checkBoxScriptProfiles_AccountBuilderMasterFarmer_FarmMasterFarmers},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_AccountBuilderMasterFarmer_WorldHopping},
                {"boolEnableFailedRestockGoldFarming", checkBoxScriptProfiles_AccountBuilderMasterFarmer_NoGpStart},
                {"boolEnableRenewBond", checkBoxScriptProfiles_AccountBuilderMasterFarmer_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_AccountBuilderMasterFarmer_Restocking},
                {"boolEnableRooftops", checkBoxScriptProfiles_AccountBuilderMasterFarmer_RooftopsMethod},
                {"boolEnableSellLoot", checkBoxScriptProfiles_AccountBuilderMasterFarmer_SellLoot},
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


            //Gold Farming Activity Time Min To Ms Converter//
            int.TryParse(ScriptProfiles_AccountBuilderMasterFarmer_GoldFarmingDuration.Text, out int intGoldFarmingDurationMs);
            {
                intGoldFarmingDuration = intGoldFarmingDurationMs * 60000;
                goldFarmingDuration = intGoldFarmingDuration.ToString();
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileAccountBuilderMasterFarmer))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nAccount Builder Settings");
                writer.WriteLine(boolEnableFarmMasterFarmers);
                writer.WriteLine(boolEnableFailedRestockGoldFarming);
                writer.WriteLine(boolEnableRooftops);
                writer.WriteLine("<Find>71/*/85</Find><Replace>" + comboBoxScriptProfiles_AccountBuilderMasterFarmer_FarmingStopLevel.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("\nActivity Duration Settings");
                writer.WriteLine("<Find>12600000</Find><Replace>" + goldFarmingDuration + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }

        // Form load
        public void formScriptProfiles_AccountBuilderMasterFarmer_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_AccountBuilderMasterFarmer_FarmingStopLevel.SelectedIndex = 0;
        }
    }
}

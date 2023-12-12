using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMiningAIO : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesMiningAIO(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBankOre = "<Find>boolEnableBankOre:false</Find><Replace>boolEnableBankOre:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDragonPickaxe = "<Find>boolEnableDragonPickaxe:false</Find><Replace>boolEnableDragonPickaxe:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileMiningAIO = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMagic-Orber.txt");

        // Form load
        public void formScriptProfiles_MiningAIO_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_MiningAIO_SelectOre.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_MiningAIO_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_MiningAIO_Antipattern},
                {"boolEnableBankOre", checkBoxScriptProfiles_MiningAIO_BankOre},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_MiningAIO_DeathHandler},
                {"boolEnableDragonPickaxe", checkBoxScriptProfiles_MiningAIO_UseDragonPickaxe},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_MiningAIO_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_MiningAIO_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_MiningAIO_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_MiningAIO_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileMiningAIO))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nMining AIO Settings");
                writer.WriteLine(boolEnableBankOre);
                writer.WriteLine(boolEnableDragonPickaxe);
                writer.WriteLine("<Find>Progressive/*/Tin/*/Copper/*/Clay/*/Iron/*/Silver/*/Coal/*/Mithril/*/Adamantite/*/Runite</Find><Replace>" + comboBoxScriptProfiles_MiningAIO_SelectOre.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesCookingRangeAndFire : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesCookingRangeAndFire(formMainForm mainForm)
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
        string filepathProfileCookingRangeAndFire = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxCooking-RangeAndFire.txt");

        // Form Load
        public void formScriptProfiles_CookingRangeAndFire_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_CookingRangeAndFire_SelectDish.SelectedIndex = 0;
            comboBoxScriptProfiles_CookingRangeAndFire_SelectCookingArea.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_CookingRangeAndFire_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_CookingRangeAndFire_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_CookingRangeAndFire_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_CookingRangeAndFire_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_CookingRangeAndFire_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_CookingRangeAndFire_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_CookingRangeAndFire_SellLoot},
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
            using (StreamWriter writer = new StreamWriter(filepathProfileCookingRangeAndFire))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nCooking Range And Fire Settings");
                writer.WriteLine("<Find>Progressive/*/Shrimps/*/Trout/*/Salmon/*/Lobster/*/Swordfish/*/Monkfish/*/Shark/*/Anglerfish</Find><Replace>" + comboBoxScriptProfiles_CookingRangeAndFire_SelectDish.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>AlKharid/*/Falador/*/Hosidius/*/Zanaris/*/RoguesDen</Find><Replace>" + comboBoxScriptProfiles_CookingRangeAndFire_SelectCookingArea.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

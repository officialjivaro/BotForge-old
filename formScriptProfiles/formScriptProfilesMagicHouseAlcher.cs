using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMagicHouseAlcher : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesMagicHouseAlcher(formMainForm mainForm)
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
        string filepathProfileMagicHouseAlcher = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMagic-HouseAlcher.txt");

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_MagicHouseAlcher_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_MagicHouseAlcher_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_MagicHouseAlcher_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_MagicHouseAlcher_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_MagicHouseAlcher_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_MagicHouseAlcher_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_MagicHouseAlcher_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileMagicHouseAlcher))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nMagic House Alcher Settings");
                writer.WriteLine("<Find>Yew longbow</Find><Replace>" + textBoxScriptProfiles_MagicHouseAlcher_ItemToAlch.Text + "</Replace>");
                writer.WriteLine("<Find>855</Find><Replace>" + textBoxScriptProfiles_MagicHouseAlcher_ItemId.Text + "</Replace>");
            }

            MessageBox.Show("Profile successfully created.");

        }

        // Button click - Search for item id
        public void btnScriptProfiles_MagicHouseAlcher_SearchForId_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.osrsbox.com/tools/item-search/");
        }
    }
}

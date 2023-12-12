using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesRunecraftingZeah : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesRunecraftingZeah(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBuyDragonPickaxe = "<Find>boolEnableBuyDragonPickaxe:false</Find><Replace>boolEnableBuyDragonPickaxe:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableIronMan = "<Find>boolEnableIronMan:false</Find><Replace>boolEnableIronMan:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string boolEnableSwitchSpellbook = "<Find>boolEnableSwitchSpellbook:false</Find><Replace>boolEnableSwitchSpellbook:false</Replace>";
        string filepathProfileRunecraftingZeah = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxRunecrafting-Zeah.txt");

        // Btn Click - Save Profile
        public void btnScriptProfiles_RunecraftingZeah_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_RunecraftingZeah_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_RunecraftingZeah_DeathHandler},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_RunecraftingZeah_WorldHopping},
                {"boolEnableIronMan", checkBoxScriptProfiles_RunecraftingZeah_IronMan},
                {"boolEnableRenewBond", checkBoxScriptProfiles_RunecraftingZeah_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_RunecraftingZeah_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_RunecraftingZeah_SellLoot },
                {"boolEnableSwitchSpellbook", checkBoxScriptProfiles_RunecraftingZeah_ArceuusHomeTeleport}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileRunecraftingZeah))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nRunecrafting Zeah Settings");
                writer.WriteLine(boolEnableBuyDragonPickaxe);
                writer.WriteLine(boolEnableIronMan);
                writer.WriteLine(boolEnableSwitchSpellbook);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

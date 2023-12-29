using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMiningMotherlodeMine : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesMiningMotherlodeMine(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBuyCoalBag = "<Find>boolEnableBuyCoalBag:false</Find><Replace>boolEnableBuyCoalBag:false</Replace>";
        string boolEnableBuyGemBag = "<Find>boolEnableBuyGemBag:false</Find><Replace>boolEnableBuyGemBag:false</Replace>";
        string boolEnableBuyOutfit = "<Find>boolEnableBuyOutfit:false</Find><Replace>boolEnableBuyOutfit:false</Replace>";
        string boolEnableBuySoftClayPack = "<Find>boolEnableBuySoftClayPack:false</Find><Replace>boolEnableBuySoftClayPack:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableDragonPickaxe = "<Find>boolEnableDragonPickaxe:false</Find><Replace>boolEnableDragonPickaxe:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileMotherlodeMine = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMining-MotherlodeMine.txt");

        // Form load
        public void formScriptProfiles_MiningMotherlodeMine_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_MiningMotherlodeMine_SelectSector.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_MiningMotherlodeMine_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_MiningMotherlodeMine_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_MiningMotherlodeMine_DeathHandler},
                {"boolEnableDragonPickaxe", checkBoxScriptProfiles_MiningMotherlodeMine_DragonPickaxe},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_MiningMotherlodeMine_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_MiningMotherlodeMine_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_MiningMotherlodeMine_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_MiningMotherlodeMine_SellLoot}
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

            if (listBoxScriptProfiles_MiningMotherlodeMine_SpendNuggets.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> spendNuggetsMap = new Dictionary<string, Action>
                {
                    {"Coal Bag", () => boolEnableBuyCoalBag = "<Find>boolEnableBuyCoalBag:false</Find><Replace>boolEnableBuyCoalBag:true</Replace>"},
                    {"Gem Bag", () => boolEnableBuyGemBag = "<Find>boolEnableBuyGemBag:false</Find><Replace>boolEnableBuyGemBag:true</Replace>"},
                    {"Prospector Outfit", () => boolEnableBuyOutfit = "<Find>boolEnableBuyOutfit:false</Find><Replace>boolEnableBuyOutfit:true</Replace>"},
                    {"Softclay Packs", () => boolEnableBuySoftClayPack = "<Find>boolEnableBuySoftClayPack:false</Find><Replace>boolEnableBuySoftClayPack:true</Replace>"},
                };

                // Loop Through Dictionary & Generate Output
                foreach (var selectedSpendNuggetsItem in listBoxScriptProfiles_MiningMotherlodeMine_SpendNuggets.SelectedItems)
                {
                    string selectedSpendNuggets = selectedSpendNuggetsItem.ToString();

                    foreach (var spendNuggets in spendNuggetsMap)
                    {
                        if (selectedSpendNuggets.Contains(spendNuggets.Key))
                        {
                            spendNuggets.Value.Invoke();
                        }
                    }
                }
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileMotherlodeMine))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nMining Motherlode Mine Settings");
                writer.WriteLine(boolEnableBuyCoalBag);
                writer.WriteLine(boolEnableBuyGemBag);
                writer.WriteLine(boolEnableBuyOutfit);
                writer.WriteLine(boolEnableBuySoftClayPack);
                writer.WriteLine(boolEnableDragonPickaxe);
                writer.WriteLine("<Find>Random/*/West/*/SouthWest/*/South/*/SouthEast</Find><Replace>" + comboBoxScriptProfiles_MiningMotherlodeMine_SelectSector.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

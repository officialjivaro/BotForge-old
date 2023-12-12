using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesRunecraftingAbyss : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesRunecraftingAbyss(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableBloodEssence = "<Find>boolEnableBloodEssence:false</Find><Replace>boolEnableBloodEssence:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableGetPouches = "<Find>boolEnableGetPouches:false</Find><Replace>boolEnableGetPouches:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnablePouchColossal = "<Find>boolEnablePouchColossal:false</Find><Replace>boolEnablePouchColossal:false</Replace>";
        string boolEnablePouchGiant = "<Find>boolEnablePouchGiant:false</Find><Replace>boolEnablePouchGiant:false</Replace>";
        string boolEnablePouchLarge = "<Find>boolEnablePouchLarge:false</Find><Replace>boolEnablePouchLarge:false</Replace>";
        string boolEnablePouchMedium = "<Find>boolEnableObsidianArmor:false</Find><Replace>boolEnableObsidianArmor:false</Replace>";
        string boolEnablePouchSmall = "<Find>boolEnablePouchMedium:false</Find><Replace>boolEnablePouchMedium:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableRingOfLife = "<Find>boolEnableRingOfLife:false</Find><Replace>boolEnableRingOfLife:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileRunecraftingAbyss = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxRunecrafting-Abyss.txt");

        // Form load
        public void formScriptProfiles_RunecraftingAbyss_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_RunecraftingAbyss_SelectObstacle.SelectedIndex = 0;
            comboBoxScriptProfiles_RunecraftingAbyss_SelectRune.SelectedIndex = 0;
            comboBoxScriptProfiles_RunecraftingAbyss_SelectWearables.SelectedIndex = 0;
            comboBoxScriptProfiles_RunecraftingAbyss_Teleport.SelectedIndex = 0;
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_RunecraftingAbyss_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_RunecraftingAbyss_Antipattern},
                {"boolEnableBloodEssence", checkBoxScriptProfiles_RunecraftingAbyss_BloodEssence},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_RunecraftingAbyss_DeathHandler},
                {"boolEnableGetPouches", checkBoxScriptProfiles_RunecraftingAbyss_GetPouches},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_RunecraftingAbyss_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_RunecraftingAbyss_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_RunecraftingAbyss_Restocking},
                {"boolEnableRingOfLife", checkBoxScriptProfiles_RunecraftingAbyss_RingOfLife},
                {"boolEnableSellLoot", checkBoxScriptProfiles_RunecraftingAbyss_SellLoot}
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

            // Set Pouch Variables
            if (listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItems.Count > 0)
            {
                Dictionary<string, Action> f2pQuestsMap = new Dictionary<string, Action>
                {
                    {"Colossal Pouch", () => boolEnablePouchColossal = "<Find>boolEnablePouchColossal:false</Find><Replace>boolEnablePouchColossal:false</Replace>"},
                    {"Giant Pouch", () => boolEnablePouchGiant = "<Find>boolEnablePouchGiant:false</Find><Replace>boolEnablePouchGiant:false</Replace>"},
                    {"Large Pouch", () => boolEnablePouchLarge = "<Find>boolEnablePouchLarge:false</Find><Replace>boolEnablePouchLarge:false</Replace>"},
                    {"Medium Pouch", () => boolEnablePouchMedium = "<Find>boolEnablePouchMedium:false</Find><Replace>boolEnablePouchMedium:false</Replace>"},
                    {"Small Pouch", () => boolEnablePouchSmall = "<Find>boolEnablePouchSmall:false</Find><Replace>boolEnablePouchSmall:false</Replace>"}
                };

                // Loop Through Dictionary & Generate Output
                foreach (var selectedF2pItem in listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItems)
                {
                    string selectedF2pQuest = selectedF2pItem.ToString();

                    foreach (var f2PQuest in f2pQuestsMap)
                    {
                        if (selectedF2pQuest.Contains(f2PQuest.Key))
                        {
                            f2PQuest.Value.Invoke();
                        }
                    }
                }
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileRunecraftingAbyss))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nRunecrafting Abyss Settings");
                writer.WriteLine(boolEnableBloodEssence);
                writer.WriteLine(boolEnableGetPouches);
                writer.WriteLine(boolEnablePouchColossal);
                writer.WriteLine(boolEnablePouchGiant);
                writer.WriteLine(boolEnablePouchLarge);
                writer.WriteLine(boolEnablePouchMedium);
                writer.WriteLine(boolEnablePouchSmall);
                writer.WriteLine(boolEnableRingOfLife);
                writer.WriteLine("<Find>Progressive/*/Air/*/Water/*/Earth/*/Fire/*/Body/*/Cosmic/*/Nature/*/Law/*/Soul/*/Mind/*/Chaos/*/Death/*/Blood/*/Soul</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_SelectRune.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Mining/*/Agility/*/Thieving/*/None</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_SelectObstacle.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>Amulet of Glory/*/Ring of Dueling/*/Games Necklace</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_Teleport.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/Adamant Armor/*/Graceful/*/Rainment</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_SelectWearables.SelectedItem.ToString() + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

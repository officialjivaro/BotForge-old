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

        // Initialize Variables - Strings
        string pc_username = Environment.UserName;
        string folderpathProfiles = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form load
        public void formScriptProfiles_RunecraftingAbyss_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_RunecraftingAbyss_SelectObstacle.SelectedIndex = 0;
            comboBoxScriptProfiles_RunecraftingAbyss_SelectRune.SelectedIndex = 0;
            comboBoxScriptProfiles_RunecraftingAbyss_SelectWearables.SelectedIndex = 0;
            comboBoxScriptProfiles_RunecraftingAbyss_Teleport.SelectedIndex = 0;
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_RunecraftingAbyss_SaveButton_Click(object sender, EventArgs e)
        {
            // Intialize variables
            string filepathProfileRunecraftingAbyss = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxRunecrafting-Abyss.txt");
            string boolEnableGetPouches = "<Find>boolEnableGetPouches:false</Find><Replace>boolEnableGetPouches:false</Replace>";
            string boolEnablePouchSmall = "<Find>boolEnablePouchMedium:false</Find><Replace>boolEnablePouchMedium:false</Replace>";
            string boolEnablePouchMedium = "<Find>boolEnableObsidianArmor:false</Find><Replace>boolEnableObsidianArmor:false</Replace>";
            string boolEnablePouchLarge = "<Find>boolEnablePouchLarge:false</Find><Replace>boolEnablePouchLarge:false</Replace>";
            string boolEnablePouchGiant = "<Find>boolEnablePouchGiant:false</Find><Replace>boolEnablePouchGiant:false</Replace>";
            string boolEnablePouchColossal = "<Find>boolEnablePouchColossal:false</Find><Replace>boolEnablePouchColossal:false</Replace>";
            string boolEnableBloodEssence = "<Find>boolEnableBloodEssence:false</Find><Replace>boolEnableBloodEssence:false</Replace>";
            string boolEnableRingOfLife = "<Find>boolEnableRingOfLife:false</Find><Replace>boolEnableRingOfLife:false</Replace>";
            string selectRune = "<Find>Progressive/*/Air/*/Water/*/Earth/*/Fire/*/Body/*/Cosmic/*/Nature/*/Law/*/Soul/*/Mind/*/Chaos/*/Death/*/Blood/*/Soul</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_SelectRune.SelectedItem.ToString() + "</Replace>";
            string selectObstacle = "<Find>Mining/*/Agility/*/Thieving/*/None</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_SelectObstacle.SelectedItem.ToString() + "</Replace>";
            string selectTeleport = "<Find>Amulet of Glory/*/Ring of Dueling/*/Games Necklace</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_Teleport.SelectedItem.ToString() + "</Replace>";
            string selectWearables = "<Find>None/*/Adamant Armor/*/Graceful/*/Rainment</Find><Replace>" + comboBoxScriptProfiles_RunecraftingAbyss_SelectWearables.SelectedItem.ToString() + "</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_RunecraftingAbyss_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_RunecraftingAbyss_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_RunecraftingAbyss_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_RunecraftingAbyss_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_RunecraftingAbyss_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable//
            if (checkBoxScriptProfiles_RunecraftingAbyss_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Enable get pouches checkbox
            if (checkBoxScriptProfiles_RunecraftingAbyss_RingOfLife.Checked)
            {
                boolEnableGetPouches = "<Find>boolEnableRingOfLife:false</Find><Replace>boolEnableRingOfLife:true</Replace>";
            }

            // Enable blood essence checkbox
            if (checkBoxScriptProfiles_RunecraftingAbyss_GetPouches.Checked)
            {
                boolEnableBloodEssence = "<Find>boolEnableBloodEssence:false</Find><Replace>boolEnableBloodEssence:true</Replace>";
            }

            // Enable ring of life checkbox
            if (checkBoxScriptProfiles_RunecraftingAbyss_BloodEssence.Checked)
            {
                boolEnableRingOfLife = "<Find>boolEnableRingOfLife:false</Find><Replace>boolEnableRingOfLife:true</Replace>";
            }

            // Use small pouch
            if (listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem != null && listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem.ToString() == "Small Pouch")
            {
                boolEnablePouchSmall = "<Find>boolEnablePouchSmall:false</Find><Replace>boolEnablePouchSmall:false</Replace>";
            }

            // Use medium pouch
            if (listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem != null && listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem.ToString() == "Medium Pouch")
            {
                boolEnablePouchSmall = "<Find>boolEnablePouchMedium:false</Find><Replace>boolEnablePouchMedium:false</Replace>";
            }

            // Use large pouch
            if (listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem != null && listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem.ToString() == "Large Pouch")
            {
                boolEnablePouchSmall = "<Find>boolEnablePouchLarge:false</Find><Replace>boolEnablePouchLarge:false</Replace>";
            }

            // Use giant pouch
            if (listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem != null && listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem.ToString() == "Giant Pouch")
            {
                boolEnablePouchSmall = "<Find>boolEnablePouchGiant:false</Find><Replace>boolEnablePouchGiant:false</Replace>";
            }

            // Use colossal pouch
            if (listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem != null && listBoxScriptProfiles_RunecraftingAbyss_SelectPouches.SelectedItem.ToString() == "Colossal Pouch")
            {
                boolEnablePouchSmall = "<Find>boolEnablePouchColossal:false</Find><Replace>boolEnablePouchColossal:false</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileRunecraftingAbyss))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(selectRune);
                writer.WriteLine(selectObstacle);
                writer.WriteLine(selectTeleport);
                writer.WriteLine(selectWearables);
                writer.WriteLine(boolEnableGetPouches);
                writer.WriteLine(boolEnableBloodEssence);
                writer.WriteLine(boolEnableRingOfLife);
                writer.WriteLine(boolEnablePouchSmall);
                writer.WriteLine(boolEnablePouchMedium);
                writer.WriteLine(boolEnablePouchLarge);
                writer.WriteLine(boolEnablePouchGiant);
                writer.WriteLine(boolEnablePouchColossal);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

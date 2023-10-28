namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesCookingRangeAndFire : Form
    {

        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesCookingRangeAndFire(formMainForm mainForm)
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

        // Form Load
        public void formScriptProfiles_CookingRangeAndFire_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_CookingRangeAndFire_SelectDish.SelectedIndex = 0;
            comboBoxScriptProfiles_CookingRangeAndFire_SelectCookingArea.SelectedIndex = 0;
        }


        // Button Click - Save Profile
        public void btnScriptProfiles_CookingRangeAndFire_SaveButton_Click(object sender, EventArgs e)
        {
            // Intialize variables
            string filepathProfileCookingRangeAndFire = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxCooking-RangeAndFire.txt");
            string selectCookingArea = "<Find>AlKharid/*/Falador/*/Hosidius/*/Zanaris/*/RoguesDen</Find><Replace>" + comboBoxScriptProfiles_CookingRangeAndFire_SelectCookingArea.SelectedItem.ToString() + "</Replace>";
            string selectCookingDish = "<Find>Progressive/*/Shrimps/*/Trout/*/Salmon/*/Lobster/*/Swordfish/*/Monkfish/*/Shark/*/Anglerfish</Find><Replace>" + comboBoxScriptProfiles_CookingRangeAndFire_SelectDish.SelectedItem.ToString() + "</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_CookingRangeAndFire_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_CookingRangeAndFire_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_CookingRangeAndFire_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_CookingRangeAndFire_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_CookingRangeAndFire_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable//
            if (checkBoxScriptProfiles_CookingRangeAndFire_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileCookingRangeAndFire))
            {
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(selectCookingArea);
                writer.WriteLine(selectCookingDish);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

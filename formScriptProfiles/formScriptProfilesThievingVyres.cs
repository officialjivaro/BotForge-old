namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesThievingVyres : Form
    {

        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesThievingVyres(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables - Strings
        string pc_username = Environment.UserName;
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form load
        public void formScriptProfiles_ThievingVyres_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_ThievingVyres_SelectNpc.SelectedIndex = 0;
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_ThievingVyres_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize variables
            string filepathProfileThievingVyres = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxThieving-Vyres.txt");
            string boolEnableShadowVeil = "<Find>boolEnableShadowVeil:false</Find><Replace>boolEnableShadowVeil:false</Replace>";
            string slectNpc = "<Find>Random/*/Vallessia von Pitt/*/Vlad Diaemus/*/Vonnetta Varnis</Find><Replace>Random/*/Vallessia von Pitt/*/Vlad Diaemus/*/Vonnetta Varnis</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_ThievingVyres_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_ThievingVyres_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_ThievingVyres_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_ThievingVyres_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_ThievingVyres_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable// checked
            if (checkBoxScriptProfiles_ThievingVyres_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Enable shadow veil
            if (checkBoxScriptProfiles_ThievingVyres_ShadowVeil.Checked)
            {
                boolEnableShadowVeil = "<Find>boolDisableGearChecks:false</Find><Replace>boolDisableGearChecks:true</Replace>";
            }

            // Select npc
            if (comboBoxScriptProfiles_ThievingVyres_SelectNpc != null)
            {
                slectNpc = "<Find>Random/*/Vallessia von Pitt/*/Vlad Diaemus/*/Vonnetta Varnis</Find><Replace>" + comboBoxScriptProfiles_ThievingVyres_SelectNpc.SelectedItem.ToString() + "</Replace>";
            }


            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileThievingVyres))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(boolEnableShadowVeil);
                writer.WriteLine(slectNpc);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

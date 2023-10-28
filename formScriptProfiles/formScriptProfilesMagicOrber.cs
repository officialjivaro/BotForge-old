using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;


namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesMagicOrber : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesMagicOrber(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize variables
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";

        // Form load
        public void formScriptProfiles_MagicOrber_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_MagicOrber_SelectOrb.SelectedIndex = 0;
        }

        // Cancel non number input and set the limit to 99 on textchange
        public void GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(sender, e);
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_MagicOrber_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize variables
            string filepathProfileMagicOrber = Path.Combine(@"C:\\Users\\" + MainForm.pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxMagic-Orber.txt");
            string boolEnableStaminaPotions = "<Find>boolEnableStaminaPotions:false</Find><Replace>boolEnableStaminaPotions:false</Replace>";
            string boolEnableUseRandomCape = "<Find>boolEnableUseRandomCape:false</Find><Replace>boolEnableUseRandomCape:false</Replace>";
            string trainAgility = "<Find>10101010</Find><Replace>" + textBoxScriptProfiles_MagicOrber_TrainAgility.Text + "</Replace>";
            string trainMelee = "<Find>93939393</Find><Replace>" + textBoxScriptProfiles_MagicOrber_TrainMelee.Text + "</Replace>";
            string selectOrb = "<Find>Earth/*/Air</Find><Replace>" + comboBoxScriptProfiles_MagicOrber_SelectOrb.SelectedItem.ToString() + "</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_MagicOrber_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_MagicOrber_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_MagicOrber_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_MagicOrber_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_MagicOrber_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable//
            if (checkBoxScriptProfiles_MagicOrber_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Enable bank coal checkbox
            if (checkBoxScriptProfiles_MagicOrber_UseStaminas.Checked)
            {
                boolEnableStaminaPotions = "<Find>boolEnableStaminaPotions:false</Find><Replace>boolEnableStaminaPotions:true</Replace>";
            }

            // Enable bank coal checkbox
            if (checkBoxScriptProfiles_MagicOrber_UseRandomCape.Checked)
            {
                boolEnableUseRandomCape = "<Find>boolEnableUseRandomCape:false</Find><Replace>boolEnableUseRandomCape:true</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileMagicOrber))
            {
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(boolEnableStaminaPotions);
                writer.WriteLine(boolEnableUseRandomCape);
                writer.WriteLine(trainAgility);
                writer.WriteLine(trainMelee);
                writer.WriteLine(selectOrb);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

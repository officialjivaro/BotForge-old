using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterVyres : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterVyres(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        int intBankingIntervals;
        int intBankingIntervalsVariation;
        string bankingIntervals;
        string bankingIntervalsVariation;
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDamagePrayers = "<Find>boolEnableDamagePrayers:false</Find><Replace>boolEnableDamagePrayers:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHighAlching = "<Find>boolEnableHighAlching:false</Find><Replace>boolEnableHighAlching:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileFighterVyres = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-Vyres.txt");

        // Form Load
        public void formScriptProfilesFighterVyres_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_FighterVyres_SelectArea.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterVyres_SelectPotion.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterVyres_HopWorldsWhenFull.SelectedIndex = 0;
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Cancel Non Numbers From Textbox
        public void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_KeyPress(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_FighterVyres_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterVyres_Antipattern},
                {"boolEnableDamagePrayers", checkBoxScriptProfiles_FighterVyres_DamagePrayers},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterVyres_DeathHandler},
                {"boolEnableHighAlching", checkBoxScriptProfiles_FighterVyres_HighAlching},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterVyres_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterVyres_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterVyres_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterVyres_SellLoot}
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

            // Banking Intevals Min To Ms Converter 
            int.TryParse(textBoxScriptProfiles_FighterVyres_BankingIntervals.Text, out int intBankingIntervalsMs);
            {
                intBankingIntervals = intBankingIntervalsMs * 60000;
                bankingIntervals = intBankingIntervals.ToString();
            }

            // Interval Variation Min To Ms Converter
            int.TryParse(textBoxScriptProfiles_FighterVyres_IntervalVariation.Text, out int intBankingIntervalsVariationMs);
            {
                intBankingIntervalsVariation = intBankingIntervalsVariationMs * 60000;
                bankingIntervalsVariation = intBankingIntervalsVariation.ToString();
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileFighterVyres))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nVyre Settings");
                writer.WriteLine(boolEnableDamagePrayers);
                writer.WriteLine(boolEnableHighAlching);
                writer.WriteLine("<Find>Random/*/NorthWest/*/SouthWest/*/East</Find><Replace>" + comboBoxScriptProfiles_FighterVyres_SelectArea.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/CombatPotion/*/SuperCombatPotion</Find><Replace>" + comboBoxScriptProfiles_FighterVyres_SelectPotion.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>No/*/Yes - 2 Players/*/Yes - 3 Players/*/Yes - 4 Players</Find><Replace>" + comboBoxScriptProfiles_FighterVyres_HopWorldsWhenFull.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>5400000,true,1800000,true</Find><Replace>" + bankingIntervals + ",true," + bankingIntervalsVariation + ",true</Replace>");
                writer.WriteLine("\nGear Settings");
                writer.WriteLine("<Find>Amulet of glory</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeAmulet.Text + "</Replace>");
                writer.WriteLine("<Find>Peaceful blessing</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Guthix cloak</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeCape.Text + "</Replace>");
                writer.WriteLine("<Find>Monk's robe top</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeChest.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeFeet.Text + "</Replace>");
                writer.WriteLine("<Find>Granite gloves</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeHands.Text + "</Replace>");
                writer.WriteLine("<Find>Guthix mitre</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeHead.Text + "</Replace>");
                writer.WriteLine("<Find>Monk's robe</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Warrior ring</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeRing.Text + "</Replace>");
                writer.WriteLine("<Find>Toktz-ket-xil</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeShield.Text + "</Replace>");
                writer.WriteLine("<Find>Blisterwood flail</Find><Replace>" + textBoxScriptProfiles_FighterVyres_MeleeWeapon.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

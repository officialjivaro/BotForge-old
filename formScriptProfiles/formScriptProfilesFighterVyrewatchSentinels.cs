using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterVyrewatchSentinels : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterVyrewatchSentinels(formMainForm mainForm)
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
        string boolEnablePrayersOffensive = "<Find>boolEnablePrayersOffensive:false</Find><Replace>boolEnablePrayersOffensive:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHighAlchemy = "<Find>boolEnableHighAlchemy:false</Find><Replace>boolEnableHighAlchemy:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileFighterVyrewatchSentinels = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-VyrewatchSentinels.txt");

        // Form Load
        public void formScriptProfilesFighterVyrewatchSentinels_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_FighterVyrewatchSentinels_SelectArea.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterVyrewatchSentinels_SelectPotion.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterVyrewatchSentinels_HopWorldsWhenFull.SelectedIndex = 0;
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
        public void btnScriptProfiles_FighterVyrewatchSentinels_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterVyrewatchSentinels_Antipattern},
                {"boolEnablePrayersOffensive", checkBoxScriptProfiles_FighterVyrewatchSentinels_DamagePrayers},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterVyrewatchSentinels_DeathHandler},
                {"boolEnableHighAlchemy", checkBoxScriptProfiles_FighterVyrewatchSentinels_HighAlchemy},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterVyrewatchSentinels_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterVyrewatchSentinels_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterVyrewatchSentinels_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterVyrewatchSentinels_SellLoot}
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
            int.TryParse(textBoxScriptProfiles_FighterVyrewatchSentinels_BankingIntervals.Text, out int intBankingIntervalsMs);
            {
                intBankingIntervals = intBankingIntervalsMs * 60000;
                bankingIntervals = intBankingIntervals.ToString();
            }

            // Interval Variation Min To Ms Converter
            int.TryParse(textBoxScriptProfiles_FighterVyrewatchSentinels_IntervalVariation.Text, out int intBankingIntervalsVariationMs);
            {
                intBankingIntervalsVariation = intBankingIntervalsVariationMs * 60000;
                bankingIntervalsVariation = intBankingIntervalsVariation.ToString();
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileFighterVyrewatchSentinels))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nVyre Settings");
                writer.WriteLine(boolEnablePrayersOffensive);
                writer.WriteLine(boolEnableHighAlchemy);
                writer.WriteLine("<Find>Random/*/NorthWest/*/SouthWest/*/East</Find><Replace>" + comboBoxScriptProfiles_FighterVyrewatchSentinels_SelectArea.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/CombatPotion/*/SuperCombatPotion</Find><Replace>" + comboBoxScriptProfiles_FighterVyrewatchSentinels_SelectPotion.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>No/*/Yes - 2 Players/*/Yes - 3 Players/*/Yes - 4 Players</Find><Replace>" + comboBoxScriptProfiles_FighterVyrewatchSentinels_HopWorldsWhenFull.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>5400000,true,1800000,true</Find><Replace>" + bankingIntervals + ",true," + bankingIntervalsVariation + ",true</Replace>");
                writer.WriteLine("\nGear Settings");
                writer.WriteLine("<Find>Amulet of glory</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeAmulet.Text + "</Replace>");
                writer.WriteLine("<Find>Peaceful blessing</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Guthix cloak</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeCape.Text + "</Replace>");
                writer.WriteLine("<Find>Monk's robe top</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeChest.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeFeet.Text + "</Replace>");
                writer.WriteLine("<Find>Granite gloves</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeHands.Text + "</Replace>");
                writer.WriteLine("<Find>Guthix mitre</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeHead.Text + "</Replace>");
                writer.WriteLine("<Find>Monk's robe</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Warrior ring</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeRing.Text + "</Replace>");
                writer.WriteLine("<Find>Toktz-ket-xil</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeShield.Text + "</Replace>");
                writer.WriteLine("<Find>Blisterwood flail</Find><Replace>" + textBoxScriptProfiles_FighterVyrewatchSentinels_MeleeWeapon.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

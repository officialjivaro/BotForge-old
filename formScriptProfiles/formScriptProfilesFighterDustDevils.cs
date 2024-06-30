using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using System.ComponentModel;
using System.Reflection;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesFighterDustDevils : Form
    {

        // Initialize Instances
        public formMainForm MainForm;

        public formScriptProfilesFighterDustDevils(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Initialize Variables
        string boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:false</Replace>";
        string boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:false</Replace>";
        string boolEnableHighAlchemy = "<Find>boolEnableHighAlchemy:false</Find><Replace>boolEnableHighAlchemy:false</Replace>";
        string boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:false</Replace>";
        string boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:false</Replace>";
        string boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:false</Replace>";
        string boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:false</Replace>";
        string filepathProfileFighterDustDevils = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxFighter-DustDevils.txt");


        // Form Load
        public void formScriptProfilesFighterDustDevils_Load(object sender, EventArgs e)
        {
            comboBoxScriptProfiles_FighterDustDevils_SelectArea.SelectedIndex = 0;
            comboBoxScriptProfiles_FighterDustDevils_SelectPotion.SelectedIndex = 0;
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        // Btn Click - Save Profile
        public void btnScriptProfiles_FighterDustDevils_SaveButton_Click(object sender, EventArgs e)
        {
            // Set Checkbox Variables
            var checkBoxMappings = new Dictionary<string, CheckBox>
            {
                {"boolEnableAntipattern", checkBoxScriptProfiles_FighterDustDevils_Antipattern},
                {"boolEnableDeathHandler", checkBoxScriptProfiles_FighterDustDevils_DeathHandler},
                {"boolEnableHighAlchemy", checkBoxScriptProfiles_FighterDustDevils_HighAlchemy},
                {"boolEnableHopWorlds", checkBoxScriptProfiles_FighterDustDevils_WorldHopping},
                {"boolEnableRenewBond", checkBoxScriptProfiles_FighterDustDevils_RenewBond},
                {"boolEnableRestocking", checkBoxScriptProfiles_FighterDustDevils_Restocking},
                {"boolEnableSellLoot", checkBoxScriptProfiles_FighterDustDevils_SellLoot}
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
            using (StreamWriter writer = new StreamWriter(filepathProfileFighterDustDevils))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine("\nDust Devil Settings");
                writer.WriteLine(boolEnableHighAlchemy);
                writer.WriteLine("<Find>SmokeDungeon/*/CatacombsOfKourend</Find><Replace>" + comboBoxScriptProfiles_FighterDustDevils_SelectArea.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("<Find>None/*/CombatPotion/*/SuperCombatPotion</Find><Replace>" + comboBoxScriptProfiles_FighterDustDevils_SelectPotion.SelectedItem.ToString() + "</Replace>");
                writer.WriteLine("\nGear Settings");
                writer.WriteLine("<Find>Amulet of glory</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MiscAmulet.Text + "</Replace>");
                writer.WriteLine("<Find>None</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeArrow.Text + "</Replace>");
                writer.WriteLine("<Find>Zamorak cloak</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeCape.Text + "</Replace>");
                writer.WriteLine("<Find>Obsidian platebody</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeChest.Text + "</Replace>");
                writer.WriteLine("<Find>Dragon boots</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeFeet.Text + "</Replace>");
                writer.WriteLine("<Find>Granite gloves</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeHands.Text + "</Replace>");
                writer.WriteLine("<Find>Obsidian helmet</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeHead.Text + "</Replace>");
                writer.WriteLine("<Find>Obsidian platelegs</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeLegs.Text + "</Replace>");
                writer.WriteLine("<Find>Toktz-ket-xil</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MiscShield.Text + "</Replace>");
                writer.WriteLine("<Find>Warrior ring</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeRing.Text + "</Replace>");
                writer.WriteLine("<Find>Abyssal whip</Find><Replace>" + textBoxScriptProfiles_FighterDustDevils_MeleeWeapon.Text + "</Replace>");
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

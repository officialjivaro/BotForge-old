﻿namespace Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles
{
    public partial class formScriptProfilesTutorial : Form
    {

        // Initialize Instances
        private formMainForm MainForm;

        public formScriptProfilesTutorial(formMainForm mainForm)
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
        public void formScriptProfilesTutorial_Load(object sender, EventArgs e)
        {
        }

        // Button Click - Save Profile
        public void btnScriptProfiles_TutorialIsland_SaveButton_Click(object sender, EventArgs e)
        {

            // Intialize Variables - Strings
            string filepathProfileTutorialIsland = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\fxTutorial.txt");
            string enableFastDialogue = "<Find><Boolean>enableFastDialogue:false</Find><Replace><Boolean>enableFastDialogue:false</Replace>";
            string enableStopAfterTutorial = "<Find><Boolean>enableStopAfterTutorial:false>/Find><Replace><Boolean>enableStopAfterTutorial:false</Replace>";
            string enableWalkToRandomArea = "<Find><Boolean>enableWalkToRandomArea:false</Find><Replace><Boolean>enableWalkToRandomArea:false</Replace>";
            string enableNoObjectInteractions = "<Find><Boolean>enableNoObjectInteractions:false</Find><Replace><Boolean>enableNoObjectInteractions:false</Replace>";
            string enableNoNpcInteractions = "<Find><Boolean>enableNoNpcInteractions:false</Find><Replace><Boolean>enableNoNpcInteractions:false</Replace>";
            string enableNoWalkInteractions = "<Find><Boolean>enableNoWalkInteractions:false</Find><Replace><Boolean>enableNoWalkInteractions:false</Replace>";

            //Set EnableDeathHandler Variable//
            if (checkBoxScriptProfiles_TutorialIsland_DeathHandler.Checked)
            {
                boolEnableDeathHandler = "<Find>boolEnableDeathHandler:false</Find><Replace>boolEnableDeathHandler:true</Replace>";
            }

            //Set EnableRenewBond Handler Variable//
            if (checkBoxScriptProfiles_TutorialIsland_RenewBond.Checked)
            {
                boolEnableRenewBond = "<Find>boolEnableRenewBond:false</Find><Replace>boolEnableRenewBond:true</Replace>";
            }

            //Set EnableAntipattern Handler Variable//
            if (checkBoxScriptProfiles_TutorialIsland_Antipattern.Checked)
            {
                boolEnableAntipattern = "<Find>boolEnableAntipattern:false</Find><Replace>boolEnableAntipattern:true</Replace>";
            }

            //Set EnableHopWorlds Handler Variable//
            if (checkBoxScriptProfiles_TutorialIsland_WorldHopping.Checked)
            {
                boolEnableHopWorlds = "<Find>boolEnableHopWorlds:false</Find><Replace>boolEnableHopWorlds:true</Replace>";
            }

            //Set EnableRestocking Handler Variable//
            if (checkBoxScriptProfiles_TutorialIsland_Restocking.Checked)
            {
                boolEnableRestocking = "<Find>boolEnableRestocking:false</Find><Replace>boolEnableRestocking:true</Replace>";
            }

            //Set EnableSellLoot Handler Variable//
            if (checkBoxScriptProfiles_TutorialIsland_SellLoot.Checked)
            {
                boolEnableSellLoot = "<Find>boolEnableSellLoot:false</Find><Replace>boolEnableSellLoot:true</Replace>";
            }

            // Enable fast dialogue 
            if (checkBoxScriptProfiles_TutorialIsland_FastDialogue.Checked)
            {
                enableFastDialogue = "<Find><Boolean>enableFastDialogue:false</Find><Replace><Boolean>enableFastDialogue:true</Replace>";
            }

            // Stop script after tutorial 
            if (checkBoxScriptProfiles_TutorialIsland_StopImmediately.Checked)
            {
                enableStopAfterTutorial = "<Find><Boolean>enableStopAfterTutorial:false>/Find><Replace><Boolean>enableStopAfterTutorial:true</Replace>";
            }

            // Walk to random place after tutorial
            if (checkBoxScriptProfiles_TutorialIsland_WalkToRandom.Checked)
            {
                enableWalkToRandomArea = "<Find><Boolean>enableWalkToRandomArea:false</Find><Replace><Boolean>enableWalkToRandomArea:true</Replace>";
            }

            // Disable object interactions
            if (listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItem != null && listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItem.ToString() == "Disable Object Interactions")
            {
                enableNoObjectInteractions = "<Find><Boolean>enableNoObjectInteractions:false</Find><Replace><Boolean>enableNoObjectInteractions:true</Replace>";
            }

            // Disable npc interactions
            if (listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItem != null && listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItem.ToString() == "Disable NPC Interactions")
            {
                enableNoNpcInteractions = "<Find><Boolean>enableNoNpcInteractions:false</Find><Replace><Boolean>enableNoNpcInteractions:true</Replace>";
            }

            // Disable walking interactions
            if (listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItem != null && listBoxScriptProfiles_TutorialIsland_DisableInteractions.SelectedItem.ToString() == "Disable Walk Interactions")
            {
                enableNoWalkInteractions = "<Find><Boolean>enableNoWalkInteractions:false</Find><Replace><Boolean>enableNoWalkInteractions:true</Replace>";
            }

            // Write to file
            using (StreamWriter writer = new StreamWriter(filepathProfileTutorialIsland))
            {
                writer.WriteLine("General Settings");
                writer.WriteLine(boolEnableDeathHandler);
                writer.WriteLine(boolEnableRenewBond);
                writer.WriteLine(boolEnableAntipattern);
                writer.WriteLine(boolEnableHopWorlds);
                writer.WriteLine(boolEnableRestocking);
                writer.WriteLine(boolEnableSellLoot);
                writer.WriteLine(enableFastDialogue);
                writer.WriteLine(enableStopAfterTutorial);
                writer.WriteLine(enableWalkToRandomArea);
                writer.WriteLine(enableNoObjectInteractions);
                writer.WriteLine(enableNoNpcInteractions);
                writer.WriteLine(enableNoWalkInteractions);
            }
            MessageBox.Show("Profile successfully created.");
        }
    }
}

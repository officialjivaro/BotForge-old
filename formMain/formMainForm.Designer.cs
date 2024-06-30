using System.Windows.Forms;
using Krypton.Navigator;
using Krypton.Toolkit;

namespace Jivaro_Old_School_RuneScape_Bot_Manager
{
    partial class formMainForm
    {

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            buttonNav_JivaroLogo = new Button();
            checkBoxBreakProfiles_EnableBreaks = new CheckBox();
            checkBoxBreakProfiles_EnableSleepBreaks = new CheckBox();
            checkBoxSettings_ShowCpuAndRamUsage = new CheckBox();
            checkBoxSettings_ShowWelcomeScreen = new CheckBox();
            comboBoxBreakProfiles_SelectBreakFilename = new ComboBox();
            comboBoxScriptProfiles_SelectScript = new ComboBox();
            dataGridViewDashboard_DreamBotManager = new DataGridView();
            dataGridViewDashboard_DreamBotManager_Account = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_Password = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_Pin = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_Proxy = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_Script = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_DreamBotManager_Args = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_Breaks = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_World = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_DreamBotManager_RunStop = new DataGridViewButtonColumn();
            dataGridViewDashboard_DreamBotManager_Notes = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_Status = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_DreamBotManager_SandboxieNumber = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager = new DataGridView();
            dataGridViewDashboard_OSBotManager_Account = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_Password = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_Pin = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_Proxy = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_Script = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_OSBotManager_Args = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_World = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_OSBotManager_RunStop = new DataGridViewButtonColumn();
            dataGridViewDashboard_OSBotManager_Notes = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_Status = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_OSBotManager_SandboxieNumber = new DataGridViewTextBoxColumn();
            kryptonButton1 = new KryptonButton();
            kryptonButtonBreakProfiles_Save = new KryptonButton();
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount = new KryptonButton();
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount = new KryptonButton();
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient = new KryptonButton();
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts = new KryptonButton();
            kryptonButtonButtonDashboard_DreamBotManager_Save = new KryptonButton();
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot = new KryptonButton();
            kryptonButtonDashboard_OSBotManager_AddAccount = new KryptonButton();
            kryptonButtonDashboard_OSBotManager_DeleteAccount = new KryptonButton();
            kryptonButtonDashboard_OSBotManager_DownloadClient = new KryptonButton();
            kryptonButtonDashboard_OSBotManager_ImportAccounts = new KryptonButton();
            kryptonButtonDashboard_OSBotManager_LaunchOSBot = new KryptonButton();
            kryptonButtonDashboard_OSBotManager_Save = new KryptonButton();
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount = new KryptonButton();
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount = new KryptonButton();
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient = new KryptonButton();
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts = new KryptonButton();
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot = new KryptonButton();
            kryptonButtonDashboard_ScriptFactoryManager_Save = new KryptonButton();
            kryptonButtonDashboard_TRiBotManager_AddAccount = new KryptonButton();
            kryptonButtonDashboard_TRiBotManager_DeleteAccount = new KryptonButton();
            kryptonButtonDashboard_TRiBotManager_DownloadClient = new KryptonButton();
            kryptonButtonDashboard_TRiBotManager_ImportAccounts = new KryptonButton();
            kryptonButtonDashboard_TRiBotManager_LaunchClient = new KryptonButton();
            kryptonButtonDashboard_TRiBotManager_Save = new KryptonButton();
            kryptonButtonNav_BreakProfiles = new KryptonButton();
            kryptonButtonNav_Dashboard = new KryptonButton();
            kryptonButtonNav_ScriptProfiles = new KryptonButton();
            kryptonButtonNav_Settings = new KryptonButton();
            kryptonButtonSettings_BottingGuide = new KryptonButton();
            kryptonButtonSettings_BuyProxies = new KryptonButton();
            kryptonButtonSettings_CreateAccount = new KryptonButton();
            kryptonButtonSettings_Discord = new KryptonButton();
            kryptonButtonSettings_DownloadJava = new KryptonButton();
            kryptonButtonSettings_InstallProxifier = new KryptonButton();
            kryptonButtonSettings_KillAllBotClients = new KryptonButton();
            kryptonButtonSettings_LocalScripts = new KryptonButton();
            kryptonButtonSettings_SaveLogin = new KryptonButton();
            kryptonButtonSettings_SetupGuide = new KryptonButton();
            kryptonButtonSettings_UpdateManager = new KryptonButton();
            kryptonButtonSettings_UpdateScripts = new KryptonButton();
            kryptonButtonSettings_VisitWebsite = new KryptonButton();
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop = new KryptonCheckBox();
            kryptonCheckBoxDashboard_OSBotManager_Loop = new KryptonCheckBox();
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop = new KryptonCheckBox();
            kryptonCheckBoxDashboard_TRiBotManager_Loop = new KryptonCheckBox();
            dataGridViewDashboard_ScriptFactoryManager = new DataGridView();
            dataGridViewDashboard_ScriptFactoryManager_Account = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_ScriptFactory_Password = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_ScriptFactory_Pin = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_ScriptFactory_Proxy = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_ScriptFactory_ScriptFactory = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_ScriptFactory_Script = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_ScriptFactory_World = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_ScriptFactory_RunStop = new DataGridViewButtonColumn();
            dataGridViewDashboard_ScriptFactory_Notes = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_ScriptFactory_Status = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_ScriptFactory_SandboxieNumber = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager = new DataGridView();
            dataGridViewDashboard_TRiBotManager_Account = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_Password = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_Pin = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_Proxy = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_Script = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_TRiBotManager_Args = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_Breaks = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_World = new DataGridViewComboBoxColumn();
            dataGridViewDashboard_TRiBotManager_RunStop = new DataGridViewButtonColumn();
            dataGridViewDashboard_TRiBotManager_Notes = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_Status = new DataGridViewTextBoxColumn();
            dataGridViewDashboard_TRiBotManager_SandboxieNumber = new DataGridViewTextBoxColumn();
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings = new KryptonListBox();
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings = new KryptonListBox();
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings = new KryptonListBox();
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings = new KryptonListBox();
            kryptonNavigatorDashboard = new KryptonNavigator();
            kryptonPageDashboard_ScriptFactoryManager = new KryptonPage();
            labelDashboard_ScriptFactoryManager_BreakTimeMins = new Label();
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime = new KryptonTextBox();
            labelDashboard_ScriptFactoryManager_RunTimeMins = new Label();
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime = new KryptonTextBox();
            labelDashboard_ScriptFactoryManager_BreakTime = new Label();
            labelDashboard_ScriptFactoryManager_RunTime = new Label();
            labelDashboard_ScriptFactoryManager_AdditionalSettings = new Label();
            kryptonPageDashboard_OSBotManager = new KryptonPage();
            labelDashboard_OSBotManager_BreakTimeMins = new Label();
            kryptonTextBoxDashboard_OSBotManager_BreakTime = new KryptonTextBox();
            labelDashboard_OSBotManager_RunTimeMins = new Label();
            kryptonTextBoxDashboard_OSBotManager_RunTime = new KryptonTextBox();
            labelDashboard_OSBotManager_BreakTime = new Label();
            labelDashboard_OSBotManager_RunTime = new Label();
            labelDashboard_OSBotManager_AdditionalSettings = new Label();
            kryptonPageDashboard_DreamBotManager = new KryptonPage();
            labelButtonDashboard_DreamBotManager_BreakTimeMins = new Label();
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime = new KryptonTextBox();
            labelButtonDashboard_DreamBotManager_RunTimeMins = new Label();
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime = new KryptonTextBox();
            labelButtonDashboard_DreamBotManager_BreakTime = new Label();
            labelButtonDashboard_DreamBotManager_RunTime = new Label();
            labelButtonDashboard_DreamBotManager_AdditionalSettings = new Label();
            kryptonPageDashboard_TRiBotManager = new KryptonPage();
            labelDashboard_TRiBotManager_BreakTimeMins = new Label();
            kryptonTextBoxDashboard_TRiBotManager_BreakTime = new KryptonTextBox();
            labelDashboard_TRiBotManager_RunTimeMins = new Label();
            kryptonTextBoxDashboard_TRiBotManager_RunTime = new KryptonTextBox();
            labelDashboard_TRiBotManager_BreakTime = new Label();
            labelDashboard_TRiBotManager_RunTime = new Label();
            labelDashboard_TRiBotManager_AdditionalSettings = new Label();
            kryptonProgressBarGlobal = new KryptonProgressBar();
            labelBotTime = new Label();
            labelBotTimeMinutes = new Label();
            labelBotTimeVariation = new Label();
            labelBotTimeVariationMinutes = new Label();
            labelBreakProfiles_Header = new Label();
            labelBreakTime = new Label();
            labelBreakTimeMinutes = new Label();
            labelBreakTimePercentage = new Label();
            labelBreakTimeVariation = new Label();
            labelNav_ByFushigiBot = new Label();
            labelNav_CpuUsageMonitor = new Label();
            labelNav_Jivaro = new Label();
            labelNav_OSRSLauncher = new Label();
            labelNav_RamUsageMonitor = new Label();
            labelScriptProfiles_Explanation1 = new Label();
            labelScriptProfiles_Explanation2 = new Label();
            labelScriptProfiles_Explanation4 = new Label();
            labelScriptProfiles_Explanation5 = new Label();
            labelScriptProfiles_Header = new Label();
            labelScriptProfiles_SelectScript = new Label();
            labelSettings_DreamBotDetails = new Label();
            labelSettings_DreamBotPassword = new Label();
            labelSettings_DreamBotUsername = new Label();
            labelSettings_Header = new Label();
            labelSettings_OSBotDetails = new Label();
            labelSettings_OSBotPassword = new Label();
            labelSettings_OSBotUsername = new Label();
            labelSettings_TRiBotDetails = new Label();
            labelSettings_TRiBotEmail = new Label();
            labelSettings_TRiBotPassword = new Label();
            labelSleepTime = new Label();
            labelSleepTimeMinutes = new Label();
            labelSleepTimeVariation = new Label();
            labelSleepTimeVariationPercentage = new Label();
            labelTimeUntilSleep = new Label();
            labelTimeUntilSleepMinutes = new Label();
            labelTimeUntilSleepVariation = new Label();
            labelTimeUntilSleepVariationMinutes = new Label();
            linkLabelScriptProfilesWebpage = new LinkLabel();
            panelBreakProfiles = new Panel();
            textBoxBreakProfiles_BotTime = new TextBox();
            textBoxBreakProfiles_BotTimeVariation = new TextBox();
            textBoxBreakProfiles_TimeUntilSleep = new TextBox();
            textBoxBreakProfiles_TimeUntilSleepVariation = new TextBox();
            textBoxBreakProfiles_SleepTime = new TextBox();
            textBoxBreakProfiles_SleepTimeVariation = new TextBox();
            textBoxBreakProfiles_BreakTime = new TextBox();
            textBoxBreakProfiles_BreakTimeVariation = new TextBox();
            panelDashboard = new Panel();
            panelMain = new Panel();
            panelSettings = new Panel();
            textBoxSettings_TRiBotPassword = new TextBox();
            textBoxSettings_TRiBotEmail = new TextBox();
            textBoxSettings_OSBotUsername = new TextBox();
            textBoxSettings_DreamBotPassword = new TextBox();
            textBoxSettings_DreamBotUsername = new TextBox();
            textBoxSettings_OSBotPassword = new TextBox();
            panelScriptProfiles = new Panel();
            timerNav_PerformanceCounters = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_DreamBotManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_OSBotManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_ScriptFactoryManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_TRiBotManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigatorDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_ScriptFactoryManager).BeginInit();
            kryptonPageDashboard_ScriptFactoryManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_OSBotManager).BeginInit();
            kryptonPageDashboard_OSBotManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_DreamBotManager).BeginInit();
            kryptonPageDashboard_DreamBotManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_TRiBotManager).BeginInit();
            kryptonPageDashboard_TRiBotManager.SuspendLayout();
            panelBreakProfiles.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelMain.SuspendLayout();
            panelSettings.SuspendLayout();
            panelScriptProfiles.SuspendLayout();
            SuspendLayout();
            // 
            // buttonNav_JivaroLogo
            // 
            buttonNav_JivaroLogo.BackColor = Color.Transparent;
            buttonNav_JivaroLogo.BackgroundImage = (Image)resources.GetObject("buttonNav_JivaroLogo.BackgroundImage");
            buttonNav_JivaroLogo.BackgroundImageLayout = ImageLayout.Zoom;
            buttonNav_JivaroLogo.Cursor = Cursors.Hand;
            buttonNav_JivaroLogo.FlatAppearance.BorderSize = 0;
            buttonNav_JivaroLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonNav_JivaroLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonNav_JivaroLogo.FlatStyle = FlatStyle.Flat;
            buttonNav_JivaroLogo.Location = new Point(75, 100);
            buttonNav_JivaroLogo.Margin = new Padding(0);
            buttonNav_JivaroLogo.Name = "buttonNav_JivaroLogo";
            buttonNav_JivaroLogo.Size = new Size(50, 50);
            buttonNav_JivaroLogo.TabIndex = 49;
            buttonNav_JivaroLogo.UseVisualStyleBackColor = false;
            buttonNav_JivaroLogo.Click += btnSettings_VisitWebsite_Click;
            // 
            // checkBoxBreakProfiles_EnableBreaks
            // 
            checkBoxBreakProfiles_EnableBreaks.AutoSize = true;
            checkBoxBreakProfiles_EnableBreaks.BackColor = Color.Transparent;
            checkBoxBreakProfiles_EnableBreaks.BackgroundImageLayout = ImageLayout.Stretch;
            checkBoxBreakProfiles_EnableBreaks.Checked = true;
            checkBoxBreakProfiles_EnableBreaks.CheckState = CheckState.Checked;
            checkBoxBreakProfiles_EnableBreaks.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBreakProfiles_EnableBreaks.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxBreakProfiles_EnableBreaks.Location = new Point(350, 200);
            checkBoxBreakProfiles_EnableBreaks.Name = "checkBoxBreakProfiles_EnableBreaks";
            checkBoxBreakProfiles_EnableBreaks.RightToLeft = RightToLeft.No;
            checkBoxBreakProfiles_EnableBreaks.Size = new Size(123, 22);
            checkBoxBreakProfiles_EnableBreaks.TabIndex = 11;
            checkBoxBreakProfiles_EnableBreaks.Text = "Enable Breaks";
            checkBoxBreakProfiles_EnableBreaks.UseVisualStyleBackColor = false;
            // 
            // checkBoxBreakProfiles_EnableSleepBreaks
            // 
            checkBoxBreakProfiles_EnableSleepBreaks.AutoSize = true;
            checkBoxBreakProfiles_EnableSleepBreaks.BackColor = Color.Transparent;
            checkBoxBreakProfiles_EnableSleepBreaks.BackgroundImageLayout = ImageLayout.Stretch;
            checkBoxBreakProfiles_EnableSleepBreaks.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBreakProfiles_EnableSleepBreaks.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxBreakProfiles_EnableSleepBreaks.Location = new Point(825, 200);
            checkBoxBreakProfiles_EnableSleepBreaks.Name = "checkBoxBreakProfiles_EnableSleepBreaks";
            checkBoxBreakProfiles_EnableSleepBreaks.RightToLeft = RightToLeft.No;
            checkBoxBreakProfiles_EnableSleepBreaks.Size = new Size(164, 22);
            checkBoxBreakProfiles_EnableSleepBreaks.TabIndex = 12;
            checkBoxBreakProfiles_EnableSleepBreaks.Text = "Enable Sleep Breaks";
            checkBoxBreakProfiles_EnableSleepBreaks.UseVisualStyleBackColor = false;
            // 
            // checkBoxSettings_ShowCpuAndRamUsage
            // 
            checkBoxSettings_ShowCpuAndRamUsage.AutoSize = true;
            checkBoxSettings_ShowCpuAndRamUsage.BackColor = Color.Transparent;
            checkBoxSettings_ShowCpuAndRamUsage.Checked = true;
            checkBoxSettings_ShowCpuAndRamUsage.CheckState = CheckState.Checked;
            checkBoxSettings_ShowCpuAndRamUsage.Cursor = Cursors.Hand;
            checkBoxSettings_ShowCpuAndRamUsage.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxSettings_ShowCpuAndRamUsage.Location = new Point(294, 501);
            checkBoxSettings_ShowCpuAndRamUsage.Margin = new Padding(0);
            checkBoxSettings_ShowCpuAndRamUsage.Name = "checkBoxSettings_ShowCpuAndRamUsage";
            checkBoxSettings_ShowCpuAndRamUsage.Size = new Size(180, 21);
            checkBoxSettings_ShowCpuAndRamUsage.TabIndex = 104;
            checkBoxSettings_ShowCpuAndRamUsage.Text = "Show CPU / RAM Usage";
            checkBoxSettings_ShowCpuAndRamUsage.UseVisualStyleBackColor = false;
            // 
            // checkBoxSettings_ShowWelcomeScreen
            // 
            checkBoxSettings_ShowWelcomeScreen.AutoSize = true;
            checkBoxSettings_ShowWelcomeScreen.BackColor = Color.Transparent;
            checkBoxSettings_ShowWelcomeScreen.Checked = true;
            checkBoxSettings_ShowWelcomeScreen.CheckState = CheckState.Checked;
            checkBoxSettings_ShowWelcomeScreen.Cursor = Cursors.Hand;
            checkBoxSettings_ShowWelcomeScreen.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxSettings_ShowWelcomeScreen.Location = new Point(294, 476);
            checkBoxSettings_ShowWelcomeScreen.Margin = new Padding(0);
            checkBoxSettings_ShowWelcomeScreen.Name = "checkBoxSettings_ShowWelcomeScreen";
            checkBoxSettings_ShowWelcomeScreen.Size = new Size(172, 21);
            checkBoxSettings_ShowWelcomeScreen.TabIndex = 103;
            checkBoxSettings_ShowWelcomeScreen.Text = "Show Welcome Screen";
            checkBoxSettings_ShowWelcomeScreen.UseVisualStyleBackColor = false;
            // 
            // comboBoxBreakProfiles_SelectBreakFilename
            // 
            comboBoxBreakProfiles_SelectBreakFilename.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxBreakProfiles_SelectBreakFilename.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBreakProfiles_SelectBreakFilename.FlatStyle = FlatStyle.Flat;
            comboBoxBreakProfiles_SelectBreakFilename.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBreakProfiles_SelectBreakFilename.ForeColor = Color.FromArgb(60, 60, 60);
            comboBoxBreakProfiles_SelectBreakFilename.FormattingEnabled = true;
            comboBoxBreakProfiles_SelectBreakFilename.Items.AddRange(new object[] { "fxBreaks-AccountBuilder.txt", "fxBreaks-Agility.txt", "fxBreaks-Aragorn.txt", "fxBreaks-Bossing.txt", "fxBreaks-Construction.txt", "fxBreaks-Cooking.txt", "fxBreaks-Crafting.txt", "fxBreaks-Farming.txt", "fxBreaks-Fighter.txt", "fxBreaks-Firemaking.txt", "fxBreaks-Fishing.txt", "fxBreaks-Fletching.txt", "fxBreaks-Gandalf.txt", "fxBreaks-Generic.txt", "fxBreaks-GoldFarming.txt", "fxBreaks-GOTR.txt", "fxBreaks-Herblore.txt", "fxBreaks-Hunter.txt", "fxBreaks-Legolas.txt", "fxBreaks-Magic.txt", "fxBreaks-Mining.txt", "fxBreaks-Miscellaneous.txt", "fxBreaks-Prayer.txt", "fxBreaks-ProgressiveFighter.txt", "fxBreaks-RoguesDen.txt", "fxBreaks-Runecrafting.txt", "fxBreaks-Slayer.txt", "fxBreaks-Smithing.txt", "fxBreaks-Thieving.txt", "fxBreaks-Woodcutting.txt" });
            comboBoxBreakProfiles_SelectBreakFilename.Location = new Point(350, 525);
            comboBoxBreakProfiles_SelectBreakFilename.Name = "comboBoxBreakProfiles_SelectBreakFilename";
            comboBoxBreakProfiles_SelectBreakFilename.Size = new Size(297, 23);
            comboBoxBreakProfiles_SelectBreakFilename.TabIndex = 26;
            // 
            // comboBoxScriptProfiles_SelectScript
            // 
            comboBoxScriptProfiles_SelectScript.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxScriptProfiles_SelectScript.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxScriptProfiles_SelectScript.FlatStyle = FlatStyle.Flat;
            comboBoxScriptProfiles_SelectScript.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxScriptProfiles_SelectScript.ForeColor = Color.FromArgb(60, 60, 60);
            comboBoxScriptProfiles_SelectScript.FormattingEnabled = true;
            comboBoxScriptProfiles_SelectScript.Items.AddRange(new object[] { "fxAccountBuilder.txt", "fxAccountBuilder-MasterFarmer.txt", "fxAccountBuilder-Orber.txt", "fxAgility-Rooftops.txt", "fxCooking-AIO.txt", "fxFarming-TitheFarm.txt", "fxFighter-Crabs.txt", "fxFighter-DustDevils.txt", "fxFighter-ChaosTemple.txt", "fxFighter-LavaDragons.txt", "fxFighter-Kurasks.txt", "fxFighter-RuneDragons.txt", "fxFighter-VyrewatchSentinels.txt", "fxFiremaking-GrandExchange.txt", "fxFletching-Longbows.txt", "fxGeneric.txt", "fxHerblore-CleanHerbs.txt", "fxMagic-HouseAlcher.txt", "fxMagic-Orber.txt", "fxMagic-Splasher.txt", "fxMiniGames-RoguesDen.txt", "fxMining-AIO.txt", "fxMining-MotherlodeMine.txt", "fxMuler.txt", "fxPrayer-GildedAltar.txt", "fxProgressiveFighter-Magic.txt", "fxProgressiveFighter-Melee.txt", "fxProgressiveFighter-Ranged.txt", "fxRunecrafting-Abyss.txt", "fxRunecrafting-Zeah.txt", "fxSlayer-AIO.txt", "fxSmithing-AIO.txt", "fxThieving-AIO.txt", "fxThieving-Elves.txt", "fxThieving-MasterFarmers.txt", "fxThieving-VyrewatchSentinels.txt", "fxTutorial.txt" });
            comboBoxScriptProfiles_SelectScript.Location = new Point(615, 250);
            comboBoxScriptProfiles_SelectScript.Margin = new Padding(0);
            comboBoxScriptProfiles_SelectScript.Name = "comboBoxScriptProfiles_SelectScript";
            comboBoxScriptProfiles_SelectScript.Size = new Size(350, 26);
            comboBoxScriptProfiles_SelectScript.TabIndex = 26;
            comboBoxScriptProfiles_SelectScript.SelectionChangeCommitted += comboBoxScriptProfiles_SelectScript_ChangeCommited;
            // 
            // dataGridViewDashboard_DreamBotManager
            // 
            dataGridViewDashboard_DreamBotManager.AllowUserToAddRows = false;
            dataGridViewDashboard_DreamBotManager.AllowUserToDeleteRows = false;
            dataGridViewDashboard_DreamBotManager.AllowUserToResizeColumns = false;
            dataGridViewDashboard_DreamBotManager.AllowUserToResizeRows = false;
            dataGridViewDashboard_DreamBotManager.BackgroundColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_DreamBotManager.BorderStyle = BorderStyle.None;
            dataGridViewDashboard_DreamBotManager.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDashboard_DreamBotManager.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewDashboard_DreamBotManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDashboard_DreamBotManager.ColumnHeadersHeight = 25;
            dataGridViewDashboard_DreamBotManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDashboard_DreamBotManager.Columns.AddRange(new DataGridViewColumn[] { dataGridViewDashboard_DreamBotManager_Account, dataGridViewDashboard_DreamBotManager_Password, dataGridViewDashboard_DreamBotManager_Pin, dataGridViewDashboard_DreamBotManager_Proxy, dataGridViewDashboard_DreamBotManager_Script, dataGridViewDashboard_DreamBotManager_Args, dataGridViewDashboard_DreamBotManager_Breaks, dataGridViewDashboard_DreamBotManager_World, dataGridViewDashboard_DreamBotManager_RunStop, dataGridViewDashboard_DreamBotManager_Notes, dataGridViewDashboard_DreamBotManager_Status, dataGridViewDashboard_DreamBotManager_SandboxieNumber });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewDashboard_DreamBotManager.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDashboard_DreamBotManager.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDashboard_DreamBotManager.EnableHeadersVisualStyles = false;
            dataGridViewDashboard_DreamBotManager.GridColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_DreamBotManager.Location = new Point(5, 5);
            dataGridViewDashboard_DreamBotManager.Margin = new Padding(0);
            dataGridViewDashboard_DreamBotManager.MultiSelect = false;
            dataGridViewDashboard_DreamBotManager.Name = "dataGridViewDashboard_DreamBotManager";
            dataGridViewDashboard_DreamBotManager.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewDashboard_DreamBotManager.RowHeadersVisible = false;
            dataGridViewDashboard_DreamBotManager.RowHeadersWidth = 40;
            dataGridViewDashboard_DreamBotManager.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDashboard_DreamBotManager.RowTemplate.Height = 25;
            dataGridViewDashboard_DreamBotManager.ScrollBars = ScrollBars.Vertical;
            dataGridViewDashboard_DreamBotManager.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewDashboard_DreamBotManager.Size = new Size(1137, 525);
            dataGridViewDashboard_DreamBotManager.StandardTab = true;
            dataGridViewDashboard_DreamBotManager.TabIndex = 97;
            dataGridViewDashboard_DreamBotManager.CellContentClick += dataGridView_DreamBotRun_CellButtonClick;
            // 
            // dataGridViewDashboard_DreamBotManager_Account
            // 
            dataGridViewDashboard_DreamBotManager_Account.HeaderText = "Account";
            dataGridViewDashboard_DreamBotManager_Account.Name = "dataGridViewDashboard_DreamBotManager_Account";
            dataGridViewDashboard_DreamBotManager_Account.Width = 150;
            // 
            // dataGridViewDashboard_DreamBotManager_Password
            // 
            dataGridViewDashboard_DreamBotManager_Password.HeaderText = "Password";
            dataGridViewDashboard_DreamBotManager_Password.Name = "dataGridViewDashboard_DreamBotManager_Password";
            // 
            // dataGridViewDashboard_DreamBotManager_Pin
            // 
            dataGridViewDashboard_DreamBotManager_Pin.HeaderText = "Pin";
            dataGridViewDashboard_DreamBotManager_Pin.Name = "dataGridViewDashboard_DreamBotManager_Pin";
            dataGridViewDashboard_DreamBotManager_Pin.Width = 75;
            // 
            // dataGridViewDashboard_DreamBotManager_Proxy
            // 
            dataGridViewDashboard_DreamBotManager_Proxy.HeaderText = "Proxy";
            dataGridViewDashboard_DreamBotManager_Proxy.Name = "dataGridViewDashboard_DreamBotManager_Proxy";
            dataGridViewDashboard_DreamBotManager_Proxy.Width = 125;
            // 
            // dataGridViewDashboard_DreamBotManager_Script
            // 
            dataGridViewDashboard_DreamBotManager_Script.HeaderText = "Script";
            dataGridViewDashboard_DreamBotManager_Script.Name = "dataGridViewDashboard_DreamBotManager_Script";
            dataGridViewDashboard_DreamBotManager_Script.Width = 225;
            // 
            // dataGridViewDashboard_DreamBotManager_Args
            // 
            dataGridViewDashboard_DreamBotManager_Args.HeaderText = "Args";
            dataGridViewDashboard_DreamBotManager_Args.Name = "dataGridViewDashboard_DreamBotManager_Args";
            dataGridViewDashboard_DreamBotManager_Args.Width = 75;
            // 
            // dataGridViewDashboard_DreamBotManager_Breaks
            // 
            dataGridViewDashboard_DreamBotManager_Breaks.HeaderText = "Breaks";
            dataGridViewDashboard_DreamBotManager_Breaks.Name = "dataGridViewDashboard_DreamBotManager_Breaks";
            dataGridViewDashboard_DreamBotManager_Breaks.Width = 75;
            // 
            // dataGridViewDashboard_DreamBotManager_World
            // 
            dataGridViewDashboard_DreamBotManager_World.HeaderText = "World";
            dataGridViewDashboard_DreamBotManager_World.Items.AddRange(new object[] { "f2p", "301", "308", "316", "326", "335", "371", "380", "382", "383", "384", "394", "397", "398", "399", "417", "418", "430", "431", "433", "434", "435", "436", "437", "451", "452", "453", "454", "455", "456", "469", "470", "471", "475", "476", "483", "497", "498", "499", "500", "501", "537", "542", "543", "544", "545", "546", "547", "552", "553", "554", "555", "556", "557", "562", "563", "571", "575", "members", "302", "303", "304", "305", "306", "307", "309", "310", "311", "312", "313", "314", "315", "317", "318", "319", "320", "321", "322", "323", "324", "325", "327", "328", "329", "330", "331", "332", "333", "334", "336", "337", "338", "339", "340", "341", "343", "344", "346", "347", "348", "350", "351", "352", "354", "355", "357", "358", "359", "360", "362", "367", "368", "369", "370", "374", "375", "376", "377", "378", "386", "387", "388", "389", "390", "395", "421", "422", "424", "443", "444", "445", "446", "463", "464", "465", "466", "477", "478", "480", "481", "482", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493", "494", "495", "496", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525", "531", "532", "533", "534", "535", "580" });
            dataGridViewDashboard_DreamBotManager_World.Name = "dataGridViewDashboard_DreamBotManager_World";
            dataGridViewDashboard_DreamBotManager_World.Width = 60;
            // 
            // dataGridViewDashboard_DreamBotManager_RunStop
            // 
            dataGridViewDashboard_DreamBotManager_RunStop.HeaderText = "Run | Stop";
            dataGridViewDashboard_DreamBotManager_RunStop.Name = "dataGridViewDashboard_DreamBotManager_RunStop";
            dataGridViewDashboard_DreamBotManager_RunStop.Width = 75;
            // 
            // dataGridViewDashboard_DreamBotManager_Notes
            // 
            dataGridViewDashboard_DreamBotManager_Notes.HeaderText = "Notes";
            dataGridViewDashboard_DreamBotManager_Notes.Name = "dataGridViewDashboard_DreamBotManager_Notes";
            // 
            // dataGridViewDashboard_DreamBotManager_Status
            // 
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.ForestGreen;
            dataGridViewDashboard_DreamBotManager_Status.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDashboard_DreamBotManager_Status.HeaderText = "Status";
            dataGridViewDashboard_DreamBotManager_Status.Name = "dataGridViewDashboard_DreamBotManager_Status";
            dataGridViewDashboard_DreamBotManager_Status.ReadOnly = true;
            dataGridViewDashboard_DreamBotManager_Status.Width = 75;
            // 
            // dataGridViewDashboard_DreamBotManager_SandboxieNumber
            // 
            dataGridViewDashboard_DreamBotManager_SandboxieNumber.HeaderText = "Sandboxie Number";
            dataGridViewDashboard_DreamBotManager_SandboxieNumber.Name = "dataGridViewDashboard_DreamBotManager_SandboxieNumber";
            dataGridViewDashboard_DreamBotManager_SandboxieNumber.Visible = false;
            // 
            // dataGridViewDashboard_OSBotManager
            // 
            dataGridViewDashboard_OSBotManager.AllowUserToAddRows = false;
            dataGridViewDashboard_OSBotManager.AllowUserToDeleteRows = false;
            dataGridViewDashboard_OSBotManager.AllowUserToResizeColumns = false;
            dataGridViewDashboard_OSBotManager.AllowUserToResizeRows = false;
            dataGridViewDashboard_OSBotManager.BackgroundColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_OSBotManager.BorderStyle = BorderStyle.None;
            dataGridViewDashboard_OSBotManager.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDashboard_OSBotManager.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewDashboard_OSBotManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewDashboard_OSBotManager.ColumnHeadersHeight = 25;
            dataGridViewDashboard_OSBotManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDashboard_OSBotManager.Columns.AddRange(new DataGridViewColumn[] { dataGridViewDashboard_OSBotManager_Account, dataGridViewDashboard_OSBotManager_Password, dataGridViewDashboard_OSBotManager_Pin, dataGridViewDashboard_OSBotManager_Proxy, dataGridViewDashboard_OSBotManager_Script, dataGridViewDashboard_OSBotManager_Args, dataGridViewDashboard_OSBotManager_World, dataGridViewDashboard_OSBotManager_RunStop, dataGridViewDashboard_OSBotManager_Notes, dataGridViewDashboard_OSBotManager_Status, dataGridViewDashboard_OSBotManager_SandboxieNumber });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewDashboard_OSBotManager.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewDashboard_OSBotManager.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDashboard_OSBotManager.EnableHeadersVisualStyles = false;
            dataGridViewDashboard_OSBotManager.Location = new Point(5, 5);
            dataGridViewDashboard_OSBotManager.Margin = new Padding(0);
            dataGridViewDashboard_OSBotManager.MultiSelect = false;
            dataGridViewDashboard_OSBotManager.Name = "dataGridViewDashboard_OSBotManager";
            dataGridViewDashboard_OSBotManager.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewDashboard_OSBotManager.RowHeadersVisible = false;
            dataGridViewDashboard_OSBotManager.RowHeadersWidth = 40;
            dataGridViewDashboard_OSBotManager.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDashboard_OSBotManager.RowTemplate.Height = 25;
            dataGridViewDashboard_OSBotManager.ScrollBars = ScrollBars.Vertical;
            dataGridViewDashboard_OSBotManager.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewDashboard_OSBotManager.Size = new Size(1137, 525);
            dataGridViewDashboard_OSBotManager.StandardTab = true;
            dataGridViewDashboard_OSBotManager.TabIndex = 81;
            dataGridViewDashboard_OSBotManager.CellContentClick += dataGridView_OSBotRun_CellButtonClick;
            // 
            // dataGridViewDashboard_OSBotManager_Account
            // 
            dataGridViewDashboard_OSBotManager_Account.HeaderText = "Account";
            dataGridViewDashboard_OSBotManager_Account.Name = "dataGridViewDashboard_OSBotManager_Account";
            dataGridViewDashboard_OSBotManager_Account.Width = 150;
            // 
            // dataGridViewDashboard_OSBotManager_Password
            // 
            dataGridViewDashboard_OSBotManager_Password.HeaderText = "Password";
            dataGridViewDashboard_OSBotManager_Password.Name = "dataGridViewDashboard_OSBotManager_Password";
            // 
            // dataGridViewDashboard_OSBotManager_Pin
            // 
            dataGridViewDashboard_OSBotManager_Pin.HeaderText = "Pin";
            dataGridViewDashboard_OSBotManager_Pin.Name = "dataGridViewDashboard_OSBotManager_Pin";
            dataGridViewDashboard_OSBotManager_Pin.Width = 75;
            // 
            // dataGridViewDashboard_OSBotManager_Proxy
            // 
            dataGridViewDashboard_OSBotManager_Proxy.HeaderText = "Proxy";
            dataGridViewDashboard_OSBotManager_Proxy.Name = "dataGridViewDashboard_OSBotManager_Proxy";
            dataGridViewDashboard_OSBotManager_Proxy.Width = 125;
            // 
            // dataGridViewDashboard_OSBotManager_Script
            // 
            dataGridViewDashboard_OSBotManager_Script.HeaderText = "Script";
            dataGridViewDashboard_OSBotManager_Script.Name = "dataGridViewDashboard_OSBotManager_Script";
            dataGridViewDashboard_OSBotManager_Script.Width = 225;
            // 
            // dataGridViewDashboard_OSBotManager_Args
            // 
            dataGridViewDashboard_OSBotManager_Args.HeaderText = "Args";
            dataGridViewDashboard_OSBotManager_Args.Name = "dataGridViewDashboard_OSBotManager_Args";
            dataGridViewDashboard_OSBotManager_Args.Width = 125;
            // 
            // dataGridViewDashboard_OSBotManager_World
            // 
            dataGridViewDashboard_OSBotManager_World.HeaderText = "World";
            dataGridViewDashboard_OSBotManager_World.Items.AddRange(new object[] { "-F2P-", "301", "308", "316", "326", "335", "371", "380", "382", "383", "384", "394", "397", "398", "399", "417", "418", "430", "431", "433", "434", "435", "436", "437", "451", "452", "453", "454", "455", "456", "469", "470", "471", "475", "476", "483", "497", "498", "499", "500", "501", "537", "542", "543", "544", "545", "546", "547", "552", "553", "554", "555", "556", "557", "562", "563", "571", "575", "-P2P-", "302", "303", "304", "305", "306", "307", "309", "310", "311", "312", "313", "314", "315", "317", "318", "319", "320", "321", "322", "323", "324", "325", "327", "328", "329", "330", "331", "332", "333", "334", "336", "337", "338", "339", "340", "341", "343", "344", "346", "347", "348", "350", "351", "352", "354", "355", "357", "358", "359", "360", "362", "367", "368", "369", "370", "374", "375", "376", "377", "378", "386", "387", "388", "389", "390", "395", "421", "422", "424", "443", "444", "445", "446", "463", "464", "465", "466", "477", "478", "480", "481", "482", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493", "494", "495", "496", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525", "531", "532", "533", "534", "535", "580" });
            dataGridViewDashboard_OSBotManager_World.Name = "dataGridViewDashboard_OSBotManager_World";
            dataGridViewDashboard_OSBotManager_World.Width = 85;
            // 
            // dataGridViewDashboard_OSBotManager_RunStop
            // 
            dataGridViewDashboard_OSBotManager_RunStop.HeaderText = "Run | Stop";
            dataGridViewDashboard_OSBotManager_RunStop.Name = "dataGridViewDashboard_OSBotManager_RunStop";
            dataGridViewDashboard_OSBotManager_RunStop.Width = 75;
            // 
            // dataGridViewDashboard_OSBotManager_Notes
            // 
            dataGridViewDashboard_OSBotManager_Notes.HeaderText = "Notes";
            dataGridViewDashboard_OSBotManager_Notes.Name = "dataGridViewDashboard_OSBotManager_Notes";
            // 
            // dataGridViewDashboard_OSBotManager_Status
            // 
            dataGridViewCellStyle6.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.ForestGreen;
            dataGridViewDashboard_OSBotManager_Status.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewDashboard_OSBotManager_Status.HeaderText = "Status";
            dataGridViewDashboard_OSBotManager_Status.Name = "dataGridViewDashboard_OSBotManager_Status";
            dataGridViewDashboard_OSBotManager_Status.ReadOnly = true;
            dataGridViewDashboard_OSBotManager_Status.Width = 75;
            // 
            // dataGridViewDashboard_OSBotManager_SandboxieNumber
            // 
            dataGridViewDashboard_OSBotManager_SandboxieNumber.HeaderText = "Sandboxie Number";
            dataGridViewDashboard_OSBotManager_SandboxieNumber.Name = "dataGridViewDashboard_OSBotManager_SandboxieNumber";
            dataGridViewDashboard_OSBotManager_SandboxieNumber.Visible = false;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(1175, 150);
            kryptonButton1.Margin = new Padding(0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButton1.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButton1.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButton1.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButton1.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButton1.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButton1.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButton1.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButton1.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButton1.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButton1.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButton1.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.Size = new Size(100, 50);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButton1.StateCommon.Back.ColorAngle = 50F;
            kryptonButton1.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButton1.StateCommon.Border.Color1 = Color.Silver;
            kryptonButton1.StateCommon.Border.Color2 = Color.Silver;
            kryptonButton1.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButton1.StatePressed.Back.ColorAngle = 50F;
            kryptonButton1.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButton1.StatePressed.Border.Color1 = Color.Silver;
            kryptonButton1.StatePressed.Border.Color2 = Color.Silver;
            kryptonButton1.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButton1.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButton1.StateTracking.Back.ColorAngle = 50F;
            kryptonButton1.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButton1.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.TabIndex = 108;
            kryptonButton1.Values.Text = "Install Sandboxie";
            kryptonButton1.Click += btnSettings_InstallSandboxie_Click;
            // 
            // kryptonButtonBreakProfiles_Save
            // 
            kryptonButtonBreakProfiles_Save.Location = new Point(750, 510);
            kryptonButtonBreakProfiles_Save.Margin = new Padding(0);
            kryptonButtonBreakProfiles_Save.Name = "kryptonButtonBreakProfiles_Save";
            kryptonButtonBreakProfiles_Save.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonBreakProfiles_Save.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonBreakProfiles_Save.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonBreakProfiles_Save.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonBreakProfiles_Save.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonBreakProfiles_Save.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonBreakProfiles_Save.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonBreakProfiles_Save.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonBreakProfiles_Save.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonBreakProfiles_Save.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonBreakProfiles_Save.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonBreakProfiles_Save.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonBreakProfiles_Save.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.Size = new Size(100, 50);
            kryptonButtonBreakProfiles_Save.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonBreakProfiles_Save.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonBreakProfiles_Save.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonBreakProfiles_Save.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonBreakProfiles_Save.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonBreakProfiles_Save.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonBreakProfiles_Save.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonBreakProfiles_Save.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonBreakProfiles_Save.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonBreakProfiles_Save.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonBreakProfiles_Save.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonBreakProfiles_Save.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonBreakProfiles_Save.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonBreakProfiles_Save.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonBreakProfiles_Save.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonBreakProfiles_Save.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonBreakProfiles_Save.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonBreakProfiles_Save.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonBreakProfiles_Save.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonBreakProfiles_Save.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonBreakProfiles_Save.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonBreakProfiles_Save.TabIndex = 55;
            kryptonButtonBreakProfiles_Save.Values.Text = "Save";
            kryptonButtonBreakProfiles_Save.Click += btnBreakProfiles_Save_Click;
            // 
            // kryptonButtonButtonDashboard_DreamBotManager_AddAccount
            // 
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.Location = new Point(150, 600);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.Margin = new Padding(0);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.Name = "kryptonButtonButtonDashboard_DreamBotManager_AddAccount";
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.Size = new Size(100, 50);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.TabIndex = 87;
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.Values.Text = "Add Account";
            kryptonButtonButtonDashboard_DreamBotManager_AddAccount.Click += btnDreamBotManager_AddAccount_Click;
            // 
            // kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount
            // 
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.Location = new Point(275, 600);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.Margin = new Padding(0);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.Name = "kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount";
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.Size = new Size(100, 50);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.TabIndex = 88;
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.Values.Text = "Delete Account";
            kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount.Click += btnDreamBotManager_DeleteAccount_Click;
            // 
            // kryptonButtonButtonDashboard_DreamBotManager_DownloadClient
            // 
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.Location = new Point(525, 600);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.Margin = new Padding(0);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.Name = "kryptonButtonButtonDashboard_DreamBotManager_DownloadClient";
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.Size = new Size(100, 50);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.TabIndex = 90;
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.Values.Text = "Download Client";
            kryptonButtonButtonDashboard_DreamBotManager_DownloadClient.Click += btnDreamBotManager_DownloadDreamBot_Click;
            // 
            // kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts
            // 
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.Location = new Point(400, 600);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.Margin = new Padding(0);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.Name = "kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts";
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.Size = new Size(100, 50);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.TabIndex = 89;
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.Values.Text = "Import Accounts";
            kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts.Click += btnShared_OpenImportAccounts_Click;
            // 
            // kryptonButtonButtonDashboard_DreamBotManager_Save
            // 
            kryptonButtonButtonDashboard_DreamBotManager_Save.Location = new Point(650, 600);
            kryptonButtonButtonDashboard_DreamBotManager_Save.Margin = new Padding(0);
            kryptonButtonButtonDashboard_DreamBotManager_Save.Name = "kryptonButtonButtonDashboard_DreamBotManager_Save";
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.Size = new Size(100, 50);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonButtonDashboard_DreamBotManager_Save.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonButtonDashboard_DreamBotManager_Save.TabIndex = 91;
            kryptonButtonButtonDashboard_DreamBotManager_Save.Values.Text = "Save";
            kryptonButtonButtonDashboard_DreamBotManager_Save.Click += btnDreamBotManager_Save_Click;
            // 
            // kryptonButtonDashboard_DreamBotManager_LaunchDreamBot
            // 
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.Location = new Point(25, 600);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.Margin = new Padding(0);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.Name = "kryptonButtonDashboard_DreamBotManager_LaunchDreamBot";
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.Size = new Size(100, 50);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.TabIndex = 86;
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.Values.Text = "Launch DB";
            kryptonButtonDashboard_DreamBotManager_LaunchDreamBot.Click += btnDreamBotManager_LaunchDreamBot_Click;
            // 
            // kryptonButtonDashboard_OSBotManager_AddAccount
            // 
            kryptonButtonDashboard_OSBotManager_AddAccount.Location = new Point(150, 600);
            kryptonButtonDashboard_OSBotManager_AddAccount.Margin = new Padding(0);
            kryptonButtonDashboard_OSBotManager_AddAccount.Name = "kryptonButtonDashboard_OSBotManager_AddAccount";
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.Size = new Size(100, 50);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_AddAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_AddAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_AddAccount.TabIndex = 71;
            kryptonButtonDashboard_OSBotManager_AddAccount.Values.Text = "Add Account";
            kryptonButtonDashboard_OSBotManager_AddAccount.Click += btnOSBotManager_AddAccount_Click;
            // 
            // kryptonButtonDashboard_OSBotManager_DeleteAccount
            // 
            kryptonButtonDashboard_OSBotManager_DeleteAccount.Location = new Point(275, 600);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.Margin = new Padding(0);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.Name = "kryptonButtonDashboard_OSBotManager_DeleteAccount";
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.Size = new Size(100, 50);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DeleteAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.TabIndex = 72;
            kryptonButtonDashboard_OSBotManager_DeleteAccount.Values.Text = "Delete Account";
            kryptonButtonDashboard_OSBotManager_DeleteAccount.Click += btnOSBotManager_DeleteAccount_Click;
            // 
            // kryptonButtonDashboard_OSBotManager_DownloadClient
            // 
            kryptonButtonDashboard_OSBotManager_DownloadClient.Location = new Point(525, 600);
            kryptonButtonDashboard_OSBotManager_DownloadClient.Margin = new Padding(0);
            kryptonButtonDashboard_OSBotManager_DownloadClient.Name = "kryptonButtonDashboard_OSBotManager_DownloadClient";
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.Size = new Size(100, 50);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_DownloadClient.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_DownloadClient.TabIndex = 74;
            kryptonButtonDashboard_OSBotManager_DownloadClient.Values.Text = "Download Client";
            kryptonButtonDashboard_OSBotManager_DownloadClient.Click += btnOSBotManager_DownloadOSBot_Click;
            // 
            // kryptonButtonDashboard_OSBotManager_ImportAccounts
            // 
            kryptonButtonDashboard_OSBotManager_ImportAccounts.Location = new Point(400, 600);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.Margin = new Padding(0);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.Name = "kryptonButtonDashboard_OSBotManager_ImportAccounts";
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.Size = new Size(100, 50);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_ImportAccounts.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.TabIndex = 73;
            kryptonButtonDashboard_OSBotManager_ImportAccounts.Values.Text = "Import Accounts";
            kryptonButtonDashboard_OSBotManager_ImportAccounts.Click += btnShared_OpenImportAccounts_Click;
            // 
            // kryptonButtonDashboard_OSBotManager_LaunchOSBot
            // 
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.Location = new Point(25, 600);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.Margin = new Padding(0);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.Name = "kryptonButtonDashboard_OSBotManager_LaunchOSBot";
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.Size = new Size(100, 50);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.TabIndex = 69;
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.Values.Text = "Launch OSBot";
            kryptonButtonDashboard_OSBotManager_LaunchOSBot.Click += btnOSBotManager_LaunchOsbot_Click;
            // 
            // kryptonButtonDashboard_OSBotManager_Save
            // 
            kryptonButtonDashboard_OSBotManager_Save.Location = new Point(650, 600);
            kryptonButtonDashboard_OSBotManager_Save.Margin = new Padding(0);
            kryptonButtonDashboard_OSBotManager_Save.Name = "kryptonButtonDashboard_OSBotManager_Save";
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.Size = new Size(100, 50);
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_Save.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_OSBotManager_Save.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_OSBotManager_Save.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_OSBotManager_Save.TabIndex = 75;
            kryptonButtonDashboard_OSBotManager_Save.Values.Text = "Save";
            kryptonButtonDashboard_OSBotManager_Save.Click += btnOSBotManager_Save_Click;
            // 
            // kryptonButtonDashboard_ScriptFactoryManager_AddAccount
            // 
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.Location = new Point(150, 600);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.Margin = new Padding(0);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.Name = "kryptonButtonDashboard_ScriptFactoryManager_AddAccount";
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.Size = new Size(100, 50);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.TabIndex = 55;
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.Values.Text = "Add Account";
            kryptonButtonDashboard_ScriptFactoryManager_AddAccount.Click += btnScriptFactory_AddAccount_Click;
            // 
            // kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount
            // 
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.Location = new Point(275, 600);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.Margin = new Padding(0);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.Name = "kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount";
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.Size = new Size(100, 50);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.TabIndex = 56;
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.Values.Text = "Delete Account";
            kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount.Click += btnScriptFactory_DeleteAccount_Click;
            // 
            // kryptonButtonDashboard_ScriptFactoryManager_DownloadClient
            // 
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.Location = new Point(525, 600);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.Margin = new Padding(0);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.Name = "kryptonButtonDashboard_ScriptFactoryManager_DownloadClient";
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.Size = new Size(100, 50);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.TabIndex = 58;
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.Values.Text = "Download Client";
            kryptonButtonDashboard_ScriptFactoryManager_DownloadClient.Click += btnScriptFactory_DownloadOSBot_Click;
            // 
            // kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts
            // 
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.Location = new Point(400, 600);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.Margin = new Padding(0);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.Name = "kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts";
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.Size = new Size(100, 50);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.TabIndex = 57;
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.Values.Text = "Import Accounts";
            kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts.Click += btnShared_OpenImportAccounts_Click;
            // 
            // kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot
            // 
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.Location = new Point(25, 600);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.Margin = new Padding(0);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.Name = "kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot";
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.Size = new Size(100, 50);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.TabIndex = 54;
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.Values.Text = "Launch OSBot";
            kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot.Click += btnScriptFactory_LaunchOsbot_Click;
            // 
            // kryptonButtonDashboard_ScriptFactoryManager_Save
            // 
            kryptonButtonDashboard_ScriptFactoryManager_Save.Location = new Point(650, 600);
            kryptonButtonDashboard_ScriptFactoryManager_Save.Margin = new Padding(0);
            kryptonButtonDashboard_ScriptFactoryManager_Save.Name = "kryptonButtonDashboard_ScriptFactoryManager_Save";
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.Size = new Size(100, 50);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_ScriptFactoryManager_Save.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_ScriptFactoryManager_Save.TabIndex = 59;
            kryptonButtonDashboard_ScriptFactoryManager_Save.Values.Text = "Save";
            kryptonButtonDashboard_ScriptFactoryManager_Save.Click += btnScriptFactory_Save_Click;
            // 
            // kryptonButtonDashboard_TRiBotManager_AddAccount
            // 
            kryptonButtonDashboard_TRiBotManager_AddAccount.Location = new Point(150, 600);
            kryptonButtonDashboard_TRiBotManager_AddAccount.Margin = new Padding(0);
            kryptonButtonDashboard_TRiBotManager_AddAccount.Name = "kryptonButtonDashboard_TRiBotManager_AddAccount";
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.Size = new Size(100, 50);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_AddAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_AddAccount.TabIndex = 103;
            kryptonButtonDashboard_TRiBotManager_AddAccount.Values.Text = "Add Account";
            kryptonButtonDashboard_TRiBotManager_AddAccount.Click += btnTRiBotManager_AddAccount_Click;
            // 
            // kryptonButtonDashboard_TRiBotManager_DeleteAccount
            // 
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.Location = new Point(275, 600);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.Margin = new Padding(0);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.Name = "kryptonButtonDashboard_TRiBotManager_DeleteAccount";
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.Size = new Size(100, 50);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.TabIndex = 104;
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.Values.Text = "Delete Account";
            kryptonButtonDashboard_TRiBotManager_DeleteAccount.Click += btnTRiBotManager_DeleteAccount_Click;
            // 
            // kryptonButtonDashboard_TRiBotManager_DownloadClient
            // 
            kryptonButtonDashboard_TRiBotManager_DownloadClient.Location = new Point(525, 600);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.Margin = new Padding(0);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.Name = "kryptonButtonDashboard_TRiBotManager_DownloadClient";
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.Size = new Size(100, 50);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_DownloadClient.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.TabIndex = 106;
            kryptonButtonDashboard_TRiBotManager_DownloadClient.Values.Text = "Download Client";
            kryptonButtonDashboard_TRiBotManager_DownloadClient.Click += btnTRiBotManager_DownloadTRiBot_Click;
            // 
            // kryptonButtonDashboard_TRiBotManager_ImportAccounts
            // 
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.Location = new Point(400, 600);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.Margin = new Padding(0);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.Name = "kryptonButtonDashboard_TRiBotManager_ImportAccounts";
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.Size = new Size(100, 50);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.TabIndex = 105;
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.Values.Text = "Import Accounts";
            kryptonButtonDashboard_TRiBotManager_ImportAccounts.Click += btnShared_OpenImportAccounts_Click;
            // 
            // kryptonButtonDashboard_TRiBotManager_LaunchClient
            // 
            kryptonButtonDashboard_TRiBotManager_LaunchClient.Location = new Point(25, 600);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.Margin = new Padding(0);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.Name = "kryptonButtonDashboard_TRiBotManager_LaunchClient";
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.Size = new Size(100, 50);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_LaunchClient.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.TabIndex = 102;
            kryptonButtonDashboard_TRiBotManager_LaunchClient.Values.Text = "Launch TRiBot";
            kryptonButtonDashboard_TRiBotManager_LaunchClient.Click += btnTRiBotManager_LaunchTRiBot_Click;
            // 
            // kryptonButtonDashboard_TRiBotManager_Save
            // 
            kryptonButtonDashboard_TRiBotManager_Save.Location = new Point(650, 600);
            kryptonButtonDashboard_TRiBotManager_Save.Margin = new Padding(0);
            kryptonButtonDashboard_TRiBotManager_Save.Name = "kryptonButtonDashboard_TRiBotManager_Save";
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.Size = new Size(100, 50);
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_Save.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonDashboard_TRiBotManager_Save.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonDashboard_TRiBotManager_Save.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonDashboard_TRiBotManager_Save.TabIndex = 107;
            kryptonButtonDashboard_TRiBotManager_Save.Values.Text = "Save";
            kryptonButtonDashboard_TRiBotManager_Save.Click += btnTRiBotManager_Save_Click;
            // 
            // kryptonButtonNav_BreakProfiles
            // 
            kryptonButtonNav_BreakProfiles.Location = new Point(10, 400);
            kryptonButtonNav_BreakProfiles.Margin = new Padding(0);
            kryptonButtonNav_BreakProfiles.Name = "kryptonButtonNav_BreakProfiles";
            kryptonButtonNav_BreakProfiles.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Border.Draw = InheritBool.False;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_BreakProfiles.OverrideDefault.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.OverrideDefault.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Border.Draw = InheritBool.False;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_BreakProfiles.OverrideFocus.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.OverrideFocus.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.Size = new Size(180, 50);
            kryptonButtonNav_BreakProfiles.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.StateCommon.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_BreakProfiles.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButtonNav_BreakProfiles.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.StateDisabled.Back.ColorAngle = 50F;
            kryptonButtonNav_BreakProfiles.StateDisabled.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_BreakProfiles.StateDisabled.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateDisabled.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.StateDisabled.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.StateDisabled.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateDisabled.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateNormal.Back.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateNormal.Back.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateNormal.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateNormal.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.StateNormal.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_BreakProfiles.StateNormal.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateNormal.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StatePressed.Back.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StatePressed.Back.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StatePressed.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StatePressed.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.StatePressed.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.StatePressed.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.StatePressed.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_BreakProfiles.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_BreakProfiles.StatePressed.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StatePressed.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateTracking.Back.Color1 = Color.Silver;
            kryptonButtonNav_BreakProfiles.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonNav_BreakProfiles.StateTracking.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_BreakProfiles.StateTracking.Border.Color1 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateTracking.Border.Color2 = Color.Transparent;
            kryptonButtonNav_BreakProfiles.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_BreakProfiles.StateTracking.Border.Rounding = 10F;
            kryptonButtonNav_BreakProfiles.StateTracking.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.StateTracking.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_BreakProfiles.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_BreakProfiles.StateTracking.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.StateTracking.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_BreakProfiles.TabIndex = 52;
            kryptonButtonNav_BreakProfiles.Values.Text = "Break Profiles";
            kryptonButtonNav_BreakProfiles.Click += btnNavigation_BreakProfiles_Click;
            // 
            // kryptonButtonNav_Dashboard
            // 
            kryptonButtonNav_Dashboard.Location = new Point(10, 250);
            kryptonButtonNav_Dashboard.Margin = new Padding(0);
            kryptonButtonNav_Dashboard.Name = "kryptonButtonNav_Dashboard";
            kryptonButtonNav_Dashboard.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.OverrideDefault.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.OverrideDefault.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.OverrideDefault.Border.Draw = InheritBool.False;
            kryptonButtonNav_Dashboard.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.OverrideDefault.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Dashboard.OverrideDefault.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.OverrideDefault.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButtonNav_Dashboard.OverrideFocus.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonNav_Dashboard.OverrideFocus.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_Dashboard.OverrideFocus.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.OverrideFocus.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.OverrideFocus.Border.Draw = InheritBool.False;
            kryptonButtonNav_Dashboard.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.OverrideFocus.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Dashboard.OverrideFocus.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.OverrideFocus.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.Size = new Size(180, 50);
            kryptonButtonNav_Dashboard.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.StateCommon.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Dashboard.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButtonNav_Dashboard.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.StateDisabled.Back.ColorAngle = 50F;
            kryptonButtonNav_Dashboard.StateDisabled.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_Dashboard.StateDisabled.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateDisabled.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.StateDisabled.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.StateDisabled.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateDisabled.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateNormal.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateNormal.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateNormal.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateNormal.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.StateNormal.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Dashboard.StateNormal.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateNormal.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StatePressed.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StatePressed.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StatePressed.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StatePressed.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.StatePressed.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.StatePressed.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.StatePressed.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Dashboard.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Dashboard.StatePressed.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StatePressed.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateTracking.Back.Color1 = Color.Silver;
            kryptonButtonNav_Dashboard.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonNav_Dashboard.StateTracking.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_Dashboard.StateTracking.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateTracking.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Dashboard.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Dashboard.StateTracking.Border.Rounding = 10F;
            kryptonButtonNav_Dashboard.StateTracking.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.StateTracking.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Dashboard.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Dashboard.StateTracking.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.StateTracking.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Dashboard.TabIndex = 50;
            kryptonButtonNav_Dashboard.Values.Text = "Dashboard";
            kryptonButtonNav_Dashboard.Click += btnNavigation_ScriptFactory_Click;
            // 
            // kryptonButtonNav_ScriptProfiles
            // 
            kryptonButtonNav_ScriptProfiles.Location = new Point(10, 325);
            kryptonButtonNav_ScriptProfiles.Margin = new Padding(0);
            kryptonButtonNav_ScriptProfiles.Name = "kryptonButtonNav_ScriptProfiles";
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Border.Draw = InheritBool.False;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.OverrideDefault.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Border.Draw = InheritBool.False;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.OverrideFocus.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.Size = new Size(180, 50);
            kryptonButtonNav_ScriptProfiles.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.StateCommon.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_ScriptProfiles.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.StateDisabled.Back.ColorAngle = 50F;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.StateDisabled.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateDisabled.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateNormal.Back.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateNormal.Back.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateNormal.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateNormal.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.StateNormal.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_ScriptProfiles.StateNormal.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateNormal.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StatePressed.Back.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StatePressed.Back.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StatePressed.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StatePressed.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.StatePressed.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.StatePressed.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.StatePressed.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_ScriptProfiles.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_ScriptProfiles.StatePressed.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StatePressed.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateTracking.Back.Color1 = Color.Silver;
            kryptonButtonNav_ScriptProfiles.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonNav_ScriptProfiles.StateTracking.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_ScriptProfiles.StateTracking.Border.Color1 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateTracking.Border.Color2 = Color.Transparent;
            kryptonButtonNav_ScriptProfiles.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_ScriptProfiles.StateTracking.Border.Rounding = 10F;
            kryptonButtonNav_ScriptProfiles.StateTracking.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.StateTracking.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_ScriptProfiles.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_ScriptProfiles.StateTracking.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.StateTracking.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_ScriptProfiles.TabIndex = 51;
            kryptonButtonNav_ScriptProfiles.Values.Text = "Script Profiles";
            kryptonButtonNav_ScriptProfiles.Click += btnNavigation_ScriptProfiles_Click;
            // 
            // kryptonButtonNav_Settings
            // 
            kryptonButtonNav_Settings.Location = new Point(10, 475);
            kryptonButtonNav_Settings.Margin = new Padding(0);
            kryptonButtonNav_Settings.Name = "kryptonButtonNav_Settings";
            kryptonButtonNav_Settings.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.OverrideDefault.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.OverrideDefault.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.OverrideDefault.Border.Draw = InheritBool.False;
            kryptonButtonNav_Settings.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.OverrideDefault.Border.Rounding = 10F;
            kryptonButtonNav_Settings.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Settings.OverrideDefault.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.OverrideDefault.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButtonNav_Settings.OverrideFocus.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonNav_Settings.OverrideFocus.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_Settings.OverrideFocus.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.OverrideFocus.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.OverrideFocus.Border.Draw = InheritBool.False;
            kryptonButtonNav_Settings.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.OverrideFocus.Border.Rounding = 10F;
            kryptonButtonNav_Settings.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Settings.OverrideFocus.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.OverrideFocus.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.Size = new Size(180, 50);
            kryptonButtonNav_Settings.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.StateCommon.Border.Rounding = 10F;
            kryptonButtonNav_Settings.StateCommon.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.StateCommon.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Settings.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButtonNav_Settings.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.StateDisabled.Back.ColorAngle = 50F;
            kryptonButtonNav_Settings.StateDisabled.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_Settings.StateDisabled.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StateDisabled.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StateDisabled.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.StateDisabled.Border.Rounding = 10F;
            kryptonButtonNav_Settings.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.StateDisabled.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateDisabled.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateNormal.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StateNormal.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StateNormal.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StateNormal.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.StateNormal.Border.Rounding = 10F;
            kryptonButtonNav_Settings.StateNormal.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.StateNormal.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.StateNormal.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Settings.StateNormal.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateNormal.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StatePressed.Back.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StatePressed.Back.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StatePressed.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StatePressed.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.StatePressed.Border.Rounding = 10F;
            kryptonButtonNav_Settings.StatePressed.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.StatePressed.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonNav_Settings.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Settings.StatePressed.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StatePressed.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateTracking.Back.Color1 = Color.Silver;
            kryptonButtonNav_Settings.StateTracking.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonNav_Settings.StateTracking.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonButtonNav_Settings.StateTracking.Border.Color1 = Color.Transparent;
            kryptonButtonNav_Settings.StateTracking.Border.Color2 = Color.Transparent;
            kryptonButtonNav_Settings.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonNav_Settings.StateTracking.Border.Rounding = 10F;
            kryptonButtonNav_Settings.StateTracking.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.StateTracking.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonNav_Settings.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonNav_Settings.StateTracking.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.StateTracking.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonNav_Settings.TabIndex = 53;
            kryptonButtonNav_Settings.Values.Text = "Settings";
            kryptonButtonNav_Settings.Click += btnNavigation_Settings_Click;
            // 
            // kryptonButtonSettings_BottingGuide
            // 
            kryptonButtonSettings_BottingGuide.Location = new Point(1175, 300);
            kryptonButtonSettings_BottingGuide.Margin = new Padding(0);
            kryptonButtonSettings_BottingGuide.Name = "kryptonButtonSettings_BottingGuide";
            kryptonButtonSettings_BottingGuide.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BottingGuide.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_BottingGuide.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BottingGuide.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_BottingGuide.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_BottingGuide.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BottingGuide.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BottingGuide.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BottingGuide.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_BottingGuide.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BottingGuide.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BottingGuide.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BottingGuide.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BottingGuide.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BottingGuide.Size = new Size(100, 50);
            kryptonButtonSettings_BottingGuide.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BottingGuide.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_BottingGuide.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BottingGuide.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_BottingGuide.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_BottingGuide.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BottingGuide.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BottingGuide.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_BottingGuide.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_BottingGuide.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BottingGuide.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BottingGuide.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_BottingGuide.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BottingGuide.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_BottingGuide.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_BottingGuide.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BottingGuide.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BottingGuide.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BottingGuide.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BottingGuide.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_BottingGuide.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BottingGuide.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BottingGuide.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BottingGuide.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BottingGuide.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BottingGuide.TabIndex = 114;
            kryptonButtonSettings_BottingGuide.Values.Text = "Botting Guide";
            kryptonButtonSettings_BottingGuide.Click += btnSettings_BottingGuide_Click;
            // 
            // kryptonButtonSettings_BuyProxies
            // 
            kryptonButtonSettings_BuyProxies.Location = new Point(1000, 375);
            kryptonButtonSettings_BuyProxies.Margin = new Padding(0);
            kryptonButtonSettings_BuyProxies.Name = "kryptonButtonSettings_BuyProxies";
            kryptonButtonSettings_BuyProxies.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BuyProxies.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_BuyProxies.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BuyProxies.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_BuyProxies.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_BuyProxies.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BuyProxies.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BuyProxies.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BuyProxies.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_BuyProxies.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BuyProxies.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BuyProxies.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BuyProxies.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BuyProxies.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BuyProxies.Size = new Size(100, 50);
            kryptonButtonSettings_BuyProxies.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BuyProxies.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_BuyProxies.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BuyProxies.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_BuyProxies.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_BuyProxies.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BuyProxies.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BuyProxies.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_BuyProxies.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_BuyProxies.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BuyProxies.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BuyProxies.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_BuyProxies.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BuyProxies.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_BuyProxies.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_BuyProxies.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BuyProxies.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BuyProxies.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_BuyProxies.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_BuyProxies.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_BuyProxies.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_BuyProxies.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BuyProxies.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_BuyProxies.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_BuyProxies.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_BuyProxies.TabIndex = 116;
            kryptonButtonSettings_BuyProxies.Values.Text = "Buy Proxies";
            kryptonButtonSettings_BuyProxies.Click += btnSettings_BuyProxies_Click;
            // 
            // kryptonButtonSettings_CreateAccount
            // 
            kryptonButtonSettings_CreateAccount.Location = new Point(825, 375);
            kryptonButtonSettings_CreateAccount.Margin = new Padding(0);
            kryptonButtonSettings_CreateAccount.Name = "kryptonButtonSettings_CreateAccount";
            kryptonButtonSettings_CreateAccount.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_CreateAccount.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_CreateAccount.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_CreateAccount.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_CreateAccount.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_CreateAccount.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_CreateAccount.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_CreateAccount.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_CreateAccount.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_CreateAccount.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_CreateAccount.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_CreateAccount.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_CreateAccount.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_CreateAccount.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_CreateAccount.Size = new Size(100, 50);
            kryptonButtonSettings_CreateAccount.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_CreateAccount.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_CreateAccount.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_CreateAccount.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_CreateAccount.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_CreateAccount.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_CreateAccount.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_CreateAccount.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_CreateAccount.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_CreateAccount.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_CreateAccount.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_CreateAccount.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_CreateAccount.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_CreateAccount.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_CreateAccount.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_CreateAccount.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_CreateAccount.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_CreateAccount.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_CreateAccount.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_CreateAccount.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_CreateAccount.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_CreateAccount.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_CreateAccount.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_CreateAccount.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_CreateAccount.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_CreateAccount.TabIndex = 115;
            kryptonButtonSettings_CreateAccount.Values.Text = "Create Account";
            kryptonButtonSettings_CreateAccount.Click += btnSettings_CreateOSRSAccount_Click;
            // 
            // kryptonButtonSettings_Discord
            // 
            kryptonButtonSettings_Discord.Location = new Point(1175, 375);
            kryptonButtonSettings_Discord.Margin = new Padding(0);
            kryptonButtonSettings_Discord.Name = "kryptonButtonSettings_Discord";
            kryptonButtonSettings_Discord.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_Discord.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_Discord.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_Discord.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_Discord.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_Discord.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_Discord.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_Discord.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_Discord.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_Discord.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_Discord.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_Discord.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_Discord.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_Discord.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_Discord.Size = new Size(100, 50);
            kryptonButtonSettings_Discord.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_Discord.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_Discord.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_Discord.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_Discord.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_Discord.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_Discord.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_Discord.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_Discord.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_Discord.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_Discord.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_Discord.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_Discord.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_Discord.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_Discord.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_Discord.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_Discord.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_Discord.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_Discord.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_Discord.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_Discord.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_Discord.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_Discord.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_Discord.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_Discord.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_Discord.TabIndex = 117;
            kryptonButtonSettings_Discord.Values.Text = "Discord";
            kryptonButtonSettings_Discord.Click += btnSettings_JoinDiscord_Click;
            // 
            // kryptonButtonSettings_DownloadJava
            // 
            kryptonButtonSettings_DownloadJava.Location = new Point(825, 150);
            kryptonButtonSettings_DownloadJava.Margin = new Padding(0);
            kryptonButtonSettings_DownloadJava.Name = "kryptonButtonSettings_DownloadJava";
            kryptonButtonSettings_DownloadJava.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_DownloadJava.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_DownloadJava.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_DownloadJava.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_DownloadJava.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_DownloadJava.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_DownloadJava.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_DownloadJava.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_DownloadJava.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_DownloadJava.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_DownloadJava.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_DownloadJava.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_DownloadJava.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.Size = new Size(100, 50);
            kryptonButtonSettings_DownloadJava.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_DownloadJava.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_DownloadJava.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_DownloadJava.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_DownloadJava.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_DownloadJava.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_DownloadJava.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_DownloadJava.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_DownloadJava.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_DownloadJava.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_DownloadJava.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_DownloadJava.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_DownloadJava.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_DownloadJava.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_DownloadJava.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_DownloadJava.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_DownloadJava.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_DownloadJava.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_DownloadJava.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_DownloadJava.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_DownloadJava.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_DownloadJava.TabIndex = 106;
            kryptonButtonSettings_DownloadJava.Values.Text = "Download Java";
            kryptonButtonSettings_DownloadJava.Click += btnScriptFactory_DownloadJava_Click;
            // 
            // kryptonButtonSettings_InstallProxifier
            // 
            kryptonButtonSettings_InstallProxifier.Location = new Point(1000, 150);
            kryptonButtonSettings_InstallProxifier.Margin = new Padding(0);
            kryptonButtonSettings_InstallProxifier.Name = "kryptonButtonSettings_InstallProxifier";
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.Size = new Size(100, 50);
            kryptonButtonSettings_InstallProxifier.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_InstallProxifier.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_InstallProxifier.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_InstallProxifier.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_InstallProxifier.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_InstallProxifier.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_InstallProxifier.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_InstallProxifier.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_InstallProxifier.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_InstallProxifier.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_InstallProxifier.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_InstallProxifier.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_InstallProxifier.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_InstallProxifier.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_InstallProxifier.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_InstallProxifier.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_InstallProxifier.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_InstallProxifier.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_InstallProxifier.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_InstallProxifier.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_InstallProxifier.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_InstallProxifier.TabIndex = 107;
            kryptonButtonSettings_InstallProxifier.Values.Text = "Install Proxifier";
            kryptonButtonSettings_InstallProxifier.Click += btnSettings_InstallProxifier_Click;
            // 
            // kryptonButtonSettings_KillAllBotClients
            // 
            kryptonButtonSettings_KillAllBotClients.Location = new Point(825, 450);
            kryptonButtonSettings_KillAllBotClients.Margin = new Padding(0);
            kryptonButtonSettings_KillAllBotClients.Name = "kryptonButtonSettings_KillAllBotClients";
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_KillAllBotClients.Size = new Size(450, 50);
            kryptonButtonSettings_KillAllBotClients.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_KillAllBotClients.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_KillAllBotClients.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_KillAllBotClients.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_KillAllBotClients.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_KillAllBotClients.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_KillAllBotClients.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_KillAllBotClients.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_KillAllBotClients.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_KillAllBotClients.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_KillAllBotClients.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_KillAllBotClients.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_KillAllBotClients.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_KillAllBotClients.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_KillAllBotClients.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_KillAllBotClients.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_KillAllBotClients.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_KillAllBotClients.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_KillAllBotClients.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_KillAllBotClients.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_KillAllBotClients.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_KillAllBotClients.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_KillAllBotClients.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_KillAllBotClients.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_KillAllBotClients.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_KillAllBotClients.TabIndex = 118;
            kryptonButtonSettings_KillAllBotClients.Values.Text = "Kill All Bot Clients";
            kryptonButtonSettings_KillAllBotClients.Click += btnSettings_KillAllBots_Click;
            // 
            // kryptonButtonSettings_LocalScripts
            // 
            kryptonButtonSettings_LocalScripts.Location = new Point(1000, 225);
            kryptonButtonSettings_LocalScripts.Margin = new Padding(0);
            kryptonButtonSettings_LocalScripts.Name = "kryptonButtonSettings_LocalScripts";
            kryptonButtonSettings_LocalScripts.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_LocalScripts.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_LocalScripts.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_LocalScripts.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_LocalScripts.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_LocalScripts.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_LocalScripts.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_LocalScripts.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_LocalScripts.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_LocalScripts.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_LocalScripts.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_LocalScripts.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_LocalScripts.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_LocalScripts.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_LocalScripts.Size = new Size(100, 50);
            kryptonButtonSettings_LocalScripts.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_LocalScripts.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_LocalScripts.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_LocalScripts.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_LocalScripts.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_LocalScripts.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_LocalScripts.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_LocalScripts.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_LocalScripts.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_LocalScripts.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_LocalScripts.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_LocalScripts.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_LocalScripts.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_LocalScripts.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_LocalScripts.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_LocalScripts.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_LocalScripts.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_LocalScripts.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_LocalScripts.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_LocalScripts.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_LocalScripts.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_LocalScripts.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_LocalScripts.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_LocalScripts.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_LocalScripts.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_LocalScripts.TabIndex = 110;
            kryptonButtonSettings_LocalScripts.Values.Text = "Local Scripts";
            kryptonButtonSettings_LocalScripts.Click += btnShared_OpenLocalScripts_Click;
            // 
            // kryptonButtonSettings_SaveLogin
            // 
            kryptonButtonSettings_SaveLogin.Location = new Point(400, 550);
            kryptonButtonSettings_SaveLogin.Margin = new Padding(0);
            kryptonButtonSettings_SaveLogin.Name = "kryptonButtonSettings_SaveLogin";
            kryptonButtonSettings_SaveLogin.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SaveLogin.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_SaveLogin.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SaveLogin.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_SaveLogin.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_SaveLogin.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SaveLogin.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SaveLogin.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_SaveLogin.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SaveLogin.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SaveLogin.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SaveLogin.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SaveLogin.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.Size = new Size(100, 50);
            kryptonButtonSettings_SaveLogin.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SaveLogin.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_SaveLogin.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SaveLogin.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_SaveLogin.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_SaveLogin.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SaveLogin.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_SaveLogin.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_SaveLogin.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SaveLogin.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_SaveLogin.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SaveLogin.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_SaveLogin.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_SaveLogin.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SaveLogin.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SaveLogin.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SaveLogin.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_SaveLogin.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SaveLogin.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SaveLogin.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SaveLogin.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SaveLogin.TabIndex = 105;
            kryptonButtonSettings_SaveLogin.Values.Text = "Save";
            kryptonButtonSettings_SaveLogin.Click += btnSettings_SaveLoginInfo_Click;
            // 
            // kryptonButtonSettings_SetupGuide
            // 
            kryptonButtonSettings_SetupGuide.Location = new Point(1000, 300);
            kryptonButtonSettings_SetupGuide.Margin = new Padding(0);
            kryptonButtonSettings_SetupGuide.Name = "kryptonButtonSettings_SetupGuide";
            kryptonButtonSettings_SetupGuide.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SetupGuide.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_SetupGuide.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SetupGuide.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_SetupGuide.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_SetupGuide.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SetupGuide.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_SetupGuide.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SetupGuide.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_SetupGuide.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SetupGuide.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SetupGuide.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SetupGuide.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SetupGuide.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_SetupGuide.Size = new Size(100, 50);
            kryptonButtonSettings_SetupGuide.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SetupGuide.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_SetupGuide.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SetupGuide.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_SetupGuide.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_SetupGuide.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SetupGuide.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_SetupGuide.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_SetupGuide.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_SetupGuide.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_SetupGuide.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SetupGuide.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_SetupGuide.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SetupGuide.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_SetupGuide.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_SetupGuide.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SetupGuide.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_SetupGuide.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_SetupGuide.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_SetupGuide.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_SetupGuide.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_SetupGuide.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SetupGuide.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_SetupGuide.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_SetupGuide.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_SetupGuide.TabIndex = 113;
            kryptonButtonSettings_SetupGuide.Values.Text = "Setup Guide";
            kryptonButtonSettings_SetupGuide.Click += btnSettings_SetupGuide_Click;
            // 
            // kryptonButtonSettings_UpdateManager
            // 
            kryptonButtonSettings_UpdateManager.Location = new Point(1175, 226);
            kryptonButtonSettings_UpdateManager.Margin = new Padding(0);
            kryptonButtonSettings_UpdateManager.Name = "kryptonButtonSettings_UpdateManager";
            kryptonButtonSettings_UpdateManager.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateManager.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateManager.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateManager.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_UpdateManager.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_UpdateManager.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateManager.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateManager.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateManager.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateManager.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateManager.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateManager.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateManager.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateManager.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateManager.Size = new Size(100, 50);
            kryptonButtonSettings_UpdateManager.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateManager.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateManager.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateManager.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_UpdateManager.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_UpdateManager.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateManager.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateManager.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_UpdateManager.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_UpdateManager.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateManager.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateManager.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateManager.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateManager.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_UpdateManager.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_UpdateManager.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateManager.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateManager.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateManager.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateManager.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateManager.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateManager.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateManager.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateManager.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateManager.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateManager.TabIndex = 111;
            kryptonButtonSettings_UpdateManager.Values.Text = "Update Manager";
            kryptonButtonSettings_UpdateManager.Click += btnSettings_CheckForUpdates_Click;
            // 
            // kryptonButtonSettings_UpdateScripts
            // 
            kryptonButtonSettings_UpdateScripts.Location = new Point(825, 225);
            kryptonButtonSettings_UpdateScripts.Margin = new Padding(0);
            kryptonButtonSettings_UpdateScripts.Name = "kryptonButtonSettings_UpdateScripts";
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateScripts.Size = new Size(100, 50);
            kryptonButtonSettings_UpdateScripts.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateScripts.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateScripts.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateScripts.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_UpdateScripts.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_UpdateScripts.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateScripts.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateScripts.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_UpdateScripts.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_UpdateScripts.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateScripts.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateScripts.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateScripts.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateScripts.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_UpdateScripts.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_UpdateScripts.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateScripts.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateScripts.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_UpdateScripts.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_UpdateScripts.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_UpdateScripts.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_UpdateScripts.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateScripts.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_UpdateScripts.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_UpdateScripts.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_UpdateScripts.TabIndex = 109;
            kryptonButtonSettings_UpdateScripts.Values.Text = "Update Scripts";
            kryptonButtonSettings_UpdateScripts.Click += btnScriptFactory_UpdateScripts_Click;
            // 
            // kryptonButtonSettings_VisitWebsite
            // 
            kryptonButtonSettings_VisitWebsite.Location = new Point(825, 300);
            kryptonButtonSettings_VisitWebsite.Margin = new Padding(0);
            kryptonButtonSettings_VisitWebsite.Name = "kryptonButtonSettings_VisitWebsite";
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Back.ColorAngle = 50F;
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Border.Color1 = Color.Silver;
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Border.Color2 = Color.Silver;
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Back.ColorAngle = 50F;
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.OverrideFocus.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_VisitWebsite.Size = new Size(100, 50);
            kryptonButtonSettings_VisitWebsite.StateCommon.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StateCommon.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_VisitWebsite.StateCommon.Back.ColorAngle = 50F;
            kryptonButtonSettings_VisitWebsite.StateCommon.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_VisitWebsite.StateCommon.Border.Color1 = Color.Silver;
            kryptonButtonSettings_VisitWebsite.StateCommon.Border.Color2 = Color.Silver;
            kryptonButtonSettings_VisitWebsite.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_VisitWebsite.StateCommon.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StateCommon.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_VisitWebsite.StateDisabled.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StateDisabled.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_VisitWebsite.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButtonSettings_VisitWebsite.StateDisabled.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_VisitWebsite.StatePressed.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StatePressed.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_VisitWebsite.StatePressed.Back.ColorAngle = 50F;
            kryptonButtonSettings_VisitWebsite.StatePressed.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_VisitWebsite.StatePressed.Border.Color1 = Color.Silver;
            kryptonButtonSettings_VisitWebsite.StatePressed.Border.Color2 = Color.Silver;
            kryptonButtonSettings_VisitWebsite.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_VisitWebsite.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_VisitWebsite.StateTracking.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonButtonSettings_VisitWebsite.StateTracking.Back.Color2 = SystemColors.ScrollBar;
            kryptonButtonSettings_VisitWebsite.StateTracking.Back.ColorAngle = 50F;
            kryptonButtonSettings_VisitWebsite.StateTracking.Back.ColorStyle = PaletteColorStyle.Sigma;
            kryptonButtonSettings_VisitWebsite.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_VisitWebsite.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 0);
            kryptonButtonSettings_VisitWebsite.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonSettings_VisitWebsite.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButtonSettings_VisitWebsite.TabIndex = 112;
            kryptonButtonSettings_VisitWebsite.Values.Text = "Visit Website";
            kryptonButtonSettings_VisitWebsite.Click += btnSettings_VisitWebsite_Click;
            // 
            // kryptonCheckBoxButtonDashboard_DreamBotManager_Loop
            // 
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.AutoSize = false;
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.Location = new Point(930, 600);
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.Name = "kryptonCheckBoxButtonDashboard_DreamBotManager_Loop";
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.Size = new Size(75, 25);
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.TabIndex = 83;
            kryptonCheckBoxButtonDashboard_DreamBotManager_Loop.Values.Text = "Loop";
            // 
            // kryptonCheckBoxDashboard_OSBotManager_Loop
            // 
            kryptonCheckBoxDashboard_OSBotManager_Loop.AutoSize = false;
            kryptonCheckBoxDashboard_OSBotManager_Loop.Location = new Point(930, 600);
            kryptonCheckBoxDashboard_OSBotManager_Loop.Name = "kryptonCheckBoxDashboard_OSBotManager_Loop";
            kryptonCheckBoxDashboard_OSBotManager_Loop.Size = new Size(75, 25);
            kryptonCheckBoxDashboard_OSBotManager_Loop.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxDashboard_OSBotManager_Loop.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxDashboard_OSBotManager_Loop.TabIndex = 66;
            kryptonCheckBoxDashboard_OSBotManager_Loop.Values.Text = "Loop";
            // 
            // kryptonCheckBoxDashboard_ScriptFactoryManager_Loop
            // 
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.AutoSize = false;
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.Location = new Point(930, 600);
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.Name = "kryptonCheckBoxDashboard_ScriptFactoryManager_Loop";
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.Size = new Size(75, 25);
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.TabIndex = 54;
            kryptonCheckBoxDashboard_ScriptFactoryManager_Loop.Values.Text = "Loop";
            // 
            // kryptonCheckBoxDashboard_TRiBotManager_Loop
            // 
            kryptonCheckBoxDashboard_TRiBotManager_Loop.AutoSize = false;
            kryptonCheckBoxDashboard_TRiBotManager_Loop.Location = new Point(930, 600);
            kryptonCheckBoxDashboard_TRiBotManager_Loop.Name = "kryptonCheckBoxDashboard_TRiBotManager_Loop";
            kryptonCheckBoxDashboard_TRiBotManager_Loop.Size = new Size(75, 25);
            kryptonCheckBoxDashboard_TRiBotManager_Loop.StateCommon.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxDashboard_TRiBotManager_Loop.StateCommon.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonCheckBoxDashboard_TRiBotManager_Loop.TabIndex = 99;
            kryptonCheckBoxDashboard_TRiBotManager_Loop.Values.Text = "Loop";
            // 
            // dataGridViewDashboard_ScriptFactoryManager
            // 
            dataGridViewDashboard_ScriptFactoryManager.AllowUserToAddRows = false;
            dataGridViewDashboard_ScriptFactoryManager.AllowUserToDeleteRows = false;
            dataGridViewDashboard_ScriptFactoryManager.AllowUserToResizeColumns = false;
            dataGridViewDashboard_ScriptFactoryManager.AllowUserToResizeRows = false;
            dataGridViewDashboard_ScriptFactoryManager.BackgroundColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_ScriptFactoryManager.BorderStyle = BorderStyle.None;
            dataGridViewDashboard_ScriptFactoryManager.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDashboard_ScriptFactoryManager.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewDashboard_ScriptFactoryManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewDashboard_ScriptFactoryManager.ColumnHeadersHeight = 25;
            dataGridViewDashboard_ScriptFactoryManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDashboard_ScriptFactoryManager.Columns.AddRange(new DataGridViewColumn[] { dataGridViewDashboard_ScriptFactoryManager_Account, dataGridViewDashboard_ScriptFactory_Password, dataGridViewDashboard_ScriptFactory_Pin, dataGridViewDashboard_ScriptFactory_Proxy, dataGridViewDashboard_ScriptFactory_ScriptFactory, dataGridViewDashboard_ScriptFactory_Script, dataGridViewDashboard_ScriptFactory_World, dataGridViewDashboard_ScriptFactory_RunStop, dataGridViewDashboard_ScriptFactory_Notes, dataGridViewDashboard_ScriptFactory_Status, dataGridViewDashboard_ScriptFactory_SandboxieNumber });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewDashboard_ScriptFactoryManager.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewDashboard_ScriptFactoryManager.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDashboard_ScriptFactoryManager.EnableHeadersVisualStyles = false;
            dataGridViewDashboard_ScriptFactoryManager.GridColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_ScriptFactoryManager.Location = new Point(5, 5);
            dataGridViewDashboard_ScriptFactoryManager.Margin = new Padding(0);
            dataGridViewDashboard_ScriptFactoryManager.MultiSelect = false;
            dataGridViewDashboard_ScriptFactoryManager.Name = "dataGridViewDashboard_ScriptFactoryManager";
            dataGridViewDashboard_ScriptFactoryManager.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewDashboard_ScriptFactoryManager.RowHeadersVisible = false;
            dataGridViewDashboard_ScriptFactoryManager.RowHeadersWidth = 40;
            dataGridViewDashboard_ScriptFactoryManager.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDashboard_ScriptFactoryManager.RowTemplate.Height = 25;
            dataGridViewDashboard_ScriptFactoryManager.ScrollBars = ScrollBars.Vertical;
            dataGridViewDashboard_ScriptFactoryManager.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewDashboard_ScriptFactoryManager.Size = new Size(1137, 525);
            dataGridViewDashboard_ScriptFactoryManager.StandardTab = true;
            dataGridViewDashboard_ScriptFactoryManager.TabIndex = 54;
            dataGridViewDashboard_ScriptFactoryManager.CellContentClick += dataGridView_ScriptFactoryRun_CellButtonClick;
            // 
            // dataGridViewDashboard_ScriptFactoryManager_Account
            // 
            dataGridViewDashboard_ScriptFactoryManager_Account.HeaderText = "Account";
            dataGridViewDashboard_ScriptFactoryManager_Account.Name = "dataGridViewDashboard_ScriptFactoryManager_Account";
            dataGridViewDashboard_ScriptFactoryManager_Account.Width = 150;
            // 
            // dataGridViewDashboard_ScriptFactory_Password
            // 
            dataGridViewDashboard_ScriptFactory_Password.HeaderText = "Password";
            dataGridViewDashboard_ScriptFactory_Password.Name = "dataGridViewDashboard_ScriptFactory_Password";
            // 
            // dataGridViewDashboard_ScriptFactory_Pin
            // 
            dataGridViewDashboard_ScriptFactory_Pin.HeaderText = "Pin";
            dataGridViewDashboard_ScriptFactory_Pin.Name = "dataGridViewDashboard_ScriptFactory_Pin";
            dataGridViewDashboard_ScriptFactory_Pin.Width = 75;
            // 
            // dataGridViewDashboard_ScriptFactory_Proxy
            // 
            dataGridViewDashboard_ScriptFactory_Proxy.HeaderText = "Proxy";
            dataGridViewDashboard_ScriptFactory_Proxy.Name = "dataGridViewDashboard_ScriptFactory_Proxy";
            dataGridViewDashboard_ScriptFactory_Proxy.Width = 125;
            // 
            // dataGridViewDashboard_ScriptFactory_ScriptFactory
            // 
            dataGridViewDashboard_ScriptFactory_ScriptFactory.HeaderText = "Script Factory";
            dataGridViewDashboard_ScriptFactory_ScriptFactory.Items.AddRange(new object[] { "SF I", "SF II", "SF Pro", "SF Expansion" });
            dataGridViewDashboard_ScriptFactory_ScriptFactory.Name = "dataGridViewDashboard_ScriptFactory_ScriptFactory";
            // 
            // dataGridViewDashboard_ScriptFactory_Script
            // 
            dataGridViewDashboard_ScriptFactory_Script.HeaderText = "Script";
            dataGridViewDashboard_ScriptFactory_Script.Name = "dataGridViewDashboard_ScriptFactory_Script";
            dataGridViewDashboard_ScriptFactory_Script.Width = 235;
            // 
            // dataGridViewDashboard_ScriptFactory_World
            // 
            dataGridViewDashboard_ScriptFactory_World.HeaderText = "World";
            dataGridViewDashboard_ScriptFactory_World.Items.AddRange(new object[] { "-F2P-", "301", "308", "316", "326", "335", "371", "380", "382", "383", "384", "394", "397", "398", "399", "417", "418", "430", "431", "433", "434", "435", "436", "437", "451", "452", "453", "454", "455", "456", "469", "470", "471", "475", "476", "483", "497", "498", "499", "500", "501", "537", "542", "543", "544", "545", "546", "547", "552", "553", "554", "555", "556", "557", "562", "563", "571", "575", "-P2P-", "302", "303", "304", "305", "306", "307", "309", "310", "311", "312", "313", "314", "315", "317", "318", "319", "320", "321", "322", "323", "324", "325", "327", "328", "329", "330", "331", "332", "333", "334", "336", "337", "338", "339", "340", "341", "343", "344", "346", "347", "348", "350", "351", "352", "354", "355", "357", "358", "359", "360", "362", "367", "368", "369", "370", "374", "375", "376", "377", "378", "386", "387", "388", "389", "390", "395", "421", "422", "424", "443", "444", "445", "446", "463", "464", "465", "466", "477", "478", "480", "481", "482", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493", "494", "495", "496", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525", "531", "532", "533", "534", "535", "580" });
            dataGridViewDashboard_ScriptFactory_World.Name = "dataGridViewDashboard_ScriptFactory_World";
            // 
            // dataGridViewDashboard_ScriptFactory_RunStop
            // 
            dataGridViewDashboard_ScriptFactory_RunStop.HeaderText = "Run | Stop";
            dataGridViewDashboard_ScriptFactory_RunStop.Name = "dataGridViewDashboard_ScriptFactory_RunStop";
            dataGridViewDashboard_ScriptFactory_RunStop.Width = 75;
            // 
            // dataGridViewDashboard_ScriptFactory_Notes
            // 
            dataGridViewDashboard_ScriptFactory_Notes.HeaderText = "Notes";
            dataGridViewDashboard_ScriptFactory_Notes.Name = "dataGridViewDashboard_ScriptFactory_Notes";
            // 
            // dataGridViewDashboard_ScriptFactory_Status
            // 
            dataGridViewCellStyle10.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.ForestGreen;
            dataGridViewDashboard_ScriptFactory_Status.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewDashboard_ScriptFactory_Status.HeaderText = "Status";
            dataGridViewDashboard_ScriptFactory_Status.Name = "dataGridViewDashboard_ScriptFactory_Status";
            dataGridViewDashboard_ScriptFactory_Status.ReadOnly = true;
            dataGridViewDashboard_ScriptFactory_Status.Width = 75;
            // 
            // dataGridViewDashboard_ScriptFactory_SandboxieNumber
            // 
            dataGridViewDashboard_ScriptFactory_SandboxieNumber.HeaderText = "Sandboxie Number";
            dataGridViewDashboard_ScriptFactory_SandboxieNumber.Name = "dataGridViewDashboard_ScriptFactory_SandboxieNumber";
            dataGridViewDashboard_ScriptFactory_SandboxieNumber.Visible = false;
            // 
            // dataGridViewDashboard_TRiBotManager
            // 
            dataGridViewDashboard_TRiBotManager.AllowUserToAddRows = false;
            dataGridViewDashboard_TRiBotManager.AllowUserToDeleteRows = false;
            dataGridViewDashboard_TRiBotManager.AllowUserToResizeColumns = false;
            dataGridViewDashboard_TRiBotManager.AllowUserToResizeRows = false;
            dataGridViewDashboard_TRiBotManager.BackgroundColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_TRiBotManager.BorderStyle = BorderStyle.None;
            dataGridViewDashboard_TRiBotManager.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDashboard_TRiBotManager.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewDashboard_TRiBotManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewDashboard_TRiBotManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDashboard_TRiBotManager.Columns.AddRange(new DataGridViewColumn[] { dataGridViewDashboard_TRiBotManager_Account, dataGridViewDashboard_TRiBotManager_Password, dataGridViewDashboard_TRiBotManager_Pin, dataGridViewDashboard_TRiBotManager_Proxy, dataGridViewDashboard_TRiBotManager_Script, dataGridViewDashboard_TRiBotManager_Args, dataGridViewDashboard_TRiBotManager_Breaks, dataGridViewDashboard_TRiBotManager_World, dataGridViewDashboard_TRiBotManager_RunStop, dataGridViewDashboard_TRiBotManager_Notes, dataGridViewDashboard_TRiBotManager_Status, dataGridViewDashboard_TRiBotManager_SandboxieNumber });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dataGridViewDashboard_TRiBotManager.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewDashboard_TRiBotManager.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDashboard_TRiBotManager.EnableHeadersVisualStyles = false;
            dataGridViewDashboard_TRiBotManager.GridColor = Color.FromArgb(60, 60, 60);
            dataGridViewDashboard_TRiBotManager.Location = new Point(5, 5);
            dataGridViewDashboard_TRiBotManager.Margin = new Padding(0);
            dataGridViewDashboard_TRiBotManager.MultiSelect = false;
            dataGridViewDashboard_TRiBotManager.Name = "dataGridViewDashboard_TRiBotManager";
            dataGridViewDashboard_TRiBotManager.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewDashboard_TRiBotManager.RowHeadersVisible = false;
            dataGridViewDashboard_TRiBotManager.RowHeadersWidth = 40;
            dataGridViewDashboard_TRiBotManager.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewDashboard_TRiBotManager.RowTemplate.Height = 25;
            dataGridViewDashboard_TRiBotManager.ScrollBars = ScrollBars.Vertical;
            dataGridViewDashboard_TRiBotManager.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewDashboard_TRiBotManager.Size = new Size(1137, 525);
            dataGridViewDashboard_TRiBotManager.StandardTab = true;
            dataGridViewDashboard_TRiBotManager.TabIndex = 97;
            dataGridViewDashboard_TRiBotManager.CellContentClick += dataGridView_TRiBotRun_CellButtonClick;
            // 
            // dataGridViewDashboard_TRiBotManager_Account
            // 
            dataGridViewDashboard_TRiBotManager_Account.HeaderText = "Account";
            dataGridViewDashboard_TRiBotManager_Account.Name = "dataGridViewDashboard_TRiBotManager_Account";
            dataGridViewDashboard_TRiBotManager_Account.Width = 150;
            // 
            // dataGridViewDashboard_TRiBotManager_Password
            // 
            dataGridViewDashboard_TRiBotManager_Password.HeaderText = "Password";
            dataGridViewDashboard_TRiBotManager_Password.Name = "dataGridViewDashboard_TRiBotManager_Password";
            // 
            // dataGridViewDashboard_TRiBotManager_Pin
            // 
            dataGridViewDashboard_TRiBotManager_Pin.HeaderText = "Pin";
            dataGridViewDashboard_TRiBotManager_Pin.Name = "dataGridViewDashboard_TRiBotManager_Pin";
            dataGridViewDashboard_TRiBotManager_Pin.Width = 75;
            // 
            // dataGridViewDashboard_TRiBotManager_Proxy
            // 
            dataGridViewDashboard_TRiBotManager_Proxy.HeaderText = "Proxy";
            dataGridViewDashboard_TRiBotManager_Proxy.Name = "dataGridViewDashboard_TRiBotManager_Proxy";
            dataGridViewDashboard_TRiBotManager_Proxy.Width = 125;
            // 
            // dataGridViewDashboard_TRiBotManager_Script
            // 
            dataGridViewDashboard_TRiBotManager_Script.HeaderText = "Script";
            dataGridViewDashboard_TRiBotManager_Script.Name = "dataGridViewDashboard_TRiBotManager_Script";
            dataGridViewDashboard_TRiBotManager_Script.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewDashboard_TRiBotManager_Script.Width = 200;
            // 
            // dataGridViewDashboard_TRiBotManager_Args
            // 
            dataGridViewDashboard_TRiBotManager_Args.HeaderText = "Args";
            dataGridViewDashboard_TRiBotManager_Args.Name = "dataGridViewDashboard_TRiBotManager_Args";
            dataGridViewDashboard_TRiBotManager_Args.Width = 85;
            // 
            // dataGridViewDashboard_TRiBotManager_Breaks
            // 
            dataGridViewDashboard_TRiBotManager_Breaks.HeaderText = "Breaks";
            dataGridViewDashboard_TRiBotManager_Breaks.Name = "dataGridViewDashboard_TRiBotManager_Breaks";
            dataGridViewDashboard_TRiBotManager_Breaks.Width = 75;
            // 
            // dataGridViewDashboard_TRiBotManager_World
            // 
            dataGridViewDashboard_TRiBotManager_World.HeaderText = "World";
            dataGridViewDashboard_TRiBotManager_World.Items.AddRange(new object[] { "-F2P-", "301", "308", "316", "326", "335", "371", "380", "382", "383", "384", "394", "397", "398", "399", "417", "418", "430", "431", "433", "434", "435", "436", "437", "451", "452", "453", "454", "455", "456", "469", "470", "471", "475", "476", "483", "497", "498", "499", "500", "501", "537", "542", "543", "544", "545", "546", "547", "552", "553", "554", "555", "556", "557", "562", "563", "571", "575", "-P2P-", "302", "303", "304", "305", "306", "307", "309", "310", "311", "312", "313", "314", "315", "317", "318", "319", "320", "321", "322", "323", "324", "325", "327", "328", "329", "330", "331", "332", "333", "334", "336", "337", "338", "339", "340", "341", "343", "344", "346", "347", "348", "350", "351", "352", "354", "355", "357", "358", "359", "360", "362", "367", "368", "369", "370", "374", "375", "376", "377", "378", "386", "387", "388", "389", "390", "395", "421", "422", "424", "443", "444", "445", "446", "463", "464", "465", "466", "477", "478", "480", "481", "482", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493", "494", "495", "496", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525", "531", "532", "533", "534", "535", "580" });
            dataGridViewDashboard_TRiBotManager_World.Name = "dataGridViewDashboard_TRiBotManager_World";
            dataGridViewDashboard_TRiBotManager_World.Width = 75;
            // 
            // dataGridViewDashboard_TRiBotManager_RunStop
            // 
            dataGridViewDashboard_TRiBotManager_RunStop.HeaderText = "Run | Stop";
            dataGridViewDashboard_TRiBotManager_RunStop.Name = "dataGridViewDashboard_TRiBotManager_RunStop";
            dataGridViewDashboard_TRiBotManager_RunStop.Width = 75;
            // 
            // dataGridViewDashboard_TRiBotManager_Notes
            // 
            dataGridViewDashboard_TRiBotManager_Notes.HeaderText = "Notes";
            dataGridViewDashboard_TRiBotManager_Notes.Name = "dataGridViewDashboard_TRiBotManager_Notes";
            // 
            // dataGridViewDashboard_TRiBotManager_Status
            // 
            dataGridViewCellStyle14.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle14.SelectionForeColor = Color.ForestGreen;
            dataGridViewDashboard_TRiBotManager_Status.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewDashboard_TRiBotManager_Status.HeaderText = "Status";
            dataGridViewDashboard_TRiBotManager_Status.Name = "dataGridViewDashboard_TRiBotManager_Status";
            dataGridViewDashboard_TRiBotManager_Status.ReadOnly = true;
            dataGridViewDashboard_TRiBotManager_Status.Width = 75;
            // 
            // dataGridViewDashboard_TRiBotManager_SandboxieNumber
            // 
            dataGridViewDashboard_TRiBotManager_SandboxieNumber.HeaderText = "Sandboxie Number";
            dataGridViewDashboard_TRiBotManager_SandboxieNumber.Name = "dataGridViewDashboard_TRiBotManager_SandboxieNumber";
            dataGridViewDashboard_TRiBotManager_SandboxieNumber.Visible = false;
            // 
            // kryptonListBoxDashboard_DreamBotManager_AdditionalSettings
            // 
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.Cursor = Cursors.Hand;
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.Items.AddRange(new object[] { "Covert", "Fresh Start", "Handle 2FA", "Jagex Account", "Menu Manipulation", "No Click Walk", "No Render", "Resizable Mode", "Sandboxie" });
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.Location = new Point(775, 585);
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.Margin = new Padding(0);
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.Name = "kryptonListBoxDashboard_DreamBotManager_AdditionalSettings";
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.ScrollAlwaysVisible = true;
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.SelectionMode = SelectionMode.MultiSimple;
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.Size = new Size(120, 75);
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.StateCommon.Back.Color2 = Color.Silver;
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.StateCommon.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.TabIndex = 84;
            // 
            // kryptonListBoxDashboard_OSBotManager_AdditionalSettings
            // 
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.Cursor = Cursors.Hand;
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.Items.AddRange(new object[] { "Low CPU", "Low Resource", "Mirror", "New Mouse", "No Interface", "No Render", "Sandboxie" });
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.Location = new Point(775, 585);
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.Margin = new Padding(0);
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.Name = "kryptonListBoxDashboard_OSBotManager_AdditionalSettings";
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.ScrollAlwaysVisible = true;
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.SelectionMode = SelectionMode.MultiSimple;
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.Size = new Size(120, 75);
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.StateCommon.Back.Color2 = Color.Silver;
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.StateCommon.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_OSBotManager_AdditionalSettings.TabIndex = 67;
            // 
            // kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings
            // 
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.Cursor = Cursors.Hand;
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.Items.AddRange(new object[] { "Low CPU", "Low Resource", "Mirror", "New Mouse", "No Interface", "No Render", "Sandboxie" });
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.Location = new Point(775, 585);
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.Margin = new Padding(0);
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.Name = "kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings";
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.ScrollAlwaysVisible = true;
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.SelectionMode = SelectionMode.MultiSimple;
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.Size = new Size(120, 75);
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.StateCommon.Back.Color2 = Color.Silver;
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.StateCommon.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.TabIndex = 54;
            // 
            // kryptonListBoxDashboard_TRiBotManager_AdditionalSettings
            // 
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.Cursor = Cursors.Hand;
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.Items.AddRange(new object[] { "Looking Glass", "Sandboxie" });
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.Location = new Point(775, 585);
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.Margin = new Padding(0);
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.Name = "kryptonListBoxDashboard_TRiBotManager_AdditionalSettings";
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.ScrollAlwaysVisible = true;
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.SelectionMode = SelectionMode.MultiSimple;
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.Size = new Size(120, 75);
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.StateCommon.Back.Color2 = Color.Silver;
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.StateCommon.Back.ColorStyle = PaletteColorStyle.LinearShadow;
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.StateCommon.Item.Content.ShortText.Color2 = Color.FromArgb(60, 60, 60);
            kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.TabIndex = 100;
            // 
            // kryptonNavigatorDashboard
            // 
            kryptonNavigatorDashboard.AllowPageReorder = false;
            kryptonNavigatorDashboard.Button.ButtonDisplayLogic = ButtonDisplayLogic.None;
            kryptonNavigatorDashboard.Button.CloseButtonAction = CloseButtonAction.None;
            kryptonNavigatorDashboard.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            kryptonNavigatorDashboard.Button.ContextButtonAction = ContextButtonAction.SelectPage;
            kryptonNavigatorDashboard.Button.ContextButtonDisplay = ButtonDisplay.Logic;
            kryptonNavigatorDashboard.Button.ContextMenuMapImage = MapKryptonPageImage.Small;
            kryptonNavigatorDashboard.Button.ContextMenuMapText = MapKryptonPageText.TextTitle;
            kryptonNavigatorDashboard.Button.NextButtonAction = DirectionButtonAction.ModeAppropriateAction;
            kryptonNavigatorDashboard.Button.NextButtonDisplay = ButtonDisplay.Logic;
            kryptonNavigatorDashboard.Button.PreviousButtonAction = DirectionButtonAction.ModeAppropriateAction;
            kryptonNavigatorDashboard.Button.PreviousButtonDisplay = ButtonDisplay.Logic;
            kryptonNavigatorDashboard.ControlKryptonFormFeatures = false;
            kryptonNavigatorDashboard.Header.HeaderPositionBar = VisualOrientation.Top;
            kryptonNavigatorDashboard.Header.HeaderPositionPrimary = VisualOrientation.Top;
            kryptonNavigatorDashboard.Header.HeaderPositionSecondary = VisualOrientation.Bottom;
            kryptonNavigatorDashboard.Header.HeaderStyleBar = HeaderStyle.Primary;
            kryptonNavigatorDashboard.Header.HeaderStylePrimary = HeaderStyle.Primary;
            kryptonNavigatorDashboard.Header.HeaderStyleSecondary = HeaderStyle.Primary;
            kryptonNavigatorDashboard.Header.HeaderValuesPrimary.Description = "Dashboard";
            kryptonNavigatorDashboard.Header.HeaderValuesPrimary.Heading = "Dashboard";
            kryptonNavigatorDashboard.Header.HeaderValuesPrimary.MapDescription = MapKryptonPageText.None;
            kryptonNavigatorDashboard.Header.HeaderValuesPrimary.MapHeading = MapKryptonPageText.Title;
            kryptonNavigatorDashboard.Header.HeaderValuesPrimary.MapImage = MapKryptonPageImage.None;
            kryptonNavigatorDashboard.Header.HeaderValuesSecondary.MapDescription = MapKryptonPageText.Text;
            kryptonNavigatorDashboard.Header.HeaderValuesSecondary.MapHeading = MapKryptonPageText.Text;
            kryptonNavigatorDashboard.Header.HeaderValuesSecondary.MapImage = MapKryptonPageImage.None;
            kryptonNavigatorDashboard.Header.HeaderVisibleSecondary = false;
            kryptonNavigatorDashboard.Location = new Point(200, 0);
            kryptonNavigatorDashboard.Margin = new Padding(0);
            kryptonNavigatorDashboard.Name = "kryptonNavigatorDashboard";
            kryptonNavigatorDashboard.NavigatorMode = NavigatorMode.HeaderGroupTab;
            kryptonNavigatorDashboard.Owner = null;
            kryptonNavigatorDashboard.PageBackStyle = PaletteBackStyle.ButtonStandalone;
            kryptonNavigatorDashboard.Pages.AddRange(new KryptonPage[] { kryptonPageDashboard_ScriptFactoryManager, kryptonPageDashboard_OSBotManager, kryptonPageDashboard_DreamBotManager, kryptonPageDashboard_TRiBotManager });
            kryptonNavigatorDashboard.PaletteMode = PaletteMode.Microsoft365DarkGray;
            kryptonNavigatorDashboard.PopupPages.AllowPopupPages = PopupPageAllow.OnlyOutlookMiniMode;
            kryptonNavigatorDashboard.PopupPages.Border = 0;
            kryptonNavigatorDashboard.PopupPages.Element = PopupPageElement.Item;
            kryptonNavigatorDashboard.PopupPages.Gap = 0;
            kryptonNavigatorDashboard.PopupPages.Position = PopupPagePosition.ModeAppropriate;
            kryptonNavigatorDashboard.SelectedIndex = 0;
            kryptonNavigatorDashboard.Size = new Size(1148, 730);
            kryptonNavigatorDashboard.Stack.BorderEdgeStyle = PaletteBorderStyle.ButtonStandalone;
            kryptonNavigatorDashboard.Stack.CheckButtonStyle = ButtonStyle.NavigatorStack;
            kryptonNavigatorDashboard.Stack.ItemOrientation = ButtonOrientation.Auto;
            kryptonNavigatorDashboard.Stack.StackAlignment = RelativePositionAlign.Center;
            kryptonNavigatorDashboard.Stack.StackMapExtraText = MapKryptonPageText.None;
            kryptonNavigatorDashboard.Stack.StackMapImage = MapKryptonPageImage.Small;
            kryptonNavigatorDashboard.Stack.StackMapText = MapKryptonPageText.TextTitle;
            kryptonNavigatorDashboard.Stack.StackOrientation = Orientation.Vertical;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.Back.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.Back.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.Border.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.Border.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Back.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Back.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Border.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Border.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Content.LongText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderBar.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Back.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Back.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Border.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Border.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderOverflow.Content.LongText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Back.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Back.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Border.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Border.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Content.LongText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonNavigatorDashboard.StateCommon.HeaderGroup.HeaderPrimary.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonNavigatorDashboard.StateCommon.Page.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.Page.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.Panel.Color1 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.Panel.Color2 = Color.Transparent;
            kryptonNavigatorDashboard.StateCommon.RibbonGeneral.TextFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonNavigatorDashboard.StateCommon.RibbonGeneral.TextHint = PaletteTextHint.Inherit;
            kryptonNavigatorDashboard.StateCommon.RibbonTab.TabDraw.BackColor1 = Color.Empty;
            kryptonNavigatorDashboard.StateCommon.RibbonTab.TabDraw.BackColor2 = Color.Empty;
            kryptonNavigatorDashboard.StateCommon.RibbonTab.TabDraw.BackColor3 = Color.Empty;
            kryptonNavigatorDashboard.StateCommon.RibbonTab.TabDraw.BackColor4 = Color.Empty;
            kryptonNavigatorDashboard.StateCommon.RibbonTab.TabDraw.BackColor5 = Color.Empty;
            kryptonNavigatorDashboard.StateCommon.RibbonTab.TabDraw.TextColor = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.Tab.Back.Color1 = Color.FromArgb(60, 60, 60);
            kryptonNavigatorDashboard.StateCommon.Tab.Back.Color2 = Color.FromArgb(60, 60, 60);
            kryptonNavigatorDashboard.StateCommon.Tab.Border.Color1 = Color.Gray;
            kryptonNavigatorDashboard.StateCommon.Tab.Border.Color2 = Color.FromArgb(60, 60, 60);
            kryptonNavigatorDashboard.StateCommon.Tab.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonNavigatorDashboard.StateCommon.Tab.Border.Width = 1;
            kryptonNavigatorDashboard.StateCommon.Tab.Content.LongText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.Tab.Content.LongText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.Tab.Content.LongText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonNavigatorDashboard.StateCommon.Tab.Content.ShortText.Color1 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.StateCommon.Tab.Content.ShortText.Color2 = Color.FromArgb(224, 224, 224);
            kryptonNavigatorDashboard.TabIndex = 37;
            kryptonNavigatorDashboard.Text = "Dashboard";
            // 
            // kryptonPageDashboard_ScriptFactoryManager
            // 
            kryptonPageDashboard_ScriptFactoryManager.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(labelDashboard_ScriptFactoryManager_BreakTimeMins);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(labelDashboard_ScriptFactoryManager_RunTimeMins);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonTextBoxDashboard_ScriptFactoryManager_RunTime);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(labelDashboard_ScriptFactoryManager_BreakTime);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonCheckBoxDashboard_ScriptFactoryManager_Loop);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(labelDashboard_ScriptFactoryManager_RunTime);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(labelDashboard_ScriptFactoryManager_AdditionalSettings);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonButtonDashboard_ScriptFactoryManager_Save);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonButtonDashboard_ScriptFactoryManager_DownloadClient);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonButtonDashboard_ScriptFactoryManager_AddAccount);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot);
            kryptonPageDashboard_ScriptFactoryManager.Controls.Add(dataGridViewDashboard_ScriptFactoryManager);
            kryptonPageDashboard_ScriptFactoryManager.Flags = 65534;
            kryptonPageDashboard_ScriptFactoryManager.LastVisibleSet = true;
            kryptonPageDashboard_ScriptFactoryManager.MinimumSize = new Size(150, 50);
            kryptonPageDashboard_ScriptFactoryManager.Name = "kryptonPageDashboard_ScriptFactoryManager";
            kryptonPageDashboard_ScriptFactoryManager.Size = new Size(1146, 672);
            kryptonPageDashboard_ScriptFactoryManager.Text = "Script Factory Manager";
            kryptonPageDashboard_ScriptFactoryManager.TextTitle = "Dashboard";
            kryptonPageDashboard_ScriptFactoryManager.ToolTipTitle = "Page ToolTip";
            kryptonPageDashboard_ScriptFactoryManager.UniqueName = "ffdc80e3a970484aa258c1c1f8d155d9";
            // 
            // labelDashboard_ScriptFactoryManager_BreakTimeMins
            // 
            labelDashboard_ScriptFactoryManager_BreakTimeMins.BackColor = Color.Transparent;
            labelDashboard_ScriptFactoryManager_BreakTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_ScriptFactoryManager_BreakTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_ScriptFactoryManager_BreakTimeMins.Location = new Point(1060, 625);
            labelDashboard_ScriptFactoryManager_BreakTimeMins.Margin = new Padding(0);
            labelDashboard_ScriptFactoryManager_BreakTimeMins.Name = "labelDashboard_ScriptFactoryManager_BreakTimeMins";
            labelDashboard_ScriptFactoryManager_BreakTimeMins.Size = new Size(50, 25);
            labelDashboard_ScriptFactoryManager_BreakTimeMins.TabIndex = 64;
            labelDashboard_ScriptFactoryManager_BreakTimeMins.Text = "Mins";
            labelDashboard_ScriptFactoryManager_BreakTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime
            // 
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.Location = new Point(1000, 625);
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.Margin = new Padding(0);
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.Name = "kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime";
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.Size = new Size(50, 24);
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.TabIndex = 63;
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.Text = "0";
            kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDashboard_ScriptFactoryManager_RunTimeMins
            // 
            labelDashboard_ScriptFactoryManager_RunTimeMins.BackColor = Color.Transparent;
            labelDashboard_ScriptFactoryManager_RunTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_ScriptFactoryManager_RunTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_ScriptFactoryManager_RunTimeMins.Location = new Point(1060, 575);
            labelDashboard_ScriptFactoryManager_RunTimeMins.Margin = new Padding(0);
            labelDashboard_ScriptFactoryManager_RunTimeMins.Name = "labelDashboard_ScriptFactoryManager_RunTimeMins";
            labelDashboard_ScriptFactoryManager_RunTimeMins.Size = new Size(50, 25);
            labelDashboard_ScriptFactoryManager_RunTimeMins.TabIndex = 62;
            labelDashboard_ScriptFactoryManager_RunTimeMins.Text = "Mins";
            labelDashboard_ScriptFactoryManager_RunTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxDashboard_ScriptFactoryManager_RunTime
            // 
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.Location = new Point(1000, 575);
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.Margin = new Padding(0);
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.Name = "kryptonTextBoxDashboard_ScriptFactoryManager_RunTime";
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.Size = new Size(50, 24);
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.TabIndex = 54;
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.Text = "0";
            kryptonTextBoxDashboard_ScriptFactoryManager_RunTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDashboard_ScriptFactoryManager_BreakTime
            // 
            labelDashboard_ScriptFactoryManager_BreakTime.BackColor = Color.Transparent;
            labelDashboard_ScriptFactoryManager_BreakTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_ScriptFactoryManager_BreakTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_ScriptFactoryManager_BreakTime.Location = new Point(925, 625);
            labelDashboard_ScriptFactoryManager_BreakTime.Name = "labelDashboard_ScriptFactoryManager_BreakTime";
            labelDashboard_ScriptFactoryManager_BreakTime.Size = new Size(75, 25);
            labelDashboard_ScriptFactoryManager_BreakTime.TabIndex = 61;
            labelDashboard_ScriptFactoryManager_BreakTime.Text = "Break Time";
            labelDashboard_ScriptFactoryManager_BreakTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDashboard_ScriptFactoryManager_RunTime
            // 
            labelDashboard_ScriptFactoryManager_RunTime.BackColor = Color.Transparent;
            labelDashboard_ScriptFactoryManager_RunTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_ScriptFactoryManager_RunTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_ScriptFactoryManager_RunTime.Location = new Point(925, 575);
            labelDashboard_ScriptFactoryManager_RunTime.Margin = new Padding(0);
            labelDashboard_ScriptFactoryManager_RunTime.Name = "labelDashboard_ScriptFactoryManager_RunTime";
            labelDashboard_ScriptFactoryManager_RunTime.Size = new Size(75, 25);
            labelDashboard_ScriptFactoryManager_RunTime.TabIndex = 60;
            labelDashboard_ScriptFactoryManager_RunTime.Text = "Run Time";
            labelDashboard_ScriptFactoryManager_RunTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDashboard_ScriptFactoryManager_AdditionalSettings
            // 
            labelDashboard_ScriptFactoryManager_AdditionalSettings.BackColor = Color.Transparent;
            labelDashboard_ScriptFactoryManager_AdditionalSettings.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_ScriptFactoryManager_AdditionalSettings.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_ScriptFactoryManager_AdditionalSettings.Location = new Point(875, 550);
            labelDashboard_ScriptFactoryManager_AdditionalSettings.Name = "labelDashboard_ScriptFactoryManager_AdditionalSettings";
            labelDashboard_ScriptFactoryManager_AdditionalSettings.Size = new Size(250, 25);
            labelDashboard_ScriptFactoryManager_AdditionalSettings.TabIndex = 54;
            labelDashboard_ScriptFactoryManager_AdditionalSettings.Text = "Additional Settings";
            labelDashboard_ScriptFactoryManager_AdditionalSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonPageDashboard_OSBotManager
            // 
            kryptonPageDashboard_OSBotManager.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPageDashboard_OSBotManager.Controls.Add(labelDashboard_OSBotManager_BreakTimeMins);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonTextBoxDashboard_OSBotManager_BreakTime);
            kryptonPageDashboard_OSBotManager.Controls.Add(labelDashboard_OSBotManager_RunTimeMins);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonTextBoxDashboard_OSBotManager_RunTime);
            kryptonPageDashboard_OSBotManager.Controls.Add(labelDashboard_OSBotManager_BreakTime);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonCheckBoxDashboard_OSBotManager_Loop);
            kryptonPageDashboard_OSBotManager.Controls.Add(labelDashboard_OSBotManager_RunTime);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonListBoxDashboard_OSBotManager_AdditionalSettings);
            kryptonPageDashboard_OSBotManager.Controls.Add(labelDashboard_OSBotManager_AdditionalSettings);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonButtonDashboard_OSBotManager_Save);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonButtonDashboard_OSBotManager_DownloadClient);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonButtonDashboard_OSBotManager_ImportAccounts);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonButtonDashboard_OSBotManager_DeleteAccount);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonButtonDashboard_OSBotManager_AddAccount);
            kryptonPageDashboard_OSBotManager.Controls.Add(kryptonButtonDashboard_OSBotManager_LaunchOSBot);
            kryptonPageDashboard_OSBotManager.Controls.Add(dataGridViewDashboard_OSBotManager);
            kryptonPageDashboard_OSBotManager.Flags = 65534;
            kryptonPageDashboard_OSBotManager.LastVisibleSet = true;
            kryptonPageDashboard_OSBotManager.MinimumSize = new Size(150, 50);
            kryptonPageDashboard_OSBotManager.Name = "kryptonPageDashboard_OSBotManager";
            kryptonPageDashboard_OSBotManager.Size = new Size(1146, 672);
            kryptonPageDashboard_OSBotManager.Text = "OSBot Manager";
            kryptonPageDashboard_OSBotManager.TextTitle = "Dashboard";
            kryptonPageDashboard_OSBotManager.ToolTipTitle = "Page ToolTip";
            kryptonPageDashboard_OSBotManager.UniqueName = "82666c4bfb3a40a1ab539cbbb6e7fa0e";
            // 
            // labelDashboard_OSBotManager_BreakTimeMins
            // 
            labelDashboard_OSBotManager_BreakTimeMins.BackColor = Color.Transparent;
            labelDashboard_OSBotManager_BreakTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_OSBotManager_BreakTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_OSBotManager_BreakTimeMins.Location = new Point(1060, 625);
            labelDashboard_OSBotManager_BreakTimeMins.Margin = new Padding(0);
            labelDashboard_OSBotManager_BreakTimeMins.Name = "labelDashboard_OSBotManager_BreakTimeMins";
            labelDashboard_OSBotManager_BreakTimeMins.Size = new Size(50, 25);
            labelDashboard_OSBotManager_BreakTimeMins.TabIndex = 80;
            labelDashboard_OSBotManager_BreakTimeMins.Text = "Mins";
            labelDashboard_OSBotManager_BreakTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxDashboard_OSBotManager_BreakTime
            // 
            kryptonTextBoxDashboard_OSBotManager_BreakTime.Location = new Point(1000, 625);
            kryptonTextBoxDashboard_OSBotManager_BreakTime.Margin = new Padding(0);
            kryptonTextBoxDashboard_OSBotManager_BreakTime.Name = "kryptonTextBoxDashboard_OSBotManager_BreakTime";
            kryptonTextBoxDashboard_OSBotManager_BreakTime.Size = new Size(50, 24);
            kryptonTextBoxDashboard_OSBotManager_BreakTime.TabIndex = 79;
            kryptonTextBoxDashboard_OSBotManager_BreakTime.Text = "0";
            kryptonTextBoxDashboard_OSBotManager_BreakTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDashboard_OSBotManager_RunTimeMins
            // 
            labelDashboard_OSBotManager_RunTimeMins.BackColor = Color.Transparent;
            labelDashboard_OSBotManager_RunTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_OSBotManager_RunTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_OSBotManager_RunTimeMins.Location = new Point(1060, 575);
            labelDashboard_OSBotManager_RunTimeMins.Margin = new Padding(0);
            labelDashboard_OSBotManager_RunTimeMins.Name = "labelDashboard_OSBotManager_RunTimeMins";
            labelDashboard_OSBotManager_RunTimeMins.Size = new Size(50, 25);
            labelDashboard_OSBotManager_RunTimeMins.TabIndex = 78;
            labelDashboard_OSBotManager_RunTimeMins.Text = "Mins";
            labelDashboard_OSBotManager_RunTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxDashboard_OSBotManager_RunTime
            // 
            kryptonTextBoxDashboard_OSBotManager_RunTime.Location = new Point(1000, 575);
            kryptonTextBoxDashboard_OSBotManager_RunTime.Margin = new Padding(0);
            kryptonTextBoxDashboard_OSBotManager_RunTime.Name = "kryptonTextBoxDashboard_OSBotManager_RunTime";
            kryptonTextBoxDashboard_OSBotManager_RunTime.Size = new Size(50, 24);
            kryptonTextBoxDashboard_OSBotManager_RunTime.TabIndex = 65;
            kryptonTextBoxDashboard_OSBotManager_RunTime.Text = "0";
            kryptonTextBoxDashboard_OSBotManager_RunTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDashboard_OSBotManager_BreakTime
            // 
            labelDashboard_OSBotManager_BreakTime.BackColor = Color.Transparent;
            labelDashboard_OSBotManager_BreakTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_OSBotManager_BreakTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_OSBotManager_BreakTime.Location = new Point(925, 625);
            labelDashboard_OSBotManager_BreakTime.Name = "labelDashboard_OSBotManager_BreakTime";
            labelDashboard_OSBotManager_BreakTime.Size = new Size(75, 25);
            labelDashboard_OSBotManager_BreakTime.TabIndex = 77;
            labelDashboard_OSBotManager_BreakTime.Text = "Break Time";
            labelDashboard_OSBotManager_BreakTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDashboard_OSBotManager_RunTime
            // 
            labelDashboard_OSBotManager_RunTime.BackColor = Color.Transparent;
            labelDashboard_OSBotManager_RunTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_OSBotManager_RunTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_OSBotManager_RunTime.Location = new Point(925, 575);
            labelDashboard_OSBotManager_RunTime.Margin = new Padding(0);
            labelDashboard_OSBotManager_RunTime.Name = "labelDashboard_OSBotManager_RunTime";
            labelDashboard_OSBotManager_RunTime.Size = new Size(75, 25);
            labelDashboard_OSBotManager_RunTime.TabIndex = 76;
            labelDashboard_OSBotManager_RunTime.Text = "Run Time";
            labelDashboard_OSBotManager_RunTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDashboard_OSBotManager_AdditionalSettings
            // 
            labelDashboard_OSBotManager_AdditionalSettings.BackColor = Color.Transparent;
            labelDashboard_OSBotManager_AdditionalSettings.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_OSBotManager_AdditionalSettings.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_OSBotManager_AdditionalSettings.Location = new Point(875, 550);
            labelDashboard_OSBotManager_AdditionalSettings.Name = "labelDashboard_OSBotManager_AdditionalSettings";
            labelDashboard_OSBotManager_AdditionalSettings.Size = new Size(250, 25);
            labelDashboard_OSBotManager_AdditionalSettings.TabIndex = 68;
            labelDashboard_OSBotManager_AdditionalSettings.Text = "Additional Settings";
            labelDashboard_OSBotManager_AdditionalSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonPageDashboard_DreamBotManager
            // 
            kryptonPageDashboard_DreamBotManager.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPageDashboard_DreamBotManager.Controls.Add(labelButtonDashboard_DreamBotManager_BreakTimeMins);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime);
            kryptonPageDashboard_DreamBotManager.Controls.Add(labelButtonDashboard_DreamBotManager_RunTimeMins);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonTextBoxButtonDashboard_DreamBotManager_RunTime);
            kryptonPageDashboard_DreamBotManager.Controls.Add(labelButtonDashboard_DreamBotManager_BreakTime);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonCheckBoxButtonDashboard_DreamBotManager_Loop);
            kryptonPageDashboard_DreamBotManager.Controls.Add(labelButtonDashboard_DreamBotManager_RunTime);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonListBoxDashboard_DreamBotManager_AdditionalSettings);
            kryptonPageDashboard_DreamBotManager.Controls.Add(labelButtonDashboard_DreamBotManager_AdditionalSettings);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonButtonButtonDashboard_DreamBotManager_Save);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonButtonButtonDashboard_DreamBotManager_DownloadClient);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonButtonButtonDashboard_DreamBotManager_AddAccount);
            kryptonPageDashboard_DreamBotManager.Controls.Add(kryptonButtonDashboard_DreamBotManager_LaunchDreamBot);
            kryptonPageDashboard_DreamBotManager.Controls.Add(dataGridViewDashboard_DreamBotManager);
            kryptonPageDashboard_DreamBotManager.Flags = 65534;
            kryptonPageDashboard_DreamBotManager.LastVisibleSet = true;
            kryptonPageDashboard_DreamBotManager.MinimumSize = new Size(150, 50);
            kryptonPageDashboard_DreamBotManager.Name = "kryptonPageDashboard_DreamBotManager";
            kryptonPageDashboard_DreamBotManager.Size = new Size(1146, 672);
            kryptonPageDashboard_DreamBotManager.Text = "DreamBot Manager";
            kryptonPageDashboard_DreamBotManager.TextTitle = "Dashboard";
            kryptonPageDashboard_DreamBotManager.ToolTipTitle = "Page ToolTip";
            kryptonPageDashboard_DreamBotManager.UniqueName = "acc4e6031a7a4f1999520c362fd3319a";
            // 
            // labelButtonDashboard_DreamBotManager_BreakTimeMins
            // 
            labelButtonDashboard_DreamBotManager_BreakTimeMins.BackColor = Color.Transparent;
            labelButtonDashboard_DreamBotManager_BreakTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelButtonDashboard_DreamBotManager_BreakTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelButtonDashboard_DreamBotManager_BreakTimeMins.Location = new Point(1060, 625);
            labelButtonDashboard_DreamBotManager_BreakTimeMins.Margin = new Padding(0);
            labelButtonDashboard_DreamBotManager_BreakTimeMins.Name = "labelButtonDashboard_DreamBotManager_BreakTimeMins";
            labelButtonDashboard_DreamBotManager_BreakTimeMins.Size = new Size(50, 25);
            labelButtonDashboard_DreamBotManager_BreakTimeMins.TabIndex = 96;
            labelButtonDashboard_DreamBotManager_BreakTimeMins.Text = "Mins";
            labelButtonDashboard_DreamBotManager_BreakTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime
            // 
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.Location = new Point(1000, 625);
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.Margin = new Padding(0);
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.Name = "kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime";
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.Size = new Size(50, 24);
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.TabIndex = 95;
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.Text = "0";
            kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelButtonDashboard_DreamBotManager_RunTimeMins
            // 
            labelButtonDashboard_DreamBotManager_RunTimeMins.BackColor = Color.Transparent;
            labelButtonDashboard_DreamBotManager_RunTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelButtonDashboard_DreamBotManager_RunTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelButtonDashboard_DreamBotManager_RunTimeMins.Location = new Point(1060, 575);
            labelButtonDashboard_DreamBotManager_RunTimeMins.Margin = new Padding(0);
            labelButtonDashboard_DreamBotManager_RunTimeMins.Name = "labelButtonDashboard_DreamBotManager_RunTimeMins";
            labelButtonDashboard_DreamBotManager_RunTimeMins.Size = new Size(50, 25);
            labelButtonDashboard_DreamBotManager_RunTimeMins.TabIndex = 94;
            labelButtonDashboard_DreamBotManager_RunTimeMins.Text = "Mins";
            labelButtonDashboard_DreamBotManager_RunTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxButtonDashboard_DreamBotManager_RunTime
            // 
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.Location = new Point(1000, 575);
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.Margin = new Padding(0);
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.Name = "kryptonTextBoxButtonDashboard_DreamBotManager_RunTime";
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.Size = new Size(50, 24);
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.TabIndex = 82;
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.Text = "0";
            kryptonTextBoxButtonDashboard_DreamBotManager_RunTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelButtonDashboard_DreamBotManager_BreakTime
            // 
            labelButtonDashboard_DreamBotManager_BreakTime.BackColor = Color.Transparent;
            labelButtonDashboard_DreamBotManager_BreakTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelButtonDashboard_DreamBotManager_BreakTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelButtonDashboard_DreamBotManager_BreakTime.Location = new Point(925, 625);
            labelButtonDashboard_DreamBotManager_BreakTime.Name = "labelButtonDashboard_DreamBotManager_BreakTime";
            labelButtonDashboard_DreamBotManager_BreakTime.Size = new Size(75, 25);
            labelButtonDashboard_DreamBotManager_BreakTime.TabIndex = 93;
            labelButtonDashboard_DreamBotManager_BreakTime.Text = "Break Time";
            labelButtonDashboard_DreamBotManager_BreakTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelButtonDashboard_DreamBotManager_RunTime
            // 
            labelButtonDashboard_DreamBotManager_RunTime.BackColor = Color.Transparent;
            labelButtonDashboard_DreamBotManager_RunTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelButtonDashboard_DreamBotManager_RunTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelButtonDashboard_DreamBotManager_RunTime.Location = new Point(925, 575);
            labelButtonDashboard_DreamBotManager_RunTime.Margin = new Padding(0);
            labelButtonDashboard_DreamBotManager_RunTime.Name = "labelButtonDashboard_DreamBotManager_RunTime";
            labelButtonDashboard_DreamBotManager_RunTime.Size = new Size(75, 25);
            labelButtonDashboard_DreamBotManager_RunTime.TabIndex = 92;
            labelButtonDashboard_DreamBotManager_RunTime.Text = "Run Time";
            labelButtonDashboard_DreamBotManager_RunTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelButtonDashboard_DreamBotManager_AdditionalSettings
            // 
            labelButtonDashboard_DreamBotManager_AdditionalSettings.BackColor = Color.Transparent;
            labelButtonDashboard_DreamBotManager_AdditionalSettings.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelButtonDashboard_DreamBotManager_AdditionalSettings.ForeColor = Color.FromArgb(224, 224, 224);
            labelButtonDashboard_DreamBotManager_AdditionalSettings.Location = new Point(875, 550);
            labelButtonDashboard_DreamBotManager_AdditionalSettings.Name = "labelButtonDashboard_DreamBotManager_AdditionalSettings";
            labelButtonDashboard_DreamBotManager_AdditionalSettings.Size = new Size(250, 25);
            labelButtonDashboard_DreamBotManager_AdditionalSettings.TabIndex = 85;
            labelButtonDashboard_DreamBotManager_AdditionalSettings.Text = "Additional Settings";
            labelButtonDashboard_DreamBotManager_AdditionalSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonPageDashboard_TRiBotManager
            // 
            kryptonPageDashboard_TRiBotManager.AutoHiddenSlideSize = new Size(200, 200);
            kryptonPageDashboard_TRiBotManager.Controls.Add(labelDashboard_TRiBotManager_BreakTimeMins);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonTextBoxDashboard_TRiBotManager_BreakTime);
            kryptonPageDashboard_TRiBotManager.Controls.Add(labelDashboard_TRiBotManager_RunTimeMins);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonTextBoxDashboard_TRiBotManager_RunTime);
            kryptonPageDashboard_TRiBotManager.Controls.Add(labelDashboard_TRiBotManager_BreakTime);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonCheckBoxDashboard_TRiBotManager_Loop);
            kryptonPageDashboard_TRiBotManager.Controls.Add(labelDashboard_TRiBotManager_RunTime);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonListBoxDashboard_TRiBotManager_AdditionalSettings);
            kryptonPageDashboard_TRiBotManager.Controls.Add(labelDashboard_TRiBotManager_AdditionalSettings);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonButtonDashboard_TRiBotManager_Save);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonButtonDashboard_TRiBotManager_DownloadClient);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonButtonDashboard_TRiBotManager_ImportAccounts);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonButtonDashboard_TRiBotManager_DeleteAccount);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonButtonDashboard_TRiBotManager_AddAccount);
            kryptonPageDashboard_TRiBotManager.Controls.Add(kryptonButtonDashboard_TRiBotManager_LaunchClient);
            kryptonPageDashboard_TRiBotManager.Controls.Add(dataGridViewDashboard_TRiBotManager);
            kryptonPageDashboard_TRiBotManager.Flags = 65534;
            kryptonPageDashboard_TRiBotManager.LastVisibleSet = true;
            kryptonPageDashboard_TRiBotManager.MinimumSize = new Size(150, 50);
            kryptonPageDashboard_TRiBotManager.Name = "kryptonPageDashboard_TRiBotManager";
            kryptonPageDashboard_TRiBotManager.Size = new Size(1146, 672);
            kryptonPageDashboard_TRiBotManager.Text = "TRiBot Manager";
            kryptonPageDashboard_TRiBotManager.TextTitle = "Dashboard";
            kryptonPageDashboard_TRiBotManager.ToolTipTitle = "Page ToolTip";
            kryptonPageDashboard_TRiBotManager.UniqueName = "d884d200df9a4e8f9afc566a5ad522ff";
            // 
            // labelDashboard_TRiBotManager_BreakTimeMins
            // 
            labelDashboard_TRiBotManager_BreakTimeMins.BackColor = Color.Transparent;
            labelDashboard_TRiBotManager_BreakTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_TRiBotManager_BreakTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_TRiBotManager_BreakTimeMins.Location = new Point(1060, 625);
            labelDashboard_TRiBotManager_BreakTimeMins.Margin = new Padding(0);
            labelDashboard_TRiBotManager_BreakTimeMins.Name = "labelDashboard_TRiBotManager_BreakTimeMins";
            labelDashboard_TRiBotManager_BreakTimeMins.Size = new Size(50, 25);
            labelDashboard_TRiBotManager_BreakTimeMins.TabIndex = 112;
            labelDashboard_TRiBotManager_BreakTimeMins.Text = "Mins";
            labelDashboard_TRiBotManager_BreakTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxDashboard_TRiBotManager_BreakTime
            // 
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.Location = new Point(1000, 625);
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.Margin = new Padding(0);
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.Name = "kryptonTextBoxDashboard_TRiBotManager_BreakTime";
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.Size = new Size(50, 24);
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.TabIndex = 111;
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.Text = "0";
            kryptonTextBoxDashboard_TRiBotManager_BreakTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDashboard_TRiBotManager_RunTimeMins
            // 
            labelDashboard_TRiBotManager_RunTimeMins.BackColor = Color.Transparent;
            labelDashboard_TRiBotManager_RunTimeMins.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_TRiBotManager_RunTimeMins.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_TRiBotManager_RunTimeMins.Location = new Point(1060, 575);
            labelDashboard_TRiBotManager_RunTimeMins.Margin = new Padding(0);
            labelDashboard_TRiBotManager_RunTimeMins.Name = "labelDashboard_TRiBotManager_RunTimeMins";
            labelDashboard_TRiBotManager_RunTimeMins.Size = new Size(50, 25);
            labelDashboard_TRiBotManager_RunTimeMins.TabIndex = 110;
            labelDashboard_TRiBotManager_RunTimeMins.Text = "Mins";
            labelDashboard_TRiBotManager_RunTimeMins.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kryptonTextBoxDashboard_TRiBotManager_RunTime
            // 
            kryptonTextBoxDashboard_TRiBotManager_RunTime.Location = new Point(1000, 575);
            kryptonTextBoxDashboard_TRiBotManager_RunTime.Margin = new Padding(0);
            kryptonTextBoxDashboard_TRiBotManager_RunTime.Name = "kryptonTextBoxDashboard_TRiBotManager_RunTime";
            kryptonTextBoxDashboard_TRiBotManager_RunTime.Size = new Size(50, 24);
            kryptonTextBoxDashboard_TRiBotManager_RunTime.TabIndex = 98;
            kryptonTextBoxDashboard_TRiBotManager_RunTime.Text = "0";
            kryptonTextBoxDashboard_TRiBotManager_RunTime.TextAlign = HorizontalAlignment.Center;
            // 
            // labelDashboard_TRiBotManager_BreakTime
            // 
            labelDashboard_TRiBotManager_BreakTime.BackColor = Color.Transparent;
            labelDashboard_TRiBotManager_BreakTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_TRiBotManager_BreakTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_TRiBotManager_BreakTime.Location = new Point(925, 625);
            labelDashboard_TRiBotManager_BreakTime.Name = "labelDashboard_TRiBotManager_BreakTime";
            labelDashboard_TRiBotManager_BreakTime.Size = new Size(75, 25);
            labelDashboard_TRiBotManager_BreakTime.TabIndex = 109;
            labelDashboard_TRiBotManager_BreakTime.Text = "Break Time";
            labelDashboard_TRiBotManager_BreakTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDashboard_TRiBotManager_RunTime
            // 
            labelDashboard_TRiBotManager_RunTime.BackColor = Color.Transparent;
            labelDashboard_TRiBotManager_RunTime.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_TRiBotManager_RunTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_TRiBotManager_RunTime.Location = new Point(925, 575);
            labelDashboard_TRiBotManager_RunTime.Margin = new Padding(0);
            labelDashboard_TRiBotManager_RunTime.Name = "labelDashboard_TRiBotManager_RunTime";
            labelDashboard_TRiBotManager_RunTime.Size = new Size(75, 25);
            labelDashboard_TRiBotManager_RunTime.TabIndex = 108;
            labelDashboard_TRiBotManager_RunTime.Text = "Run Time";
            labelDashboard_TRiBotManager_RunTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDashboard_TRiBotManager_AdditionalSettings
            // 
            labelDashboard_TRiBotManager_AdditionalSettings.BackColor = Color.Transparent;
            labelDashboard_TRiBotManager_AdditionalSettings.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDashboard_TRiBotManager_AdditionalSettings.ForeColor = Color.FromArgb(224, 224, 224);
            labelDashboard_TRiBotManager_AdditionalSettings.Location = new Point(875, 550);
            labelDashboard_TRiBotManager_AdditionalSettings.Name = "labelDashboard_TRiBotManager_AdditionalSettings";
            labelDashboard_TRiBotManager_AdditionalSettings.Size = new Size(250, 25);
            labelDashboard_TRiBotManager_AdditionalSettings.TabIndex = 101;
            labelDashboard_TRiBotManager_AdditionalSettings.Text = "Additional Settings";
            labelDashboard_TRiBotManager_AdditionalSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonProgressBarGlobal
            // 
            kryptonProgressBarGlobal.Location = new Point(525, 575);
            kryptonProgressBarGlobal.Margin = new Padding(0);
            kryptonProgressBarGlobal.Name = "kryptonProgressBarGlobal";
            kryptonProgressBarGlobal.Size = new Size(500, 50);
            kryptonProgressBarGlobal.StateCommon.Back.Color1 = Color.FromArgb(255, 192, 128);
            kryptonProgressBarGlobal.StateCommon.Back.Color2 = Color.Gray;
            kryptonProgressBarGlobal.StateDisabled.Back.ColorStyle = PaletteColorStyle.OneNote;
            kryptonProgressBarGlobal.StateNormal.Back.ColorStyle = PaletteColorStyle.OneNote;
            kryptonProgressBarGlobal.TabIndex = 43;
            kryptonProgressBarGlobal.Values.Text = "";
            // 
            // labelBotTime
            // 
            labelBotTime.AutoSize = true;
            labelBotTime.BackColor = Color.Transparent;
            labelBotTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBotTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelBotTime.Location = new Point(350, 275);
            labelBotTime.Margin = new Padding(0);
            labelBotTime.Name = "labelBotTime";
            labelBotTime.Size = new Size(68, 18);
            labelBotTime.TabIndex = 16;
            labelBotTime.Text = "Bot Time";
            // 
            // labelBotTimeMinutes
            // 
            labelBotTimeMinutes.AutoSize = true;
            labelBotTimeMinutes.BackColor = Color.Transparent;
            labelBotTimeMinutes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBotTimeMinutes.ForeColor = Color.FromArgb(224, 224, 224);
            labelBotTimeMinutes.Location = new Point(650, 275);
            labelBotTimeMinutes.Name = "labelBotTimeMinutes";
            labelBotTimeMinutes.Size = new Size(60, 18);
            labelBotTimeMinutes.TabIndex = 19;
            labelBotTimeMinutes.Text = "Minutes";
            // 
            // labelBotTimeVariation
            // 
            labelBotTimeVariation.AutoSize = true;
            labelBotTimeVariation.BackColor = Color.Transparent;
            labelBotTimeVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBotTimeVariation.ForeColor = Color.FromArgb(224, 224, 224);
            labelBotTimeVariation.Location = new Point(350, 325);
            labelBotTimeVariation.Margin = new Padding(0);
            labelBotTimeVariation.Name = "labelBotTimeVariation";
            labelBotTimeVariation.Size = new Size(129, 18);
            labelBotTimeVariation.TabIndex = 17;
            labelBotTimeVariation.Text = "Bot Time Variation";
            // 
            // labelBotTimeVariationMinutes
            // 
            labelBotTimeVariationMinutes.AutoSize = true;
            labelBotTimeVariationMinutes.BackColor = Color.Transparent;
            labelBotTimeVariationMinutes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBotTimeVariationMinutes.ForeColor = Color.FromArgb(224, 224, 224);
            labelBotTimeVariationMinutes.Location = new Point(650, 325);
            labelBotTimeVariationMinutes.Name = "labelBotTimeVariationMinutes";
            labelBotTimeVariationMinutes.Size = new Size(60, 18);
            labelBotTimeVariationMinutes.TabIndex = 18;
            labelBotTimeVariationMinutes.Text = "Minutes";
            // 
            // labelBreakProfiles_Header
            // 
            labelBreakProfiles_Header.BackColor = Color.Transparent;
            labelBreakProfiles_Header.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBreakProfiles_Header.ForeColor = Color.FromArgb(224, 224, 224);
            labelBreakProfiles_Header.Location = new Point(200, 0);
            labelBreakProfiles_Header.Margin = new Padding(0);
            labelBreakProfiles_Header.Name = "labelBreakProfiles_Header";
            labelBreakProfiles_Header.Size = new Size(1150, 50);
            labelBreakProfiles_Header.TabIndex = 42;
            labelBreakProfiles_Header.Text = "Break Profiles";
            labelBreakProfiles_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBreakTime
            // 
            labelBreakTime.AutoSize = true;
            labelBreakTime.BackColor = Color.Transparent;
            labelBreakTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBreakTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelBreakTime.Location = new Point(350, 375);
            labelBreakTime.Name = "labelBreakTime";
            labelBreakTime.Size = new Size(84, 18);
            labelBreakTime.TabIndex = 20;
            labelBreakTime.Text = "Break Time";
            // 
            // labelBreakTimeMinutes
            // 
            labelBreakTimeMinutes.AutoSize = true;
            labelBreakTimeMinutes.BackColor = Color.Transparent;
            labelBreakTimeMinutes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBreakTimeMinutes.ForeColor = Color.FromArgb(224, 224, 224);
            labelBreakTimeMinutes.Location = new Point(650, 375);
            labelBreakTimeMinutes.Name = "labelBreakTimeMinutes";
            labelBreakTimeMinutes.Size = new Size(60, 18);
            labelBreakTimeMinutes.TabIndex = 24;
            labelBreakTimeMinutes.Text = "Minutes";
            // 
            // labelBreakTimePercentage
            // 
            labelBreakTimePercentage.AutoSize = true;
            labelBreakTimePercentage.BackColor = Color.Transparent;
            labelBreakTimePercentage.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBreakTimePercentage.ForeColor = Color.FromArgb(224, 224, 224);
            labelBreakTimePercentage.Location = new Point(650, 425);
            labelBreakTimePercentage.Name = "labelBreakTimePercentage";
            labelBreakTimePercentage.Size = new Size(21, 18);
            labelBreakTimePercentage.TabIndex = 25;
            labelBreakTimePercentage.Text = "%";
            // 
            // labelBreakTimeVariation
            // 
            labelBreakTimeVariation.AutoSize = true;
            labelBreakTimeVariation.BackColor = Color.Transparent;
            labelBreakTimeVariation.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBreakTimeVariation.ForeColor = Color.FromArgb(224, 224, 224);
            labelBreakTimeVariation.Location = new Point(350, 425);
            labelBreakTimeVariation.Name = "labelBreakTimeVariation";
            labelBreakTimeVariation.Size = new Size(145, 18);
            labelBreakTimeVariation.TabIndex = 21;
            labelBreakTimeVariation.Text = "Break Time Variation";
            // 
            // labelNav_ByFushigiBot
            // 
            labelNav_ByFushigiBot.BackColor = Color.Transparent;
            labelNav_ByFushigiBot.FlatStyle = FlatStyle.Flat;
            labelNav_ByFushigiBot.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNav_ByFushigiBot.ForeColor = Color.FromArgb(224, 224, 224);
            labelNav_ByFushigiBot.Location = new Point(0, 80);
            labelNav_ByFushigiBot.Margin = new Padding(0);
            labelNav_ByFushigiBot.Name = "labelNav_ByFushigiBot";
            labelNav_ByFushigiBot.Size = new Size(200, 20);
            labelNav_ByFushigiBot.TabIndex = 30;
            labelNav_ByFushigiBot.Text = "by FushigiBot";
            labelNav_ByFushigiBot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNav_CpuUsageMonitor
            // 
            labelNav_CpuUsageMonitor.BackColor = Color.Transparent;
            labelNav_CpuUsageMonitor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNav_CpuUsageMonitor.ForeColor = Color.FromArgb(224, 224, 224);
            labelNav_CpuUsageMonitor.Location = new Point(10, 625);
            labelNav_CpuUsageMonitor.Margin = new Padding(0);
            labelNav_CpuUsageMonitor.Name = "labelNav_CpuUsageMonitor";
            labelNav_CpuUsageMonitor.Size = new Size(180, 25);
            labelNav_CpuUsageMonitor.TabIndex = 25;
            labelNav_CpuUsageMonitor.Text = "CPU USAGE";
            labelNav_CpuUsageMonitor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNav_Jivaro
            // 
            labelNav_Jivaro.BackColor = Color.Transparent;
            labelNav_Jivaro.FlatStyle = FlatStyle.Flat;
            labelNav_Jivaro.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNav_Jivaro.ForeColor = Color.FromArgb(224, 224, 224);
            labelNav_Jivaro.Location = new Point(0, 0);
            labelNav_Jivaro.Margin = new Padding(0);
            labelNav_Jivaro.Name = "labelNav_Jivaro";
            labelNav_Jivaro.Size = new Size(200, 50);
            labelNav_Jivaro.TabIndex = 28;
            labelNav_Jivaro.Text = "Jivaro";
            labelNav_Jivaro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNav_OSRSLauncher
            // 
            labelNav_OSRSLauncher.BackColor = Color.Transparent;
            labelNav_OSRSLauncher.FlatStyle = FlatStyle.Flat;
            labelNav_OSRSLauncher.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelNav_OSRSLauncher.ForeColor = Color.FromArgb(224, 224, 224);
            labelNav_OSRSLauncher.Location = new Point(0, 50);
            labelNav_OSRSLauncher.Margin = new Padding(0);
            labelNav_OSRSLauncher.Name = "labelNav_OSRSLauncher";
            labelNav_OSRSLauncher.Size = new Size(200, 30);
            labelNav_OSRSLauncher.TabIndex = 29;
            labelNav_OSRSLauncher.Text = "OSRS Bot Manager";
            labelNav_OSRSLauncher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNav_RamUsageMonitor
            // 
            labelNav_RamUsageMonitor.BackColor = Color.Transparent;
            labelNav_RamUsageMonitor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNav_RamUsageMonitor.ForeColor = Color.FromArgb(224, 224, 224);
            labelNav_RamUsageMonitor.Location = new Point(10, 650);
            labelNav_RamUsageMonitor.Margin = new Padding(0);
            labelNav_RamUsageMonitor.Name = "labelNav_RamUsageMonitor";
            labelNav_RamUsageMonitor.Size = new Size(180, 25);
            labelNav_RamUsageMonitor.TabIndex = 24;
            labelNav_RamUsageMonitor.Text = "RAM USAGE";
            labelNav_RamUsageMonitor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelScriptProfiles_Explanation1
            // 
            labelScriptProfiles_Explanation1.AutoSize = true;
            labelScriptProfiles_Explanation1.BackColor = Color.Transparent;
            labelScriptProfiles_Explanation1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_Explanation1.ForeColor = Color.FromArgb(224, 224, 224);
            labelScriptProfiles_Explanation1.Location = new Point(645, 375);
            labelScriptProfiles_Explanation1.Margin = new Padding(0);
            labelScriptProfiles_Explanation1.Name = "labelScriptProfiles_Explanation1";
            labelScriptProfiles_Explanation1.Size = new Size(274, 17);
            labelScriptProfiles_Explanation1.TabIndex = 44;
            labelScriptProfiles_Explanation1.Text = "> Select a script from the drop down menu";
            // 
            // labelScriptProfiles_Explanation2
            // 
            labelScriptProfiles_Explanation2.AutoSize = true;
            labelScriptProfiles_Explanation2.BackColor = Color.Transparent;
            labelScriptProfiles_Explanation2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_Explanation2.ForeColor = Color.FromArgb(224, 224, 224);
            labelScriptProfiles_Explanation2.Location = new Point(645, 425);
            labelScriptProfiles_Explanation2.Name = "labelScriptProfiles_Explanation2";
            labelScriptProfiles_Explanation2.Size = new Size(295, 17);
            labelScriptProfiles_Explanation2.TabIndex = 45;
            labelScriptProfiles_Explanation2.Text = "> Fill in the blanks and select desired options.";
            // 
            // labelScriptProfiles_Explanation4
            // 
            labelScriptProfiles_Explanation4.AutoSize = true;
            labelScriptProfiles_Explanation4.BackColor = Color.Transparent;
            labelScriptProfiles_Explanation4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_Explanation4.ForeColor = Color.FromArgb(224, 224, 224);
            labelScriptProfiles_Explanation4.Location = new Point(645, 475);
            labelScriptProfiles_Explanation4.Name = "labelScriptProfiles_Explanation4";
            labelScriptProfiles_Explanation4.Size = new Size(201, 17);
            labelScriptProfiles_Explanation4.TabIndex = 46;
            labelScriptProfiles_Explanation4.Text = "> Click the Save Profile button.";
            // 
            // labelScriptProfiles_Explanation5
            // 
            labelScriptProfiles_Explanation5.AutoSize = true;
            labelScriptProfiles_Explanation5.BackColor = Color.Transparent;
            labelScriptProfiles_Explanation5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_Explanation5.ForeColor = Color.FromArgb(224, 224, 224);
            labelScriptProfiles_Explanation5.Location = new Point(645, 525);
            labelScriptProfiles_Explanation5.Name = "labelScriptProfiles_Explanation5";
            labelScriptProfiles_Explanation5.Size = new Size(187, 17);
            labelScriptProfiles_Explanation5.TabIndex = 47;
            labelScriptProfiles_Explanation5.Text = "> For more information, visit:";
            // 
            // labelScriptProfiles_Header
            // 
            labelScriptProfiles_Header.BackColor = Color.Transparent;
            labelScriptProfiles_Header.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_Header.ForeColor = Color.FromArgb(224, 224, 224);
            labelScriptProfiles_Header.Location = new Point(200, 0);
            labelScriptProfiles_Header.Margin = new Padding(0);
            labelScriptProfiles_Header.Name = "labelScriptProfiles_Header";
            labelScriptProfiles_Header.Size = new Size(1150, 50);
            labelScriptProfiles_Header.TabIndex = 50;
            labelScriptProfiles_Header.Text = "Script Profiles";
            labelScriptProfiles_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelScriptProfiles_SelectScript
            // 
            labelScriptProfiles_SelectScript.AutoSize = true;
            labelScriptProfiles_SelectScript.BackColor = Color.Transparent;
            labelScriptProfiles_SelectScript.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelScriptProfiles_SelectScript.ForeColor = Color.FromArgb(224, 224, 224);
            labelScriptProfiles_SelectScript.Location = new Point(745, 200);
            labelScriptProfiles_SelectScript.Margin = new Padding(0);
            labelScriptProfiles_SelectScript.Name = "labelScriptProfiles_SelectScript";
            labelScriptProfiles_SelectScript.Size = new Size(99, 20);
            labelScriptProfiles_SelectScript.TabIndex = 43;
            labelScriptProfiles_SelectScript.Text = "Select Script";
            // 
            // labelSettings_DreamBotDetails
            // 
            labelSettings_DreamBotDetails.AutoSize = true;
            labelSettings_DreamBotDetails.BackColor = Color.Transparent;
            labelSettings_DreamBotDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSettings_DreamBotDetails.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_DreamBotDetails.Location = new Point(294, 226);
            labelSettings_DreamBotDetails.Name = "labelSettings_DreamBotDetails";
            labelSettings_DreamBotDetails.Size = new Size(151, 20);
            labelSettings_DreamBotDetails.TabIndex = 84;
            labelSettings_DreamBotDetails.Text = "DreamBot Details";
            // 
            // labelSettings_DreamBotPassword
            // 
            labelSettings_DreamBotPassword.AutoSize = true;
            labelSettings_DreamBotPassword.BackColor = Color.Transparent;
            labelSettings_DreamBotPassword.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_DreamBotPassword.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_DreamBotPassword.Location = new Point(294, 301);
            labelSettings_DreamBotPassword.Name = "labelSettings_DreamBotPassword";
            labelSettings_DreamBotPassword.Size = new Size(75, 18);
            labelSettings_DreamBotPassword.TabIndex = 86;
            labelSettings_DreamBotPassword.Text = "Password";
            // 
            // labelSettings_DreamBotUsername
            // 
            labelSettings_DreamBotUsername.AutoSize = true;
            labelSettings_DreamBotUsername.BackColor = Color.Transparent;
            labelSettings_DreamBotUsername.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_DreamBotUsername.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_DreamBotUsername.Location = new Point(294, 266);
            labelSettings_DreamBotUsername.Name = "labelSettings_DreamBotUsername";
            labelSettings_DreamBotUsername.Size = new Size(77, 18);
            labelSettings_DreamBotUsername.TabIndex = 85;
            labelSettings_DreamBotUsername.Text = "Username";
            // 
            // labelSettings_Header
            // 
            labelSettings_Header.BackColor = Color.Transparent;
            labelSettings_Header.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_Header.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_Header.Location = new Point(200, 0);
            labelSettings_Header.Margin = new Padding(0);
            labelSettings_Header.Name = "labelSettings_Header";
            labelSettings_Header.Size = new Size(1150, 50);
            labelSettings_Header.TabIndex = 76;
            labelSettings_Header.Text = "Settings";
            labelSettings_Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSettings_OSBotDetails
            // 
            labelSettings_OSBotDetails.AutoSize = true;
            labelSettings_OSBotDetails.BackColor = Color.Transparent;
            labelSettings_OSBotDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSettings_OSBotDetails.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_OSBotDetails.Location = new Point(294, 101);
            labelSettings_OSBotDetails.Name = "labelSettings_OSBotDetails";
            labelSettings_OSBotDetails.Size = new Size(123, 20);
            labelSettings_OSBotDetails.TabIndex = 79;
            labelSettings_OSBotDetails.Text = "OSBot Details";
            // 
            // labelSettings_OSBotPassword
            // 
            labelSettings_OSBotPassword.AutoSize = true;
            labelSettings_OSBotPassword.BackColor = Color.Transparent;
            labelSettings_OSBotPassword.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_OSBotPassword.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_OSBotPassword.Location = new Point(294, 176);
            labelSettings_OSBotPassword.Name = "labelSettings_OSBotPassword";
            labelSettings_OSBotPassword.Size = new Size(75, 18);
            labelSettings_OSBotPassword.TabIndex = 82;
            labelSettings_OSBotPassword.Text = "Password";
            // 
            // labelSettings_OSBotUsername
            // 
            labelSettings_OSBotUsername.AutoSize = true;
            labelSettings_OSBotUsername.BackColor = Color.Transparent;
            labelSettings_OSBotUsername.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_OSBotUsername.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_OSBotUsername.Location = new Point(294, 141);
            labelSettings_OSBotUsername.Name = "labelSettings_OSBotUsername";
            labelSettings_OSBotUsername.Size = new Size(77, 18);
            labelSettings_OSBotUsername.TabIndex = 80;
            labelSettings_OSBotUsername.Text = "Username";
            // 
            // labelSettings_TRiBotDetails
            // 
            labelSettings_TRiBotDetails.AutoSize = true;
            labelSettings_TRiBotDetails.BackColor = Color.Transparent;
            labelSettings_TRiBotDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_TRiBotDetails.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_TRiBotDetails.Location = new Point(294, 351);
            labelSettings_TRiBotDetails.Name = "labelSettings_TRiBotDetails";
            labelSettings_TRiBotDetails.Size = new Size(111, 20);
            labelSettings_TRiBotDetails.TabIndex = 89;
            labelSettings_TRiBotDetails.Text = "TRiBot Details";
            // 
            // labelSettings_TRiBotEmail
            // 
            labelSettings_TRiBotEmail.AutoSize = true;
            labelSettings_TRiBotEmail.BackColor = Color.Transparent;
            labelSettings_TRiBotEmail.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_TRiBotEmail.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_TRiBotEmail.Location = new Point(294, 391);
            labelSettings_TRiBotEmail.Name = "labelSettings_TRiBotEmail";
            labelSettings_TRiBotEmail.Size = new Size(45, 18);
            labelSettings_TRiBotEmail.TabIndex = 90;
            labelSettings_TRiBotEmail.Text = "Email";
            // 
            // labelSettings_TRiBotPassword
            // 
            labelSettings_TRiBotPassword.AutoSize = true;
            labelSettings_TRiBotPassword.BackColor = Color.Transparent;
            labelSettings_TRiBotPassword.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSettings_TRiBotPassword.ForeColor = Color.FromArgb(224, 224, 224);
            labelSettings_TRiBotPassword.Location = new Point(294, 426);
            labelSettings_TRiBotPassword.Name = "labelSettings_TRiBotPassword";
            labelSettings_TRiBotPassword.Size = new Size(75, 18);
            labelSettings_TRiBotPassword.TabIndex = 91;
            labelSettings_TRiBotPassword.Text = "Password";
            // 
            // labelSleepTime
            // 
            labelSleepTime.AutoSize = true;
            labelSleepTime.BackColor = Color.Transparent;
            labelSleepTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSleepTime.ForeColor = Color.FromArgb(224, 224, 224);
            labelSleepTime.Location = new Point(825, 375);
            labelSleepTime.Name = "labelSleepTime";
            labelSleepTime.Size = new Size(82, 18);
            labelSleepTime.TabIndex = 30;
            labelSleepTime.Text = "Sleep Time";
            // 
            // labelSleepTimeMinutes
            // 
            labelSleepTimeMinutes.AutoSize = true;
            labelSleepTimeMinutes.BackColor = Color.Transparent;
            labelSleepTimeMinutes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSleepTimeMinutes.ForeColor = Color.FromArgb(224, 224, 224);
            labelSleepTimeMinutes.Location = new Point(1125, 375);
            labelSleepTimeMinutes.Name = "labelSleepTimeMinutes";
            labelSleepTimeMinutes.Size = new Size(60, 18);
            labelSleepTimeMinutes.TabIndex = 37;
            labelSleepTimeMinutes.Text = "Minutes";
            // 
            // labelSleepTimeVariation
            // 
            labelSleepTimeVariation.AutoSize = true;
            labelSleepTimeVariation.BackColor = Color.Transparent;
            labelSleepTimeVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSleepTimeVariation.ForeColor = Color.FromArgb(224, 224, 224);
            labelSleepTimeVariation.Location = new Point(825, 425);
            labelSleepTimeVariation.Name = "labelSleepTimeVariation";
            labelSleepTimeVariation.Size = new Size(143, 18);
            labelSleepTimeVariation.TabIndex = 31;
            labelSleepTimeVariation.Text = "Sleep Time Variation";
            // 
            // labelSleepTimeVariationPercentage
            // 
            labelSleepTimeVariationPercentage.AutoSize = true;
            labelSleepTimeVariationPercentage.BackColor = Color.Transparent;
            labelSleepTimeVariationPercentage.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSleepTimeVariationPercentage.ForeColor = Color.FromArgb(224, 224, 224);
            labelSleepTimeVariationPercentage.Location = new Point(1125, 425);
            labelSleepTimeVariationPercentage.Name = "labelSleepTimeVariationPercentage";
            labelSleepTimeVariationPercentage.Size = new Size(21, 18);
            labelSleepTimeVariationPercentage.TabIndex = 39;
            labelSleepTimeVariationPercentage.Text = "%";
            // 
            // labelTimeUntilSleep
            // 
            labelTimeUntilSleep.AutoSize = true;
            labelTimeUntilSleep.BackColor = Color.Transparent;
            labelTimeUntilSleep.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeUntilSleep.ForeColor = Color.FromArgb(224, 224, 224);
            labelTimeUntilSleep.Location = new Point(825, 275);
            labelTimeUntilSleep.Name = "labelTimeUntilSleep";
            labelTimeUntilSleep.Size = new Size(115, 18);
            labelTimeUntilSleep.TabIndex = 28;
            labelTimeUntilSleep.Text = "Time Until Sleep";
            // 
            // labelTimeUntilSleepMinutes
            // 
            labelTimeUntilSleepMinutes.AutoSize = true;
            labelTimeUntilSleepMinutes.BackColor = Color.Transparent;
            labelTimeUntilSleepMinutes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeUntilSleepMinutes.ForeColor = Color.FromArgb(224, 224, 224);
            labelTimeUntilSleepMinutes.Location = new Point(1125, 275);
            labelTimeUntilSleepMinutes.Name = "labelTimeUntilSleepMinutes";
            labelTimeUntilSleepMinutes.Size = new Size(60, 18);
            labelTimeUntilSleepMinutes.TabIndex = 36;
            labelTimeUntilSleepMinutes.Text = "Minutes";
            // 
            // labelTimeUntilSleepVariation
            // 
            labelTimeUntilSleepVariation.AutoSize = true;
            labelTimeUntilSleepVariation.BackColor = Color.Transparent;
            labelTimeUntilSleepVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeUntilSleepVariation.ForeColor = Color.FromArgb(224, 224, 224);
            labelTimeUntilSleepVariation.Location = new Point(825, 325);
            labelTimeUntilSleepVariation.Name = "labelTimeUntilSleepVariation";
            labelTimeUntilSleepVariation.Size = new Size(176, 18);
            labelTimeUntilSleepVariation.TabIndex = 29;
            labelTimeUntilSleepVariation.Text = "Time Until Sleep Variation";
            // 
            // labelTimeUntilSleepVariationMinutes
            // 
            labelTimeUntilSleepVariationMinutes.AutoSize = true;
            labelTimeUntilSleepVariationMinutes.BackColor = Color.Transparent;
            labelTimeUntilSleepVariationMinutes.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeUntilSleepVariationMinutes.ForeColor = Color.FromArgb(224, 224, 224);
            labelTimeUntilSleepVariationMinutes.Location = new Point(1125, 325);
            labelTimeUntilSleepVariationMinutes.Name = "labelTimeUntilSleepVariationMinutes";
            labelTimeUntilSleepVariationMinutes.Size = new Size(60, 18);
            labelTimeUntilSleepVariationMinutes.TabIndex = 38;
            labelTimeUntilSleepVariationMinutes.Text = "Minutes";
            // 
            // linkLabelScriptProfilesWebpage
            // 
            linkLabelScriptProfilesWebpage.AutoSize = true;
            linkLabelScriptProfilesWebpage.BackColor = Color.Transparent;
            linkLabelScriptProfilesWebpage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelScriptProfilesWebpage.LinkColor = Color.FromArgb(128, 255, 128);
            linkLabelScriptProfilesWebpage.Location = new Point(855, 523);
            linkLabelScriptProfilesWebpage.Name = "linkLabelScriptProfilesWebpage";
            linkLabelScriptProfilesWebpage.Size = new Size(97, 17);
            linkLabelScriptProfilesWebpage.TabIndex = 48;
            linkLabelScriptProfilesWebpage.TabStop = true;
            linkLabelScriptProfilesWebpage.Text = "www.jivaro.net";
            // 
            // panelBreakProfiles
            // 
            panelBreakProfiles.BackColor = Color.Transparent;
            panelBreakProfiles.Controls.Add(kryptonButtonBreakProfiles_Save);
            panelBreakProfiles.Controls.Add(labelBreakProfiles_Header);
            panelBreakProfiles.Controls.Add(labelSleepTimeVariationPercentage);
            panelBreakProfiles.Controls.Add(checkBoxBreakProfiles_EnableBreaks);
            panelBreakProfiles.Controls.Add(labelTimeUntilSleepVariationMinutes);
            panelBreakProfiles.Controls.Add(checkBoxBreakProfiles_EnableSleepBreaks);
            panelBreakProfiles.Controls.Add(labelSleepTimeMinutes);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_BotTime);
            panelBreakProfiles.Controls.Add(labelTimeUntilSleepMinutes);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_BotTimeVariation);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_TimeUntilSleep);
            panelBreakProfiles.Controls.Add(labelBotTime);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_TimeUntilSleepVariation);
            panelBreakProfiles.Controls.Add(labelBotTimeVariation);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_SleepTime);
            panelBreakProfiles.Controls.Add(labelBotTimeVariationMinutes);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_SleepTimeVariation);
            panelBreakProfiles.Controls.Add(labelBotTimeMinutes);
            panelBreakProfiles.Controls.Add(labelSleepTimeVariation);
            panelBreakProfiles.Controls.Add(labelBreakTime);
            panelBreakProfiles.Controls.Add(labelSleepTime);
            panelBreakProfiles.Controls.Add(labelBreakTimeVariation);
            panelBreakProfiles.Controls.Add(labelTimeUntilSleepVariation);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_BreakTime);
            panelBreakProfiles.Controls.Add(labelTimeUntilSleep);
            panelBreakProfiles.Controls.Add(textBoxBreakProfiles_BreakTimeVariation);
            panelBreakProfiles.Controls.Add(labelBreakTimeMinutes);
            panelBreakProfiles.Controls.Add(comboBoxBreakProfiles_SelectBreakFilename);
            panelBreakProfiles.Controls.Add(labelBreakTimePercentage);
            panelBreakProfiles.Location = new Point(0, 0);
            panelBreakProfiles.Margin = new Padding(0);
            panelBreakProfiles.Name = "panelBreakProfiles";
            panelBreakProfiles.Size = new Size(1349, 730);
            panelBreakProfiles.TabIndex = 28;
            // 
            // textBoxBreakProfiles_BotTime
            // 
            textBoxBreakProfiles_BotTime.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_BotTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_BotTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_BotTime.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_BotTime.Location = new Point(575, 275);
            textBoxBreakProfiles_BotTime.Name = "textBoxBreakProfiles_BotTime";
            textBoxBreakProfiles_BotTime.Size = new Size(72, 24);
            textBoxBreakProfiles_BotTime.TabIndex = 1;
            textBoxBreakProfiles_BotTime.Text = "60";
            textBoxBreakProfiles_BotTime.KeyPress += GlobalMethod_CancelNonNumbers_KeyPress;
            textBoxBreakProfiles_BotTime.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_BotTimeVariation
            // 
            textBoxBreakProfiles_BotTimeVariation.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_BotTimeVariation.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_BotTimeVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_BotTimeVariation.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_BotTimeVariation.Location = new Point(575, 325);
            textBoxBreakProfiles_BotTimeVariation.Name = "textBoxBreakProfiles_BotTimeVariation";
            textBoxBreakProfiles_BotTimeVariation.Size = new Size(72, 24);
            textBoxBreakProfiles_BotTimeVariation.TabIndex = 2;
            textBoxBreakProfiles_BotTimeVariation.Text = "30";
            textBoxBreakProfiles_BotTimeVariation.KeyPress += GlobalMethod_CancelNonNumbers_KeyPress;
            textBoxBreakProfiles_BotTimeVariation.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_TimeUntilSleep
            // 
            textBoxBreakProfiles_TimeUntilSleep.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_TimeUntilSleep.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_TimeUntilSleep.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_TimeUntilSleep.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_TimeUntilSleep.Location = new Point(1050, 275);
            textBoxBreakProfiles_TimeUntilSleep.Margin = new Padding(0);
            textBoxBreakProfiles_TimeUntilSleep.Name = "textBoxBreakProfiles_TimeUntilSleep";
            textBoxBreakProfiles_TimeUntilSleep.Size = new Size(72, 24);
            textBoxBreakProfiles_TimeUntilSleep.TabIndex = 5;
            textBoxBreakProfiles_TimeUntilSleep.Text = "600";
            textBoxBreakProfiles_TimeUntilSleep.KeyPress += GlobalMethod_CancelNonNumbers_KeyPress;
            textBoxBreakProfiles_TimeUntilSleep.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_TimeUntilSleepVariation
            // 
            textBoxBreakProfiles_TimeUntilSleepVariation.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_TimeUntilSleepVariation.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_TimeUntilSleepVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_TimeUntilSleepVariation.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_TimeUntilSleepVariation.Location = new Point(1050, 325);
            textBoxBreakProfiles_TimeUntilSleepVariation.Margin = new Padding(0);
            textBoxBreakProfiles_TimeUntilSleepVariation.Name = "textBoxBreakProfiles_TimeUntilSleepVariation";
            textBoxBreakProfiles_TimeUntilSleepVariation.Size = new Size(72, 24);
            textBoxBreakProfiles_TimeUntilSleepVariation.TabIndex = 6;
            textBoxBreakProfiles_TimeUntilSleepVariation.Text = "60";
            textBoxBreakProfiles_TimeUntilSleepVariation.KeyPress += GlobalMethod_CancelNonNumbers_KeyPress;
            textBoxBreakProfiles_TimeUntilSleepVariation.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_SleepTime
            // 
            textBoxBreakProfiles_SleepTime.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_SleepTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_SleepTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_SleepTime.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_SleepTime.Location = new Point(1050, 375);
            textBoxBreakProfiles_SleepTime.Margin = new Padding(0);
            textBoxBreakProfiles_SleepTime.Name = "textBoxBreakProfiles_SleepTime";
            textBoxBreakProfiles_SleepTime.Size = new Size(72, 24);
            textBoxBreakProfiles_SleepTime.TabIndex = 7;
            textBoxBreakProfiles_SleepTime.Text = "480";
            textBoxBreakProfiles_SleepTime.KeyPress += GlobalMethod_CancelNonNumbers_KeyPress;
            textBoxBreakProfiles_SleepTime.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_SleepTimeVariation
            // 
            textBoxBreakProfiles_SleepTimeVariation.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_SleepTimeVariation.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_SleepTimeVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_SleepTimeVariation.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_SleepTimeVariation.Location = new Point(1050, 425);
            textBoxBreakProfiles_SleepTimeVariation.Margin = new Padding(0);
            textBoxBreakProfiles_SleepTimeVariation.Name = "textBoxBreakProfiles_SleepTimeVariation";
            textBoxBreakProfiles_SleepTimeVariation.Size = new Size(72, 24);
            textBoxBreakProfiles_SleepTimeVariation.TabIndex = 8;
            textBoxBreakProfiles_SleepTimeVariation.Text = "25";
            textBoxBreakProfiles_SleepTimeVariation.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxBreakProfiles_SleepTimeVariation.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_BreakTime
            // 
            textBoxBreakProfiles_BreakTime.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_BreakTime.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_BreakTime.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_BreakTime.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_BreakTime.Location = new Point(575, 375);
            textBoxBreakProfiles_BreakTime.Name = "textBoxBreakProfiles_BreakTime";
            textBoxBreakProfiles_BreakTime.Size = new Size(72, 24);
            textBoxBreakProfiles_BreakTime.TabIndex = 3;
            textBoxBreakProfiles_BreakTime.Text = "30";
            textBoxBreakProfiles_BreakTime.KeyPress += GlobalMethod_CancelNonNumbers_KeyPress;
            textBoxBreakProfiles_BreakTime.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // textBoxBreakProfiles_BreakTimeVariation
            // 
            textBoxBreakProfiles_BreakTimeVariation.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBreakProfiles_BreakTimeVariation.BorderStyle = BorderStyle.FixedSingle;
            textBoxBreakProfiles_BreakTimeVariation.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreakProfiles_BreakTimeVariation.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxBreakProfiles_BreakTimeVariation.Location = new Point(575, 425);
            textBoxBreakProfiles_BreakTimeVariation.Name = "textBoxBreakProfiles_BreakTimeVariation";
            textBoxBreakProfiles_BreakTimeVariation.Size = new Size(72, 24);
            textBoxBreakProfiles_BreakTimeVariation.TabIndex = 4;
            textBoxBreakProfiles_BreakTimeVariation.Text = "25";
            textBoxBreakProfiles_BreakTimeVariation.KeyPress += GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress;
            textBoxBreakProfiles_BreakTimeVariation.Validating += GlobalMethod_RequireInput_Validating;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.Controls.Add(kryptonNavigatorDashboard);
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Margin = new Padding(0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1349, 730);
            panelDashboard.TabIndex = 26;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(60, 60, 60);
            panelMain.Controls.Add(labelNav_RamUsageMonitor);
            panelMain.Controls.Add(labelNav_CpuUsageMonitor);
            panelMain.Controls.Add(buttonNav_JivaroLogo);
            panelMain.Controls.Add(labelNav_Jivaro);
            panelMain.Controls.Add(labelNav_ByFushigiBot);
            panelMain.Controls.Add(labelNav_OSRSLauncher);
            panelMain.Controls.Add(kryptonButtonNav_Dashboard);
            panelMain.Controls.Add(kryptonButtonNav_ScriptProfiles);
            panelMain.Controls.Add(kryptonButtonNav_BreakProfiles);
            panelMain.Controls.Add(kryptonButtonNav_Settings);
            panelMain.Controls.Add(kryptonProgressBarGlobal);
            panelMain.Controls.Add(panelDashboard);
            panelMain.Controls.Add(panelSettings);
            panelMain.Controls.Add(panelBreakProfiles);
            panelMain.Controls.Add(panelScriptProfiles);
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1349, 730);
            panelMain.TabIndex = 38;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.Transparent;
            panelSettings.Controls.Add(kryptonButtonSettings_KillAllBotClients);
            panelSettings.Controls.Add(kryptonButtonSettings_Discord);
            panelSettings.Controls.Add(kryptonButtonSettings_BuyProxies);
            panelSettings.Controls.Add(kryptonButtonSettings_CreateAccount);
            panelSettings.Controls.Add(kryptonButtonSettings_BottingGuide);
            panelSettings.Controls.Add(kryptonButtonSettings_SetupGuide);
            panelSettings.Controls.Add(kryptonButtonSettings_VisitWebsite);
            panelSettings.Controls.Add(kryptonButtonSettings_UpdateManager);
            panelSettings.Controls.Add(kryptonButtonSettings_LocalScripts);
            panelSettings.Controls.Add(kryptonButtonSettings_UpdateScripts);
            panelSettings.Controls.Add(kryptonButton1);
            panelSettings.Controls.Add(kryptonButtonSettings_InstallProxifier);
            panelSettings.Controls.Add(kryptonButtonSettings_DownloadJava);
            panelSettings.Controls.Add(kryptonButtonSettings_SaveLogin);
            panelSettings.Controls.Add(checkBoxSettings_ShowCpuAndRamUsage);
            panelSettings.Controls.Add(labelSettings_Header);
            panelSettings.Controls.Add(checkBoxSettings_ShowWelcomeScreen);
            panelSettings.Controls.Add(textBoxSettings_TRiBotPassword);
            panelSettings.Controls.Add(textBoxSettings_TRiBotEmail);
            panelSettings.Controls.Add(labelSettings_TRiBotPassword);
            panelSettings.Controls.Add(labelSettings_OSBotDetails);
            panelSettings.Controls.Add(labelSettings_TRiBotEmail);
            panelSettings.Controls.Add(labelSettings_OSBotUsername);
            panelSettings.Controls.Add(labelSettings_TRiBotDetails);
            panelSettings.Controls.Add(textBoxSettings_OSBotUsername);
            panelSettings.Controls.Add(textBoxSettings_DreamBotPassword);
            panelSettings.Controls.Add(labelSettings_OSBotPassword);
            panelSettings.Controls.Add(textBoxSettings_DreamBotUsername);
            panelSettings.Controls.Add(textBoxSettings_OSBotPassword);
            panelSettings.Controls.Add(labelSettings_DreamBotPassword);
            panelSettings.Controls.Add(labelSettings_DreamBotDetails);
            panelSettings.Controls.Add(labelSettings_DreamBotUsername);
            panelSettings.Location = new Point(0, 0);
            panelSettings.Margin = new Padding(0);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(1349, 730);
            panelSettings.TabIndex = 29;
            // 
            // textBoxSettings_TRiBotPassword
            // 
            textBoxSettings_TRiBotPassword.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSettings_TRiBotPassword.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxSettings_TRiBotPassword.Location = new Point(394, 426);
            textBoxSettings_TRiBotPassword.Name = "textBoxSettings_TRiBotPassword";
            textBoxSettings_TRiBotPassword.PasswordChar = '*';
            textBoxSettings_TRiBotPassword.Size = new Size(175, 23);
            textBoxSettings_TRiBotPassword.TabIndex = 93;
            // 
            // textBoxSettings_TRiBotEmail
            // 
            textBoxSettings_TRiBotEmail.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSettings_TRiBotEmail.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxSettings_TRiBotEmail.Location = new Point(394, 391);
            textBoxSettings_TRiBotEmail.Name = "textBoxSettings_TRiBotEmail";
            textBoxSettings_TRiBotEmail.Size = new Size(175, 23);
            textBoxSettings_TRiBotEmail.TabIndex = 92;
            // 
            // textBoxSettings_OSBotUsername
            // 
            textBoxSettings_OSBotUsername.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSettings_OSBotUsername.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxSettings_OSBotUsername.Location = new Point(394, 141);
            textBoxSettings_OSBotUsername.Name = "textBoxSettings_OSBotUsername";
            textBoxSettings_OSBotUsername.Size = new Size(175, 23);
            textBoxSettings_OSBotUsername.TabIndex = 81;
            // 
            // textBoxSettings_DreamBotPassword
            // 
            textBoxSettings_DreamBotPassword.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSettings_DreamBotPassword.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxSettings_DreamBotPassword.Location = new Point(394, 301);
            textBoxSettings_DreamBotPassword.Name = "textBoxSettings_DreamBotPassword";
            textBoxSettings_DreamBotPassword.PasswordChar = '*';
            textBoxSettings_DreamBotPassword.Size = new Size(175, 23);
            textBoxSettings_DreamBotPassword.TabIndex = 88;
            // 
            // textBoxSettings_DreamBotUsername
            // 
            textBoxSettings_DreamBotUsername.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSettings_DreamBotUsername.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxSettings_DreamBotUsername.Location = new Point(394, 266);
            textBoxSettings_DreamBotUsername.Name = "textBoxSettings_DreamBotUsername";
            textBoxSettings_DreamBotUsername.Size = new Size(175, 23);
            textBoxSettings_DreamBotUsername.TabIndex = 87;
            // 
            // textBoxSettings_OSBotPassword
            // 
            textBoxSettings_OSBotPassword.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSettings_OSBotPassword.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxSettings_OSBotPassword.Location = new Point(394, 176);
            textBoxSettings_OSBotPassword.Name = "textBoxSettings_OSBotPassword";
            textBoxSettings_OSBotPassword.PasswordChar = '*';
            textBoxSettings_OSBotPassword.Size = new Size(175, 23);
            textBoxSettings_OSBotPassword.TabIndex = 83;
            // 
            // panelScriptProfiles
            // 
            panelScriptProfiles.BackColor = Color.Transparent;
            panelScriptProfiles.Controls.Add(labelScriptProfiles_Header);
            panelScriptProfiles.Controls.Add(linkLabelScriptProfilesWebpage);
            panelScriptProfiles.Controls.Add(comboBoxScriptProfiles_SelectScript);
            panelScriptProfiles.Controls.Add(labelScriptProfiles_Explanation5);
            panelScriptProfiles.Controls.Add(labelScriptProfiles_SelectScript);
            panelScriptProfiles.Controls.Add(labelScriptProfiles_Explanation4);
            panelScriptProfiles.Controls.Add(labelScriptProfiles_Explanation1);
            panelScriptProfiles.Controls.Add(labelScriptProfiles_Explanation2);
            panelScriptProfiles.Location = new Point(0, 0);
            panelScriptProfiles.Margin = new Padding(0);
            panelScriptProfiles.Name = "panelScriptProfiles";
            panelScriptProfiles.Size = new Size(1349, 730);
            panelScriptProfiles.TabIndex = 27;
            // 
            // timerNav_PerformanceCounters
            // 
            timerNav_PerformanceCounters.Enabled = true;
            timerNav_PerformanceCounters.Interval = 1000;
            timerNav_PerformanceCounters.Tick += timerNav_PerformanceCounters_Tick;
            // 
            // formMainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelMain);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formMainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jivaro Old School RuneScape Bot Manager v1.21";
            FormClosing += formMainForm_FormClose;
            Load += formMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_DreamBotManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_OSBotManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_ScriptFactoryManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDashboard_TRiBotManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonNavigatorDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_ScriptFactoryManager).EndInit();
            kryptonPageDashboard_ScriptFactoryManager.ResumeLayout(false);
            kryptonPageDashboard_ScriptFactoryManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_OSBotManager).EndInit();
            kryptonPageDashboard_OSBotManager.ResumeLayout(false);
            kryptonPageDashboard_OSBotManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_DreamBotManager).EndInit();
            kryptonPageDashboard_DreamBotManager.ResumeLayout(false);
            kryptonPageDashboard_DreamBotManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPageDashboard_TRiBotManager).EndInit();
            kryptonPageDashboard_TRiBotManager.ResumeLayout(false);
            kryptonPageDashboard_TRiBotManager.PerformLayout();
            panelBreakProfiles.ResumeLayout(false);
            panelBreakProfiles.PerformLayout();
            panelDashboard.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelScriptProfiles.ResumeLayout(false);
            panelScriptProfiles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Button buttonNav_JivaroLogo;
        public Button buttonSaveBreaks;
        public CheckBox checkBoxBreakProfiles_EnableBreaks;
        public CheckBox checkBoxBreakProfiles_EnableSleepBreaks;
        public CheckBox checkBoxSettings_ShowCpuAndRamUsage;
        public CheckBox checkBoxSettings_ShowWelcomeScreen;
        public ComboBox comboBoxBreakProfiles_SelectBreakFilename;
        public ComboBox comboBoxScriptProfiles_SelectScript;
        public DataGridView dataGridViewDashboard_DreamBotManager;
        public DataGridView dataGridViewDashboard_OSBotManager;
        public Krypton.Toolkit.KryptonButton kryptonButton1;
        public Krypton.Toolkit.KryptonButton kryptonButtonBreakProfiles_Save;
        public Krypton.Toolkit.KryptonButton kryptonButtonButtonDashboard_DreamBotManager_AddAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonButtonDashboard_DreamBotManager_DeleteAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonButtonDashboard_DreamBotManager_DownloadClient;
        public Krypton.Toolkit.KryptonButton kryptonButtonButtonDashboard_DreamBotManager_ImportAccounts;
        public Krypton.Toolkit.KryptonButton kryptonButtonButtonDashboard_DreamBotManager_Save;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_DreamBotManager_LaunchDreamBot;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_OSBotManager_AddAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_OSBotManager_DeleteAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_OSBotManager_DownloadClient;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_OSBotManager_ImportAccounts;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_OSBotManager_LaunchOSBot;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_OSBotManager_Save;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_ScriptFactoryManager_AddAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_ScriptFactoryManager_DeleteAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_ScriptFactoryManager_DownloadClient;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_ScriptFactoryManager_ImportAccounts;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_ScriptFactoryManager_LaunchOSBot;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_ScriptFactoryManager_Save;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_TRiBotManager_AddAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_TRiBotManager_DeleteAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_TRiBotManager_DownloadClient;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_TRiBotManager_ImportAccounts;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_TRiBotManager_LaunchClient;
        public Krypton.Toolkit.KryptonButton kryptonButtonDashboard_TRiBotManager_Save;
        public Krypton.Toolkit.KryptonButton kryptonButtonNav_BreakProfiles;
        public Krypton.Toolkit.KryptonButton kryptonButtonNav_Dashboard;
        public Krypton.Toolkit.KryptonButton kryptonButtonNav_ScriptProfiles;
        public Krypton.Toolkit.KryptonButton kryptonButtonNav_Settings;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_BottingGuide;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_BuyProxies;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_CreateAccount;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_Discord;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_DownloadJava;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_InstallProxifier;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_KillAllBotClients;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_LocalScripts;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_SaveLogin;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_SetupGuide;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_UpdateManager;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_UpdateScripts;
        public Krypton.Toolkit.KryptonButton kryptonButtonSettings_VisitWebsite;
        public Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxButtonDashboard_DreamBotManager_Loop;
        public Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDashboard_OSBotManager_Loop;
        public Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDashboard_ScriptFactoryManager_Loop;
        public Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxDashboard_TRiBotManager_Loop;
        public DataGridView dataGridViewDashboard_ScriptFactoryManager;
        public DataGridView dataGridViewDashboard_TRiBotManager;
        public Krypton.Toolkit.KryptonListBox kryptonListBoxDashboard_DreamBotManager_AdditionalSettings;
        public Krypton.Toolkit.KryptonListBox kryptonListBoxDashboard_OSBotManager_AdditionalSettings;
        public Krypton.Toolkit.KryptonListBox kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings;
        public Krypton.Toolkit.KryptonListBox kryptonListBoxDashboard_TRiBotManager_AdditionalSettings;
        public Krypton.Toolkit.KryptonProgressBar kryptonProgressBarGlobal;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxButtonDashboard_DreamBotManager_BreakTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxButtonDashboard_DreamBotManager_RunTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxDashboard_OSBotManager_BreakTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxDashboard_OSBotManager_RunTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxDashboard_ScriptFactoryManager_BreakTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxDashboard_ScriptFactoryManager_RunTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxDashboard_TRiBotManager_BreakTime;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBoxDashboard_TRiBotManager_RunTime;
        public KryptonNavigator kryptonNavigatorDashboard;
        public KryptonPage kryptonPageDashboard_ScriptFactoryManager;
        public KryptonPage kryptonPageDashboard_OSBotManager;
        public KryptonPage kryptonPageDashboard_DreamBotManager;
        public KryptonPage kryptonPageDashboard_TRiBotManager;
        public Label labelBotTime;
        public Label labelBotTimeMinutes;
        public Label labelBotTimeVariation;
        public Label labelBotTimeVariationMinutes;
        public Label labelBreakProfiles_Header;
        public Label labelBreakTime;
        public Label labelBreakTimeMinutes;
        public Label labelBreakTimePercentage;
        public Label labelBreakTimeVariation;
        public Label labelButtonDashboard_DreamBotManager_AdditionalSettings;
        public Label labelButtonDashboard_DreamBotManager_BreakTime;
        public Label labelButtonDashboard_DreamBotManager_BreakTimeMins;
        public Label labelButtonDashboard_DreamBotManager_RunTime;
        public Label labelButtonDashboard_DreamBotManager_RunTimeMins;
        public Label labelDashboard_OSBotManager_AdditionalSettings;
        public Label labelDashboard_OSBotManager_BreakTime;
        public Label labelDashboard_OSBotManager_BreakTimeMins;
        public Label labelDashboard_OSBotManager_RunTime;
        public Label labelDashboard_OSBotManager_RunTimeMins;
        public Label labelDashboard_ScriptFactoryManager_AdditionalSettings;
        public Label labelDashboard_ScriptFactoryManager_BreakTime;
        public Label labelDashboard_ScriptFactoryManager_BreakTimeMins;
        public Label labelDashboard_ScriptFactoryManager_RunTime;
        public Label labelDashboard_ScriptFactoryManager_RunTimeMins;
        public Label labelDashboard_TRiBotManager_AdditionalSettings;
        public Label labelDashboard_TRiBotManager_BreakTime;
        public Label labelDashboard_TRiBotManager_BreakTimeMins;
        public Label labelDashboard_TRiBotManager_RunTime;
        public Label labelDashboard_TRiBotManager_RunTimeMins;
        public Label labelNav_ByFushigiBot;
        public Label labelNav_CpuUsageMonitor;
        public Label labelNav_Jivaro;
        public Label labelNav_OSRSLauncher;
        public Label labelNav_RamUsageMonitor;
        public Label labelScriptProfiles_Explanation1;
        public Label labelScriptProfiles_Explanation2;
        public Label labelScriptProfiles_Explanation4;
        public Label labelScriptProfiles_Explanation5;
        public Label labelScriptProfiles_Header;
        public Label labelScriptProfiles_SelectScript;
        public Label labelSettings_DreamBotDetails;
        public Label labelSettings_DreamBotPassword;
        public Label labelSettings_DreamBotUsername;
        public Label labelSettings_Header;
        public Label labelSettings_OSBotDetails;
        public Label labelSettings_OSBotPassword;
        public Label labelSettings_OSBotUsername;
        public Label labelSettings_TRiBotDetails;
        public Label labelSettings_TRiBotEmail;
        public Label labelSettings_TRiBotPassword;
        public Label labelSleepTime;
        public Label labelSleepTimeMinutes;
        public Label labelSleepTimeVariation;
        public Label labelSleepTimeVariationPercentage;
        public Label labelTimeUntilSleep;
        public Label labelTimeUntilSleepMinutes;
        public Label labelTimeUntilSleepVariation;
        public Label labelTimeUntilSleepVariationMinutes;
        public LinkLabel linkLabelScriptProfilesWebpage;
        public Panel panelBreakProfiles;
        public Panel panelDashboard;
        public Panel panelMain;
        public Panel panelScriptProfiles;
        public Panel panelSettings;
        public System.Windows.Forms.Timer timerNav_PerformanceCounters;
        public TextBox textBoxBreakProfiles_BotTime;
        public TextBox textBoxBreakProfiles_BotTimeVariation;
        public TextBox textBoxBreakProfiles_BreakTime;
        public TextBox textBoxBreakProfiles_BreakTimeVariation;
        public TextBox textBoxBreakProfiles_SleepTime;
        public TextBox textBoxBreakProfiles_SleepTimeVariation;
        public TextBox textBoxBreakProfiles_TimeUntilSleep;
        public TextBox textBoxBreakProfiles_TimeUntilSleepVariation;
        public TextBox textBoxSettings_DreamBotPassword;
        public TextBox textBoxSettings_DreamBotUsername;
        public TextBox textBoxSettings_OSBotPassword;
        public TextBox textBoxSettings_OSBotUsername;
        public TextBox textBoxSettings_TRiBotEmail;
        public TextBox textBoxSettings_TRiBotPassword;
        private System.ComponentModel.IContainer components;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Account;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Password;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Pin;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Proxy;
        private DataGridViewComboBoxColumn dataGridViewDashboard_DreamBotManager_Script;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Args;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Breaks;
        private DataGridViewComboBoxColumn dataGridViewDashboard_DreamBotManager_World;
        private DataGridViewButtonColumn dataGridViewDashboard_DreamBotManager_RunStop;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Notes;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_Status;
        private DataGridViewTextBoxColumn dataGridViewDashboard_DreamBotManager_SandboxieNumber;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Account;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Password;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Pin;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Proxy;
        private DataGridViewComboBoxColumn dataGridViewDashboard_OSBotManager_Script;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Args;
        private DataGridViewComboBoxColumn dataGridViewDashboard_OSBotManager_World;
        private DataGridViewButtonColumn dataGridViewDashboard_OSBotManager_RunStop;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Notes;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_Status;
        private DataGridViewTextBoxColumn dataGridViewDashboard_OSBotManager_SandboxieNumber;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactoryManager_Account;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactory_Password;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactory_Pin;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactory_Proxy;
        private DataGridViewComboBoxColumn dataGridViewDashboard_ScriptFactory_ScriptFactory;
        private DataGridViewComboBoxColumn dataGridViewDashboard_ScriptFactory_Script;
        private DataGridViewComboBoxColumn dataGridViewDashboard_ScriptFactory_World;
        private DataGridViewButtonColumn dataGridViewDashboard_ScriptFactory_RunStop;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactory_Notes;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactory_Status;
        private DataGridViewTextBoxColumn dataGridViewDashboard_ScriptFactory_SandboxieNumber;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Account;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Password;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Pin;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Proxy;
        private DataGridViewComboBoxColumn dataGridViewDashboard_TRiBotManager_Script;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Args;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Breaks;
        private DataGridViewComboBoxColumn dataGridViewDashboard_TRiBotManager_World;
        private DataGridViewButtonColumn dataGridViewDashboard_TRiBotManager_RunStop;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Notes;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_Status;
        private DataGridViewTextBoxColumn dataGridViewDashboard_TRiBotManager_SandboxieNumber;
    }
}
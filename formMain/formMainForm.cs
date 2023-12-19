using Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous;
using Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles;
using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
using Krypton.Toolkit;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Jivaro_Old_School_RuneScape_Bot_Manager
{
    public partial class formMainForm : Form
    {
        ///////////////////////////////////////
        //Start of initialize class variables//
        ///////////////////////////////////////

        // Initialize Variables - Background Workers
        public BackgroundWorker workerFileHandler = new BackgroundWorker();
        public BackgroundWorker workerGetProcessHandler = new BackgroundWorker();
        public BackgroundWorker workerUpdateBotStatus = new BackgroundWorker();

        // Initialize Variables - Booleans
        public bool isDownloadingDreamBotEventRunning = false;
        public bool isDownloadingJavaRuntimeEnvironmentEventRunning = false;
        public bool isDownloadingOSBotEventRunning = false;
        public bool isDownloadingProxifierEventRunning = false;
        public bool isDownloadingSandboxiePlusEventRunning = false;
        public bool isDownloadingTRiBotEventRunning = false;
        public bool isUpdatingScriptsEventRunning = false;

        // Initialize Variables - Performance Counters
        public PerformanceCounter cpuCounter;
        public PerformanceCounter ramCounter;

        // Initialize Variables - Strings
        public string botcli;
        public string cliArgs;
        public string cliCommand;
        public string filePathApplicationDataAccountsDreamBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Accounts_DreamBot";
        public string filePathApplicationDataAccountsOSBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Accounts_OSBot";
        public string filePathApplicationDataAccountsScriptFactory = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Accounts_ScriptFactory";
        public string filePathApplicationDataAccountsSettingsIni = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Settings.ini";
        public string filePathApplicationDataAccountsTRiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Accounts_TRiBot";
        public string filePathApplicationDataLocalScriptsDreamBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_DreamBot";
        public string filePathApplicationDataLocalScriptsOSBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_OSBot";
        public string filePathApplicationDataLocalScriptsScriptFactory = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_ScriptFactory";
        public string filePathApplicationDataLocalScriptsTRiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_TRiBot";
        public string filePathApplicationDreamBotJar = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\DreamBot.jar";
        public string filePathApplicationMainMiscVersion = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\misc\\version.txt";
        public string filePathApplicationMainUpdaterExe = Path.Combine("updater.exe");
        public string filePathApplicationOSBotJar = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar";
        public string filePathApplicationTRiBotJar = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar";
        public string filePathJivaroTempJavaRuntimeEnvironment = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\JavaRuntimeEnvironment.exe";
        public string filePathJivaroTempBotManagerUpdaterExe = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\Old School RuneScape Bot Manager\\updater.exe";
        public string filePathJivaroTempProxifier = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\Proxifier.exe";
        public string filePathJivaroTempSandboxiePlus = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\Sandboxie-Plus.exe";
        public string filePathSandboxieIni = @"C:\\Windows\\Sandboxie.ini";
        public string filePathSandboxieStartExe = @"C:\\Program Files\\Sandboxie-Plus\\Start.exe";
        public string filePathSbieIni = @"C:\Program Files\Sandboxie-Plus\SbieIni.exe";
        public string folderPathApplication = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\";
        public string folderPathApplicationData = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\";
        public string folderPathApplicationMain = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\";
        public string folderPathApplicationMainJava = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\";
        public string folderPathJagexCache = @"C:\\Users\\" + Environment.UserName.ToString() + "\\jagexcache";
        public string folderPathJivaroTemp = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\";
        public string folderPathJivaroTempFushigiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\FushigiBot";
        public string folderPathJivaroTempFushigiBotZip = @"C:\Users\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\FushigiBot.zip";
        public string folderPathJivaroTempJava = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\java";
        public string folderPathJivaroTempJavaZip = @"C:\Users\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\java.zip";
        public string folderPathOSBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot";
        public string folderPathScriptFactoryPrivateScripts = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Private Scripts";
        public string folderPathScriptFactoryPrivateScriptsFushigiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Private Scripts\\FushigiBot";
        public string folderPathScriptFactoryProfiles = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles";
        public string folderPathJivaroTempBotManager = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\Old School RuneScape Bot Manager\\";
        public string folderPathUsername = @"C:\\Users\\" + Environment.UserName;
        public static string lastFetchedArgs = "";
        public string urlDreamBotClient = "https://dreambot.org/DBLauncher.jar";
        public string urlFushigiBotScripts = "https://download.jivaro.net/s/D7csx35Em5ADbNP/download/FushigiBot.zip";
        public string urlJavaRuntimeEnvironment = "https://download.jivaro.net/s/6kMtcjq97xaSbdr/download/jre_8.zip";
        public string urlLatestApplicationVersion = "https://download.jivaro.net/s/gBY4egoBbBAywyp/download/version.txt";
        public string urlOSBotClient = "https://osbot.org/mvc/get";
        public string urlProxifier = "https://www.proxifier.com/download/ProxifierSetup.exe";
        public string urlSandboxiePlus = "https://download.jivaro.net/s/ALLqfY7MdwqLqq5/download/Sandboxie-Plus.exe";
        public string urlSdnScriptsDreamBot = "https://download.jivaro.net/s/Mms2Jjj6pxXPnFZ/download/dreambot_script_list.txt";
        public string urlSdnScriptsOSBot = "https://download.jivaro.net/s/qDzAY9QJJ4DAFzi/download/osbot_script_list.txt";
        public string urlSdnScriptsScriptFactory = "https://download.jivaro.net/s/fsjwMxi2G55YsYg/download/script_factory_script_list.txt";
        public string urlSdnScriptsTRiBot = "https://download.jivaro.net/s/QxpqptAkRsa6swC/download/tribot_script_list.txt";
        public string urlTRiBotClient = "https://installers.tribot.org/tribot-splash.jar";
        public string[] filesMirrorJunk;

        /////////////////////////////////////
        //End of Initialize Class Variables//
        /////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////////////
        //Start of Initialize Components//
        //////////////////////////////////

        public formMainForm()
        {
            InitializeComponent();

            // Hide the form
            this.Visible = false;

            // Optimized double buffer
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            // Instances - Performance Counters
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            // Timers - Performance Counters
            timerNav_PerformanceCounters.Interval = 1000;
            timerNav_PerformanceCounters.Start();
        }

        ////////////////////////////////
        //End of Initialize Components//
        ////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////////
        //Start of Form Load & Close//
        //////////////////////////////

        // Form Load
        public async void formMainForm_Load(object sender, EventArgs e)
        {
            // Create Folders
            invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathApplication);
            invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathApplicationData);
            invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathApplicationMain);
            invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathJivaroTemp);
            invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathScriptFactoryPrivateScripts);
            invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathScriptFactoryProfiles);

            // Create Files
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsDreamBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsOSBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsScriptFactory);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsSettingsIni);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsTRiBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsDreamBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsOSBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsScriptFactory);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsTRiBot);

            // Worker - File Handler
            workerFileHandler.DoWork += Worker_FileHandler;
            workerFileHandler.WorkerSupportsCancellation = true;

            if (!workerFileHandler.IsBusy)
            {
                workerFileHandler.RunWorkerAsync();
            }

            // Worker - Get Process Handler
            workerGetProcessHandler.DoWork += Worker_GetProcessHandler;
            workerGetProcessHandler.WorkerSupportsCancellation = true;

            if (!workerGetProcessHandler.IsBusy)
            {
                workerGetProcessHandler.RunWorkerAsync();
            }

            // Worker - Update Bot Status
            workerUpdateBotStatus.DoWork += Worker_UpdateBotStatus;
            workerUpdateBotStatus.WorkerSupportsCancellation = true;

            if (!workerUpdateBotStatus.IsBusy)
            {
                workerUpdateBotStatus.RunWorkerAsync();
            }

            // Populate  dataGridView's Script Collections
            await Invoke_PopulateComboBoxColumn(kryptonDataGridViewDashboard_DreamBotManager, "kryptonDataGridViewDashboard_DreamBotManager_Script", urlSdnScriptsDreamBot, filePathApplicationDataLocalScriptsDreamBot);
            await Invoke_PopulateComboBoxColumn(kryptonDataGridViewDashboard_OSBotManager, "kryptonDataGridViewDashboard_OSBotManager_Script", urlSdnScriptsOSBot, filePathApplicationDataLocalScriptsOSBot);
            await Invoke_PopulateComboBoxColumn(kryptonDataGridViewDashboard_ScriptFactoryManager, "kryptonDataGridViewDashboard_ScriptFactory_Script", urlSdnScriptsScriptFactory, filePathApplicationDataLocalScriptsScriptFactory);
            await Invoke_PopulateComboBoxColumn(kryptonDataGridViewDashboard_TRiBotManager, "kryptonDataGridViewDashboard_TRiBotManager_Script", urlSdnScriptsTRiBot, filePathApplicationDataLocalScriptsTRiBot);

            // Populate dataGridView's Account Data
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(kryptonDataGridViewDashboard_ScriptFactoryManager, filePathApplicationDataAccountsScriptFactory);
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(kryptonDataGridViewDashboard_OSBotManager, filePathApplicationDataAccountsOSBot);
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(kryptonDataGridViewDashboard_DreamBotManager, filePathApplicationDataAccountsDreamBot);
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(kryptonDataGridViewDashboard_TRiBotManager, filePathApplicationDataAccountsTRiBot);

            // Populate Client Login Info
            invokeMethodsPassiveMainForm.Invoke_PopulateTextBoxFromIniFile(textBoxSettings_OSBotUsername, "osbot_username=", filePathApplicationDataAccountsSettingsIni);
            invokeMethodsPassiveMainForm.Invoke_PopulateTextBoxFromIniFile(textBoxSettings_OSBotPassword, "osbot_password=", filePathApplicationDataAccountsSettingsIni);
            invokeMethodsPassiveMainForm.Invoke_PopulateTextBoxFromIniFile(textBoxSettings_DreamBotUsername, "dreambot_username=", filePathApplicationDataAccountsSettingsIni);
            invokeMethodsPassiveMainForm.Invoke_PopulateTextBoxFromIniFile(textBoxSettings_DreamBotPassword, "dreambot_password=", filePathApplicationDataAccountsSettingsIni);
            invokeMethodsPassiveMainForm.Invoke_PopulateTextBoxFromIniFile(textBoxSettings_TRiBotEmail, "tribot_email=", filePathApplicationDataAccountsSettingsIni);
            invokeMethodsPassiveMainForm.Invoke_PopulateTextBoxFromIniFile(textBoxSettings_TRiBotPassword, "tribot_password=", filePathApplicationDataAccountsSettingsIni);

            // Clear selection in the KryptonDataGridView
            kryptonDataGridViewDashboard_ScriptFactoryManager.ClearSelection();
            kryptonDataGridViewDashboard_OSBotManager.ClearSelection();
            kryptonDataGridViewDashboard_DreamBotManager.ClearSelection();
            kryptonDataGridViewDashboard_TRiBotManager.ClearSelection();

            // Bring panelScriptFactory to the front
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control != kryptonPanelDashboard)
                {
                    control.SendToBack();
                }
            }
            kryptonPanelDashboard.BringToFront();

            // Set ProgressBar Visibility to False
            kryptonProgressBarGlobal.Visible = false;

            // Bring Nav Controls to Front
            this.Invoke_BringNavControlsToFront(null, EventArgs.Empty);

            // Disable Dashboard Button
            Invoke_DisableKryptonButton(this, "kryptonButtonNav_Dashboard");

            // Default ComboBox Selections
            comboBoxBreakProfiles_SelectBreakFilename.SelectedIndex = 0;

            // Set default Checkboxes
            try
            {
                string[] lines = File.ReadAllLines(filePathApplicationDataAccountsSettingsIni);

                foreach (string line in lines)
                {
                    if (line.Trim().Equals("welcome_screen=false", StringComparison.OrdinalIgnoreCase))
                    {
                        checkBoxSettings_ShowWelcomeScreen.Checked = false;
                    }
                    else if (line.Trim().Equals("hardware_usage=false", StringComparison.OrdinalIgnoreCase))
                    {
                        checkBoxSettings_ShowCpuAndRamUsage.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading settings: " + ex.Message);
            }

            // Show Welcome Screen
            if (checkBoxSettings_ShowWelcomeScreen.Checked)
            {
                try
                {
                    formWelcomeScreen welcomeScreen = new formWelcomeScreen();
                    welcomeScreen.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening welcome screen: " + ex.Message);
                }
            }

            // Send CPU and RAM Usage Controls to Back
            if (!checkBoxSettings_ShowCpuAndRamUsage.Checked)
            {
                try
                {
                    labelNav_CpuUsageMonitor.Visible = false;
                    labelNav_RamUsageMonitor.Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Show the form
            await Task.Delay(3000);
            this.Visible = true;

        }

        // Form Close
        public void formMainForm_FormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        ////////////////////////////
        //End of Form Load & Close//
        ////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////
        //Start of Background Workers//
        ///////////////////////////////

        // Worker - File Handler
        public async void Worker_FileHandler(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    // Create Folders
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathApplication));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathApplicationData));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathApplicationMain));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathJivaroTemp));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathScriptFactoryPrivateScripts));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFolderIfNotExists(folderPathScriptFactoryProfiles));

                    // Create Files
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsDreamBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsOSBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsScriptFactory));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsSettingsIni));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsTRiBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsDreamBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsOSBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsScriptFactory));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsTRiBot));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while handling files: " + ex.Message);
                }

                // Sleep for 30 seconds
                await Task.Delay(TimeSpan.FromSeconds(60));
            }
        }

        // Worker - Get Process Handler
        public async void Worker_GetProcessHandler(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    // Get the command line arguments of the processes
                    string allArgs = await Task.Run(() => invokeMethodsPassiveMainForm.Invoke_GetJavaCommandLineArgs());

                    lastFetchedArgs = allArgs;

                    // Print the arguments to the console
                    Console.WriteLine(allArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // Sleep for 10 seconds
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }

        // Worker - Update Bot Status
        public async void Worker_UpdateBotStatus(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // Script Factory
                try
                {
                    if (kryptonDataGridViewDashboard_ScriptFactoryManager.InvokeRequired)
                    {
                        kryptonDataGridViewDashboard_ScriptFactoryManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_ScriptFactoryManager, "kryptonDataGridViewDashboard_ScriptFactoryManager_Account", "kryptonDataGridViewDashboard_ScriptFactory_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_ScriptFactoryManager, "kryptonDataGridViewDashboard_ScriptFactoryManager_Account", "kryptonDataGridViewDashboard_ScriptFactory_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // OSBot Manager
                try
                {
                    if (kryptonDataGridViewDashboard_OSBotManager.InvokeRequired)
                    {
                        kryptonDataGridViewDashboard_OSBotManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_OSBotManager, "kryptonDataGridViewDashboard_OSBotManager_Account", "kryptonDataGridViewDashboard_OSBotManager_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_OSBotManager, "kryptonDataGridViewDashboard_OSBotManager_Account", "kryptonDataGridViewDashboard_OSBotManager_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // DreamBot Manager
                try
                {
                    if (kryptonDataGridViewDashboard_DreamBotManager.InvokeRequired)
                    {
                        kryptonDataGridViewDashboard_DreamBotManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_DreamBotManager, "kryptonDataGridViewDashboard_DreamBotManager_Account", "kryptonDataGridViewDashboard_DreamBotManager_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_DreamBotManager, "kryptonDataGridViewDashboard_DreamBotManager_Account", "kryptonDataGridViewDashboard_DreamBotManager_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // TRiBot Manager
                try
                {
                    if (kryptonDataGridViewDashboard_TRiBotManager.InvokeRequired)
                    {
                        kryptonDataGridViewDashboard_TRiBotManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_TRiBotManager, "kryptonDataGridViewDashboard_TRiBotManager_Account", "kryptonDataGridViewDashboard_TRiBotManager_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(kryptonDataGridViewDashboard_TRiBotManager, "kryptonDataGridViewDashboard_TRiBotManager_Account", "kryptonDataGridViewDashboard_TRiBotManager_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // Sleep for 10 seconds
                await Task.Delay(TimeSpan.FromSeconds(6));
            }
        }

        /////////////////////////////
        //End Of Background Workers//
        /////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of Performance Counters//
        /////////////////////////////////

        // Tick - Performance Counters
        public async void timerNav_PerformanceCounters_Tick(object sender, EventArgs e)
        {
            try
            {
                // Sleep
                await Task.Delay(1000);

                // Get next value
                float cpuUsage = cpuCounter.NextValue();
                float ramUsage = ramCounter.NextValue();

                // Check if Control Handle Has Been Created
                if (labelNav_CpuUsageMonitor.IsHandleCreated && labelNav_RamUsageMonitor.IsHandleCreated)
                {
                    // Update Labels With Current Values
                    this.Invoke((MethodInvoker)delegate
                    {
                        labelNav_CpuUsageMonitor.Text = $"CPU Usage: {cpuUsage:F2}%";
                        labelNav_RamUsageMonitor.Text = $"RAM Usage: {ramUsage:F2}%";
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Optionally, you can log the full exception details, like:
                // Console.WriteLine(ex.ToString());
            }
        }


        ///////////////////////////////
        //End of Performance Counters//
        ///////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////
        //Start of Navigation Buttons//
        ///////////////////////////////

        // Btn Click - Navigate To Dashboard
        public void btnNavigation_ScriptFactory_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(kryptonPanelDashboard);
            this.Invoke_BringNavControlsToFront(null, EventArgs.Empty);
            Invoke_DisableKryptonButton(this, "kryptonButtonNav_Dashboard");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_ScriptProfiles");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_BreakProfiles");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_Settings");
        }

        // Btn Click - Navigate To Script Profiles
        public void btnNavigation_ScriptProfiles_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(kryptonPanelScriptProfiles);
            this.Invoke_BringNavControlsToFront(null, EventArgs.Empty);
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_Dashboard");
            Invoke_DisableKryptonButton(this, "kryptonButtonNav_ScriptProfiles");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_BreakProfiles");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_Settings");
        }

        // Btn Click - Navigate to Break Profiles
        public void btnNavigation_BreakProfiles_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(kryptonPanelBreakProfiles);
            this.Invoke_BringNavControlsToFront(null, EventArgs.Empty);
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_Dashboard");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_ScriptProfiles");
            Invoke_DisableKryptonButton(this, "kryptonButtonNav_BreakProfiles");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_Settings");
        }

        // Btn Click - Navigate To Settings
        public void btnNavigation_Settings_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(kryptonPanelSettings);
            this.Invoke_BringNavControlsToFront(null, EventArgs.Empty);
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_Dashboard");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_ScriptProfiles");
            Invoke_EnableKryptonButton(this, "kryptonButtonNav_BreakProfiles");
            Invoke_DisableKryptonButton(this, "kryptonButtonNav_Settings");
        }


        /////////////////////////////
        //End of Navigation Buttons//
        /////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of Script Factory Panel//
        /////////////////////////////////

        // Cell Btn Click - Cli Launch
        public void dataGridView_ScriptFactoryRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < kryptonDataGridViewDashboard_ScriptFactoryManager.Rows.Count)
            {
                // Initialize Variables
                string directoryPath = @"C:\Users\" + Environment.UserName + @"\OSBot\Data";
                if (Directory.Exists(directoryPath))
                {
                    filesMirrorJunk = Directory.GetFiles(directoryPath, "mirror_*");
                }
                else
                {
                    // Create the missing directory
                    Directory.CreateDirectory(directoryPath);

                    // Since the directory is new, it won't have any files matching the pattern
                    filesMirrorJunk = new string[0];
                }

                // Point to dataGridView
                DataGridViewRow clickedRow = kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactoryManager_Account"].Value?.ToString();

                // Get all the currently running Java processes with their arguments and process ID.
                var javaProcessesList = invokeMethodsPassiveMainForm.Invoke_GetJavaCommandLineArgsAndProcessId();
                int processIdToKill = -1;

                foreach (var processInfo in javaProcessesList)
                {
                    string[] splitInfo = processInfo.Split(',');
                    string args = splitInfo[0];
                    int processId = int.Parse(splitInfo[1]);

                    if (args.Contains(account))
                    {
                        processIdToKill = processId;
                        break;
                    }
                }

                // Create Cli Args
                if (processIdToKill == -1 && e.ColumnIndex == kryptonDataGridViewDashboard_ScriptFactoryManager.Columns["kryptonDataGridViewDashboard_ScriptFactory_RunStop"].Index && e.RowIndex >= 0)
                {
                    // Initialize variables
                    string loginInfoOSBot = "-login " + textBoxSettings_OSBotUsername.Text.ToString() + ":" + textBoxSettings_OSBotPassword.Text.ToString() + " ";
                    string lowCpu = "";
                    string lowResource = "";
                    string mirror = "";
                    string newMouse = "";
                    string noInterface = "";
                    string noRender = "";
                    string password = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_Password"].Value?.ToString();
                    string pin = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_Proxy"].Value?.ToString();
                    string sandboxie = "No";
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_SandboxieNumber"].Value?.ToString();
                    string script = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_ScriptFactory"].Value?.ToString();
                    string task = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_Script"].Value?.ToString();
                    string world = clickedRow.Cells["kryptonDataGridViewDashboard_ScriptFactory_World"].Value?.ToString();

                    // Set BotCli variables
                    botcli = "-bot " + account + ":" + password + ":" + (string.IsNullOrWhiteSpace(pin) ? "1234" : pin) + " ";

                    // Set Proxy Variable
                    proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : "-proxy " + proxy + " ";

                    // Set Script Variable
                    script = new Dictionary<string, string> { { "SF I", "1097" }, { "SF II", "1214" }, { "SF Pro", "1163" }, { "SF Expansion", "1144" } }.TryGetValue(script, out var mappedValue) ? $"-script {mappedValue}:{task} " : script;

                    // Set World Variable
                    Random rnd = new Random();

                    Dictionary<string, int[]> worldMap = new Dictionary<string, int[]>
                    {
                        { "-F2P-", new int[] { 301, 308, 316, 326, 335, 371, 380, 382, 383, 384, 394, 397, 398, 399, 417, 418, 430, 431, 433, 434, 435, 436, 437, 451, 452, 453, 454, 455, 456, 469, 470, 471, 475, 476, 483, 497, 498, 499, 500, 501, 537, 542, 543, 544, 545, 546, 547, 552, 553, 554, 555, 556, 557, 562, 563, 571, 575 } },
                        { "-P2P-", new int[] { 302, 303, 304, 305, 306, 307, 309, 310, 311, 312, 313, 314, 315, 317, 318, 319, 320, 321, 322, 323, 324, 325, 327, 328, 329, 330, 331, 332, 333, 334, 336, 337, 338, 339, 340, 341, 343, 344, 346, 347, 348, 350, 351, 352, 354, 355, 357, 358, 359, 360, 362, 367, 368, 369, 370, 374, 375, 376, 377, 378, 386, 387, 388, 389, 390, 395, 421, 422, 424, 443, 444, 445, 446, 463, 464, 465, 466, 477, 478, 480, 481, 482, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 531, 532, 533, 534, 535, 580 } }
                    };

                    world = worldMap.ContainsKey(world)
                        ? "-world " + worldMap[world][rnd.Next(worldMap[world].Length)] + " "
                        : "-world " + world + " ";

                    // Set Additional Settings Variables
                    if (kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.SelectedItems.Count > 0)
                    {
                        Dictionary<string, Action> additionalSettingsMap = new Dictionary<string, Action>
                        {
                            {"Low CPU", () => lowCpu = "-allow lowcpu "},
                            {"Low Resource", () => lowResource = "-allow lowresource "},
                            {"Mirror", () => mirror = "-mirror -launchgame "},
                            {"New Mouse", () => newMouse = "-newmouse "},
                            {"No Interface", () => noInterface = "-allow nointerface "},
                            {"No Render", () => noRender = "-allow norender "},
                            {"Sandboxie", () => sandboxie = "Yes"}
                        };

                        // Loop Through Dictionary & Generate Output
                        foreach (var additionalSettingsItem in kryptonListBoxDashboard_ScriptFactoryManager_AdditionalSettings.SelectedItems)
                        {
                            string selectedAdditionalSetting = additionalSettingsItem.ToString();

                            foreach (var additionalSetting in additionalSettingsMap)
                            {
                                if (selectedAdditionalSetting.Contains(additionalSetting.Key))
                                {
                                    additionalSetting.Value.Invoke();
                                }
                            }
                        }
                    }

                    // Delete Mirror Files
                    foreach (string file in filesMirrorJunk)
                    {
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(file);
                    }

                    // Delete Jagex Files
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagex_cl_oldschool_LIVE.dat");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagexappletviewer.preferences");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "random.dat");

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        // Set CliArgs Variable
                        cliArgs = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\" -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mirror + newMouse + lowCpu + lowResource + noInterface + noRender + "-closeOnInitializationError -debug 0";

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"",
                                Arguments = cliArgs,
                                UseShellExecute = false,
                                CreateNoWindow = true,
                            };

                            Process process = new Process
                            {
                                StartInfo = psi
                            };

                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliArgs);
                    }

                    ////////////////////
                    //Sandboxie Launch//
                    ////////////////////
                    if (sandboxie == "Yes")
                    {
                        // Initialize Variables
                        string folderPathSandboxieCurrent = "C:\\Sandbox\\" + Environment.UserName.ToString() + "\\" + sandboxieNumber + "\\user\\current\\";
                        string folderPathSandboxieCurrentOSBotData = "C:\\Sandbox\\" + Environment.UserName.ToString() + "\\" + sandboxieNumber + "\\user\\current\\OSBot\\Data";
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /nosbiectrl /silent /wait /box:" + sandboxieNumber + " \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\" -jar " + "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"" + " -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mirror + newMouse + lowCpu + lowResource + noInterface + noRender + "-closeOnInitializationError -debug 0";

                        // Create Sandbox If It Doesn't Exist
                        if (!enabledSandboxes.Contains(sandboxieNumber))
                        {
                            invokeMethodsActiveMainForm.Invoke_CreateSandboxFolder(sandboxieNumber, filePathSbieIni);
                            Thread.Sleep(100);
                        }

                        // Delete Sandbox Files
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\jagex_cl_oldschool_LIVE.dat");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\jagexappletviewer.preferences");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\random.dat");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrentOSBotData + "\\map.bin");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrentOSBotData + "\\map.zip");

                        // Copy Jagex Cache to Sandbox
                        invokeMethodsActiveMainForm.Invoke_CopyDirectory(folderPathJagexCache, folderPathSandboxieCurrent + "\\jagexcache", "Copied jagexcache to sandboxie");
                        invokeMethodsActiveMainForm.Invoke_CopyDirectory(folderPathOSBot, folderPathSandboxieCurrent + "\\OSBot", "Copied OSBot folder to sandboxie");

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = filePathSandboxieStartExe,
                                Arguments = cliArgs,
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                UseShellExecute = false,
                            };

                            Process process = new Process
                            {
                                StartInfo = psi
                            };

                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliArgs);
                    }
                }
                else if (processIdToKill != -1 && e.ColumnIndex == kryptonDataGridViewDashboard_ScriptFactoryManager.Columns["kryptonDataGridViewDashboard_ScriptFactory_RunStop"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        invokeMethodsActiveMainForm.Invoke_KillProcessAndChildren(processIdToKill);
                        Console.WriteLine($"Killed process and its children: {processIdToKill}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to kill process {processIdToKill}. Error: {ex.Message} \n\n Details: {ex.ToString()}");
                    }
                }
            }
        }

        // Btn Click - Launch OSBot
        public void btnScriptFactory_LaunchOsbot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"", arguments);
        }

        // Btn Click - Add Bot
        public void btnScriptFactory_AddAccount_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = kryptonDataGridViewDashboard_ScriptFactoryManager.Rows.Add(newRow);

            // Set Default Values
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactoryManager_Account"].Value = "ACCOUNT_EMAIL";
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_Password"].Value = "PASSWORD";
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_Pin"].Value = "1234";
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_Proxy"].Value = "IP:PORT:USER:PASS";
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_ScriptFactory"].Value = "SF I";
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_Script"].Value = "fxAccountBuilder";
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_World"].Value = "-F2P-";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            kryptonDataGridViewDashboard_ScriptFactoryManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_ScriptFactory_SandboxieNumber"].Value = randomNumber;
        }

        // Btn Click - Delete Bot
        public void btnScriptFactory_DeleteAccount_Click(object sender, EventArgs e)
        {
            // Check if any cell is currently selected
            if (kryptonDataGridViewDashboard_ScriptFactoryManager.CurrentCell != null)
            {
                int rowIndex = kryptonDataGridViewDashboard_ScriptFactoryManager.CurrentCell.RowIndex;
                if (rowIndex >= 0) // Check if the rowIndex is valid
                {
                    kryptonDataGridViewDashboard_ScriptFactoryManager.Rows.RemoveAt(rowIndex);
                }
            }
        }

        // Btn Click - Download OSBot
        public async void btnScriptFactory_DownloadOSBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlOSBotClient, filePathApplicationOSBotJar, kryptonProgressBarGlobal, value => isDownloadingOSBotEventRunning = value, sender as KryptonButton);
        }

        // Btn Click - Save
        public void btnScriptFactory_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(kryptonDataGridViewDashboard_ScriptFactoryManager, filePathApplicationDataAccountsScriptFactory);
        }

        ///////////////////////////////
        //End of Script Factory Panel//
        ///////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////
        //Start of OSBot Manager Panel//
        ////////////////////////////////

        // Cell Btn Click - CLI Launch
        public void dataGridView_OSBotRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < kryptonDataGridViewDashboard_OSBotManager.Rows.Count)
            {
                // Initialize Variables
                string directoryPath = @"C:\Users\" + Environment.UserName + @"\OSBot\Data";
                if (Directory.Exists(directoryPath))
                {
                    filesMirrorJunk = Directory.GetFiles(directoryPath, "mirror_*");
                }
                else
                {
                    // Create the missing directory
                    Directory.CreateDirectory(directoryPath);

                    // Since the directory is new, it won't have any files matching the pattern
                    filesMirrorJunk = new string[0];
                }

                // Point to dataGridView
                DataGridViewRow clickedRow = kryptonDataGridViewDashboard_OSBotManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_Account"].Value?.ToString();

                // Get all the currently running Java processes with their arguments and process ID.
                var javaProcessesList = invokeMethodsPassiveMainForm.Invoke_GetJavaCommandLineArgsAndProcessId();
                int processIdToKill = -1;

                foreach (var processInfo in javaProcessesList)
                {
                    string[] splitInfo = processInfo.Split(',');
                    string args = splitInfo[0];
                    int processId = int.Parse(splitInfo[1]);

                    if (args.Contains(account))
                    {
                        processIdToKill = processId;
                        break;
                    }
                }

                if (processIdToKill == -1 && e.ColumnIndex == kryptonDataGridViewDashboard_OSBotManager.Columns["kryptonDataGridViewDashboard_OSBotManager_RunStop"].Index && e.RowIndex >= 0)
                {

                    // Initialize Variables
                    string loginInfoOSBot = "-login " + textBoxSettings_OSBotUsername.Text.ToString() + ":" + textBoxSettings_OSBotPassword.Text.ToString() + " ";
                    string lowCpu = "";
                    string lowResource = "";
                    string mirror = "";
                    string newMouse = "";
                    string noInterface = "";
                    string noRender = "";
                    string password = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_Password"].Value?.ToString();
                    string pin = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_Proxy"].Value?.ToString();
                    string sandboxie = "No";
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_SandboxieNumber"].Value?.ToString();
                    string script = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_Script"].Value?.ToString();
                    string scriptArgs = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_Args"].Value?.ToString();
                    string world = clickedRow.Cells["kryptonDataGridViewDashboard_OSBotManager_World"].Value?.ToString();

                    // Set BotCli Variable
                    botcli = "-bot " + account + ":" + password + ":" + (string.IsNullOrWhiteSpace(pin) ? "1234" : pin) + " ";

                    // Set Proxy Variable
                    proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : "-proxy " + proxy + " ";

                    // Set Script Variable
                    if (Regex.IsMatch(script, @" - \d+"))
                    {
                        script = "-script " + Regex.Replace(script, "\\D", "") + ":" + scriptArgs + " ";
                    }
                    else
                    {
                        script = "-script " + script + ":" + scriptArgs + " ";
                    }

                    // Set World Variable
                    Random rnd = new Random();

                    Dictionary<string, int[]> worldMap = new Dictionary<string, int[]>
                    {
                        { "-F2P-", new int[] { 301, 308, 316, 326, 335, 371, 380, 382, 383, 384, 394, 397, 398, 399, 417, 418, 430, 431, 433, 434, 435, 436, 437, 451, 452, 453, 454, 455, 456, 469, 470, 471, 475, 476, 483, 497, 498, 499, 500, 501, 537, 542, 543, 544, 545, 546, 547, 552, 553, 554, 555, 556, 557, 562, 563, 571, 575 } },
                        { "-P2P-", new int[] { 302, 303, 304, 305, 306, 307, 309, 310, 311, 312, 313, 314, 315, 317, 318, 319, 320, 321, 322, 323, 324, 325, 327, 328, 329, 330, 331, 332, 333, 334, 336, 337, 338, 339, 340, 341, 343, 344, 346, 347, 348, 350, 351, 352, 354, 355, 357, 358, 359, 360, 362, 367, 368, 369, 370, 374, 375, 376, 377, 378, 386, 387, 388, 389, 390, 395, 421, 422, 424, 443, 444, 445, 446, 463, 464, 465, 466, 477, 478, 480, 481, 482, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 531, 532, 533, 534, 535, 580 } }
                    };

                    world = worldMap.ContainsKey(world)
                        ? "-world " + worldMap[world][rnd.Next(worldMap[world].Length)] + " "
                        : "-world " + world + " ";

                    // Set Additional Settings Variables
                    if (kryptonListBoxDashboard_OSBotManager_AdditionalSettings.SelectedItems.Count > 0)
                    {
                        Dictionary<string, Action> additionalSettingsMap = new Dictionary<string, Action>
                        {
                            {"Low CPU", () => lowCpu = "-allow lowcpu "},
                            {"Low Resource", () => lowResource = "-allow lowresource "},
                            {"Mirror", () => mirror = "-mirror -launchgame "},
                            {"New Mouse", () => newMouse = "-newmouse "},
                            {"No Interface", () => noInterface = "-allow nointerface "},
                            {"No Render", () => noRender = "-allow norender "},
                            {"Sandboxie", () => sandboxie = "Yes"}
                        };

                        // Loop Through Dictionary & Generate Output
                        foreach (var additionalSettingsItem in kryptonListBoxDashboard_OSBotManager_AdditionalSettings.SelectedItems)
                        {
                            string selectedAdditionalSetting = additionalSettingsItem.ToString();

                            foreach (var additionalSetting in additionalSettingsMap)
                            {
                                if (selectedAdditionalSetting.Contains(additionalSetting.Key))
                                {
                                    additionalSetting.Value.Invoke();
                                }
                            }
                        }
                    }

                    // Delete Mirror Files
                    foreach (string file in filesMirrorJunk)
                    {
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(file);
                    }

                    // Delete Jagex Files
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagex_cl_oldschool_LIVE.dat");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagexappletviewer.preferences");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "random.dat");

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        // Set CliArgs Variable
                        cliArgs = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\" -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mirror + newMouse + lowCpu + lowResource + noInterface + noRender + "-closeOnInitializationError -debug 0";

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"",
                                Arguments = cliArgs,
                                UseShellExecute = false,
                                CreateNoWindow = true,
                            };

                            Process process = new Process
                            {
                                StartInfo = psi
                            };

                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliArgs);
                    }

                    ////////////////////
                    //Sandboxie Launch//
                    ////////////////////
                    if (sandboxie == "Yes")
                    {
                        //Initialize Variables
                        string folderPathSandboxieCurrent = "C:\\Sandbox\\" + Environment.UserName.ToString() + "\\" + sandboxieNumber + "\\user\\current\\";
                        string folderPathSandboxieCurrentOSBotData = "C:\\Sandbox\\" + Environment.UserName.ToString() + "\\" + sandboxieNumber + "\\user\\current\\OSBot\\Data";
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /nosbiectrl /silent /wait /box:" + sandboxieNumber + " \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\" -jar " + "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"" + " -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mirror + newMouse + lowCpu + lowResource + noInterface + noRender + "-closeOnInitializationError -debug 0";

                        // Create Sandbox If It Doesn't Exist
                        if (!enabledSandboxes.Contains(sandboxieNumber))
                        {
                            invokeMethodsActiveMainForm.Invoke_CreateSandboxFolder(sandboxieNumber, filePathSbieIni);
                            Thread.Sleep(100);
                        }

                        // Delete Sandbox Files
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\jagex_cl_oldschool_LIVE.dat");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\jagexappletviewer.preferences");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\random.dat");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrentOSBotData + "\\map.bin");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrentOSBotData + "\\map.zip");

                        // Copy Jagexcache To Sandbox
                        invokeMethodsActiveMainForm.Invoke_CopyDirectory(folderPathJagexCache, folderPathSandboxieCurrent + "\\jagexcache", "Copied jagexcache to sandboxie");
                        invokeMethodsActiveMainForm.Invoke_CopyDirectory(folderPathOSBot, folderPathSandboxieCurrent + "\\OSBot", "Copied OSBot folder to sandboxie");

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = filePathSandboxieStartExe,
                                Arguments = cliArgs,
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                UseShellExecute = false,
                            };

                            Process process = new Process
                            {
                                StartInfo = psi
                            };

                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliArgs);
                    }
                }
                else if (processIdToKill != -1 && e.ColumnIndex == kryptonDataGridViewDashboard_OSBotManager.Columns["kryptonDataGridViewDashboard_OSBotManager_RunStop"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        invokeMethodsActiveMainForm.Invoke_KillProcessAndChildren(processIdToKill);
                        Console.WriteLine($"Killed process and its children: {processIdToKill}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to kill process {processIdToKill}. Error: {ex.Message} \n\n Details: {ex.ToString()}");
                    }
                }
            }
        }

        // Btn Click - Launch OSBot
        public void btnOSBotManager_LaunchOsbot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"", arguments);
        }

        // Btn Click - Add Bot
        public void btnOSBotManager_AddAccount_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = kryptonDataGridViewDashboard_OSBotManager.Rows.Add(newRow);

            // Set Default Values
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_Account"].Value = "ACCOUNT_EMAIL";
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_Password"].Value = "PASSWORD";
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_Pin"].Value = "1234";
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_Proxy"].Value = "IP:PORT:USER:PASS";
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_Script"].Value = "Excellent Dragons - 898";
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_Args"].Value = "SCRIPT_ARGS";
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_World"].Value = "-F2P-";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            kryptonDataGridViewDashboard_OSBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_OSBotManager_SandboxieNumber"].Value = randomNumber;
        }

        // Btn Click - Delete Bot
        public void btnOSBotManager_DeleteAccount_Click(object sender, EventArgs e)
        {
            // Check if any cell is currently selected
            if (kryptonDataGridViewDashboard_OSBotManager.CurrentCell != null)
            {
                int rowIndex = kryptonDataGridViewDashboard_OSBotManager.CurrentCell.RowIndex;
                if (rowIndex >= 0) // Check if the rowIndex is valid
                {
                    kryptonDataGridViewDashboard_OSBotManager.Rows.RemoveAt(rowIndex);
                }
            }
        }

        // Btn Click - Download OSBot
        public async void btnOSBotManager_DownloadOSBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlOSBotClient, filePathApplicationOSBotJar, kryptonProgressBarGlobal, value => isDownloadingOSBotEventRunning = value, sender as KryptonButton);
        }

        // Btn Click - Save
        public void btnOSBotManager_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(kryptonDataGridViewDashboard_OSBotManager, filePathApplicationDataAccountsOSBot);
        }

        //////////////////////////////
        //End of OSBot Manager Panel//
        //////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////////
        //Start of DreamBot Manager Panel//
        ///////////////////////////////////

        // DreamBot Manager Panel - CLI Launch
        public void dataGridView_DreamBotRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < kryptonDataGridViewDashboard_DreamBotManager.Rows.Count)
            {

                // Point to dataGridView
                DataGridViewRow clickedRow = kryptonDataGridViewDashboard_DreamBotManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Account"].Value?.ToString();

                // Get all the currently running Java processes with their arguments and process ID.
                var javaProcessesList = invokeMethodsPassiveMainForm.Invoke_GetJavaCommandLineArgsAndProcessId();
                int processIdToKill = -1;

                foreach (var processInfo in javaProcessesList)
                {
                    string[] splitInfo = processInfo.Split(',');
                    string args = splitInfo[0];
                    int processId = int.Parse(splitInfo[1]);

                    if (args.Contains(account))
                    {
                        processIdToKill = processId;
                        break;
                    }
                }

                // Create Cli Args
                if (processIdToKill == -1 && e.ColumnIndex == kryptonDataGridViewDashboard_DreamBotManager.Columns["kryptonDataGridViewDashboard_DreamBotManager_RunStop"].Index && e.RowIndex >= 0)
                {

                    // Initialize Variables
                    string breaks = clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Breaks"].Value?.ToString();
                    string covert = "-no-covert ";
                    string freshStart = "-no-fresh ";
                    string layout = "-layout fixed ";
                    string loginInfoDreamBot = "-username " + textBoxSettings_DreamBotUsername.Text.ToString() + " " + "-password " + textBoxSettings_DreamBotPassword.Text.ToString() + " ";
                    string password = "-accountPassword " + clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Password"].Value?.ToString() + " ";
                    string pin = clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Proxy"].Value?.ToString();
                    string render = "-render all ";
                    string sandboxie = "No";
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_SandboxieNumber"].Value?.ToString();
                    string script = "-script " + "\"" + clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Script"].Value?.ToString() + "\"" + " ";
                    string scriptParams = clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Args"].Value?.ToString();
                    string world = "-world " + clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_World"].Value?.ToString() + " ";

                    // Initialize the mode mappings
                    var modeMappings = new Dictionary<string, string> { { "Normal - Render", "-no-covert -render all " }, { "Normal - No Render", "-no-covert -render none " }, { "Covert - Render", "-covert -render all " }, { "Covert - No Render", "-covert -render none " } };

                    // Set account variable
                    account = "-accountUsername " + clickedRow.Cells["kryptonDataGridViewDashboard_DreamBotManager_Account"].Value?.ToString() + " ";

                    // Set Pin Variable
                    pin = string.IsNullOrWhiteSpace(pin) ? "-accountPin 1234 " : "-accountPin " + pin + " ";

                    // Set Breaks Variable
                    breaks = string.IsNullOrWhiteSpace(breaks) || breaks == "BREAK_NICKNAME" ? "" : "-breaks " + breaks + " ";

                    // Set Proxy Variable
                    try
                    {
                        string[] proxyParts = proxy.Split(':');
                        proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : $"-proxyHost {proxyParts[0]} -proxyPort {proxyParts[1]} -proxyUser {proxyParts[2]} -proxyPass {proxyParts[3]} ";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error processing proxy string: " + ex.Message);
                    }

                    // Set scriptParams Variable
                    scriptParams = string.IsNullOrWhiteSpace(scriptParams) ? "" : "-params " + scriptParams + " ";

                    // Set Additional Settings Variables
                    if (kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.SelectedItems.Count > 0)
                    {
                        Dictionary<string, Action> additionalSettingsMap = new Dictionary<string, Action>
                        {
                            {"Covert", () => covert = "-covert "},
                            {"Fresh Start", () => freshStart = "-fresh "},
                            {"No Render", () => render = "-render none "},
                            {"Resizable Mode", () => layout = "-layout resizable_modern "},
                            {"Sandboxie", () => sandboxie = "Yes"}
                        };

                        // Loop Through Dictionary & Generate Output
                        foreach (var additionalSettingsItem in kryptonListBoxDashboard_DreamBotManager_AdditionalSettings.SelectedItems)
                        {
                            string selectedAdditionalSetting = additionalSettingsItem.ToString();

                            foreach (var additionalSetting in additionalSettingsMap)
                            {
                                if (selectedAdditionalSetting.Contains(additionalSetting.Key))
                                {
                                    additionalSetting.Value.Invoke();
                                }
                            }
                        }
                    }

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        //Initialize CliArgs Variable//
                        cliArgs = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\DreamBot\\BotData\\client.jar\" " + loginInfoDreamBot + account + password + pin + proxy + script + scriptParams + breaks + world + covert + freshStart + render + layout + "-fps 25";

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"",
                                Arguments = cliArgs,
                                UseShellExecute = false,
                                CreateNoWindow = true,
                            };

                            Process process = new Process
                            {
                                StartInfo = psi
                            };

                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliArgs);
                    }

                    ///////////////////////
                    //Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "Yes")
                    {
                        // Initialize Variables
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /nosbiectrl /silent /wait /box:" + sandboxieNumber + " \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\" -jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\DreamBot\\BotData\\client.jar\" " + loginInfoDreamBot + account + password + pin + proxy + script + scriptParams + breaks + world + covert + freshStart + render + layout + "-fps 25";

                        //Create Sandbox If It Doesn't Exist//
                        if (!enabledSandboxes.Contains(sandboxieNumber))
                        {
                            invokeMethodsActiveMainForm.Invoke_CreateSandboxFolder(sandboxieNumber, filePathSbieIni);
                            Thread.Sleep(100);
                        }

                        // Execute Cli Args
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = filePathSandboxieStartExe,
                            Arguments = cliArgs,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                            UseShellExecute = false,
                        };

                        try
                        {
                            Process.Start(startInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                    }
                }
                else if (processIdToKill != -1 && e.ColumnIndex == kryptonDataGridViewDashboard_DreamBotManager.Columns["kryptonDataGridViewDashboard_DreamBotManager_RunStop"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        invokeMethodsActiveMainForm.Invoke_KillProcessAndChildren(processIdToKill);
                        Console.WriteLine($"Killed process and its children: {processIdToKill}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to kill process {processIdToKill}. Error: {ex.Message} \n\n Details: {ex.ToString()}");
                    }
                }
            }
        }

        // Btn Click - Launch DreamBot
        public void btnDreamBotManager_LaunchDreamBot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\DreamBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"", arguments);
        }

        // Btn Click - Add Bot
        public void btnDreamBotManager_AddAccount_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = kryptonDataGridViewDashboard_DreamBotManager.Rows.Add(newRow);

            // Set Default Values
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Account"].Value = "ACCOUNT_EMAIL";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Password"].Value = "PASSWORD";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Pin"].Value = "1234";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Proxy"].Value = "IP:PORT:USER:PASS";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Script"].Value = "0x's Aerial Fish Catcher";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Args"].Value = "SCRIPT_ARGS";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_Breaks"].Value = "BREAK_NICKNAME";
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_World"].Value = "f2p";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            kryptonDataGridViewDashboard_DreamBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_DreamBotManager_SandboxieNumber"].Value = randomNumber;
        }

        // Btn Click - Delete Bot
        public void btnDreamBotManager_DeleteAccount_Click(object sender, EventArgs e)
        {
            // Check if any cell is currently selected
            if (kryptonDataGridViewDashboard_DreamBotManager.CurrentCell != null)
            {
                int rowIndex = kryptonDataGridViewDashboard_DreamBotManager.CurrentCell.RowIndex;
                if (rowIndex >= 0) // Check if the rowIndex is valid
                {
                    kryptonDataGridViewDashboard_DreamBotManager.Rows.RemoveAt(rowIndex);
                }
            }
        }

        // Btn Click - Download DreamBot
        public async void btnDreamBotManager_DownloadDreamBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlDreamBotClient, filePathApplicationDreamBotJar, kryptonProgressBarGlobal, value => isDownloadingDreamBotEventRunning = value, sender as KryptonButton);
        }

        // DreamBot Manager Panel - Save
        public void btnDreamBotManager_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(kryptonDataGridViewDashboard_DreamBotManager, filePathApplicationDataAccountsDreamBot);
        }

        /////////////////////////////////
        //End of DreamBot Manager Panel//
        /////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of TRiBot Manager Panel//
        /////////////////////////////////

        // Cell Btn Click - Launch CLI
        public void dataGridView_TRiBotRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < kryptonDataGridViewDashboard_TRiBotManager.Rows.Count)
            {

                // Point to dataGridView
                DataGridViewRow clickedRow = kryptonDataGridViewDashboard_TRiBotManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Account"].Value?.ToString();

                // Get all the currently running Java processes with their arguments and process ID.
                var javaProcessesList = invokeMethodsPassiveMainForm.Invoke_GetJavaCommandLineArgsAndProcessId();
                int processIdToKill = -1;

                foreach (var processInfo in javaProcessesList)
                {
                    string[] splitInfo = processInfo.Split(',');
                    string args = splitInfo[0];
                    int processId = int.Parse(splitInfo[1]);

                    if (args.Contains(account))
                    {
                        processIdToKill = processId;
                        break;
                    }
                }

                if (processIdToKill == -1 && e.ColumnIndex == kryptonDataGridViewDashboard_TRiBotManager.Columns["kryptonDataGridViewDashboard_TRiBotManager_RunStop"].Index && e.RowIndex >= 0)
                {

                    // Initialize Variables
                    string loginInfoTRiBot = "--username " + "\"" + textBoxSettings_TRiBotEmail.Text.ToString() + "\" " + "--password " + "\"" + textBoxSettings_TRiBotPassword.Text.ToString() + "\" ";
                    string breaks = clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Breaks"].Value?.ToString();
                    string password = "--charpassword " + "\"" + clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Password"].Value?.ToString() + "\" ";
                    string lookingGlass = "";
                    string pin = clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Proxy"].Value?.ToString();
                    string sandboxie = "No";
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_SandboxieNumber"].Value?.ToString();
                    string script = "--script \"" + clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Script"].Value?.ToString() + "\" ";
                    string scriptArgs = "--scriptargs " + "\"" + clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Args"].Value?.ToString() + "\" ";
                    string world = clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_World"].Value?.ToString();

                    // Set account variable
                    account = "--charusername \"" + clickedRow.Cells["kryptonDataGridViewDashboard_TRiBotManager_Account"].Value?.ToString() + "\" ";

                    // Set pin variable
                    pin = string.IsNullOrWhiteSpace(pin) ? "" : "--charpin \"" + pin + "\" ";

                    // Set break profile variable
                    breaks = string.IsNullOrWhiteSpace(breaks) ? "" : "--breakprofile \"" + breaks + "\" ";

                    // Set Proxy Variable
                    try
                    {
                        string[] proxyParts = proxy.Split(':');
                        proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : $"--proxyhost {proxyParts[0]} --proxyport {proxyParts[1]} --proxyusername {proxyParts[2]} --proxypassword {proxyParts[3]} ";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error processing proxy string: " + ex.Message);
                    }

                    // Set World Variable
                    Random rnd = new Random();

                    Dictionary<string, int[]> worldMap = new Dictionary<string, int[]>
                    {
                        { "-F2P-", new int[] { 301, 308, 316, 326, 335, 371, 380, 382, 383, 384, 394, 397, 398, 399, 417, 418, 430, 431, 433, 434, 435, 436, 437, 451, 452, 453, 454, 455, 456, 469, 470, 471, 475, 476, 483, 497, 498, 499, 500, 501, 537, 542, 543, 544, 545, 546, 547, 552, 553, 554, 555, 556, 557, 562, 563, 571, 575 } },
                        { "-P2P-", new int[] { 302, 303, 304, 305, 306, 307, 309, 310, 311, 312, 313, 314, 315, 317, 318, 319, 320, 321, 322, 323, 324, 325, 327, 328, 329, 330, 331, 332, 333, 334, 336, 337, 338, 339, 340, 341, 343, 344, 346, 347, 348, 350, 351, 352, 354, 355, 357, 358, 359, 360, 362, 367, 368, 369, 370, 374, 375, 376, 377, 378, 386, 387, 388, 389, 390, 395, 421, 422, 424, 443, 444, 445, 446, 463, 464, 465, 466, 477, 478, 480, 481, 482, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 531, 532, 533, 534, 535, 580 } }
                    };

                    world = worldMap.ContainsKey(world)
                        ? "--charworld  \"" + worldMap[world][rnd.Next(worldMap[world].Length)] + "\" "
                        : "--charworld  \"" + world + "\" ";

                    // Set Additional Settings Variables
                    if (kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.SelectedItems.Count > 0)
                    {
                        Dictionary<string, Action> additionalSettingsMap = new Dictionary<string, Action>
                        {
                            {"Looking Glass", () => lookingGlass = "--lgdelay 10 --lgpath \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\RuneLite.jar\" "},
                            {"Sandboxie", () => sandboxie = "Yes"}
                        };

                        // Loop Through Dictionary & Generate Output
                        foreach (var additionalSettingsItem in kryptonListBoxDashboard_TRiBotManager_AdditionalSettings.SelectedItems)
                        {
                            string selectedAdditionalSetting = additionalSettingsItem.ToString();

                            foreach (var additionalSetting in additionalSettingsMap)
                            {
                                if (selectedAdditionalSetting.Contains(additionalSetting.Key))
                                {
                                    additionalSetting.Value.Invoke();
                                }
                            }
                        }
                    }

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        // Set CliArgs Variable
                        cliArgs = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar\" " + loginInfoTRiBot + account + password + pin + proxy + script + scriptArgs + breaks + world + lookingGlass;

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe",
                                Arguments = cliArgs,
                                UseShellExecute = false,
                                CreateNoWindow = true,
                            };

                            Process process = new Process
                            {
                                StartInfo = psi
                            };

                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliArgs);
                    }


                    ////////////////////
                    //Sandboxie Launch//
                    ////////////////////
                    if (sandboxie == "Yes")
                    {
                        // Initialize Variables
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /box:" + sandboxieNumber + " \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\" -jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar\" " + loginInfoTRiBot + account + password + pin + proxy + script + scriptArgs + breaks + world + lookingGlass;

                        // Create Sandbox If It Doesn't Exist
                        if (!enabledSandboxes.Contains(sandboxieNumber))
                        {
                            invokeMethodsActiveMainForm.Invoke_CreateSandboxFolder(sandboxieNumber, filePathSbieIni);
                            Thread.Sleep(100);
                        }

                        // Execute Cli Args
                        ProcessStartInfo startInfo = new ProcessStartInfo
                        {
                            FileName = filePathSandboxieStartExe,
                            Arguments = cliArgs,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                            UseShellExecute = false,
                        };

                        try
                        {
                            Process.Start(startInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error running command: " + ex.Message);
                        }
                        Console.WriteLine("Sandboxie CLI Args: " + cliCommand + cliArgs);
                    }
                }
                else if (processIdToKill != -1 && e.ColumnIndex == kryptonDataGridViewDashboard_TRiBotManager.Columns["kryptonDataGridViewDashboard_TRiBotManager_RunStop"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        invokeMethodsActiveMainForm.Invoke_KillProcessAndChildren(processIdToKill);
                        Console.WriteLine($"Killed process and its children: {processIdToKill}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to kill process {processIdToKill}. Error: {ex.Message} \n\n Details: {ex.ToString()}");
                    }
                }
            }
        }

        // Btn Click - Launch TRiBot
        public void btnTRiBotManager_LaunchTRiBot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\java\\bin\\javaw.exe\"", arguments);
        }

        // Btn Click - Add Bot
        public void btnTRiBotManager_AddAccount_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = kryptonDataGridViewDashboard_TRiBotManager.Rows.Add(newRow);

            // Set default values
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Account"].Value = "ACCOUNT_EMAIL";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Password"].Value = "PASSWORD";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Pin"].Value = "1234";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Proxy"].Value = "IP:PORT:USER:PASS";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Script"].Value = "aAgility AIO";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Args"].Value = "SCRIPT_ARGS";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_Breaks"].Value = "BREAK_NAME";
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_World"].Value = "-F2P-";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            kryptonDataGridViewDashboard_TRiBotManager.Rows[rowIndex].Cells["kryptonDataGridViewDashboard_TRiBotManager_SandboxieNumber"].Value = randomNumber;
        }

        // Btn Click - Delete Bot
        public void btnTRiBotManager_DeleteAccount_Click(object sender, EventArgs e)
        {
            // Check if any cell is currently selected
            if (kryptonDataGridViewDashboard_TRiBotManager.CurrentCell != null)
            {
                int rowIndex = kryptonDataGridViewDashboard_TRiBotManager.CurrentCell.RowIndex;
                if (rowIndex >= 0) // Check if the rowIndex is valid
                {
                    kryptonDataGridViewDashboard_TRiBotManager.Rows.RemoveAt(rowIndex);
                }
            }
        }

        //Btn Click - Download TRiBot
        public async void btnTRiBotManager_DownloadTRiBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlTRiBotClient, filePathApplicationTRiBotJar, kryptonProgressBarGlobal, value => isDownloadingTRiBotEventRunning = value, sender as KryptonButton);
        }

        // DreamBot Manager Panel - Save
        public void btnTRiBotManager_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(kryptonDataGridViewDashboard_TRiBotManager, filePathApplicationDataAccountsTRiBot);
        }

        ///////////////////////////////
        //End of TRiBot Manager Panel//
        ///////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of Break Profiles Panel//
        /////////////////////////////////

        // Btn Click - Save Break Profile
        public void btnBreakProfiles_Save_Click(object sender, EventArgs e)
        {

            // Initialize Variables
            string filePathScriptFactoryProfiles = Path.Combine(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\" + comboBoxBreakProfiles_SelectBreakFilename.SelectedItem.ToString());
            string breakFileEnableBreaks = "<Find>boolEnableBreaks:true</Find><Replace>boolEnableBreaks:false</Replace>";
            string breakFileEnableSleepBreaks = "<Find>boolEnableSleepBreaks:false</Find><Replace>boolEnableSleepBreaks:false</Replace>";
            string botTime;
            string botTimeVariation;
            string breakTime;
            string breakTimeVariation = textBoxBreakProfiles_BreakTimeVariation.Text;
            string timeUntilSleep;
            string timeUntilSleepVariation;
            string sleepTime;
            string sleepTimeVariation = textBoxBreakProfiles_SleepTimeVariation.Text;
            int intBotTime;
            int intBotTimeVariation;
            int intBreakTime;
            int intTimeUntilSleep;
            int intTimeUntilSleepVariation;
            int intSleepTime;

            // Set EnableBreaks Variable
            if (checkBoxBreakProfiles_EnableBreaks.Checked)
            {
                breakFileEnableBreaks = "<Find>boolEnableBreaks:true</Find><Replace>boolEnableBreaks:true</Replace>";
            }

            // Set EnableSleepBreaks Variable
            if (checkBoxBreakProfiles_EnableSleepBreaks.Checked)
            {
                breakFileEnableSleepBreaks = "<Find>boolEnableSleepBreaks:false</Find><Replace>boolEnableSleepBreaks:true</Replace>";
            }

            // Convert Minutes to Miliseconds & Set BotTime Variable
            int.TryParse(textBoxBreakProfiles_BotTime.Text, out int intBotTimeMs);
            {
                intBotTime = intBotTimeMs * 60000;
                botTime = intBotTime.ToString();
            }

            // Convert Minutes to Miliseconds & Set BotTimeVariation Variable
            int.TryParse(textBoxBreakProfiles_BotTimeVariation.Text, out int intBotTimeVariationMs);
            {
                intBotTimeVariation = intBotTimeVariationMs * 60000;
                botTimeVariation = intBotTimeVariation.ToString();
            }

            // Convert Minutes to Miliseconds & Set BreakTime Variable
            int.TryParse(textBoxBreakProfiles_BreakTime.Text, out int intBreakTimeMs);
            {
                intBreakTime = intBreakTimeMs * 60000;
                breakTime = intBreakTime.ToString();
            }

            // Convert Minutes to Miliseconds & Set TimeUntilSleep Variable
            int.TryParse(textBoxBreakProfiles_TimeUntilSleep.Text, out int intTimeUntilSleepMs);
            {
                intTimeUntilSleep = intTimeUntilSleepMs * 60000;
                timeUntilSleep = intTimeUntilSleep.ToString();
            }

            // Convert Minutes to Miliseconds & Set TimeUntilSleepVariation Variable
            int.TryParse(textBoxBreakProfiles_TimeUntilSleepVariation.Text, out int intTimeUntilSleepVariationMs);
            {
                intTimeUntilSleepVariation = intTimeUntilSleepVariationMs * 60000;
                timeUntilSleepVariation = intTimeUntilSleepVariation.ToString();
            }

            // Convert Minutes to Miliseconds & Set SleepTime Variable
            int.TryParse(textBoxBreakProfiles_SleepTime.Text, out int intSleepTimeMs);
            {
                intSleepTime = intSleepTimeMs * 60000;
                sleepTime = intSleepTime.ToString();
            }

            // Write To File
            using (StreamWriter writer = new StreamWriter(filePathScriptFactoryProfiles))
            {
                writer.WriteLine(breakFileEnableBreaks);
                writer.WriteLine(breakFileEnableSleepBreaks);
                writer.WriteLine("<Find>3600000,true,1800000,true</Find><Replace>" + botTime + ",true," + botTimeVariation + ",true</Replace>");
                writer.WriteLine("<Find>1200000:0.75</Find><Replace>" + breakTime + ":0." + breakTimeVariation + "</Replace>");
                writer.WriteLine("<Find>32400000,true,7200000,false</Find><Replace>" + timeUntilSleep + ",true," + timeUntilSleepVariation + ",false</Replace>");
                writer.WriteLine("<Find>19200000:0.25</Find><Replace>" + sleepTime + ":0." + sleepTimeVariation + "</Replace>");
            }
            MessageBox.Show("Break profile successfully created.");
        }

        ///////////////////////////////
        //End of Break Profiles Panel//
        ///////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////////////
        //Start of Script Profiles Panel//
        //////////////////////////////////

        // Change Commited - Open Script Profile Forms
        public void comboBoxScriptProfiles_SelectScript_ChangeCommited(object sender, EventArgs e)
        {
            // Mapping between file names and their respective form classes
            Dictionary<string, Type> formMappings = new Dictionary<string, Type>
            {
                {"fxAccountBuilder.txt", typeof(formScriptProfilesAccountBuilder)},
                {"fxAccountBuilder-MasterFarmer.txt", typeof(formScriptProfilesAccountBuilderMasterFarmer)},
                {"fxAgility-Rooftops.txt", typeof(formScriptProfilesAgilityRooftops)},
                {"fxCooking-RangeAndFire.txt", typeof(formScriptProfilesCookingRangeAndFire)},
                {"fxFarming-TitheFarm.txt", typeof(formScriptProfilesFarmingTitheFarm)},
                {"fxFighter-DustDevils.txt", typeof(formScriptProfilesFighterDustDevils)},
                {"fxFighter-ElderChaosDruids.txt", typeof(formScriptProfilesFighterElderChaosDruids)},
                {"fxFighter-Kurasks.txt", typeof(formScriptProfilesFighterKurasks)},
                {"fxFighter-Vyres.txt", typeof(formScriptProfilesFighterVyres)},
                {"fxFiremaking-GrandExchange.txt", typeof(formScriptProfilesFiremakingGrandExchange)},
                {"fxFletching-Longbows.txt", typeof(formScriptProfilesFletchingLongbows)},
                {"fxGeneric.txt", typeof(formScriptProfilesGeneric)},
                {"fxHerblore-CleanHerbs.txt", typeof(formScriptProfilesHerbloreCleanHerbs)},
                {"fxLOTR-Aragorn.txt", typeof(formScriptProfilesLOTRAragorn)},
                {"fxLOTR-Gandalf.txt", typeof(formScriptProfilesLOTRGandalf)},
                {"fxMagic-HouseAlcher.txt", typeof(formScriptProfilesMagicHouseAlcher)},
                {"fxMagic-Orber.txt", typeof(formScriptProfilesMagicOrber)},
                {"fxMiniGames-RoguesDen.txt", typeof(formScriptProfilesMiniGamesRoguesDen)},
                {"fxMining-AIO.txt", typeof(formScriptProfilesMiningAIO)},
                {"fxMining-MotherlodeMine.txt", typeof(formScriptProfilesMiningMotherlodeMine)},
                {"fxMuler.txt", typeof(formScriptProfilesMuler)},
                {"fxPrayer-GildedAltar.txt", typeof(formScriptProfilesPrayerGildedAltar)},
                {"fxProgressiveFighter-Magic.txt", typeof(formScriptProfilesProgressiveFighterMagic)},
                {"fxProgressiveFighter-Ranged.txt", typeof(formScriptProfilesProgressiveFighterRanged)},
                {"fxRunecrafting-Abyss.txt", typeof(formScriptProfilesRunecraftingAbyss)},
                {"fxRunecrafting-Zeah.txt", typeof(formScriptProfilesRunecraftingZeah)},
                {"fxSlayer-AIO.txt", typeof(formScriptProfilesSlayerAIO)},
                {"fxThieving-MasterFarmers.txt", typeof(formScriptProfilesThievingMasterFarmers)},
                {"fxThieving-Pickpocket.txt", typeof(formScriptProfilesThievingPickpocket)},
                {"fxThieving-Vyres.txt", typeof(formScriptProfilesThievingVyres)},
                {"fxTutorial.txt", typeof(formScriptProfilesTutorial)}
            };

            string currentSelectedScriptProfileItem = comboBoxScriptProfiles_SelectScript.SelectedItem.ToString();

            if (formMappings.TryGetValue(currentSelectedScriptProfileItem, out Type formType) &&
                !Application.OpenForms.OfType<Form>().Any(form => form.GetType() == formType))
            {
                Form formScriptProfileFormInstance = (Form)Activator.CreateInstance(formType, this); // Pass 'this' as an argument
                formScriptProfileFormInstance.Show();
            }
        }

        ////////////////////////////////
        //End of Script Profiles Panel//
        ////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////
        //Start of Settings Panel//
        ///////////////////////////

        // Btn Click - Check For Updates
        public async void btnSettings_CheckForUpdates_Click(object sender, EventArgs e)
        {
            await Invoke_CheckForUpdates(urlLatestApplicationVersion, filePathApplicationMainMiscVersion, filePathApplicationMainUpdaterExe);
        }

        // Btn Click - Create OSRS Account
        public void btnSettings_CreateOSRSAccount_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://secure.runescape.com/m=account-creation/create_account");
        }

        // Btn Click - Install Sandboxie
        public async void btnSettings_InstallSandboxie_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadAndInstallFileProgerssBarDisableButton(urlSandboxiePlus, filePathJivaroTempSandboxiePlus, kryptonProgressBarGlobal, value => isDownloadingSandboxiePlusEventRunning = value, sender as KryptonButton);
        }

        // Btn Click - Install Proxifier
        public async void btnSettings_InstallProxifier_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadAndInstallFileProgerssBarDisableButton(urlProxifier, filePathJivaroTempProxifier, kryptonProgressBarGlobal, value => isDownloadingProxifierEventRunning = value, sender as KryptonButton);
        }

        // Btn Click - Download Java
        public async void btnScriptFactory_DownloadJava_Click(object sender, EventArgs e)
        {
            // Check If Event is Running
            if (isDownloadingJavaRuntimeEnvironmentEventRunning)
            {
                MessageBox.Show("The process is already running. Please wait.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set Flag & Disable Button
            isDownloadingJavaRuntimeEnvironmentEventRunning = true;
            (sender as KryptonButton).Enabled = false;

            // Initiate Progress Bar
            kryptonProgressBarGlobal.Visible = true;
            kryptonProgressBarGlobal.BringToFront();
            kryptonProgressBarGlobal.Value = 0;

            // Delete Folders
            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempJava);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempJavaZip);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathJivaroTempJavaZip);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathApplicationMainJava);
            kryptonProgressBarGlobal.PerformStep();

            // Zip File Handler
            try
            {
                // Download the .zip file
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(urlJavaRuntimeEnvironment);
                    using (FileStream fs = new FileStream(folderPathJivaroTempJavaZip, FileMode.Create))
                    {
                        await response.Content.CopyToAsync(fs);
                    }
                }
                kryptonProgressBarGlobal.PerformStep();

                // Unzip
                ZipFile.ExtractToDirectory(folderPathJivaroTempJavaZip, folderPathJivaroTempJava);
                kryptonProgressBarGlobal.PerformStep();

                // Move the Unzipped Folder
                Directory.Move(Path.Combine(folderPathJivaroTempJava), folderPathApplicationMainJava);
                kryptonProgressBarGlobal.PerformStep();
            }
            catch (DirectoryNotFoundException dirEx)
            {
                MessageBox.Show($"Error: {dirEx.Message}. Please ensure that the directory structure in the zip file matches expectations.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cleanup
            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempJava);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathJivaroTempJavaZip);
            kryptonProgressBarGlobal.PerformStep();

            //Hide The Progress Bar//
            kryptonProgressBarGlobal.Value = 0;
            kryptonProgressBarGlobal.Visible = false;

            //Reset Flag & Re-Enable Button//
            isDownloadingJavaRuntimeEnvironmentEventRunning = false;
            (sender as KryptonButton).Enabled = true;
        }

        // Btn Click - Join Jivaro's Discor
        public void btnSettings_JoinDiscord_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://discord.gg/FSzuW4mR4M");
        }

        // Btn Click - Kill All Bots
        public void btnSettings_KillAllBots_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_KillAllBots(sender, e);
        }

        // Btn Click - Open Jivaro's Website
        public void btnSettings_VisitWebsite_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://www.jivaro.net/");
        }

        // Btn Click - Open Botting Guide's Webpage
        public void btnSettings_BottingGuide_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://www.jivaro.net/media/guides/the-ultimate-guide-to-botting-old-school-runescape");
        }

        // Btn Click - Open Buy Proxies' Webpage
        public void btnSettings_BuyProxies_Click(object sender, EventArgs e)
        {
            // Check if ProxyChoiceForm is already open
            if (!Application.OpenForms.OfType<formProxyChoice>().Any())
            {
                formProxyChoice proxyChoice = new formProxyChoice(this);
                proxyChoice.ShowDialog();
            }
        }

        // Btn Click - Open Setup Guide
        public void btnSettings_SetupGuide_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://jivaro.net/osrs-botting/set-up-guide");
        }

        // Btn Click - Save Login Info
        public void btnSettings_SaveLoginInfo_Click(object sender, EventArgs e)
        {

            // Initialize Variables
            string showWelcomeScreen = "welcome_screen=true";
            string showCpuRamUsage = "hardware_usage=true";

            if (!checkBoxSettings_ShowWelcomeScreen.Checked)
            {
                showWelcomeScreen = "welcome_screen=false";
            }

            if (!checkBoxSettings_ShowCpuAndRamUsage.Checked)
            {
                showCpuRamUsage = "hardware_usage=false";
            }

            using (StreamWriter writer = new StreamWriter(filePathApplicationDataAccountsSettingsIni))
            {
                writer.WriteLine("osbot_username=" + textBoxSettings_OSBotUsername.Text);
                writer.WriteLine("osbot_password=" + textBoxSettings_OSBotPassword.Text);
                writer.WriteLine("dreambot_username=" + textBoxSettings_DreamBotUsername.Text);
                writer.WriteLine("dreambot_password=" + textBoxSettings_DreamBotPassword.Text);
                writer.WriteLine("tribot_email=" + textBoxSettings_TRiBotEmail.Text);
                writer.WriteLine("tribot_password=" + textBoxSettings_TRiBotPassword.Text);
                writer.WriteLine("");
                writer.WriteLine(showWelcomeScreen);
                writer.WriteLine(showCpuRamUsage);
            }

            // Handle CPU and RAM Usage Controls
            if (checkBoxSettings_ShowCpuAndRamUsage.Checked)
            {
                try
                {
                    labelNav_CpuUsageMonitor.Visible = true;
                    labelNav_RamUsageMonitor.Visible = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (!checkBoxSettings_ShowCpuAndRamUsage.Checked)
            {
                try
                {
                    labelNav_CpuUsageMonitor.Visible = false;
                    labelNav_RamUsageMonitor.Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MessageBox.Show("Settings Saved Successfully.");
        }

        // Btn Click - Update Scripts
        public async void btnScriptFactory_UpdateScripts_Click(object sender, EventArgs e)
        {
            // Check If Event is Running
            if (isUpdatingScriptsEventRunning)
            {
                MessageBox.Show("The process is already running. Please wait.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set Flag & Disable Button
            isUpdatingScriptsEventRunning = true;
            (sender as KryptonButton).Enabled = false;

            // Initiate Progress Bar
            kryptonProgressBarGlobal.Visible = true;
            kryptonProgressBarGlobal.BringToFront();
            kryptonProgressBarGlobal.Value = 0;

            // Delete Folders
            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathScriptFactoryPrivateScriptsFushigiBot);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempFushigiBot);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempFushigiBotZip);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathJivaroTempFushigiBotZip);
            kryptonProgressBarGlobal.PerformStep();

            // Zip File Handler
            try
            {
                // Download the .zip file
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(urlFushigiBotScripts);
                    using (FileStream fs = new FileStream(folderPathJivaroTempFushigiBotZip, FileMode.Create))
                    {
                        await response.Content.CopyToAsync(fs);
                    }
                }
                kryptonProgressBarGlobal.PerformStep();

                // Unzip
                ZipFile.ExtractToDirectory(folderPathJivaroTempFushigiBotZip, folderPathJivaroTempFushigiBot);
                kryptonProgressBarGlobal.PerformStep();

                // Move the Unzipped Folder
                Directory.Move(Path.Combine(folderPathJivaroTempFushigiBot), folderPathScriptFactoryPrivateScriptsFushigiBot);
                kryptonProgressBarGlobal.PerformStep();
            }
            catch (DirectoryNotFoundException dirEx)
            {
                MessageBox.Show($"Error: {dirEx.Message}. Please ensure that the directory structure in the zip file matches expectations.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cleanup
            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempFushigiBot);
            kryptonProgressBarGlobal.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathJivaroTempFushigiBotZip);
            kryptonProgressBarGlobal.PerformStep();

            // Hide The Progress Bar
            kryptonProgressBarGlobal.Value = 0;
            kryptonProgressBarGlobal.Visible = false;

            // Reset Flag & Re-Enable Button
            isUpdatingScriptsEventRunning = false;
            (sender as KryptonButton).Enabled = true;
        }

        //////////////////////////////////////
        //End of Accounts and Settings Panel//
        //////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////
        //Start of Invoke Methods//
        ///////////////////////////

        // Invoke - Bring Nav Controls to Front
        public void Invoke_BringNavControlsToFront(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(labelNav_Jivaro);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(labelNav_OSRSLauncher);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(labelNav_ByFushigiBot);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(buttonNav_JivaroLogo);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(kryptonButtonNav_Dashboard);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(kryptonButtonNav_ScriptProfiles);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(kryptonButtonNav_BreakProfiles);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(kryptonButtonNav_Settings);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(labelNav_CpuUsageMonitor);
            invokeMethodsActiveGlobal.Invoke_BringControlToFront(labelNav_RamUsageMonitor);
        }

        // Invoke - Check For Updates
        public async Task Invoke_CheckForUpdates(string urlLatestApplicationVersion, string filePathApplicationMainMiscVersion, string filePathApplicationMainUpdaterExe)
        {
            try
            {
                // Fetch the latest version from the URL
                var httpClient = new HttpClient();
                var latestVersionString = await httpClient.GetStringAsync(urlLatestApplicationVersion);
                decimal latestVersion = decimal.Parse(latestVersionString.Trim());

                // Read the local version from the file
                string localVersionString = File.ReadAllText(filePathApplicationMainMiscVersion);
                decimal localVersion = decimal.Parse(localVersionString.Trim());

                // Compare versions
                if (latestVersion > localVersion)
                {
                    // Prompt for update
                    var result = MessageBox.Show("There is a new update. Would you like to update?", "Update Available", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Ensure file copy is complete before updating
                        await invokeMethodsActiveMainForm.Invoke_CopyFileToDirectory(filePathApplicationMainUpdaterExe, folderPathJivaroTempBotManager, "File copied successfully.");
                        Invoke_UpdateApplication(filePathJivaroTempBotManagerUpdaterExe);
                    }
                }
                else
                {
                    MessageBox.Show("You have the latest version.", "No Update Required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking for updates: {ex.Message}", "Error");
            }
        }

        // Invoke - Generate Unique Random Number Not In Use Across DataGridViews
        public int Invoke_GenerateUniqueRandomNumber()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, 10001);  // Changed to generate numbers up to 10,000
            } while (Invoke_IsRandomNumberInUse(randomNumber));

            return randomNumber;
        }

        // Invoke - Check If Random Number is Being Used in Various DataGridViews
        public bool Invoke_IsRandomNumberInUse(int number)
        {
            return IsNumberInDataGridView(kryptonDataGridViewDashboard_ScriptFactoryManager, "kryptonDataGridViewDashboard_ScriptFactory_SandboxieNumber", number) ||
                   IsNumberInDataGridView(kryptonDataGridViewDashboard_OSBotManager, "kryptonDataGridViewDashboard_OSBotManager_SandboxieNumber", number) ||
                   IsNumberInDataGridView(kryptonDataGridViewDashboard_DreamBotManager, "kryptonDataGridViewDashboard_DreamBotManager_SandboxieNumber", number) ||
                   IsNumberInDataGridView(kryptonDataGridViewDashboard_TRiBotManager, "kryptonDataGridViewDashboard_TRiBotManager_SandboxieNumber", number);
        }

        public bool IsNumberInDataGridView(DataGridView dgv, string columnName, int number)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() == number.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        // Invoke - Navigate To Panel
        public void Invoke_NavigateToPanel(Panel targetPanel, ProgressBar targetProgressBar = null)
        {
            this.SuspendLayout();

            targetPanel.BringToFront();

            if (targetProgressBar != null)
            {
                targetProgressBar.BringToFront();
            }

            this.ResumeLayout(true);
        }

        // Invoke - Download File With Progress Bar and Button Disabling
        public async Task Invoke_DownloadFileProgerssBarDisableButton(string downloadLink, string filePath, KryptonProgressBar progressBar, Action<bool> setEventRunningFlagAction, KryptonButton senderButton)
        {
            // Check If Event is Running
            if (setEventRunningFlagAction.Target is bool isEventRunningFlag && isEventRunningFlag)
            {
                MessageBox.Show("The process is already running. Please wait.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set Flag & Disable Button
            setEventRunningFlagAction(true);
            senderButton.Enabled = false;

            // Initiate Progress Bar
            progressBar.Visible = true;
            progressBar.BringToFront();
            progressBar.Value = 0;

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
                var response = await httpClient.GetAsync(downloadLink, HttpCompletionOption.ResponseHeadersRead);

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        //Check if the File is in Use//
                        using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                        {
                            //Close if in Use//
                            stream.Close();
                        }

                        var totalBytes = response.Content.Headers.ContentLength ?? 0;
                        using (var contentStream = await response.Content.ReadAsStreamAsync())
                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            var totalReadBytes = 0L;
                            var buffer = new byte[8192];
                            var bytesRead = 0;

                            while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                            {
                                await fs.WriteAsync(buffer, 0, bytesRead);
                                totalReadBytes += bytesRead;

                                var progressPercentage = (int)((totalReadBytes * 100L) / totalBytes);

                                this.Invoke(() =>
                                {
                                    progressBar.Value = progressPercentage;
                                });
                            }
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("The file is currently in use. Please close any applications that might be using it and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to download the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Hide Progress Bar
            progressBar.Visible = false;

            // Reset Flag & Re-Enable Button
            setEventRunningFlagAction(false);
            senderButton.Enabled = true;
        }

        // Invoke - Download & Install File With Progress Bar and Button Disabling
        public async Task Invoke_DownloadAndInstallFileProgerssBarDisableButton(string downloadLink, string filePath, KryptonProgressBar progressBar, Action<bool> setEventRunningFlagAction, KryptonButton senderButton)
        {
            // Check If Event is Running
            if (setEventRunningFlagAction.Target is bool isEventRunningFlag && isEventRunningFlag)
            {
                MessageBox.Show("The process is already running. Please wait.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set Flag & Disable Button
            setEventRunningFlagAction(true);
            senderButton.Enabled = false;

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(downloadLink, HttpCompletionOption.ResponseHeadersRead))
                    {
                        var contentStream = await response.Content.ReadAsStreamAsync();
                        var totalBytes = response.Content.Headers.ContentLength.HasValue ? response.Content.Headers.ContentLength.Value : -1L;

                        // Initiate Progress Bar
                        progressBar.Visible = true;
                        progressBar.BringToFront();
                        progressBar.Value = 0;

                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            var totalReadBytes = 0L;
                            var buffer = new byte[8192];
                            var bytesRead = 0;

                            while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                            {
                                await fs.WriteAsync(buffer, 0, bytesRead);
                                totalReadBytes += bytesRead;

                                var progressPercentage = (int)((totalReadBytes * 100L) / totalBytes);

                                this.Invoke(() =>
                                {
                                    progressBar.Value = progressPercentage;
                                });
                            }
                        }
                    }
                }

                // Hide Progress Bar
                progressBar.Visible = false;

                // Execute the file
                Process.Start(filePath);

                // Wait for the process to finish
                var processName = Path.GetFileNameWithoutExtension(filePath);
                while (Process.GetProcessesByName(processName).Length > 0)
                {
                    await Task.Delay(500); // Wait half a second before checking again
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset Flag & Re-Enable Button
                setEventRunningFlagAction(false);
                senderButton.Enabled = true;
            }
        }

        // Invoke - Update Application
        public static void Invoke_UpdateApplication(string updaterExePath)
        {
            try
            {
                Process.Start(updaterExePath);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error launching updater: {ex.Message}", "Error");
            }
        }

        // Invoke - Populate ComboBox in DataGridView
        public async Task Invoke_PopulateComboBoxColumn(DataGridView dataGridView, string comboBoxColumnName, string onlineFileUrl, string localFilePath)
        {
            try
            {
                // Fetch data from online text file
                var onlineScripts = await FetchScripts(onlineFileUrl);  // Await the async method

                // Fetch data from local text file
                var localScripts = FetchScripts(localFilePath).Result;  // Use .Result to get the result from the Task

                // Combine lists and populate DataGridViewComboBoxColumn
                var combinedScripts = onlineScripts.Concat(localScripts).ToList();

                if (dataGridView.Columns[comboBoxColumnName] is DataGridViewComboBoxColumn comboBoxColumn)
                {
                    comboBoxColumn.Items.Clear();
                    foreach (var script in combinedScripts)
                    {
                        comboBoxColumn.Items.Add(script);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task<List<string>> FetchScripts(string fileUrl)
        {
            if (fileUrl.StartsWith("http"))
            {
                // Fetch from online source
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(fileUrl);
                    return response.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }
            else
            {
                // Fetch from local file
                if (File.Exists(fileUrl))
                {
                    return File.ReadAllLines(fileUrl).ToList();
                }
            }
            return new List<string>();
        }

        // Invoke - Open Form and Pass Instance
        public void Invoke_OpenUniqueForm<T>(Func<formMainForm, T> formInitializer) where T : Form
        {
            // Check if the form is already open
            if (!Application.OpenForms.OfType<T>().Any())
            {
                T formInstance = formInitializer(this);
                formInstance.Show();
            }
        }

        /////////////////////////
        //End of Invoke Methods//
        /////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////
        //Start Of Shared Methods//
        ///////////////////////////

        // Btn Click - Open Import Accounts Form
        public void btnShared_OpenImportAccounts_Click(object sender, EventArgs e)
        {
            Invoke_OpenUniqueForm(parentForm => new formImportAccounts(parentForm));
        }

        // Btn Click - Open Local Scripts Form
        public void btnShared_OpenLocalScripts_Click(object sender, EventArgs e)
        {
            Invoke_OpenUniqueForm(parentForm => new formLocalScripts(parentForm));
        }

        /////////////////////////
        //End Of Shared Methods//
        /////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////
        //Start of Object Params//
        //////////////////////////

        // Cancel Non Numbers From Textbox
        public void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_KeyPress(sender, e);
        }

        // Cancel Non Numbers & Set Limit To 99 From Textbox
        public void GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(object sender, KeyPressEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(sender, e);
        }

        // Require Input On Textbox
        public void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            invokeMethodsPassiveGlobal.GlobalMethod_RequireInput_Validating(sender, e);
        }

        ////////////////////////
        //End of Object Params//
        ////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////////
        //Start of Graphical Methods//
        //////////////////////////////

        // Invoke - Enable Krypton Button
        public static void Invoke_EnableKryptonButton(Form form, string buttonName)
        {
            // Search for the control within the form
            Control[] controls = form.Controls.Find(buttonName, true);

            if (controls.Length > 0 && controls[0] is KryptonButton button)
            {
                button.Enabled = true;
            }
            else
            {
                // Handle the case where the button is not found
                Console.WriteLine($"Button with name '{buttonName}' not found on the form.");
            }
        }

        // Invoke - Disable Krypton Button
        public void Invoke_DisableKryptonButton(Form form, string buttonName)
        {
            // Search for the control within the form
            Control[] controls = form.Controls.Find(buttonName, true);

            if (controls.Length > 0 && controls[0] is KryptonButton button)
            {
                button.Enabled = false;
            }
            else
            {
                // Handle the case where the button is not found
                Console.WriteLine($"Button with name '{buttonName}' not found on the form.");
            }
        }

        ////////////////////////////
        //End of Graphical Methods//
        ////////////////////////////
    }
}
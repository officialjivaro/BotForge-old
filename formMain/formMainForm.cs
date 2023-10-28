using Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous;
using Jivaro_Old_School_RuneScape_Bot_Manager.formScriptProfiles;
using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;
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
        public string filePathApplicationDataAccountsTRiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Accounts_TRiBot";
        public string filePathApplicationDataLocalScriptsDreamBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_DreamBot";
        public string filePathApplicationDataLocalScriptsOSBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_OSBot";
        public string filePathApplicationDataLocalScriptsScriptFactory = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_ScriptFactory";
        public string filePathApplicationDataLocalScriptsTRiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\LocalScripts_TRiBot";
        public string filePathApplicationDataLoginInfoClients = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\Login_Info_Clients";
        public string filePathApplicationDreamBotJar = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\DreamBot.jar";
        public string filePathApplicationMainMiscVersion = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\misc\\version.txt";
        public string filePathApplicationMainUpdaterExe = Path.Combine("updater.exe");
        public string filePathApplicationOSBotJar = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar";
        public string filePathApplicationTRiBotJar = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar";
        public string filePathJivaroTempJavaRuntimeEnvironment = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\JavaRuntimeEnvironment.exe";
        public string filePathJivaroTempProxifier = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\Proxifier.exe";
        public string filePathJivaroTempSandboxiePlus = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\Sandboxie-Plus.exe";
        public string filePathSandboxieIni = @"C:\\Windows\\Sandboxie.ini";
        public string filePathSandboxieStartExe = @"C:\\Program Files\\Sandboxie-Plus\\Start.exe";
        public string filePathSbieIni = @"C:\Program Files\Sandboxie-Plus\SbieIni.exe";
        public string folderPathApplication = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\";
        public string folderPathApplicationData = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Data\\";
        public string folderPathApplicationMain = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\Main\\";
        public string folderPathJagexCache = @"C:\\Users\\" + Environment.UserName.ToString() + "\\jagexcache";
        public string folderPathJivaroTemp = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\";
        public string folderPathJivaroTempFushigiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\FushigiBot";
        public string folderPathJivaroTempFushigiBotZip = @"C:\Users\" + Environment.UserName.ToString() + "\\Jivaro\\Temp\\FushigiBot.zip";
        public string folderPathOSBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot";
        public string folderPathScriptFactoryPrivateScripts = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Private Scripts";
        public string folderPathScriptFactoryPrivateScriptsFushigiBot = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Private Scripts\\FushigiBot";
        public string folderPathScriptFactoryProfiles = @"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles";
        public string folderPathUsername = @"C:\\Users\\" + Environment.UserName;
        public static string lastFetchedArgs = "";
        public string pc_username = Environment.UserName;
        public string urlDreamBotClient = "https://dreambot.org/DBLauncher.jar";
        public string urlFushigiBotScripts = "https://download.jivaro.net/s/D7csx35Em5ADbNP/download/FushigiBot.zip";
        public string urlJavaRuntimeEnvironment = "https://download.jivaro.net/s/PzPpgFZDfGtQ37y/download/Java%20Runtime%20Environment%20x64%20%5Bjivaro.net%5D.exe";
        public string urlLatestApplicationVersion = "https://download.jivaro.net/s/gBY4egoBbBAywyp/download/version.txt";
        public string urlOSBotClient = "https://osbot.org/mvc/get";
        public string urlProxifier = "https://www.proxifier.com/download/ProxifierSetup.exe";
        public string urlSandboxiePlus = "https://download.jivaro.net/s/ALLqfY7MdwqLqq5/download/Sandboxie-Plus.exe";
        public string urlSdnScriptsDreamBot = "https://download.jivaro.net/s/Mms2Jjj6pxXPnFZ/download/dreambot_script_list.txt";
        public string urlSdnScriptsOSBot = "https://download.jivaro.net/s/qDzAY9QJJ4DAFzi/download/osbot_script_list.txt";
        public string urlSdnScriptsScriptFactory = "https://download.jivaro.net/s/fsjwMxi2G55YsYg/download/script_factory_script_list.txt";
        public string urlSdnScriptsTRiBot = "https://download.jivaro.net/s/QxpqptAkRsa6swC/download/tribot_script_list.txt";
        public string urlTRiBotClient = "https://installers.tribot.org/tribot-splash.jar";
        public string[] filesMirrorJunk = Directory.GetFiles(@"C:\\Users\\" + Environment.UserName.ToString() + "\\OSBot\\Data", "mirror_*");

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

            // Optimized double buffer
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            //Instances - Performance Counters
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            //Timers - Performance Counters
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

            // Bring panelScriptFactory to the front
            foreach (Control control in this.Controls)
            {
                if (control is Panel && control != panelScriptFactory)
                {
                    control.SendToBack();
                }
            }
            panelScriptFactory.BringToFront();


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
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsTRiBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsDreamBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsOSBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsScriptFactory);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsTRiBot);
            invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLoginInfoClients);


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
            await Invoke_PopulateComboBoxColumn(dataGridViewDreamBotManager, "dataGridViewDreamBotManager_Script", urlSdnScriptsDreamBot, filePathApplicationDataLocalScriptsDreamBot);
            await Invoke_PopulateComboBoxColumn(dataGridViewOSBotManager, "dataGridViewOSBotManager_Script", urlSdnScriptsOSBot, filePathApplicationDataLocalScriptsOSBot);
            await Invoke_PopulateComboBoxColumn(dataGridViewScriptFactory, "dataGridViewScriptFactory_Task", urlSdnScriptsScriptFactory, filePathApplicationDataLocalScriptsScriptFactory);
            await Invoke_PopulateComboBoxColumn(dataGridViewTRiBotManager, "dataGridViewTRiBotManager_Script", urlSdnScriptsTRiBot, filePathApplicationDataLocalScriptsTRiBot);

            // Populate dataGridView's Account Data
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(dataGridViewScriptFactory, filePathApplicationDataAccountsScriptFactory);
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(dataGridViewOSBotManager, filePathApplicationDataAccountsOSBot);
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(dataGridViewDreamBotManager, filePathApplicationDataAccountsDreamBot);
            invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(dataGridViewTRiBotManager, filePathApplicationDataAccountsTRiBot);


            // Populate Client Login Info
            Invoke_PopulateClientLoginInfo();

            // Set ProgressBar Visibility to False
            progressBarDreamBotManager.Visible = false;
            progressBarOSBotManager.Visible = false;
            progressBarScriptFactory.Visible = false;
            progressBarSettings.Visible = false;
            progressBarTRiBotManager.Visible = false;

            // Round Buttons
            RoundButtonEdges();

            // Disable Script Factory Button
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_ScriptFactory);

            // Default ComboBox Selections
            comboBoxBreakProfiles_SelectBreakFilename.SelectedIndex = 0;
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
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataAccountsTRiBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsDreamBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsOSBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsScriptFactory));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLocalScriptsTRiBot));
                    await Task.Run(() => invokeMethodsActiveMainForm.Invoke_CreateFileIfNotExists(filePathApplicationDataLoginInfoClients));
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
                    if (dataGridViewScriptFactory.InvokeRequired)
                    {
                        dataGridViewScriptFactory.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewScriptFactory, "dataGridViewScriptFactory_Account", "dataGridViewScriptFactory_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewScriptFactory, "dataGridViewScriptFactory_Account", "dataGridViewScriptFactory_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // OSBot Manager
                try
                {
                    if (dataGridViewOSBotManager.InvokeRequired)
                    {
                        dataGridViewOSBotManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewOSBotManager, "dataGridViewOSBotManager_Account", "dataGridViewOSBotManager_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewOSBotManager, "dataGridViewOSBotManager_Account", "dataGridViewOSBotManager_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // DreamBot Manager
                try
                {
                    if (dataGridViewDreamBotManager.InvokeRequired)
                    {
                        dataGridViewDreamBotManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewOSBotManager, "dataGridViewDreamBotManager_Account", "dataGridViewDreamBotManager_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewOSBotManager, "dataGridViewDreamBotManager_Account", "dataGridViewDreamBotManager_Status");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while getting process arguments: " + ex.Message);
                }

                // TRiBot Manager
                try
                {
                    if (dataGridViewTRiBotManager.InvokeRequired)
                    {
                        dataGridViewTRiBotManager.Invoke(new MethodInvoker(delegate
                        {
                            invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewOSBotManager, "dataGridViewTRiBotManager_Account", "dataGridViewTRiBotManager_Status");
                        }));
                    }
                    else
                    {
                        invokeMethodsPassiveMainForm.Invoke_UpdateRunningStatus(dataGridViewOSBotManager, "dataGridViewTRiBotManager_Account", "dataGridViewTRiBotManager_Status");
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



        ////////////////////////
        //Start of Ads Handler//
        ////////////////////////



        //////////////////////
        //End of Ads Handler//
        //////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////
        //Start of Navigation Buttons//
        ///////////////////////////////

        //Button Click - Navigate To Script Factory//
        public void buttonNavigation_ScriptFactory_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelScriptFactory, progressBarScriptFactory);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_ScriptFactory);
        }


        //Button Click - Navigate To OSBot Manager//
        public void buttonNavigation_OSBotManager_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelOSBotManager, progressBarOSBotManager);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_OSBotManager);
        }

        //Button Click - Navigate To TRiBot Manager//
        public void buttonNavigation_TRiBotManager_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelTRiBotManager, progressBarTRiBotManager);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_TRiBotManager);
        }

        //Button Click - Navigate To DreamBot Manager//
        public void buttonNavigation_DreamBotManager_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelDreamBotManager, progressBarDreamBotManager);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_DreamBotManager);
        }

        //Button Click - Navigate to Break Profiles//
        public void buttonNavigation_BreakProfiles_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelBreakProfiles);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_BreakProfiles);
        }

        //Button Click - Navigate To Script Profiles//
        public void buttonNavigation_ScriptProfiles_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelScriptProfiles);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_ScriptProfiles);
        }

        //Button Click - Navigate To Settings//
        public void buttonNavigation_Settings_Click(object sender, EventArgs e)
        {
            Invoke_NavigateToPanel(panelAccountsAndSettings);
            Invoke_DisableButtonAndChangeColorToTeal(buttonNav_Settings);
        }


        /////////////////////////////
        //End of Navigation Buttons//
        /////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of Script Factory Panel//
        /////////////////////////////////

        // Cell Button Click - Cli Launch
        public void dataGridView_ScriptFactoryRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewScriptFactory.Rows.Count)
            {

                // Point to dataGridView
                DataGridViewRow clickedRow = dataGridViewScriptFactory.Rows[e.RowIndex];
                string account = clickedRow.Cells["dataGridViewScriptFactory_Account"].Value?.ToString();

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
                if (processIdToKill == -1 && e.ColumnIndex == dataGridViewScriptFactory.Columns["dataGridViewScriptFactory_Run"].Index && e.RowIndex >= 0)
                {
                    // Initialize variables
                    string loginInfoOSBot = "-login " + textBoxSettings_OSBotUsername.Text.ToString() + ":" + textBoxSettings_OSBotPassword.Text.ToString() + " ";
                    string mode = clickedRow.Cells["dataGridViewScriptFactory_Mode"].Value?.ToString();
                    string newmouse = clickedRow.Cells["dataGridViewScriptFactory_NewMouse"].Value?.ToString();
                    string password = clickedRow.Cells["dataGridViewScriptFactory_Password"].Value?.ToString();
                    string pin = clickedRow.Cells["dataGridViewScriptFactory_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["dataGridViewScriptFactory_Proxy"].Value?.ToString();
                    string sandboxie = clickedRow.Cells["dataGridViewScriptFactory_Sandboxie"].Value?.ToString();
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["dataGridViewScriptFactory_SandboxieNumber"].Value?.ToString();
                    string script = clickedRow.Cells["dataGridViewScriptFactory_Script"].Value?.ToString();
                    string task = clickedRow.Cells["dataGridViewScriptFactory_Task"].Value?.ToString();
                    string world = clickedRow.Cells["dataGridViewScriptFactory_World"].Value?.ToString();

                    //Set BotCli variables
                    botcli = "-bot " + account + ":" + password + ":" + (string.IsNullOrWhiteSpace(pin) ? "1234" : pin) + " ";

                    //Set Mode Variable
                    mode = (mode == "Mirror" ? "-mirror " : "");

                    //Set NewMouse Variable
                    newmouse = (newmouse == "Yes" ? "-newmouse " : "");

                    //Set Proxy Variable
                    proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : "-proxy " + proxy + " ";

                    //Set Script Variable
                    script = new Dictionary<string, string> { { "SF I", "1097" }, { "SF II", "1214" }, { "SF Pro", "1163" }, { "SF Exp", "1144" } }.TryGetValue(script, out var mappedValue) ? $"-script {mappedValue}:{task} " : script;

                    //Set World Variable
                    Random rnd = new Random();

                    Dictionary<string, int[]> worldMap = new Dictionary<string, int[]>
                {
                    { "-F2P-", new int[] { 301, 308, 316, 326, 335, 371, 380, 382, 383, 384, 394, 397, 398, 399, 417, 418, 430, 431, 433, 434, 435, 436, 437, 451, 452, 453, 454, 455, 456, 469, 470, 471, 475, 476, 483, 497, 498, 499, 500, 501, 537, 542, 543, 544, 545, 546, 547, 552, 553, 554, 555, 556, 557, 562, 563, 571, 575 } },
                    { "-P2P-", new int[] { 302, 303, 304, 305, 306, 307, 309, 310, 311, 312, 313, 314, 315, 317, 318, 319, 320, 321, 322, 323, 324, 325, 327, 328, 329, 330, 331, 332, 333, 334, 336, 337, 338, 339, 340, 341, 343, 344, 346, 347, 348, 350, 351, 352, 354, 355, 357, 358, 359, 360, 362, 367, 368, 369, 370, 374, 375, 376, 377, 378, 386, 387, 388, 389, 390, 395, 421, 422, 424, 443, 444, 445, 446, 463, 464, 465, 466, 477, 478, 480, 481, 482, 484, 485, 486, 487, 488, 489, 490, 491, 492, 493, 494, 495, 496, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 531, 532, 533, 534, 535, 580 } }
                };

                    world = worldMap.ContainsKey(world)
                        ? "-world " + worldMap[world][rnd.Next(worldMap[world].Length)] + " "
                        : "-world " + world + " ";

                    //Delete Mirror Files//
                    foreach (string file in filesMirrorJunk)
                    {
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(file);
                    }

                    //Delete Jagex Files//
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagex_cl_oldschool_LIVE.dat");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagexappletviewer.preferences");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "random.dat");

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        // Set CliArgs Variable
                        cliArgs = "-jar \"C:\\Users\\" + pc_username + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\" -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mode + newmouse + "-debug 0";

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe",
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
                        string folderPathSandboxieCurrent = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\";
                        string folderPathSandboxieCurrentOSBotData = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\OSBot\\Data";
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /nosbiectrl /silent /wait /box:" + sandboxieNumber + " \"C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe\" -jar " + "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"" + " -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mode + newmouse + "-debug 0";

                        //Create Sandbox If It Doesn't Exist
                        if (!enabledSandboxes.Contains(sandboxieNumber))
                        {
                            invokeMethodsActiveMainForm.Invoke_CreateSandboxFolder(sandboxieNumber, filePathSbieIni);
                            Thread.Sleep(100);
                        }

                        //Delete Sandbox Files
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\jagex_cl_oldschool_LIVE.dat");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\jagexappletviewer.preferences");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrent + "\\random.dat");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrentOSBotData + "\\map.bin");
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathSandboxieCurrentOSBotData + "\\map.zip");

                        //Copy Jagex Cache to Sandbox
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
                else if (processIdToKill != -1 && e.ColumnIndex == dataGridViewScriptFactory.Columns["dataGridViewScriptFactory_Run"].Index && e.RowIndex >= 0)
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

        // Button Click - Launch OSBot
        public void btnScriptFactory_LaunchOsbot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe", arguments);
        }

        // Button Click - Add Bot
        public void btnScriptFactory_AddBot_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = dataGridViewScriptFactory.Rows.Add(newRow);

            // Set Default Values
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Account"].Value = "ACCOUNT_EMAIL";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Password"].Value = "PASSWORD";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Pin"].Value = "1234";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Proxy"].Value = "IP:PORT:USER:PASS";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Script"].Value = "SF I";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Task"].Value = "fxAccountBuilder";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_World"].Value = "-F2P-";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Mode"].Value = "Stealth";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_NewMouse"].Value = "Yes";
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_Sandboxie"].Value = "No";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            dataGridViewScriptFactory.Rows[rowIndex].Cells["dataGridViewScriptFactory_SandboxieNumber"].Value = randomNumber;
        }

        // Button Click - Delete Bot//
        public void btnScriptFactory_DeleteBot_Click(object sender, EventArgs e)
        {
            if (dataGridViewScriptFactory.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewScriptFactory.SelectedRows[0].Index;
                dataGridViewScriptFactory.Rows.RemoveAt(rowIndex);
            }
        }

        // Button Click - Download OSBot
        public async void btnScriptFactory_DownloadOSBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlOSBotClient, filePathApplicationOSBotJar, progressBarScriptFactory, value => isDownloadingOSBotEventRunning = value, sender as Button);
        }

        // Button Click - Update Scripts
        public async void btnScriptFactory_UpdateScripts_Click(object sender, EventArgs e)
        {
            //Check If Event is Running
            if (isUpdatingScriptsEventRunning)
            {
                MessageBox.Show("The process is already running. Please wait.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Set Flag & Disable Button//
            isUpdatingScriptsEventRunning = true;
            (sender as Button).Enabled = false;

            //Initiate Progress Bar//
            progressBarScriptFactory.Visible = true;
            progressBarScriptFactory.Value = 0;
            progressBarScriptFactory.Step = 20;

            //Delete Folders//
            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathScriptFactoryPrivateScriptsFushigiBot);
            progressBarScriptFactory.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempFushigiBot);
            progressBarScriptFactory.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteDirectory(folderPathJivaroTempFushigiBotZip);
            progressBarScriptFactory.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathJivaroTempFushigiBotZip);
            progressBarScriptFactory.PerformStep();

            // Zip File Handler
            try
            {
                //Download the .zip file//
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(urlFushigiBotScripts);
                    using (FileStream fs = new FileStream(folderPathJivaroTempFushigiBotZip, FileMode.Create))
                    {
                        await response.Content.CopyToAsync(fs);
                    }
                }
                progressBarScriptFactory.PerformStep();

                //Unzip//
                ZipFile.ExtractToDirectory(folderPathJivaroTempFushigiBotZip, folderPathJivaroTempFushigiBot);
                progressBarScriptFactory.PerformStep();

                //Move the Unzipped Folder//
                Directory.Move(Path.Combine(folderPathJivaroTempFushigiBot), folderPathScriptFactoryPrivateScriptsFushigiBot);
                progressBarScriptFactory.PerformStep();
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
            progressBarScriptFactory.PerformStep();

            invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathJivaroTempFushigiBotZip);
            progressBarScriptFactory.PerformStep();

            //Hide The Progress Bar//
            progressBarScriptFactory.Value = 0;
            progressBarScriptFactory.Visible = false;

            //Reset Flag & Re-Enable Button//
            isUpdatingScriptsEventRunning = false;
            (sender as Button).Enabled = true;
        }

        // Button Click - Save
        public void btnScriptFactory_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(dataGridViewScriptFactory, filePathApplicationDataAccountsScriptFactory);
        }

        ///////////////////////////////
        //End of Script Factory Panel//
        ///////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////
        //Start of OSBot Manager Panel//
        ////////////////////////////////

        // Cell Button Click - CLI Launch
        public void dataGridView_OSBotRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewOSBotManager.Rows.Count)
            {

                // Point to dataGridView
                DataGridViewRow clickedRow = dataGridViewOSBotManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["dataGridViewOSBotManager_Account"].Value?.ToString();

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

                if (processIdToKill == -1 && e.ColumnIndex == dataGridViewOSBotManager.Columns["dataGridViewOSBotManager_Run"].Index && e.RowIndex >= 0)
                {

                    // Initialize Variables
                    string loginInfoOSBot = "-login " + textBoxSettings_OSBotUsername.Text.ToString() + ":" + textBoxSettings_OSBotPassword.Text.ToString() + " ";
                    string mode = clickedRow.Cells["dataGridViewOSBotManager_Mode"].Value?.ToString();
                    string newmouse = clickedRow.Cells["dataGridViewOSBotManager_NewMouse"].Value?.ToString();
                    string password = clickedRow.Cells["dataGridViewOSBotManager_Password"].Value?.ToString();
                    string pin = clickedRow.Cells["dataGridViewOSBotManager_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["dataGridViewOSBotManager_Proxy"].Value?.ToString();
                    string sandboxie = clickedRow.Cells["dataGridViewOSBotManager_Sandboxie"].Value?.ToString();
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["dataGridViewOSBotManager_SandboxieNumber"].Value?.ToString();
                    string script = clickedRow.Cells["dataGridViewOSBotManager_Script"].Value?.ToString();
                    string scriptArgs = clickedRow.Cells["dataGridViewOSBotManager_Args"].Value?.ToString();
                    string world = clickedRow.Cells["dataGridViewOSBotManager_World"].Value?.ToString();

                    // Set BotCli Variable
                    botcli = "-bot " + account + ":" + password + ":" + (string.IsNullOrWhiteSpace(pin) ? "1234" : pin) + " ";

                    // Set Mode Variable
                    mode = mode == "Mirror" ? "-mirror " : "";

                    // Set NewMouse Variable
                    newmouse = newmouse == "Yes" ? "-newmouse " : "";

                    // Set Proxy Variable
                    proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : "-proxy " + proxy + " ";

                    // Set Script Variable
                    script = "-script " + Regex.Replace(script, "\\D", "") + ":" + scriptArgs + " ";

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

                    //Delete Mirror Files//
                    foreach (string file in filesMirrorJunk)
                    {
                        invokeMethodsActiveMainForm.Invoke_DeleteFile(file);
                    }

                    //Delete Jagex Files//
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagex_cl_oldschool_LIVE.dat");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "jagexappletviewer.preferences");
                    invokeMethodsActiveMainForm.Invoke_DeleteFile(folderPathUsername + "random.dat");

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        //Set CliArgs Variable//
                        cliArgs = "-jar \"C:\\Users\\" + pc_username + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\" -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mode + newmouse + "-debug 0";

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe",
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
                        string folderPathSandboxieCurrent = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\";
                        string folderPathSandboxieCurrentOSBotData = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\OSBot\\Data";
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /nosbiectrl /silent /wait /box:" + sandboxieNumber + " \"C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe\" -jar " + "\"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"" + " -launchgame -mfps 25 -mreactiontime 50 " + loginInfoOSBot + botcli + proxy + script + world + mode + newmouse + "-debug 0";

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
                else if (processIdToKill != -1 && e.ColumnIndex == dataGridViewOSBotManager.Columns["dataGridViewOSBotManager_Run"].Index && e.RowIndex >= 0)
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

        // Button Click - Launch OSBot
        public void btnOSBotManager_LaunchOsbot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\OSBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe", arguments);
        }

        // Button Click - Add Bot
        public void btnOSBotManager_AddBot_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = dataGridViewOSBotManager.Rows.Add(newRow);

            // Set Default Values
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Account"].Value = "ACCOUNT_EMAIL";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Password"].Value = "PASSWORD";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Pin"].Value = "1234";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Proxy"].Value = "IP:PORT:USER:PASS";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Script"].Value = "Excellent Dragons - 898";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Args"].Value = "SCRIPT_ARGS";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_World"].Value = "-F2P-";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Mode"].Value = "Stealth";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_NewMouse"].Value = "Yes";
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_Sandboxie"].Value = "No";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            dataGridViewOSBotManager.Rows[rowIndex].Cells["dataGridViewOSBotManager_SandboxieNumber"].Value = randomNumber;
        }

        // Button Click - Delete Bot
        public void btnOSBotManager_DeleteBot_Click(object sender, EventArgs e)
        {
            if (dataGridViewOSBotManager.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewOSBotManager.SelectedRows[0].Index;
                dataGridViewOSBotManager.Rows.RemoveAt(rowIndex);
            }
        }

        // Button Click - Download OSBot
        public async void btnOSBotManager_DownloadOSBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlOSBotClient, filePathApplicationOSBotJar, progressBarOSBotManager, value => isDownloadingOSBotEventRunning = value, sender as Button);
        }

        // Button Click - Save
        public void btnOSBotManager_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(dataGridViewOSBotManager, filePathApplicationDataAccountsOSBot);
        }

        //////////////////////////////
        //End of OSBot Manager Panel//
        //////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////////
        //Start of DreamBot Manager Panel//
        ///////////////////////////////////

        // OSBot Manager Panel - CLI Launch
        public void dataGridView_DreamBotRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewDreamBotManager.Rows.Count)
            {

                // Point to dataGridView
                DataGridViewRow clickedRow = dataGridViewDreamBotManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["dataGridViewDreamBotManager_Account"].Value?.ToString();

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

                //Create Cli Args//
                if (processIdToKill == -1 && e.ColumnIndex == dataGridViewDreamBotManager.Columns["dataGridViewDreamBotManager_Run"].Index && e.RowIndex >= 0)
                {

                    //Initialize Variables//
                    string loginInfoDreamBot = "-username " + textBoxSettings_DreamBotUsername.Text.ToString() + " " + "-password " + textBoxSettings_DreamBotPassword.Text.ToString() + " ";
                    string password = "-accountPassword " + clickedRow.Cells["dataGridViewDreamBotManager_Password"].Value?.ToString() + " ";
                    string pin = clickedRow.Cells["dataGridViewDreamBotManager_Pin"].Value?.ToString();
                    string breaks = clickedRow.Cells["dataGridViewDreamBotManager_Breaks"].Value?.ToString();
                    string mode = clickedRow.Cells["dataGridViewDreamBotManager_Mode"].Value?.ToString();
                    string proxy = clickedRow.Cells["dataGridViewDreamBotManager_Proxy"].Value?.ToString();
                    string sandboxie = clickedRow.Cells["dataGridViewDreamBotManager_Sandboxie"].Value?.ToString();
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["dataGridViewDreamBotManager_SandboxieNumber"].Value?.ToString();
                    string script = "-script " + "\"" + clickedRow.Cells["dataGridViewDreamBotManager_Script"].Value?.ToString() + "\"" + " ";
                    string scriptArgs = clickedRow.Cells["dataGridViewDreamBotManager_Args"].Value?.ToString();
                    string world = "-world " + clickedRow.Cells["dataGridViewDreamBotManager_World"].Value?.ToString() + " ";

                    // Initialize the mode mappings
                    var modeMappings = new Dictionary<string, string> { { "Normal - Render", "-no-covert -render all " }, { "Normal - No Render", "-no-covert -render none " }, { "Covert - Render", "-covert -render all " }, { "Covert - No Render", "-covert -render none " } };

                    // Set account variable
                    account = "-accountUsername " + clickedRow.Cells["dataGridViewDreamBotManager_Account"].Value?.ToString() + " ";

                    // Set Pin Variable
                    pin = string.IsNullOrWhiteSpace(pin) ? "-accountPin 1234 " : "-accountPin " + pin + " ";

                    // Set Breaks Variable
                    breaks = string.IsNullOrWhiteSpace(breaks) ? "" : "-breaks " + breaks + " ";

                    // Set Mode Variable using dictionary
                    mode = modeMappings.ContainsKey(mode) ? modeMappings[mode] : "";

                    // Set Proxy Variable
                    proxy = string.IsNullOrWhiteSpace(proxy) || proxy == "IP:PORT:USER:PASS" ? "" : "-proxy " + proxy + " ";

                    // Set ScriptArgs Variable
                    scriptArgs = string.IsNullOrWhiteSpace(scriptArgs) ? "" : "-params " + scriptArgs + " ";

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        //Initialize CliArgs Variable//
                        cliArgs = "-jar \"C:\\Users\\" + pc_username + "\\DreamBot\\BotData\\client.jar\" " + loginInfoDreamBot + account + password + pin + proxy + script + scriptArgs + breaks + world + mode + "-fresh " + "-fps 25";

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe",
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
                        //Initialize Variables//
                        string folderPathSandboxieCurrent = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\";
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /nosbiectrl /silent /wait /box:" + sandboxieNumber + " \"C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe\" -jar \"C:\\Users\\" + pc_username + "\\DreamBot\\BotData\\client.jar\" " + loginInfoDreamBot + account + password + pin + proxy + script + scriptArgs + breaks + world + mode + "-fresh " + "-fps 25";

                        //Create Sandbox If It Doesn't Exist//
                        if (!enabledSandboxes.Contains(sandboxieNumber))
                        {
                            invokeMethodsActiveMainForm.Invoke_CreateSandboxFolder(sandboxieNumber, filePathSbieIni);
                            Thread.Sleep(100);
                        }

                        //Execute Cli Args//
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
                else if (processIdToKill != -1 && e.ColumnIndex == dataGridViewDreamBotManager.Columns["dataGridViewDreamBotManager_Run"].Index && e.RowIndex >= 0)
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

        // Button Click - Launch DreamBot
        public void btnDreamBotManager_LaunchDreamBot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\DreamBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe", arguments);
        }

        // Button Click - Add Bot
        public void btnDreamBotManager_AddBot_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = dataGridViewDreamBotManager.Rows.Add(newRow);

            // Set Default Values
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Account"].Value = "ACCOUNT_EMAIL";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Password"].Value = "PASSWORD";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Pin"].Value = "1234";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Proxy"].Value = "IP:PORT:USER:PASS";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Script"].Value = "0x's Aerial Fish Catcher";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Args"].Value = "SCRIPT_ARGS";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Breaks"].Value = "BREAK_NICKNAME";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_World"].Value = "f2p";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Mode"].Value = "Covert - Render";
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_Sandboxie"].Value = "No";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            dataGridViewDreamBotManager.Rows[rowIndex].Cells["dataGridViewDreamBotManager_SandboxieNumber"].Value = randomNumber;
        }

        // Button Click - Delete Bot
        public void btnDreamBotManager_DeleteBot_Click(object sender, EventArgs e)
        {
            if (dataGridViewDreamBotManager.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewDreamBotManager.SelectedRows[0].Index;
                dataGridViewDreamBotManager.Rows.RemoveAt(rowIndex);
            }
        }

        // Button Click - Download DreamBot
        public async void btnDreamBotManager_DownloadDreamBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlDreamBotClient, filePathApplicationDreamBotJar, progressBarDreamBotManager, value => isDownloadingDreamBotEventRunning = value, sender as Button);
        }

        // DreamBot Manager Panel - Save
        public void btnDreamBotManager_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(dataGridViewDreamBotManager, filePathApplicationDataAccountsDreamBot);
        }

        /////////////////////////////////
        //End of DreamBot Manager Panel//
        /////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of TRiBot Manager Panel//
        /////////////////////////////////

        // Cell Button Click - Launch CLI
        public void dataGridView_TRiBotRun_CellButtonClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTRiBotManager.Rows.Count)
            {

                // Point to dataGridView
                DataGridViewRow clickedRow = dataGridViewTRiBotManager.Rows[e.RowIndex];
                string account = clickedRow.Cells["dataGridViewTRiBotManager_Account"].Value?.ToString();

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

                if (processIdToKill == -1 && e.ColumnIndex == dataGridViewTRiBotManager.Columns["dataGridViewTRiBotManager_Run"].Index && e.RowIndex >= 0)
                {

                    // Initialize Variables
                    string loginInfoTRiBot = "--username " + "\"" + textBoxSettings_TRiBotEmail.Text.ToString() + "\" " + "--password " + "\"" + textBoxSettings_TRiBotPassword.Text.ToString() + "\" ";
                    string breaks = clickedRow.Cells["dataGridViewTRiBotManager_Breaks"].Value?.ToString();
                    string password = "--charpassword " + "\"" + clickedRow.Cells["dataGridViewTRiBotManager_Password"].Value?.ToString() + "\" ";
                    string mode = clickedRow.Cells["dataGridViewTRiBotManager_Mode"].Value?.ToString();
                    string pin = clickedRow.Cells["dataGridViewTRiBotManager_Pin"].Value?.ToString();
                    string proxy = clickedRow.Cells["dataGridViewTRiBotManager_Proxy"].Value?.ToString();
                    string sandboxie = clickedRow.Cells["dataGridViewTRiBotManager_Sandboxie"].Value?.ToString();
                    string sandboxieNumber = "JIVARO" + clickedRow.Cells["dataGridViewTRiBotManager_SandboxieNumber"].Value?.ToString();
                    string script = "--script \"" + clickedRow.Cells["dataGridViewTRiBotManager_Script"].Value?.ToString() + "\" ";
                    string scriptArgs = "--scriptargs " + "\"" + clickedRow.Cells["dataGridViewTRiBotManager_Args"].Value?.ToString() + "\" ";
                    string world = clickedRow.Cells["dataGridViewTRiBotManager_World"].Value?.ToString();

                    // Set account variable
                    account = "--charusername \"" + clickedRow.Cells["dataGridViewTRiBotManager_Account"].Value?.ToString() + "\" ";

                    // Set pin variable
                    pin = string.IsNullOrWhiteSpace(pin) ? "" : "--charpin \"" + pin + "\" ";

                    // Set break profile variable
                    breaks = string.IsNullOrWhiteSpace(breaks) ? "" : "--breakprofile \"" + breaks + "\" ";

                    // Set mode variable
                    mode = mode == "Injection" ? "" :
                    mode == "Looking Glass" ? "--lgdelay 10 --lgpath \"C:\\Users\\User\\Downloads\\OpenOSRS.jar\" " : mode;

                    // Set Proxy Variable
                    if (!string.IsNullOrWhiteSpace(proxy) && proxy != "IP:PORT:USER:PASS")
                    {
                        var parts = proxy.Split(':');
                        if (parts.Length == 4)
                        {
                            proxy = $" --proxyhost \"{parts[0]}\" --proxyport \"{parts[1]}\" --proxyusername \"{parts[2]}\" --proxypassword \"{parts[3]}\"";
                        }
                        else
                        {
                            // Handle unexpected format if necessary
                            Console.WriteLine("The proxy string is in an unexpected format.");
                        }
                    }
                    else
                    {
                        proxy = "";
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

                    ///////////////////////
                    //No Sandboxie Launch//
                    ///////////////////////
                    if (sandboxie == "No")
                    {
                        // Set CliArgs Variable
                        cliArgs = "-jar \"C:\\Users\\" + pc_username + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar\" " + loginInfoTRiBot + account + password + pin + proxy + script + scriptArgs + breaks + world + mode;

                        // Start Cli Process
                        try
                        {
                            ProcessStartInfo psi = new ProcessStartInfo
                            {
                                FileName = "C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe",
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
                        string folderPathSandboxieCurrent = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\";
                        string folderPathSandboxieCurrentOSBotData = "C:\\Sandbox\\" + pc_username + "\\" + sandboxieNumber + "\\user\\current\\OSBot\\Data";
                        var enabledSandboxes = invokeMethodsPassiveMainForm.Invoke_GetSandboxList(filePathSandboxieIni);
                        cliArgs = "/elevate /box:" + sandboxieNumber + " java -jar \"C:\\Users\\" + pc_username + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar\" " + loginInfoTRiBot + account + password + pin + proxy + script + scriptArgs + breaks + world + mode;

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
                else if (processIdToKill != -1 && e.ColumnIndex == dataGridViewTRiBotManager.Columns["dataGridViewTRiBotManager_Run"].Index && e.RowIndex >= 0)
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

        // Button Click - Launch TRiBot
        public void btnTRiBotManager_LaunchTRiBot_Click(object sender, EventArgs e)
        {
            string arguments = "-jar \"C:\\Users\\" + Environment.UserName.ToString() + "\\Jivaro\\Old School RuneScape Bot Manager\\TRiBot.jar\"";
            invokeMethodsActiveMainForm.Invoke_LaunchJavaw("C:\\Program Files\\Java\\jre-1.8\\bin\\javaw.exe", arguments);
        }

        // Button Click - Add Bot
        public void btnTRiBotManager_AddBot_Click(object sender, EventArgs e)
        {
            // Create New Row
            DataGridViewRow newRow = new DataGridViewRow();

            // Add Row to DataGridView
            int rowIndex = dataGridViewTRiBotManager.Rows.Add(newRow);

            // Set default values
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Account"].Value = "ACCOUNT_EMAIL";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Password"].Value = "PASSWORD";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Pin"].Value = "1234";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Proxy"].Value = "IP:PORT:USER:PASS";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Script"].Value = "aAgility AIO";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Args"].Value = "SCRIPT_ARGS";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Breaks"].Value = "BREAK_NAME";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_World"].Value = "-F2P-";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Mode"].Value = "Injection";
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_Sandboxie"].Value = "No";

            // Generate a unique random number for Sandboxie
            int randomNumber = Invoke_GenerateUniqueRandomNumber();
            dataGridViewTRiBotManager.Rows[rowIndex].Cells["dataGridViewTRiBotManager_SandboxieNumber"].Value = randomNumber;
        }

        // Button Click - Delete Bot
        public void btnTRiBotManager_DeleteBot_Click(object sender, EventArgs e)
        {
            if (dataGridViewTRiBotManager.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewTRiBotManager.SelectedRows[0].Index;
                dataGridViewTRiBotManager.Rows.RemoveAt(rowIndex);
            }
        }

        //Button Click - Download TRiBot
        public async void btnTRiBotManager_DownloadTRiBot_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadFileProgerssBarDisableButton(urlTRiBotClient, filePathApplicationTRiBotJar, progressBarTRiBotManager, value => isDownloadingTRiBotEventRunning = value, sender as Button);
        }

        // DreamBot Manager Panel - Save
        public void btnTRiBotManager_Save_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_SaveDataGridViewToFile(dataGridViewTRiBotManager, filePathApplicationDataAccountsTRiBot);
        }

        ///////////////////////////////
        //End of TRiBot Manager Panel//
        ///////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////
        //Start of Break Profiles Panel//
        /////////////////////////////////

        // Button Click - Save Break Profile
        public void btnBreakProfiles_Save_Click(object sender, EventArgs e)
        {

            // Initialize Variables
            string filePathScriptFactoryProfiles = Path.Combine(@"C:\\Users\\" + pc_username + "\\OSBot\\Data\\ProjectPact\\OSRS Script Factory\\Profiles\\" + comboBoxBreakProfiles_SelectBreakFilename.SelectedItem.ToString());
            string breakFileEnableBreaks = "<Find>boolEnableBreaks:true</Find><Replace>boolEnableBreaks:false</Replace>";
            string breakFileEnableSleepBreaks = "<Find>boolEnableSleepBreaks:true</Find><Replace>boolEnableSleepBreaks:false</Replace>";
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
                breakFileEnableSleepBreaks = "<Find>boolEnableSleepBreaks:true</Find><Replace>boolEnableSleepBreaks:true</Replace>";
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
                {"fxFiremaking-GrandExchange.txt", typeof(formScriptProfilesFiremakingGrandExchange)},
                {"fxFletching-Longbows.txt", typeof(formScriptProfilesFletchingLongbows)},
                {"fxGeneric.txt", typeof(formScriptProfilesGeneric)},
                {"fxHerblore-CleanHerbs.txt", typeof(formScriptProfilesHerbloreCleanHerbs)},
                {"fxLOTR-Aragorn.txt", typeof(formScriptProfilesLOTRAragorn)},
                {"fxLOTR-Gandalf.txt", typeof(formScriptProfilesLOTRGandalf)},
                {"fxMagic-HouseAlcher.txt", typeof(formScriptProfilesMagicHouseAlcher)},
                {"fxMagic-Orber.txt", typeof(formScriptProfilesMagicOrber)},
                {"fxMiniGames-RoguesDen.txt", typeof(formScriptProfilesMiniGamesRoguesDen)},
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

        // Button Click - Save Login Info
        public void btnSettings_SaveLoginInfo_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathApplicationDataLoginInfoClients))
            {
                writer.WriteLine("osbot_username: " + textBoxSettings_OSBotUsername.Text);
                writer.WriteLine("osbot_password: " + textBoxSettings_OSBotPassword.Text);
                writer.WriteLine("dreambot_username: " + textBoxSettings_DreamBotUsername.Text);
                writer.WriteLine("dreambot_password: " + textBoxSettings_DreamBotPassword.Text);
                writer.WriteLine("tribot_username: " + textBoxSettings_TRiBotEmail.Text);
                writer.WriteLine("tribot_password: " + textBoxSettings_TRiBotPassword.Text);
            }
            MessageBox.Show("Login info saved successfully.");
        }

        // Button Click - Install Sandboxie
        public async void btnSettings_InstallSandboxie_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadAndInstallFileProgerssBarDisableButton(urlSandboxiePlus, filePathJivaroTempSandboxiePlus, progressBarSettings, value => isDownloadingSandboxiePlusEventRunning = value, sender as Button);
        }

        // Button Click - Install Proxifier
        public async void btnSettings_InstallProxifier_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadAndInstallFileProgerssBarDisableButton(urlProxifier, filePathJivaroTempProxifier, progressBarSettings, value => isDownloadingProxifierEventRunning = value, sender as Button);
        }

        // Button Click - Install Java
        public async void btnSettings_InstallJava_Click(object sender, EventArgs e)
        {
            await Invoke_DownloadAndInstallFileProgerssBarDisableButton(urlJavaRuntimeEnvironment, filePathJivaroTempJavaRuntimeEnvironment, progressBarSettings, value => isDownloadingJavaRuntimeEnvironmentEventRunning = value, sender as Button);
        }

        // Button Click - Check For Updates
        public async void btnSettings_CheckForUpdates_Click(object sender, EventArgs e)
        {
            await Invoke_CheckForUpdates(urlLatestApplicationVersion, filePathApplicationMainMiscVersion, filePathApplicationMainUpdaterExe);
        }

        // Button Click - Visit Jivaro's Website
        public void btnSettings_VisitWebsite_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://www.jivaro.net/");
        }

        // Button Click - Join Jivaro's Discor
        public void btnSettings_JoinDiscord_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://discord.gg/FSzuW4mR4M");
        }

        // Button Click - Open Botting Guide
        public void btnSettings_BottingGuide_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://www.jivaro.net/media/guides/the-ultimate-guide-to-botting-old-school-runescape");
        }

        // Button Click - Open Buy Proxies
        public void btnSettings_BuyProxies_Click(object sender, EventArgs e)
        {
            // Check if ProxyChoiceForm is already open
            if (!Application.OpenForms.OfType<formProxyChoice>().Any())
            {
                formProxyChoice proxyChoice = new formProxyChoice(this);
                proxyChoice.ShowDialog();
            }
        }

        // Button Click - Create OSRS Account
        public void btnSettings_CreateOSRSAccount_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://secure.runescape.com/m=account-creation/create_account");
        }

        // Button Click - Open Setup Guide
        public void btnSettings_SetupGuide_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://jivaro.net/osrs-botting/set-up-guide");
        }

        // Button Click - Kill All Bots
        public void btnSettings_KillAllBots_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveMainForm.Invoke_KillAllBots(sender, e);
        }

        //////////////////////////////////////
        //End of Accounts and Settings Panel//
        //////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////
        //Start of Invoke Methods//
        ///////////////////////////

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
                        Invoke_UpdateApplication(filePathApplicationMainUpdaterExe);
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
            return IsNumberInDataGridView(dataGridViewScriptFactory, "dataGridViewScriptFactory_SandboxieNumber", number) ||
                   IsNumberInDataGridView(dataGridViewOSBotManager, "dataGridViewOSBotManager_SandboxieNumber", number) ||
                   IsNumberInDataGridView(dataGridViewDreamBotManager, "dataGridViewDreamBotManager_SandboxieNumber", number) ||
                   IsNumberInDataGridView(dataGridViewTRiBotManager, "dataGridViewTRiBotManager_SandboxieNumber", number);
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

        // Invoke - Populate Client Login Info
        public void Invoke_PopulateClientLoginInfo()
        {
            if (File.Exists(filePathApplicationDataLoginInfoClients))
            {
                using (StreamReader reader = new StreamReader(filePathApplicationDataLoginInfoClients))
                {
                    textBoxSettings_OSBotUsername.Text = invokeMethodsPassiveMainForm.Invoke_GetClientLoginValueFromLine(reader.ReadLine());
                    textBoxSettings_OSBotPassword.Text = invokeMethodsPassiveMainForm.Invoke_GetClientLoginValueFromLine(reader.ReadLine());
                    textBoxSettings_DreamBotUsername.Text = invokeMethodsPassiveMainForm.Invoke_GetClientLoginValueFromLine(reader.ReadLine());
                    textBoxSettings_DreamBotPassword.Text = invokeMethodsPassiveMainForm.Invoke_GetClientLoginValueFromLine(reader.ReadLine());
                    textBoxSettings_TRiBotEmail.Text = invokeMethodsPassiveMainForm.Invoke_GetClientLoginValueFromLine(reader.ReadLine());
                    textBoxSettings_TRiBotPassword.Text = invokeMethodsPassiveMainForm.Invoke_GetClientLoginValueFromLine(reader.ReadLine());
                }
            }
        }

        // Invoke - Download File With Progress Bar and Button Disabling
        public async Task Invoke_DownloadFileProgerssBarDisableButton(string downloadLink, string filePath, ProgressBar progressBar, Action<bool> setEventRunningFlagAction, Button senderButton)
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
        public async Task Invoke_DownloadAndInstallFileProgerssBarDisableButton(string downloadLink, string filePath, ProgressBar progressBar, Action<bool> setEventRunningFlagAction, Button senderButton)
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

        // Button Click - Open Import Accounts Form
        public void btnShared_OpenImportAccounts_Click(object sender, EventArgs e)
        {
            Invoke_OpenUniqueForm(parentForm => new formImportAccounts(parentForm));
        }

        // Button Click - Open Local Scripts Form
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

        // Set Round Edges on Nav Buttons
        public void RoundButtonEdges()
        {
            invokeMethodsAppearance.RoundEdges(buttonNav_ScriptFactory);
            invokeMethodsAppearance.RoundEdges(buttonNav_OSBotManager);
            invokeMethodsAppearance.RoundEdges(buttonNav_DreamBotManager);
            invokeMethodsAppearance.RoundEdges(buttonNav_TRiBotManager);
            invokeMethodsAppearance.RoundEdges(buttonNav_ScriptProfiles);
            invokeMethodsAppearance.RoundEdges(buttonNav_BreakProfiles);
            invokeMethodsAppearance.RoundEdges(buttonNav_Settings);
        }

        // Invoke - Disable Button and Change its color to teal
        public void Invoke_DisableButtonAndChangeColorToTeal(Button clickedButton)
        {
            // List of all the buttons.
            List<Button> allButtons = new List<Button>
            {
                buttonNav_ScriptFactory,
                buttonNav_OSBotManager,
                buttonNav_DreamBotManager,
                buttonNav_TRiBotManager,
                buttonNav_ScriptProfiles,
                buttonNav_BreakProfiles,
                buttonNav_Settings
            };

            // Loop through the buttons.
            foreach (Button btn in allButtons)
            {
                if (btn == clickedButton) // If it's the clicked button
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Teal;
                }
                else // If it's any other button
                {
                    btn.Enabled = true;
                    btn.BackColor = Color.Transparent;
                }
            }
        }

        ////////////////////////////
        //End of Graphical Methods//
        ////////////////////////////
    }
}
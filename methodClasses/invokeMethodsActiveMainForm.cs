using System.Diagnostics;
using System.Management;
using System.Text;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    internal class invokeMethodsActiveMainForm
    {

        // Invoke - Copy Directory
        public static void Invoke_CopyDirectory(string sourceDir, string destDir, string messageOnSuccess)
        {
            if (Directory.Exists(sourceDir))
            {
                try
                {
                    MethodExtension_CopyDirectoryContents(sourceDir, destDir);
                    Console.WriteLine(messageOnSuccess);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Source directory '{sourceDir}' does not exist.");
            }
        }
        public static void MethodExtension_CopyDirectoryContents(string sourceDir, string destDir)
        {
            //Create Destination Directory//
            Directory.CreateDirectory(destDir);

            //Copy Files//
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                File.Copy(file, destFile, true);
            }

            //Copy Sub Directories//
            foreach (string directory in Directory.GetDirectories(sourceDir))
            {
                string destDirectory = Path.Combine(destDir, Path.GetFileName(directory));
                MethodExtension_CopyDirectoryContents(directory, destDirectory);
            }
        }

        // Invoke - Copy File To Directory
        public static async Task Invoke_CopyFileToDirectory(string sourceFile, string destDir, string messageOnSuccess)
        {
            try
            {
                // Ensure destination directory exists
                string destFile = Path.Combine(destDir, Path.GetFileName(sourceFile));
                if (!Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }

                // Copy the file
                File.Copy(sourceFile, destFile, true);
                await Task.Delay(1);  // Ensures asynchronous behavior

                Console.WriteLine(messageOnSuccess);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error copying file: {ex.Message}");
            }
        }

        // Invoke - Create Directory
        public static void Invoke_CreateFolderIfNotExists(string folderPath)
        {
            try
            {
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                    Console.WriteLine($"Folder created at {folderPath}");
                }
                else
                {
                    Console.WriteLine($"Folder already exists at {folderPath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while trying to create the folder: {ex.Message}");
            }
        }

        // Invoke - Create File
        public static void Invoke_CreateFileIfNotExists(string filePath)
        {
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                    {
                        Console.WriteLine($"File created at {filePath}");
                    }
                }
                else
                {
                    Console.WriteLine($"File already exists at {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while trying to create the file: {ex.Message}");
            }
        }

        // Invoke - Create Sandbox Folder
        public static void Invoke_CreateSandboxFolder(string sandboxie, string filePathSbieIni)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = filePathSbieIni,
                    Arguments = $"set {sandboxie} ConfigLevel 9",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = new Process { StartInfo = startInfo };
                process.Start();
                process.WaitForExit();

                //Enable sandbox//
                startInfo.Arguments = $"append {sandboxie} Enabled y";
                process.Start();
                process.WaitForExit();

                //Other settings//
                string[] settings = new string[]
                {
                    "BlockNetworkFiles=y",
                    "RecoverFolder=%{374DE290-123F-4565-9164-39C4925E467B}%",
                    "RecoverFolder=%Personal%",
                    "RecoverFolder=%Desktop%",
                    "BorderColor=#02f6f6,ttl",
                    "Template=OpenBluetooth",
                    "Template=SkipHook",
                    "Template=FileCopy",
                    "Template=qWave",
                    "Template=BlockPorts",
                    "Template=LingerPrograms",
                    "Template=AutoRecoverIgnore",
                    "AutoRecover=y",
                    "UseSecurityMode=n",
                    "UsePrivacyMode=n"
                };

                foreach (var setting in settings)
                {
                    var parts = setting.Split('=');
                    startInfo.Arguments = $"append {sandboxie} {parts[0]} {parts[1]}";
                    process.Start();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating sandbox: {ex.Message}");
            }
        }

        // Invoke - Delete Directory
        public static void Invoke_DeleteDirectory(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                try
                {
                    Directory.Delete(folderPath, true);
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

        // Invoke - Delete File
        public static void Invoke_DeleteFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    System.IO.File.Delete(filePath);
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

        // Invoke - Kill All Bots
        public static void Invoke_KillAllBots(object sender, EventArgs e)
        {
            try
            {
                string[] targetWindowKeywords = new string[] { "OSBot", "DreamBot", "TRiBot" };

                // Get all processes
                Process[] processes = Process.GetProcesses();

                foreach (Process process in processes)
                {
                    try
                    {
                        foreach (var targetKeyword in targetWindowKeywords)
                        {
                            if (process.MainWindowTitle.IndexOf(targetKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                process.Kill();
                                break;  // Move on to the next process
                            }
                        }
                    }
                    catch (Exception innerEx)
                    {
                        Console.WriteLine($"Error accessing process with window title {process.MainWindowTitle}: {innerEx.Message}");
                    }
                }

                MessageBox.Show($"All processes with window titles containing {string.Join(", ", targetWindowKeywords)} have been terminated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Invoke - Kill Java Processes and Children
        public static void Invoke_KillProcessAndChildren(int pid)
        {
            // Get all the processes
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();

            // Kill child processes
            foreach (ManagementObject mo in moc)
            {
                Invoke_KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }

            try
            {
                // Kill parent process
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        // Invoke - Launch javaw with args
        public static void Invoke_LaunchJavaw(string fileName, string arguments)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
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
        }

        // Invoke - Save DataGridView to File
        public static void Invoke_SaveDataGridViewToFile(DataGridView dataGridView, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Iterate through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Skip the last row if it is the new row for adding new data
                if (!row.IsNewRow)
                {
                    // Iterate through each cell in the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Append the cell value to the StringBuilder
                        string cellValue = cell.Value != null ? cell.Value.ToString() : string.Empty;
                        sb.Append(cellValue);
                        sb.Append(",");
                    }

                    // Append a new line after each row
                    sb.AppendLine();
                }
            }

            // Write the StringBuilder content to the file
            System.IO.File.WriteAllText(filePath, sb.ToString());
            MessageBox.Show("Dashboard saved successfully.");
        }

    }
}

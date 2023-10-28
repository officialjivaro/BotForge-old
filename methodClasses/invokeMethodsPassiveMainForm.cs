using System.Management;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    internal class invokeMethodsPassiveMainForm
    {
        // Invoke - Get Client Login Value From Line in File
        public static string Invoke_GetClientLoginValueFromLine(string line)
        {
            if (string.IsNullOrEmpty(line))
                return "";

            string[] parts = line.Split(':');
            if (parts.Length > 1)
            {
                return parts[1].Trim();
            }

            return string.Empty;
        }

        // Invoke - Get Java Command Line Args
        public static string Invoke_GetJavaCommandLineArgs()
        {
            string queryString = "SELECT CommandLine FROM Win32_Process WHERE Name='javaw.exe'";
            string allArgs = "";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(queryString))
            {
                using (ManagementObjectCollection processes = searcher.Get())
                {
                    foreach (ManagementBaseObject process in processes)
                    {
                        var commandLine = process["CommandLine"];
                        if (commandLine != null)
                        {
                            allArgs += commandLine + Environment.NewLine;
                        }
                    }
                }
            }

            return allArgs;
        }

        // Invoke - Get Java Command Line & Process Id
        public static List<string> Invoke_GetJavaCommandLineArgsAndProcessId()
        {
            string queryString = "SELECT CommandLine, ProcessId FROM Win32_Process WHERE Name='javaw.exe'";
            List<string> results = new List<string>();

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(queryString))
            {
                using (ManagementObjectCollection processes = searcher.Get())
                {
                    foreach (ManagementBaseObject process in processes)
                    {
                        var commandLine = process["CommandLine"];
                        var processId = process["ProcessId"];

                        if (commandLine != null && processId != null)
                        {
                            string result = $"{commandLine},{processId}";
                            results.Add(result);
                        }
                    }
                }
            }

            return results;
        }

        // Invoke - Populate DataGridView
        public static void Invoke_PopulateDataGridView(DataGridView dataGridView, string filePath)
        {
            // Check if the file exists
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
                return; //Exit the method if the file doesn't exist//
            }

            //Try to Handle Exceptions//
            string[] lines;
            try
            {
                // Read All Lines
                lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file {filePath}: {ex.Message}");
                return;
            }

            // Clear Rows
            dataGridView.Rows.Clear();

            // Iterate Through Lines
            foreach (string line in lines)
            {
                // Get Lines By Comma Split
                string[] cellValues = line.Split(',');

                // Create Rows
                int rowIndex = dataGridView.Rows.Add();

                // Iterate & Assign To Each Cell
                for (int columnIndex = 0; columnIndex < cellValues.Length; columnIndex++)
                {
                    // Check For Column Index Validity
                    if (columnIndex < dataGridView.Columns.Count)
                    {
                        string cellValue = cellValues[columnIndex];

                        // Check For ComboBox Cells
                        if (dataGridView.Columns[columnIndex] is DataGridViewComboBoxColumn)
                        {
                            DataGridViewComboBoxCell comboBoxCell = dataGridView.Rows[rowIndex].Cells[columnIndex] as DataGridViewComboBoxCell;

                            // Find ComboBox Index Cell Value
                            int itemIndex = comboBoxCell.Items.IndexOf(cellValue);

                            // Set ComboBox Cell Value
                            comboBoxCell.Value = itemIndex >= 0 ? comboBoxCell.Items[itemIndex] : null;
                        }
                        else
                        {
                            // Set Other Types of Cell Values
                            dataGridView.Rows[rowIndex].Cells[columnIndex].Value = cellValue;
                        }
                    }
                }
            }
        }

    }
}

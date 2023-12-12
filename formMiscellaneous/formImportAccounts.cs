using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous
{
    public partial class formImportAccounts : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formImportAccounts(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Button CLick - Import to Script Factory
        public void btnImportAccounts_ImportToScriptFactory_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the richTextBox has any content
                if (string.IsNullOrWhiteSpace(richTextBoxImportAccounts.Text))
                {
                    MessageBox.Show("No account information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read each line from the richTextBox
                var lines = richTextBoxImportAccounts.Lines;

                // Prepare a list to collect all the formatted lines
                List<string> formattedLines = new List<string>();

                foreach (var line in lines)
                {
                    // Split the line into its individual parts
                    var parts = line.Split(',');

                    if (parts.Length != 3)
                    {
                        MessageBox.Show($"Invalid data format in line: {line}. Expected format is ACCOUNT_EMAIL,PASSWORD,PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Extract the required parts
                    var accountEmail = parts[0].Trim();
                    var password = parts[1].Trim();
                    var pin = parts[2].Trim();

                    // Generate a unique random number for Sandboxie
                    int randomNumber = MainForm.Invoke_GenerateUniqueRandomNumber();

                    // Format the string
                    var formattedLine = $"{accountEmail},{password},{pin},IP:PORT:USER:PASS,SF I,fxAccountBuilder,-F2P-,,,,{randomNumber},";

                    // Add it to the collection
                    formattedLines.Add(formattedLine);
                }

                // Write all lines to the file
                File.AppendAllLines(MainForm.filePathApplicationDataAccountsScriptFactory, formattedLines);

                // Repopulate dataGridView
                invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(MainForm.kryptonDataGridViewDashboard_ScriptFactoryManager, MainForm.filePathApplicationDataAccountsScriptFactory);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button CLick - Import to OSBot Manager
        public void btnImportAccounts_ImportToOSBotManager_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the richTextBox has any content
                if (string.IsNullOrWhiteSpace(richTextBoxImportAccounts.Text))
                {
                    MessageBox.Show("No account information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read each line from the richTextBox
                var lines = richTextBoxImportAccounts.Lines;

                // Prepare a list to collect all the formatted lines
                List<string> formattedLines = new List<string>();

                foreach (var line in lines)
                {
                    // Split the line into its individual parts
                    var parts = line.Split(',');

                    if (parts.Length != 3)
                    {
                        MessageBox.Show($"Invalid data format in line: {line}. Expected format is ACCOUNT_EMAIL,PASSWORD,PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Extract the required parts
                    var accountEmail = parts[0].Trim();
                    var password = parts[1].Trim();
                    var pin = parts[2].Trim();

                    // Generate a unique random number for Sandboxie
                    int randomNumber = MainForm.Invoke_GenerateUniqueRandomNumber();

                    // Format the string
                    var formattedLine = $"{accountEmail},{password},{pin},IP:PORT:USER:PASS,Perfect Agility - 808,SCRIPT_ARGS,-F2P-,,,,{randomNumber},";

                    // Add it to the collection
                    formattedLines.Add(formattedLine);
                }

                // Write all lines to the file
                File.AppendAllLines(MainForm.filePathApplicationDataAccountsOSBot, formattedLines);

                // Repopulate dataGridView
                invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(MainForm.kryptonDataGridViewDashboard_OSBotManager, MainForm.filePathApplicationDataAccountsOSBot);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button CLick - Import to DreamBot Manager
        public void btnImportAccounts_ImportToDreamBotManage_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the richTextBox has any content
                if (string.IsNullOrWhiteSpace(richTextBoxImportAccounts.Text))
                {
                    MessageBox.Show("No account information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read each line from the richTextBox
                var lines = richTextBoxImportAccounts.Lines;

                // Prepare a list to collect all the formatted lines
                List<string> formattedLines = new List<string>();

                foreach (var line in lines)
                {
                    // Split the line into its individual parts
                    var parts = line.Split(',');

                    if (parts.Length != 3)
                    {
                        MessageBox.Show($"Invalid data format in line: {line}. Expected format is ACCOUNT_EMAIL,PASSWORD,PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Extract the required parts
                    var accountEmail = parts[0].Trim();
                    var password = parts[1].Trim();
                    var pin = parts[2].Trim();

                    // Generate a unique random number for Sandboxie
                    int randomNumber = MainForm.Invoke_GenerateUniqueRandomNumber();

                    // Format the string
                    var formattedLine = $"{accountEmail},{password},{pin},IP:PORT:USER:PASS,0x's Aerial Fish Catcher,SCRIPT_ARGS,BREAK_NICKNAME,f2p,,,,{randomNumber},";

                    // Add it to the collection
                    formattedLines.Add(formattedLine);
                }

                // Write all lines to the file
                File.AppendAllLines(MainForm.filePathApplicationDataAccountsDreamBot, formattedLines);

                // Repopulate dataGridView
                invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(MainForm.kryptonDataGridViewDashboard_DreamBotManager, MainForm.filePathApplicationDataAccountsDreamBot);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button CLick - Import to Script Factory
        public void btnImportAccounts_ImportToTRiBotManage_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the richTextBox has any content
                if (string.IsNullOrWhiteSpace(richTextBoxImportAccounts.Text))
                {
                    MessageBox.Show("No account information provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Read each line from the richTextBox
                var lines = richTextBoxImportAccounts.Lines;

                // Prepare a list to collect all the formatted lines
                List<string> formattedLines = new List<string>();

                foreach (var line in lines)
                {
                    // Split the line into its individual parts
                    var parts = line.Split(',');

                    if (parts.Length != 3)
                    {
                        MessageBox.Show($"Invalid data format in line: {line}. Expected format is ACCOUNT_EMAIL,PASSWORD,PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Extract the required parts
                    var accountEmail = parts[0].Trim();
                    var password = parts[1].Trim();
                    var pin = parts[2].Trim();

                    // Generate a unique random number for Sandboxie
                    int randomNumber = MainForm.Invoke_GenerateUniqueRandomNumber();

                    // Format the string
                    var formattedLine = $"{accountEmail},{password},{pin},IP:PORT:USER:PASS,aAgility AIO,SCRIPT_ARGS,BREAK_NAME,-F2P-,,,,{randomNumber},";

                    // Add it to the collection
                    formattedLines.Add(formattedLine);
                }

                // Write all lines to the file
                File.AppendAllLines(MainForm.filePathApplicationDataAccountsTRiBot, formattedLines);

                // Repopulate dataGridView
                invokeMethodsPassiveMainForm.Invoke_PopulateDataGridView(MainForm.kryptonDataGridViewDashboard_TRiBotManager, MainForm.filePathApplicationDataAccountsTRiBot);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

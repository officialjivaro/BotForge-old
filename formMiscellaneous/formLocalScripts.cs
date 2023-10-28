namespace Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous
{
    public partial class formLocalScripts : Form
    {
        // Initialize Instances
        public formMainForm MainForm;

        public formLocalScripts(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Form Load
        private void Form_Load(object sender, EventArgs e)
        {
            Invoke_PopulateRichTextBoxes();
        }

        // Button Click - Close Form
        public void btnLocalScripts_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button Click - Update Script Collection with Local Scripts
        public void btnLocalScripts_UpdateScriptCollectionWithLocalScripts_Click(object sender, EventArgs e)
        {
            Invoke_UpdateScriptCollectionWithLocalScripts();
        }


        // Invoke - Add Local Scripts to ComboBoxes
        public void Invoke_UpdateScriptCollectionWithLocalScripts()
        {
            try
            {
                UpdateComboBox(MainForm.dataGridViewScriptFactory.Columns["dataGridViewScriptFactory_Task"] as DataGridViewComboBoxColumn, richTextBoxLocalScript_ScriptFactory.Lines);
                UpdateComboBox(MainForm.dataGridViewOSBotManager.Columns["dataGridViewOSBotManager_Script"] as DataGridViewComboBoxColumn, richTextBoxLocalScript_OSBot.Lines);
                UpdateComboBox(MainForm.dataGridViewDreamBotManager.Columns["dataGridViewDreamBotManager_Script"] as DataGridViewComboBoxColumn, richTextBoxLocalScript_DreamBot.Lines);
                UpdateComboBox(MainForm.dataGridViewTRiBotManager.Columns["dataGridViewTRiBotManager_Script"] as DataGridViewComboBoxColumn, richTextBoxLocalScript_TRiBot.Lines);

                // Save the contents of the richTextBox to a file
                SaveRichTextBoxContent(MainForm.filePathApplicationDataLocalScriptsScriptFactory, richTextBoxLocalScript_ScriptFactory);
                SaveRichTextBoxContent(MainForm.filePathApplicationDataLocalScriptsDreamBot, richTextBoxLocalScript_ScriptFactory);
                SaveRichTextBoxContent(MainForm.filePathApplicationDataLocalScriptsOSBot, richTextBoxLocalScript_ScriptFactory);
                SaveRichTextBoxContent(MainForm.filePathApplicationDataLocalScriptsTRiBot, richTextBoxLocalScript_ScriptFactory);

                // Display success message
                MessageBox.Show("Scripts successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateComboBox(DataGridViewComboBoxColumn comboBoxColumn, string[] lines)
        {
            if (comboBoxColumn != null)
            {
                var uniqueLines = lines.Distinct().ToList();
                foreach (var line in uniqueLines)
                {
                    if (!comboBoxColumn.Items.Contains(line))
                    {
                        comboBoxColumn.Items.Add(line);
                    }
                }
            }
        }
        private void SaveRichTextBoxContent(string filePath, RichTextBox richTextBox)
        {
            File.WriteAllText(filePath, richTextBox.Text);
        }

        // Invoke - Populate Rich Text Boxes
        public void Invoke_PopulateRichTextBoxes()
        {
            // Check if the file exists, then read the content and set it to the RichTextBox
            if (File.Exists(MainForm.filePathApplicationDataLocalScriptsScriptFactory))
            {
                richTextBoxLocalScript_ScriptFactory.Text = File.ReadAllText(MainForm.filePathApplicationDataLocalScriptsScriptFactory);
            }

            if (File.Exists(MainForm.filePathApplicationDataLocalScriptsDreamBot))
            {
                richTextBoxLocalScript_OSBot.Text = File.ReadAllText(MainForm.filePathApplicationDataLocalScriptsDreamBot);
            }

            if (File.Exists(MainForm.filePathApplicationDataLocalScriptsOSBot))
            {
                richTextBoxLocalScript_DreamBot.Text = File.ReadAllText(MainForm.filePathApplicationDataLocalScriptsOSBot);
            }

            if (File.Exists(MainForm.filePathApplicationDataLocalScriptsTRiBot))
            {
                richTextBoxLocalScript_TRiBot.Text = File.ReadAllText(MainForm.filePathApplicationDataLocalScriptsTRiBot);
            }
        }

    }
}

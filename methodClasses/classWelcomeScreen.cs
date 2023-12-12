namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    internal class classWelcomeScreen
    {

        // Invoke - Fetch Text from Url and Paste into Rich Text Box
        public static async Task Invoke_FillRichTextBoxFromUrl(string url, RichTextBox richTextBox)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Fetch the text content from the URL
                    string content = await client.GetStringAsync(url);

                    // Invoke on UI thread to update the RichTextBox
                    richTextBox.Invoke(new Action(() =>
                    {
                        richTextBox.Text = content;
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching content: " + ex.Message);
            }
        }


    }
}

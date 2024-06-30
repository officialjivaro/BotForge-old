using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    public class invokeMethodsSearchQueries
    {
        private HttpClient httpClient = new HttpClient();

        public async Task<string[]> LoadQueriesAsync(string fileUrl)
        {
            var content = await httpClient.GetStringAsync(fileUrl);
            return content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public string ChooseRandomQuery(string[] queries)
        {
            Random rnd = new Random();
            int index = rnd.Next(queries.Length);
            return queries[index];
        }

        // You'll need to modify this method to work with your form's web browser control
        public void NavigateToGoogleSearch(string query, Krypton.Toolkit.KryptonWebBrowser webBrowser)
        {
            var searchUrl = $"https://www.google.com/search?q={Uri.EscapeDataString(query)}";
            webBrowser.Navigate(searchUrl);
        }
    }
}

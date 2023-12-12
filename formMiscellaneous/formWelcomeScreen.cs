using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;


namespace Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous
{
    public partial class formWelcomeScreen : Form
    {
        public formWelcomeScreen()
        {
            InitializeComponent();
        }

        public string urlTextFileLatestNews = "https://download.jivaro.net/s/8SBMwRcZTRa3Cz2/download/latest_news.txt";
        public string urlTextFileQuickSetup = "https://download.jivaro.net/s/cctHCiMDw8S7aPa/download/quick_setup_guide.txt";

        public async void formWelcomeScreen_Load(object sender, EventArgs e)
        {
            await classWelcomeScreen.Invoke_FillRichTextBoxFromUrl(urlTextFileQuickSetup, richTextBoxWelcomeScreen_QuickSetup);
            await classWelcomeScreen.Invoke_FillRichTextBoxFromUrl(urlTextFileLatestNews, richTextBoxWelcomeScreen_LatestNewst);

        }
    }
}

using Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.formMiscellaneous
{
    public partial class formProxyChoice : Form
    {
        // Initialize Instances
        private formMainForm MainForm;

        public formProxyChoice(formMainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        // Button CLick - Open IPRoyal
        public void btnProxyChoice_IPRoyal_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://iproyal.com?r=97274");
        }

        // Button CLick - Open Proxy-Cheap
        public void btnProxyChoice_ProxyCheap_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://app.proxy-cheap.com/r/b8bioF");
        }

        // Button CLick - Open Proxy-Seller
        public void btnProxyChoice_ProxySeller_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://proxy-seller.com/?partner=OLZ8XRZKH2I14E");
        }

        // Button CLick - Open See Full List
        public void btnProxyChoice_SeeFullList_Click(object sender, EventArgs e)
        {
            invokeMethodsActiveGlobal.Invoke_OpenLink("https://jivaro.net/media/blog/the-best-affordable-proxy-providers");
        }

    }
}

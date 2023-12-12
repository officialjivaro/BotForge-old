using System.Diagnostics;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    internal class invokeMethodsActiveGlobal
    {
        // Invoke - Bring Control To Front
        public static void Invoke_BringControlToFront(Control control)
        {
            if (control != null)
            {
                control.BringToFront();
            }
        }

        // Invoke - Open Link
        public static void Invoke_OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

    }
}

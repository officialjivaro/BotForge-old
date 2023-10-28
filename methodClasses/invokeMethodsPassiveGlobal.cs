using System.ComponentModel;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    internal class invokeMethodsPassiveGlobal
    {

        // Cancel Non Numbers From Textbox
        public static void GlobalMethod_CancelNonNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Cancel Non Numbers & Set Limit To 99 From Textbox
        public static void GlobalMethod_CancelNonNumbers_SetLimitTo99_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            var textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 99)
            {
                e.Handled = true;
            }
        }

        // Require Input On Textbox
        public static void GlobalMethod_RequireInput_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                // Ensure the textbox always has an input
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("This field is required");
                    e.Cancel = true;
                }
            }
            else
            {
            }
        }
    }

}

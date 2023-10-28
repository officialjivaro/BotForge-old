using System.Drawing.Drawing2D;

namespace Jivaro_Old_School_RuneScape_Bot_Manager.methodClasses
{
    internal class invokeMethodsAppearance
    {

        // Invoke - Round The Edges of Buttons
        public static void RoundEdges(Button btn)
        {
            Rectangle r = new Rectangle(0, 0, btn.Width, btn.Height);
            int radius = 20; // adjust this for the amount of roundness
            GraphicsPath path = new GraphicsPath();
            path.AddArc(r.X, r.Y, radius, radius, 180, 90);
            path.AddArc(r.Right - radius, r.Y, radius, radius, 270, 90);
            path.AddArc(r.Right - radius, r.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(r.X, r.Bottom - radius, radius, radius, 90, 90);
            btn.Region = new Region(path);
        }

    }
}

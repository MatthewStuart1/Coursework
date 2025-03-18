using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{

    public static class DarkMode
    {

        public static void Apply(Control control)
        {
            // DarkMode.Apply(this); <-- put in load method of each form
            control.BackColor = Color.FromArgb(45, 45, 48);
            control.ForeColor = Color.White;

            // turns buttons dark
            if (control is Button)
            {
                control.BackColor = Color.FromArgb(63, 63, 70);
            }

           // makes all controls dark
            foreach (Control child in control.Controls) // all child controls in this control
            {
                Apply(child);
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    [DefaultEvent("Click")]
    public partial class menuBoxControl : UserControl
    {
        public Image Icon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public String Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        // aspectRatio = 208 / 257;
        public menuBoxControl()
        {
            InitializeComponent();

            // forward clicks from PictureBox and Label to the UserControl.
            pictureBox1.Click += ChildControl_Click;
            label1.Click += ChildControl_Click;
        }

        // makes picbox and label clickable
        private void ChildControl_Click(object sender, EventArgs e)
        {
            // "this" = the control (makes them act as a group)
            this.OnClick(e);
        }



    }
}

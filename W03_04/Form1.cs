using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureTarget.Location = new Point((int)(this.Size.Width/100*e.NewValue), pictureTarget.Location.Y);
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureTarget.Location = new Point(pictureTarget.Location.X, (int)(this.Size.Height/100*e.NewValue));
        }
    }
}

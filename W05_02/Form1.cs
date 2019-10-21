using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            (new SplashScreen()).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool warning = false;
            foreach(Control control in this.Controls)
            {
                if(control is ComputerControl)
                {
                    if((control as ComputerControl).IsRunning)
                    {
                        warning = true;
                        break;
                    }   
                }
            }
            if (warning)
            {
                if(MessageBox.Show("Computer is running. Do you want to close?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

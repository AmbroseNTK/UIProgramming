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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private Timer timer;
        private int timeOut = 150;

        private void BtStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

            progressBar1.Minimum = 0;
            progressBar1.Maximum = timeOut;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < timeOut)
            {
                progressBar1.Value++;
            }
            else
            {
                this.Close();
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05_02
{
    public partial class ComputerControl : UserControl
    {
        public ComputerControl()
        {
            InitializeComponent();
        }

        private string title;

        private void ResetState()
        {
            btStart.Enabled = true;
            btEnd.Enabled = false;
            tbStart.Text = "";
            tbEnd.Text = "";
        }

        private DateTime startTime;
        private DateTime endTime;

        private bool isRunning = false;

        public string Title { get => title;
            set
            {
                title = value;
                groupBox1.Text = title;
            }
        }

        public bool IsRunning { get => isRunning; set => isRunning = value; }

        private void ComputerControl_Load(object sender, EventArgs e)
        {
            ResetState();
            btStart.Click += BtStart_Click;
            btEnd.Click += BtEnd_Click;
        }

        private void BtEnd_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now;
            tbEnd.Text = endTime.ToShortTimeString();
            double hours = (endTime - startTime).TotalHours;
            if(MessageBox.Show("Số giờ thuê:\t" + Math.Round(hours,4) + "\nSố tiền:\t\t" + Math.Round(hours * 3000,2), "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ResetState();
            }
            isRunning = false;
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            tbStart.Text = startTime.ToShortTimeString();
            btStart.Enabled = false;
            btEnd.Enabled = true;
            isRunning = true;
        }
    }
}

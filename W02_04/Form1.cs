using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02_04
{
    public partial class Form1 : Form
    {
        public int totalCustomer = 0;
        public float price = 0;
        public float sumPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(RadioButton radio in groupMenu.Controls)
            {
                radio.CheckedChanged += (s, args) =>
                {
                    price = int.Parse((s as RadioButton).Tag.ToString());
                };
            }
        }

        private void BtCheckout_Click(object sender, EventArgs e)
        {
            if (tbSVName.Text != "")
            {
                totalCustomer++;
                sumPrice += price * (cbSV.Checked ? 0.8f : 1);
                lbTongKH.Text = "Tổng KH: " + totalCustomer;
                lbTongTien.Text = "Tổng Tiền: " + Math.Round(sumPrice*1000, 2) + "đ";
                btCheckout.Enabled = false;
            }
            else
            {
                MessageBox.Show("Enter customer's name first !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtReEnter_Click(object sender, EventArgs e)
        {
            tbSVName.Text = "";
            btCheckout.Enabled = true;
        }
    }
}

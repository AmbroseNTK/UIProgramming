using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04_01
{
    public partial class Form1 : Form
    {
        public List<User> userList = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adsBox1.DisplayText = "COOP Mart - User Registration";
            adsBox1.Velocity = 2;
           
            adsBox1.Run();

            userList = new List<User>();
        }

        public bool Validate()
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Please enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("Please enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                new DateTime((int)numYear.Value, (int)numMonth.Value, (int)numDay.Value);
            }
            catch
            {
                MessageBox.Show("Invalid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbAddress.Text == "")
            {
                MessageBox.Show("Please enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbJob.Text == "")
            {
                MessageBox.Show("Please select job title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BtDK_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                User user = new User()
                {
                    Id = tbID.Text,
                    Name = tbName.Text,
                    Date = new DateTime((int)numYear.Value, (int)numMonth.Value, (int)numDay.Value),
                    Address = tbAddress.Text,
                    JobTitle = cbJob.SelectedItem.ToString()
                };
                userList.Add(user);

                MessageBox.Show("Xin chúc mừng thành viên mới\n" + user, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtNew_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            numDay.Value = 1;
            numMonth.Value = 1;
            numYear.Value = 1900;
            tbAddress.Text = "";
            cbJob.Text = "";
            tbID.Focus();
        }

        private void BtEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã có " + userList.Count + " thành viên là khách hàng VIP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

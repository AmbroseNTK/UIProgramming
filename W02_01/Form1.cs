using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNum1.TextChanged += NumValidate;
            tbNum2.TextChanged += NumValidate;
            
            foreach(RadioButton c in groupOps.Controls)
            {
                c.CheckedChanged += CheckOperator;
            }
        }

        private void CheckOperator(object sender, EventArgs e)
        {
            float num1 = 0f;
            float num2 = 0f;
            if (float.TryParse(tbNum1.Text, out num1) && float.TryParse(tbNum2.Text, out num2)) {
                switch ((sender as RadioButton).Tag)
                {
                    case "Add":
                        lbResult.Text = (num1 + num2).ToString();
                        break;
                    case "Sub":
                        lbResult.Text = (num1 - num2).ToString();
                        break;
                    case "Mul":
                        lbResult.Text = (num1 * num2).ToString();
                        break;
                    case "Div":
                        lbResult.Text = (num1 / num2).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Input is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumValidate(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            string value = (sender as TextBox).Text;
            for(int i = 0; i < value.Length; i++)
            {
                if(!char.IsDigit(value[i]) && value[i]!='.' && value[i]!='+'&& value[i] != '-')
                {
                    (sender as TextBox).BackColor = Color.Red;
                    break;
                }
            }
        }
    }
}

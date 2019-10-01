using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (RadioButton radio in groupFont.Controls)
            {
                radio.CheckedChanged += (s, args) =>
                {
                    tbText.Font = new Font((s as RadioButton).Text, tbText.Font.Size);
                };
            }
        }
    }
}

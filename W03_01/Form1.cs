using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkRegular.CheckedChanged += FontStyleChange;
            chkBold.CheckedChanged += FontStyleChange;
            chkItalic.CheckedChanged += FontStyleChange;
            chkBoldItalic.CheckedChanged += FontStyleChange;

            rdbAutoColor.CheckedChanged += ColorChange;
            rdbBlue.CheckedChanged += ColorChange;
            rdbGreen.CheckedChanged += ColorChange;
            rdbRed.CheckedChanged += ColorChange;

            rdbAlignCenter.CheckedChanged += AlignChange;
            rdbAlignLeft.CheckedChanged += AlignChange;
            rdbAlignRight.CheckedChanged += AlignChange;

        }

        private void AlignChange(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                lbText.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), "Top" + (sender as RadioButton).Text);
            }
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if ((sender as RadioButton).Text == "AutoColor")
                {
                    lbText.ForeColor = Color.Black;
                }
                else
                {
                    lbText.ForeColor = Color.FromName((sender as RadioButton).Text);
                }
            }
        }

        private void FontStyleChange(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                switch ((sender as CheckBox).Text)
                {
                    case "Regular":
                        lbText.Font = new Font(lbText.Font, FontStyle.Regular);
                        break;
                    case "Bold":
                        lbText.Font = new Font(lbText.Font, FontStyle.Bold);
                        break;
                    case "Italic":
                        lbText.Font = new Font(lbText.Font, FontStyle.Italic);
                        break;
                    case "Bold + Italic":
                        lbText.Font = new Font(lbText.Font, FontStyle.Bold | FontStyle.Italic);
                        break;
                }
            }
        }
    }
}

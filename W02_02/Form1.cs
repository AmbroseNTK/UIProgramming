using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            lbText.Text = (sender as TextBox).Text;
            (sender as TextBox).SelectionStart = lbText.Text.Length;
        }

        private void BtSelectFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lbText.Font = fontDialog1.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRegular.CheckedChanged += SelectStyle;
            radBold.CheckedChanged += SelectStyle;
            radItalic.CheckedChanged += SelectStyle;
            radBoldItalic.CheckedChanged += SelectStyle;

            radRed.CheckedChanged += SelectColor;
            radBlue.CheckedChanged += SelectColor;
            radGreen.CheckedChanged += SelectColor;
        }

        private void SelectColor(object sender, EventArgs e)
        {
            switch((sender as RadioButton).Tag)
            {
                case "Red":
                    lbText.ForeColor = Color.Red;
                    break;
                case "Blue":
                    lbText.ForeColor = Color.Blue;
                    break;
                case "Green":
                    lbText.ForeColor = Color.Green;
                    break;
            }
        }

        private void SelectStyle(object sender, EventArgs e)
        {
            Font font = lbText.Font;
            switch((sender as RadioButton).Tag)
            {
                case "Regular":
                    lbText.Font = new Font(font.FontFamily, font.Size, FontStyle.Regular);
                    break;
                case "Bold":
                    lbText.Font = new Font(font.FontFamily, font.Size, FontStyle.Bold);
                    break;
                case "Italic":
                    lbText.Font = new Font(font.FontFamily, font.Size, FontStyle.Italic);
                    break;
                case "BoldItalic":
                    lbText.Font = new Font(font.FontFamily, font.Size, FontStyle.Bold | FontStyle.Italic);
                    break;
            }
        }

        private void BtColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lbText.ForeColor = colorDialog1.Color;
            }
        }
    }
}

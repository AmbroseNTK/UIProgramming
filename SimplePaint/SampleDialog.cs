using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class SampleDialog : Form
    {

        Color selectedColor;

        public Color SelectedColor { get => selectedColor; set => selectedColor = value; }

        public SampleDialog()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            panelRed.Click += ColorPanel_Click;
            panelGreen.Click += ColorPanel_Click;
            panelBlue.Click += ColorPanel_Click;
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            panelBlue.BorderStyle = BorderStyle.None;
            panelGreen.BorderStyle = BorderStyle.None;
            panelRed.BorderStyle = BorderStyle.None;

            (sender as FlowLayoutPanel).BorderStyle = BorderStyle.Fixed3D;
            
            selectedColor = (sender as FlowLayoutPanel).BackColor;
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

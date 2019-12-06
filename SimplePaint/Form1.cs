using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        Canvas canvas = new Canvas();
        string savedFile = "";
        public Form1()
        {
            InitializeComponent();
            canvas.Dock = DockStyle.Fill;
            this.Controls.Add(canvas);
            colorBlack.Click += OnSelectedColor;
            colorBlue.Click += OnSelectedColor;
            colorGreen.Click += OnSelectedColor;
            colorRed.Click += OnSelectedColor;
            colorYellow.Click += OnSelectedColor;
            this.canvas.ChangePosition += delegate (Point pos)
            {
                statusPosition.Text = "x = " + pos.X + "; y = " + pos.Y;
            };
            contextClear.Click += BtNew_Click;
            contextEllipse.Click += btEllipse_Click;
            contextRect.Click += btRect_Click;
            contextPen.Click += btPen_Click;
            canvas.MouseClick += Canvas_MouseClick;
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Right)
            {
                contextDraw.Show(Cursor.Position);
            }
        }

        private Color selectedColor = Color.Black;

        private void OnSelectedColor(Object sender, EventArgs e)
        {
            selectedColor = ((Panel) sender).BackColor;
            canvas.ToolColor = selectedColor;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        
        private void btPen_Click(object sender, EventArgs e)
        {
            this.canvas.Draw(ToolType.Pen,selectedColor);
        }

        private void btRect_Click(object sender, EventArgs e)
        {
            this.canvas.Draw(ToolType.Rectangle,selectedColor);
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            this.canvas.Draw(ToolType.Ellipse,selectedColor);
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            this.canvas.Draw(ToolType.Eraser,selectedColor);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Image image = this.canvas.Paper;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap *.bmp|(*.bmp)";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName);
            }
        }

        private void BtNew_Click(object sender, EventArgs e)
        {
            canvas.Clear();
        }

        private void BtToggleGrid_Click(object sender, EventArgs e)
        {
            this.canvas.ToggleGrid(50);
        }

        private void BtToggleCaroMode_Click(object sender, EventArgs e)
        {
            this.canvas.ToggleCaroMode();
        }

        private void BtOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap file (*.bmp)|*.bmp|Jpg (*.jpg)|*.jpg| Png (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.Paper = new Bitmap(openFileDialog.FileName);
                savedFile = openFileDialog.FileName;
            }
        }

        private void BtPrint_Click(object sender, EventArgs e)
        {
           
            if (savedFile != "")
            {
                var p = new Process();
                p.StartInfo.FileName = savedFile;
                p.StartInfo.Verb = "Print";
                p.Start();
            }
           
        }
        private void BtMoreColor_Click(object sender, EventArgs e)
        {

            
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.ToolColor = colorDialog.Color;
            }

        }
    }
}
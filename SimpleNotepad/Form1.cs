using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richText.TextChanged += RichText_TextChanged;
            richText.MouseClick += RichText_MouseClick;
        }

        private void RichText_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void RichText_TextChanged(object sender, EventArgs e)
        {
            if (richText.Lines.Length != 0)
            {
                statusLocation.Text = "Lines: " + richText.Lines.Length + "; Char: " + richText.Lines[richText.Lines.Length - 1].Length;
            }
        }

        private void BtUndo_Click(object sender, EventArgs e)
        {
            if (richText.CanUndo)
            {
                richText.Undo();
            }
        }

        private void BtRedo_Click(object sender, EventArgs e)
        {
            if (richText.CanRedo)
            {
                richText.Redo();
            }
        }

        private void BtFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richText.Font = fontDialog.Font;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open file...";
            openFileDialog.Filter = "Text file *.txt|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richText.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save file...";
            saveFileDialog.Filter = "Text file *.txt|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, richText.Text);
            }
        }
    }
}

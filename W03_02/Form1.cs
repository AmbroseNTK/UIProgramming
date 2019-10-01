using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (RadioButton radio in groupCountries.Controls)
            {
                radio.CheckedChanged += ChangeFlag;
            }
        }

        private void ChangeFlag(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                DownloadImage((sender as RadioButton).Tag.ToString());
            }
        }

        public void DownloadImage(string imageUrl)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                pictureFlag.Image = bitmap;
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
        }
    }
}

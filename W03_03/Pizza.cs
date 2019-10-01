using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace W03_03
{
    class Pizza
    {
        private string imageUrl;
        private Bitmap image;
        private List<String> recipts;
        private List<String> ingredients;

        public string ImageUrl { get => imageUrl;
            set {
                imageUrl = value;
                DownloadImage(imageUrl);
            }
        }
        public Bitmap Image { get => image; }
        public List<string> Recipts { get => recipts; set => recipts = value; }
        public List<string> Ingredients { get => ingredients; set => ingredients = value; }
        public void DownloadImage(string imageUrl)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            image = new Bitmap(stream);
            stream.Flush();
            stream.Close();
            client.Dispose();
        }
    }
}

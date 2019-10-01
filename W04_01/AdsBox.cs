using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04_01
{
    public partial class AdsBox : UserControl
    {
        public AdsBox()
        {
            label = new Label();
            label.Location = new Point(0, 0);
            this.Controls.Add(label);
            InitTimer();
            InitializeComponent();
           
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Interval = velocity;
            timer.Tick += (sender, e) =>
            {
                label.Location = new Point(label.Location.X + velocity, label.Location.Y);
                if (label.Location.X > this.Width)
                {
                    label.Location = new Point(-label.Width, label.Location.Y);
                }
            };
        }

        private string displayText = "";
        private int velocity = 1;
        private Label label;
        private Timer timer;

        public string DisplayText { get => displayText;
            set
            {
                displayText = value;
                this.label.Text = displayText;
                this.label.AutoSize = true;
                this.label.Font = this.Font;
                this.label.ForeColor = this.ForeColor;
            }
        }

        public int Velocity { get => velocity;
            set {
                velocity = value;
                InitTimer();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            this.label.Location = new Point(this.label.Location.X, this.Height / 2 - this.label.Height / 2);
            base.OnResize(e);
        }

        public void Run()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }

    }
}

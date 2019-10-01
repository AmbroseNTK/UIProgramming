using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtViewCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = new DateTime((int)(numYear.Value), (int)(numMonth.Value), (int)(numDay.Value));
                lbDay.Text = date.Day.ToString();
                groupCalendar.Text = "Lịch năm " + date.Year;
                switch (date.Month)
                {
                    case 1:
                        lbMonth.Text = "Tháng Một";
                        break;
                    case 2:
                        lbMonth.Text = "Tháng Hai";
                        break;

                    case 3:
                        lbMonth.Text = "Tháng Ba";
                        break;

                    case 4:
                        lbMonth.Text = "Tháng Tư";
                        break;

                    case 5:
                        lbMonth.Text = "Tháng Năm";
                        break;

                    case 6:
                        lbMonth.Text = "Tháng Sáu";
                        break;

                    case 7:
                        lbMonth.Text = "Tháng Bảy";
                        break;

                    case 8:
                        lbMonth.Text = "Tháng Tám";
                        break;

                    case 9:
                        lbMonth.Text = "Tháng Chín";
                        break;

                    case 10:
                        lbMonth.Text = "Tháng Mười";
                        break;

                    case 11:
                        lbMonth.Text = "Tháng Mười Một";
                        break;

                    case 12:
                        lbMonth.Text = "Tháng Mười Hai";
                        break;

                }

                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        lbDayOfWeek.Text = "Thứ Hai";
                        break;
                    case DayOfWeek.Tuesday:
                        lbDayOfWeek.Text = "Thứ Ba";
                        break;
                    case DayOfWeek.Wednesday:
                        lbDayOfWeek.Text = "Thứ Tư";
                        break;
                    case DayOfWeek.Thursday:
                        lbDayOfWeek.Text = "Thứ Năm";
                        break;
                    case DayOfWeek.Friday:
                        lbDayOfWeek.Text = "Thứ Sáu";
                        break;
                    case DayOfWeek.Saturday:
                        lbDayOfWeek.Text = "Thứ Bảy";
                        break;
                    case DayOfWeek.Sunday:
                        lbDayOfWeek.Text = "Chủ Nhật";
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04_01
{
    public class User
    {
        private string id;
        private string name;
        private DateTime date;
        private string address;
        private string jobTitle;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Address { get => address; set => address = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public override string ToString()
        {
            return "Mã số: " + Id + "\n"
                + "Họ tên: " + Name + "\n"
                + "Ngày: " + Date.ToShortDateString() + "\n"
                + "Địa chỉ: " + Address + "\n"
                + "Nghề: " + JobTitle + "\n";
        }
    }
}

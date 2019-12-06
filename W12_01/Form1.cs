using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W12_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        Order currentOrder = null;

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentOrder = (from order in model.Orders where order.OrderID == (int)listBox1.SelectedItem select order).FirstOrDefault();
            dataGridView1.DataSource = (from order in model.Order_Details where order.OrderID == (int)listBox1.SelectedItem select order).ToList();
            if (currentOrder != null)
            {
                custID.Text = currentOrder.CustomerID;
                custName.Text = currentOrder.Customer.ContactName;
                orderDate.Text = currentOrder.OrderDate.ToString();
                requiredDate.Text = currentOrder.RequiredDate.ToString();
                shipDate.Text = currentOrder.ShippedDate.ToString();
                shipName.Text = currentOrder.ShipName;
                shipAddress.Text = currentOrder.ShipAddress;
                shipCity.Text = currentOrder.ShipCity;
            }
        }

        NorthwindModel model = new NorthwindModel();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listBox1.Items.Clear();
            (from order in model.Orders select order.OrderID).ToList().ForEach((id) => listBox1.Items.Add(id));
            
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
           if (currentOrder != null)
            {
                currentOrder.CustomerID = custID.Text;
                currentOrder.Customer.ContactName = custName.Text;
                currentOrder.OrderDate = DateTime.Parse(orderDate.Text);
                currentOrder.RequiredDate = DateTime.Parse(requiredDate.Text);
                currentOrder.ShippedDate = DateTime.Parse(shipDate.Text);
                currentOrder.ShipName = shipName.Text;
                currentOrder.ShipAddress = shipAddress.Text;
                currentOrder.ShipCity = shipCity.Text;
            }
            model.SaveChanges();
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (currentOrder!= null)
            {
                model.Orders.Remove(currentOrder);
            }
            model.SaveChanges();
            LoadData();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            currentOrder = new Order();
            currentOrder.CustomerID = custID.Text;
            currentOrder.OrderDate = DateTime.Parse(orderDate.Text);
            currentOrder.RequiredDate = DateTime.Parse(requiredDate.Text);
            currentOrder.ShippedDate = DateTime.Parse(shipDate.Text);
            currentOrder.ShipName = shipName.Text;
            currentOrder.ShipAddress = shipAddress.Text;
            currentOrder.ShipCity = shipCity.Text;

            model.Orders.Add(currentOrder);
            model.SaveChanges();
            LoadData();
        }
    }
}

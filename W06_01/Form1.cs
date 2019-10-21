using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Contact> contacts = new List<Contact>();

        private void Form1_Load(object sender, EventArgs e)
        {
            treeContact.ImageList = imageList1;
            
            for(char c = 'A'; c < 'Z'; c++)
            {
                treeContact.Nodes.Add(c.ToString(),c.ToString(), 0, 1);
            }
            lvContact.Columns.Add("First Name",100);
            lvContact.Columns.Add("Last Name",100);
            lvContact.Columns.Add("Phone Number",150);
          
        }

        private void BtAddName_Click(object sender, EventArgs e)
        {
            contacts.Add(new Contact()
            {
                LastName = tbLastName.Text,
                FirstName = tbFirstName.Text,
                PhoneNumber = tbPhone.Text
            });
            if (tbFirstName.Text != "")
            {
                foreach (TreeNode node in treeContact.Nodes)
                {
                    if (node.Text == (char.ToUpper(tbFirstName.Text[0])).ToString()) {
                        node.Nodes.Add(new TreeNode(tbFirstName.Text + ", " + tbLastName.Text, 2, 2));
                    }
                }
            }
            ListViewItem item = new ListViewItem(new string[] { tbLastName.Text,tbFirstName.Text,tbPhone.Text});
            item.SubItems.Add(tbLastName.Text);
            item.SubItems.Add(tbFirstName.Text);
            item.SubItems.Add(tbPhone.Text);
            lvContact.Items.Add(item);
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvContact.View = View.List;
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvContact.View = View.Details;
        }
    }
}

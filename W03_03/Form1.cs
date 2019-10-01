using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbPizza01.Tag = new Pizza()
            {
                ImageUrl = "https://dominos.vn/Data/Sites/1/Product/723/seafood-insland-slide.png",
                Ingredients = new List<string>() { "Mozzarella cheese", "shrimp", "squid" },
                Recipts = new List<string>() { "7-inches", "9-inches", "12-inches" }
            };
            rdbPizza01.CheckedChanged += SelectPizza;
            rdbPizza02.Tag = new Pizza()
            {
                ImageUrl = "https://dominos.vn/Data/Sites/1/Product/583/pepperronifn.png",
                Ingredients = new List<string>() { "Pepperoni sausage", "tomato", "pepper","cheese" },
                Recipts = new List<string>() {  "9-inches", "12-inches" }
            };
            rdbPizza02.CheckedChanged += SelectPizza;
            rdbPizza03.Tag = new Pizza()
            {
                ImageUrl = "https://dominos.vn/Data/Sites/1/Product/593/cheesy-chicken-bacon.png",
                Ingredients = new List<string>() { "Mozzarella cheese", "chicken", "pepper" },
                Recipts = new List<string>() { "7-inches", "12-inches" }
            };
            rdbPizza03.CheckedChanged += SelectPizza;
            rdbPizza04.Tag = new Pizza()
            {
                ImageUrl = "https://dominos.vn/Data/Sites/1/Product/582/surf-and-turf.png",
                Ingredients = new List<string>() { "Mozzarella cheese", "shrimp", "beef" },
                Recipts = new List<string>() { "7-inches", "9-inches", "12-inches" }
            };
            rdbPizza04.CheckedChanged += SelectPizza;
            rdbPizza05.Tag = new Pizza()
            {
                ImageUrl = "https://dominos.vn/Data/Sites/1/Product/581/seafood-delight.png",
                Ingredients = new List<string>() { "Tomato sauce","cheese", "shrimp", "squid","crab" },
                Recipts = new List<string>() {  "9-inches", "12-inches" }
            };
            rdbPizza05.CheckedChanged += SelectPizza;
        }

        private void SelectPizza(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                Pizza pizza = (sender as RadioButton).Tag as Pizza;
                picturePizza.Image = pizza.Image;
                lbRecipe.Items.Clear();
                lbIngredients.Items.Clear();
                pizza.Recipts.ForEach((recipt) => lbRecipe.Items.Add(recipt));
                pizza.Ingredients.ForEach((ingredient) => lbIngredients.Items.Add(ingredient));
            }
        }
    }
}

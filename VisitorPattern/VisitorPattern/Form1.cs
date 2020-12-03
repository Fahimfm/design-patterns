using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPattern
{
    public partial class Form1 : Form
    {

        GeneralItem GeneralItem;
        List<GeneralItem> orderItems = new List<GeneralItem>();
        Double Sum;
        double DiscountSum;
        SaleDiscount sale = new SaleDiscount();
        GoldenDiscount golden = new GoldenDiscount();
        public Form1()
        {
            InitializeComponent();
        }




        public void Update()
        {

            richTextBox1.Text = " ";
            Sum = 0;

            foreach (GeneralItem item in orderItems)
            {
                richTextBox1.Text += item.GetName() + " PRICE  " + item.GetPrice().ToString() + " $  *******************************************   ";
                Sum += item.GetPrice();
            }

            richTextBox1.Text += " total price for your order " + Sum.ToString();

        }

        private void buttonShowDiscount_Click(object sender, EventArgs e)
        {
            if (radioButtonGoldenDiscount.Checked)
            {
                foreach (GeneralItem item in orderItems)
                {
                    DiscountSum += item.accept(golden);
                }

            }

            if (radioButtonSaleDiscount.Checked)
            {
                foreach (GeneralItem item in orderItems)
                {
                    DiscountSum += item.accept(sale);
                }

            }

            MessageBox.Show(" new price after discount " + DiscountSum.ToString() + "$");
            DiscountSum = 0.0;
        }
        //Adding Items
        private void buttonApple_Click(object sender, EventArgs e)
        {
            GeneralItem = new FruitItem("Apple", 1.5);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            GeneralItem = new FruitItem("Orange", 1.2);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonBanana_Click(object sender, EventArgs e)
        {
            GeneralItem = new FruitItem("banana", 1.7);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonStrawberry_Click(object sender, EventArgs e)
        {
            GeneralItem = new FruitItem("Strawberry", 2.5);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonMango_Click(object sender, EventArgs e)
        {
            GeneralItem = new FruitItem("Mango", 2.1);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonOnion_Click(object sender, EventArgs e)
        {
            GeneralItem = new VegetableItem("onion", 0.7);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonRedPepper_Click(object sender, EventArgs e)
        {
            GeneralItem = new VegetableItem("red pepper", 0.9);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonPeas_Click(object sender, EventArgs e)
        {
            GeneralItem = new VegetableItem("peas", 0.5);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonBroccoli_Click(object sender, EventArgs e)
        {
            GeneralItem = new VegetableItem("broccoli", 1.7);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonCorn_Click(object sender, EventArgs e)
        {
            GeneralItem = new VegetableItem("corn", 0.7);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonMilk_Click(object sender, EventArgs e)
        {
            GeneralItem = new DairyItem("Milk", 1.4);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonYogurt_Click(object sender, EventArgs e)
        {
            GeneralItem = new DairyItem("Yogurt ", 1.0);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonCheese_Click(object sender, EventArgs e)
        {
            GeneralItem = new DairyItem("Cheese", 5.4);
            orderItems.Add(GeneralItem);
            Update();
        }

        private void buttonButter_Click(object sender, EventArgs e)
        {
            GeneralItem = new DairyItem("Butter", 1.2);
            orderItems.Add(GeneralItem);
            Update();
        }
    }
}

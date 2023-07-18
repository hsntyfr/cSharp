using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Order.FicheOrder();
            //Form5 form5 = new Form5();
            //foreach (string food in this.orderReviewCombobox.Items)
            //{
            //    foreach (Food foodCompare in Food.foods)
            //    {
            //        if (food == foodCompare.name)
            //        {
            //            Delivery.deliveryCheck.Add(foodCompare);
            //        }
            //    }
            //}
            //string foodLabel = "Food";
            //string priceLabel = "Price";
            //string titleReview = String.Format("{0,-40} {1,-20}\r", foodLabel, priceLabel);
            //form5.orderReviewLabel.Text = titleReview;

            //foreach (Food food in Delivery.deliveryCheck)
            //{
            //    string foodReview = String.Format("{0,-40} {1,-20}\r", food.name, food.price);
            //    form5.orderReviewLabel.Text += foodReview;
            //}
            //form5.Show();
            //this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Food food in Food.foods)
            {
                this.orderCombobox.Items.Add(food.name);
                Order.order.Add(food, 0);
            }
            
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            orderReviewCombobox.Items.Add(Order.AddFood(orderCombobox.SelectedIndex.ToString()).name);
        }

        private void removeFoodButton_Click(object sender, EventArgs e)
        {
            orderReviewCombobox.Items.Remove(Order.RemoveFood(orderCombobox.SelectedIndex.ToString()).name);
        }
    }
}

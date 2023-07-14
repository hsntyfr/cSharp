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
            Form5 form5 = new Form5();
            foreach (string food in this.orderReviewCombobox.Items)
            {
                foreach (Food foodCompare in Food.foods)
                {
                    if (food == foodCompare.name)
                    {
                        Delivery.deliveryCheck.Add(foodCompare);
                    }
                }
            }
            string foodLabel = "Food";
            string priceLabel = "Price";
            string titleReview = String.Format("{0,-40} {1,-20}\r", foodLabel, priceLabel);
            form5.orderReviewLabel.Text = titleReview;

            foreach (Food food in Delivery.deliveryCheck)
            {
                string foodReview = String.Format("{0,-40} {1,-20}\r", food.name, food.price);
                form5.orderReviewLabel.Text += foodReview;
            }
            form5.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Food food in Food.foods)
            {
                this.orderCombobox.Items.Add(food.name);
            }
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = orderCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            orderReviewCombobox.Items.Add(Food.foods[selectedFoodIndex].name);
            //orderLabel.Text += "\r" + Food.foods[selectedFoodIndex].name;
            //if (!orderReviewCombobox.Items.Contains(Food.foods[selectedFoodIndex].name))
            //{
            //    orderReviewCombobox.Items.Add(Food.foods[selectedFoodIndex].name);
            //}
        }

        private void removeFoodButton_Click(object sender, EventArgs e)
        {
            string removedFood = orderCombobox.SelectedIndex.ToString();
            int removedFoodIndex = int.Parse(removedFood);
            if (orderReviewCombobox.Items.Contains(Food.foods[removedFoodIndex].name))
            {
                orderReviewCombobox.Items.Remove(Food.foods[removedFoodIndex].name);
            }

        }
    }
}

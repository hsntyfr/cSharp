using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            foreach (KeyValuePair<Food, int> food in Order.order)
            {
                //Food key = food.Key;
                //int value = food.Value;
                if (food.Value > 0)
                {
                    foreach (KeyValuePair<Food, int> order in Food.foodCapacity)
                    {
                        if (order.Value > 0)
                        {
                            Food.foodCapacity[food.Key] -= order.Value;

                        }
                    }
                }
            }

            //foreach (Food food in Delivery.deliveryCheck)
            //{
            //    form2.orderReviewCombobox.Items.Add(food.name);
            //}
            //Delivery.deliveryCheck.Clear();
            form2.Show();
            this.Close();
            //Form2 form2 = new Form2();
            //foreach (KeyValuePair<Food, int> order in Order.order)
            //{
            //    if (order.Value > 0 && Food.foodCapacity[order.Key] >= order.Value)
            //    {
            //        form2.orderLabel.Text = "ok";
            //    }
            //}
            //form2.orderLabel.Text = "Food capacity is changed";
            //form2.Show();
            //this.Close();

            //form2.orderReviewCombobox.Items.Clear();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            foreach (KeyValuePair<Food, int> food in Order.order)
            {
                //Food key = food.Key;
                //int value = food.Value;
                if (food.Value > 0)
                {
                    for (int i = 0; i < food.Value; i++)
                    {
                        form2.orderReviewCombobox.Items.Add(food.Key.name);

                    }
                }
            }
            //foreach (Food food in Delivery.deliveryCheck)
            //{
            //    form2.orderReviewCombobox.Items.Add(food.name);
            //}
            //Delivery.deliveryCheck.Clear();
            form2.Show();
            this.Close();
        }
    }
}

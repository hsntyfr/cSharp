using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            foodTotalLabel.Text = $"{"Food Name", -20}{"Cost", -20}{"Count", -20}{"Total Cost",-20}\r";
            foreach (KeyValuePair <Food, int> food in Food.foodCapacity)
            {
                if (food.Value > 0)
                {
                    foodTotalLabel.Text += $"{food.Key.name, -20}{Food.CalculateCost(food.Key), -20}{food.Value, -20}{Food.CalculateCost(food.Key) * food.Value, -20}\r";
                }
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}

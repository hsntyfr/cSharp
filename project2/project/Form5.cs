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
            form2.orderLabel.Text = "Repo is changed";
            form2.Show();
            this.Close();
            form2.orderReviewCombobox.Items.Clear();
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
            //buralar silinecek
            Form2 form2 = new Form2();
            foreach (Food food in Delivery.deliveryCheck)
            {
                form2.orderReviewCombobox.Items.Add(food.name);
            }
            Delivery.deliveryCheck.Clear();
            form2.Show();
            this.Close();

        }
    }
}

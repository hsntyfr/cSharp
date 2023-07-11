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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            materialCombobox.Items.Add(111);
            Material.LoadMaterials();
        }

        private void materialsButton_Click(object sender, EventArgs e)
        {
            string newMaterial = materialTextBox.Text;
            string[] data = newMaterial.Split(',');
            if (data.Length == 5)
            {
                string name = data[0];
                DateTime productionDate = DateTime.Parse(data[1]);
                DateTime expirationDate = DateTime.Parse(data[2]);
                float stock = float.Parse(data[3]);
                float price = float.Parse(data[4]);
                Material material = new Material(name, productionDate, expirationDate, stock, price);
                Material.materials.Add(material);
                materialCombobox.Items.Add(material.name);
                materialTextBox.Text = "";
                Material.Write(Material.materials, "C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
            }

        }
    }
}

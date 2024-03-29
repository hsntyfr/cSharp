﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            foreach (Material material in Material.materials)
            {
                this.materialCombobox.Items.Add(material.name);
            }
        }

        private void materialAddButton_Click(object sender, EventArgs e)
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
                
                if (Material.SearchMaterial(name))
                {
                    materialLabel.Text = "Material is already exist change material name";
                }
                else
                {
                    Material.materials.Add(material);
                    materialCombobox.Items.Add(material.name);
                    materialLabel.Text = "Material is added";
                }                
                materialTextBox.Text = string.Empty;
                Material.Write(Material.materials, "C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string selectedMaterial = materialCombobox.SelectedIndex.ToString();
            int selectedMaterialIndex = int.Parse(selectedMaterial);
            Material showedMaterial = Material.materials[selectedMaterialIndex];
            materialLabel.Text = "Material Name: " + showedMaterial.name + "\r" + "Production Date: " + showedMaterial.productionDate.ToString() + "\r" + "Expiration Date: " + showedMaterial.expirationDate.ToString() + "\r" + "Stock: " + showedMaterial.stock.ToString() + "\r" + "Price: " + showedMaterial.price.ToString();

        }

        private void materialEditButton_Click(object sender, EventArgs e)
        {
            string selectedMaterial = materialCombobox.SelectedIndex.ToString();
            int selectedMaterialIndex = int.Parse(selectedMaterial);
            Material showedMaterial = Material.materials[selectedMaterialIndex];
            materialTextBox.Text = $"{showedMaterial.name},{showedMaterial.productionDate},{showedMaterial.expirationDate},{showedMaterial.stock},{showedMaterial.price}";

        }

        private void saveMaterialButton_Click(object sender, EventArgs e)
        {

            string selectedMaterial = materialCombobox.SelectedIndex.ToString();
            int selectedMaterialIndex = int.Parse(selectedMaterial);
            string[] edittedMaterialText = materialTextBox.Text.Split(",");
            Material.materials[selectedMaterialIndex].name = edittedMaterialText[0];
            Material.materials[selectedMaterialIndex].productionDate = DateTime.Parse(edittedMaterialText[1]);
            Material.materials[selectedMaterialIndex].expirationDate = DateTime.Parse(edittedMaterialText[2]);
            Material.materials[selectedMaterialIndex].stock = float.Parse(edittedMaterialText[3]);
            Material.materials[selectedMaterialIndex].price = float.Parse(edittedMaterialText[4]);
            materialTextBox.Text = string.Empty;
            materialLabel.Text = "Material is changed";
            foreach (Material material in Material.materials)
            {
                Material.Write(Material.materials, "C:\\Users\\Hasan\\source\\repos\\project\\project\\list2.txt");
                File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
                File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\list2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
            }
        }

        private void deleteMaterialButton_Click(object sender, EventArgs e)
        {
            string selectedMaterial = materialCombobox.SelectedIndex.ToString();
            int selectedMaterialIndex = int.Parse(selectedMaterial);
            List<Material> newMaterials = new List<Material>();
            foreach (Material material in Material.materials)
            {
                if (material.name != Material.materials[selectedMaterialIndex].name)
                {
                    newMaterials.Add(material);
                    Material.Write(newMaterials, "C:\\Users\\Hasan\\source\\repos\\project\\project\\list2.txt");
                    File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
                    File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\list2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
                }
            }

            Material.materials.Clear();
            materialCombobox.Items.Clear();
            Material.materials = Material.ReadMaterial("C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");

            foreach (Material material in Material.materials)
            {
                this.materialCombobox.Items.Add(material.name);
            }
            materialLabel.Text = "Material is deleted";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            materialLabel.Text = string.Empty;
            materialTextBox.Text = string.Empty;
        }

        private void repoReportButton_Click(object sender, EventArgs e)
        {

            switch (repoReportCombobox.SelectedIndex)
            {
                case -1:
                    materialLabel.Text = "Please select any case";
                    break;

                case 0:
                    Material.StockLowToHighMaterial();
                    break;

                case 1:
                    Material.StockHighToLowMaterial();
                    break;

                case 2:
                    Material.OldestMaterial();
                    break;

                case 3:
                    Material.NewestMaterial();
                    break;
            }
        }

        private void repoReportCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

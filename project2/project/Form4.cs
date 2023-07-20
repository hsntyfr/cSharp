using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Food food in Food.foods)
            {
                this.foodCombobox.Items.Add(food.name);
            }
        }

        private void foodAddButton_Click(object sender, EventArgs e)
        {
            string newMaterial = menuTextbox.Text;
            string[] data = newMaterial.Split(',');
            if (data.Length == 12)
            {
                int kind = int.Parse(data[0]);
                string name = data[1];
                float price = float.Parse(data[2]);
                int tax = int.Parse(data[3]);
                string material1 = data[4];
                float material1Amount = float.Parse(data[5]);
                string material2 = data[6];
                float material2Amount = float.Parse(data[7]);
                string material3 = data[8];
                float material3Amount = float.Parse(data[9]);
                string material4 = data[10];
                float material4Amount = float.Parse(data[11]);

                Food food = new Food(kind, name, price, tax, material1, material1Amount, material2, material2Amount, material3, material3Amount, material4, material4Amount);
                Food.foods.Add(food);
                foodCombobox.Items.Add(food.name);
                foodLabel.Text = "Food is added";
                Food.WriteFood(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");
                Food.WriteRecipe(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe.txt");

            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            Food showedFood = Food.foods[selectedFoodIndex];
            foodLabel.Text = "Food Name: " + showedFood.name + "\r" + "Price: " + showedFood.price.ToString() + "\r" + "Tax: " + showedFood.tax.ToString() + "\r" + "Material: " + showedFood.material1.ToString() + "\r" + "Material Amount: " + showedFood.material1Amount.ToString() + "\r" + "Material: " + showedFood.material2.ToString() + "\r" + "Material Amount: " + showedFood.material2Amount.ToString() + "\r" + "Material: " + showedFood.material3.ToString() + "\r" + "Material Amount: " + showedFood.material3Amount.ToString() + "\r" + "Material: " + showedFood.material4.ToString() + "\r" + "Material Amount: " + showedFood.material4Amount.ToString() + "\r";
        }

        private void editFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            Food showedFood = Food.foods[selectedFoodIndex];
            menuTextbox.Text = $"{showedFood.kind},{showedFood.name},{showedFood.price},{showedFood.tax},{showedFood.material1},{showedFood.material1Amount},{showedFood.material2},{showedFood.material2Amount},{showedFood.material3},{showedFood.material3Amount},{showedFood.material4},{showedFood.material4Amount}";
        }

        private void saveFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            string[] edittedFoodText = menuTextbox.Text.Split(",");
            Food.foods[selectedFoodIndex].kind = int.Parse(edittedFoodText[0]);
            Food.foods[selectedFoodIndex].name = edittedFoodText[1];
            Food.foods[selectedFoodIndex].price = float.Parse(edittedFoodText[2]);
            Food.foods[selectedFoodIndex].tax = int.Parse(edittedFoodText[3]);
            Food.foods[selectedFoodIndex].material1 = edittedFoodText[4];
            Food.foods[selectedFoodIndex].material1Amount = float.Parse(edittedFoodText[5]);
            Food.foods[selectedFoodIndex].material2 = edittedFoodText[6];
            Food.foods[selectedFoodIndex].material2Amount = float.Parse(edittedFoodText[7]);
            Food.foods[selectedFoodIndex].material3 = edittedFoodText[8];
            Food.foods[selectedFoodIndex].material3Amount = float.Parse(edittedFoodText[9]);
            Food.foods[selectedFoodIndex].material4 = edittedFoodText[10];
            Food.foods[selectedFoodIndex].material4Amount = float.Parse(edittedFoodText[11]);

            menuTextbox.Text = string.Empty;
            foodLabel.Text = "Food is editted";
            foreach (Food food in Food.foods)
            {
                Food.WriteFood(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\food2.txt");
                Food.WriteRecipe(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe2.txt");
                File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");
                File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\food2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");
                File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe.txt");
                File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe.txt");
            }
        }

        private void deleteFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            List<Food> newFoods = new List<Food>();
            foreach (Food food in Food.foods)
            {
                if (food.name != Food.foods[selectedFoodIndex].name)
                {
                    newFoods.Add(food);
                    Food.WriteFood(newFoods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\food2.txt");
                    Food.WriteRecipe(newFoods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe2.txt");
                    File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");
                    File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\food2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");
                    File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe.txt");
                    File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe.txt");

                }
            }
            Food.foods.Clear();
            foodCombobox.Items.Clear();
            Food.foods = Food.ReadFood("C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");

            foreach (Food food in Food.foods)
            {
                this.foodCombobox.Items.Add(food.name);
            }
            foodLabel.Text = "Food is deleted";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foodLabel.Text = "Food is not selected\r\n1-Salad\r\n2-Meal\r\n3-Snack\r\n4-Desert\r\n";
            menuTextbox.Text = string.Empty;
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {
            switch (foodReportCombobox.SelectedIndex)
            {
                case -1:
                    foodLabel.Text = "Please select any case";
                    break;

                case 0:
                    Food.PriceLowToHigh();
                    break;

                case 1:
                    Food.PriceHighToLow();
                    break;

                case 2:
                    Food.TaxLowToHigh();
                    break;

                case 3:
                    Food.TaxHighToLow();
                    break;
            }
        }

        private void setDailyFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            string selectedFoodName = Food.foods[selectedFoodIndex].name;
            foreach (KeyValuePair<Food, int> settedFood in Food.foodCapacity)
            {
                if (settedFood.Key.name == selectedFoodName)
                {
                    menuTextbox.Text = $"{settedFood.Key.name},{settedFood.Value}";

                }
            }
        }

        private void saveDailyFoodButton_Click(object sender, EventArgs e)
        {
            string[] settedFood = menuTextbox.Text.Split(',');
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            Food.foodCapacity[Food.foods[selectedFoodIndex]] = int.Parse(settedFood[1]);
            foodLabel.Text = "Capacity is changed";
        }

        private void finalDailyFoodButton_Click(object sender, EventArgs e)
        {
            Food.DailyFoodList();
            foodLabel.Text = "Shop list created";
        }
        
    }
}

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
            if (data.Length == 7)
            {
                string name = data[0];
                float price = float.Parse(data[1]);
                int tax = int.Parse(data[2]);
                string material1 = data[3];
                string material2 = data[4];
                string material3 = data[5];
                string material4 = data[6];
                Food food = new Food(name, price, tax, material1, material2, material3, material4);
                Food.foods.Add(food);
                foodCombobox.Items.Add(food.name);
                menuTextbox.Text = "";
                Food.WriteFood(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\food.txt");
                Food.WriteRecipe(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\recipe.txt");

            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            Food showedFood = Food.foods[selectedFoodIndex];
            foodLabel.Text = "Food Name: " + showedFood.name + "\r" + "Price: " + showedFood.price.ToString() + "\r" + "Tax: " + showedFood.tax.ToString() + "\r";
        }

        private void editFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            Food showedFood = Food.foods[selectedFoodIndex];
            menuTextbox.Text = $"{showedFood.name},{showedFood.price},{showedFood.tax},{showedFood.material1},{showedFood.material2},{showedFood.material3},{showedFood.material4}";
        }

        private void saveFoodButton_Click(object sender, EventArgs e)
        {
            string selectedFood = foodCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            string[] edittedFoodText = menuTextbox.Text.Split(",");
            Food.foods[selectedFoodIndex].name = edittedFoodText[0];
            Food.foods[selectedFoodIndex].price = float.Parse(edittedFoodText[1]);
            Food.foods[selectedFoodIndex].tax = int.Parse(edittedFoodText[2]);
            Food.foods[selectedFoodIndex].material1 = edittedFoodText[3];
            Food.foods[selectedFoodIndex].material2 = edittedFoodText[4];
            Food.foods[selectedFoodIndex].material2 = edittedFoodText[5];
            Food.foods[selectedFoodIndex].material2 = edittedFoodText[6];
            menuTextbox.Text = "";
            foodLabel.Text = "Food is changed";
            foreach (Food food in Food.foods)
            {
                Food.WriteFood(Food.foods, "C:\\Users\\Hasan\\source\\repos\\project\\project\\food2.txt");
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
                }
            }
            foodLabel.Text = "Food is deleted";
        }
    }
}

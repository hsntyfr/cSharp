using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Order
    {
        public static Dictionary<Food, int> order = new Dictionary<Food, int>();
        public static Food AddFood(string foodName)
        {
            Form2 form2 = new Form2();
            string selectedFood = foodName;
            int selectedFoodIndex = int.Parse(selectedFood);
            if (Food.foodCapacity.ElementAt(selectedFoodIndex).Value > 0) 
            {
                order[Food.foods[selectedFoodIndex]] += 1;
            }
            else
            {
                form2.orderLabel.Text = "This food is not added cause not exist enough daily capacity";
            }
            return Food.foods[selectedFoodIndex];
        }
        public static Food RemoveFood(string foodName)
        {
            Form2 form2 = new Form2();
            string removedFood = foodName;
            int removedFoodIndex = int.Parse(removedFood);
            order[Food.foods[removedFoodIndex]] -= 1;

            return Food.foods[removedFoodIndex];
        }
        public static void FicheOrder()
        {
            Form5 form5 = new Form5();
            form5.orderReviewLabel.Text = $"{"Food",-40}{"Count",-20}\r";
            foreach (KeyValuePair <Food, int> food in order)
            {
                Food key = food.Key;
                int value = food.Value;
                if (food.Value > 0 ) 
                {
                    form5.orderReviewLabel.Text += $"{food.Key.name, -40}{food.Value, -20}\r";
                }
                
            }
            form5.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Order
    {
        public static void AddFood()
        {
            Form2 form2 = new Form2();
            string selectedFood = form2.orderCombobox.SelectedIndex.ToString();
            int selectedFoodIndex = int.Parse(selectedFood);
            form2.orderReviewCombobox.Items.Add(Food.foods[selectedFoodIndex].name);
            //orderLabel.Text += "\r" + Food.foods[selectedFoodIndex].name;
            //if (!orderReviewCombobox.Items.Contains(Food.foods[selectedFoodIndex].name))
            //{
            //    orderReviewCombobox.Items.Add(Food.foods[selectedFoodIndex].name);
            //}
        }
        public static void RemoveFood()
        {
            Form2 form2 = new Form2();
            string removedFood = form2.orderCombobox.SelectedIndex.ToString();
            int removedFoodIndex = int.Parse(removedFood);
            if (form2.orderReviewCombobox.Items.Contains(Food.foods[removedFoodIndex].name))
            {
                form2.orderReviewCombobox.Items.Remove(Food.foods[removedFoodIndex].name);
            }
        }
        public static void FicheOrder()
        {

        }
    }
}

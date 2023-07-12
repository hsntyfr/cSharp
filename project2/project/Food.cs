using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Food
    {
        public static List<Food> foods = new List<Food>();
        public static List<Food> recipes = new List<Food>();



        public string name { get; set; }
        public float price { get; set; }
        public int tax { get; set; }
        public string material1 { get; set; }
        public string material2 { get; set; }
        public string material3 { get; set; }
        public string material4 { get; set; }


        public Food(string name, float price, int tax, string material1, string material2, string material3, string material4)
        {
            this.name = name;
            this.price = price;
            this.tax = tax;
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;
            this.material4 = material4;

        }
        public static void WriteFood(List<Food> foods, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Food food in foods)
                {
                    writer.WriteLine($"{food.name},{food.price},{food.tax},{food.material1},{food.material2},{food.material3},{food.material4}");
                }
            }
        }
        public static void WriteRecipe(List<Food> foods, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Food food in foods)
                {
                    writer.WriteLine($"{food.name},{food.material1},{food.material2},{food.material3},{food.material4}");
                }
            }
        }
        public static List<Food> ReadFood(string filePath)
        {
            List<Food> foods = new List<Food>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

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
                        foods.Add(food);
                    }
                }
            }

            return foods;
        }
        

    }
    public class Salad : Food
    {
        

        public Salad(string name, float price, int tax, string material1, string material2, string material3, string material4) : base(name, price, tax, material1, material2, material3, material4)

        {
            

        }
        

    }
    public class Desert : Food
    {

        public Desert(string name, float price, int tax, string material1, string material2, string material3, string material4) : base(name, price, tax, material1, material2, material3, material4)

        {
            

        }
    }
    
    public class Meal : Food
    {


        public Meal(string name, float price, int tax, string material1, string material2, string material3, string material4) : base(name, price, tax, material1, material2, material3, material4)

        {
            
        }
    }
    public class Snack : Food
    {

        public Snack(string name, float price, int tax, string material1, string material2, string material3, string material4) : base(name, price, tax, material1, material2, material3, material4)

        {

        }
    }

}

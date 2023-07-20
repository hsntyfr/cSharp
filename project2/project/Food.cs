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
        public static Dictionary<Food, int> foodCapacity = new Dictionary<Food, int>();

        public int kind { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int tax { get; set; }
        public string material1 { get; set; }
        public float material1Amount { get; set; }
        public string material2 { get; set; }
        public float material2Amount { get; set; }
        public string material3 { get; set; }
        public float material3Amount { get; set; }
        public string material4 { get; set; }
        public float material4Amount { get; set; }



        public Food(int kind, string name, float price, int tax, string material1,float material1Amount, string material2, float material2Amount, string material3, float material3Amount, string material4, float material4Amount)
        {
            this.kind = kind;
            this.name = name;
            this.price = price;
            this.tax = tax;
            this.material1 = material1;
            this.material1Amount = material1Amount;
            this.material2 = material2;
            this.material2Amount = material2Amount;
            this.material3 = material3;
            this.material3Amount = material3Amount;
            this.material4 = material4;
            this.material4Amount = material4Amount;
        }
        public static void WriteFood(List<Food> foods, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Food food in foods)
                {
                    writer.WriteLine($"{food.kind},{food.name},{food.price},{food.tax},{food.material1},{food.material1Amount},{food.material2},{food.material2Amount},{food.material3},{food.material3Amount},{food.material4},{food.material4Amount}");
                }
            }
        }
        public static void WriteRecipe(List<Food> foods, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Food food in foods)
                {
                    writer.WriteLine($"{food.kind},{food.name},{food.material1},{food.material1Amount},{food.material2},{food.material2Amount},{food.material3},{food.material3Amount},{food.material4},{food.material4Amount}");
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
                        foods.Add(food);
                    }
                }
            }

            return foods;
        }
        public static void PriceLowToHigh()
        {
            Form6 form6 = new Form6();
            List<Food> sortedFoods = new List<Food>();
            sortedFoods = foods.OrderBy(x => x.price).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Price",20}\r";

            foreach (Food food in sortedFoods)
            {
                string sortedList = string.Format($"{food.name,-10}{food.price,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void PriceHighToLow()
        {
            Form6 form6 = new Form6();
            List<Food> sortedFoods = new List<Food>();
            sortedFoods = foods.OrderByDescending(x => x.price).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Price",20}\r";

            foreach (Food food in sortedFoods)
            {
                string sortedList = string.Format($"{food.name,-10}{food.price,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void TaxHighToLow()
        {
            Form6 form6 = new Form6();
            List<Food> sortedFoods = new List<Food>();
            sortedFoods = foods.OrderByDescending(x => x.price).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Tax",20}\r";

            foreach (Food food in sortedFoods)
            {
                string sortedList = string.Format($"{food.name,-10}{food.tax,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void TaxLowToHigh()
        {
            Form6 form6 = new Form6();
            List<Food> sortedFoods = new List<Food>();
            sortedFoods = foods.OrderByDescending(x => x.price).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Tax",20}\r";

            foreach (Food food in sortedFoods)
            {
                string sortedList = string.Format($"{food.name,-10}{food.tax,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void DailyFoodList()
        {
            foreach (KeyValuePair<Food, int> food in Food.foodCapacity)
            {
                if (food.Value > 0)
                {
                    foreach (Material material1Repo in Material.materials)
                    {
                        if (food.Key.material1 == material1Repo.name)
                        {
                            float usedMaterial = food.Key.material1Amount * food.Value;
                            if (material1Repo.stock >= usedMaterial)
                            {
                                material1Repo.stock -= usedMaterial;
                            }
                            else
                            {
                                Material.materialShopList[material1Repo] = -(material1Repo.stock -= usedMaterial);
                            }

                        }
                    }
                    foreach (Material material2Repo in Material.materials)
                    {
                        if (food.Key.material2 == material2Repo.name)
                        {
                            float usedMaterial = food.Key.material2Amount * food.Value;
                            if (material2Repo.stock >= usedMaterial)
                            {
                                material2Repo.stock -= usedMaterial;
                            }
                            else
                            {
                                Material.materialShopList[material2Repo] = -(material2Repo.stock -= usedMaterial);
                            }

                        }
                    }
                    foreach (Material material3Repo in Material.materials)
                    {
                        if (food.Key.material3 == material3Repo.name)
                        {
                            float usedMaterial = food.Key.material3Amount * food.Value;
                            if (material3Repo.stock >= usedMaterial)
                            {
                                material3Repo.stock -= usedMaterial;
                            }
                            else
                            {
                                Material.materialShopList[material3Repo] = -(material3Repo.stock -= usedMaterial);
                            }

                        }
                    }
                    foreach (Material material4Repo in Material.materials)
                    {
                        if (food.Key.material4 == material4Repo.name)
                        {
                            float usedMaterial = food.Key.material4Amount * food.Value;
                            if (material4Repo.stock >= usedMaterial)
                            {
                                material4Repo.stock -= usedMaterial;
                            }
                            else
                            {
                                Material.materialShopList[material4Repo] = -(material4Repo.stock -= usedMaterial);
                            }

                        }
                    }

                }
            }
            Material.Write(Material.materials, "C:\\Users\\Hasan\\source\\repos\\project\\project\\list2.txt");
            File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
            File.Move("C:\\Users\\Hasan\\source\\repos\\project\\project\\list2.txt", "C:\\Users\\Hasan\\source\\repos\\project\\project\\list.txt");
            File.Delete("C:\\Users\\Hasan\\source\\repos\\project\\project\\shopList.txt");
            Material.WriteShopList(Material.materialShopList, "C:\\Users\\Hasan\\source\\repos\\project\\project\\shopList.txt");
        }


    }
    public class Salad : Food
    {
        public int poriton;
        public Salad(int kind, string name, float price, int tax, string material1, float material1Amount, string material2, float material2Amount, string material3, float material3Amount, string material4, float material4Amount) : base(kind, name, price, tax, material1, material1Amount, material2, material2Amount, material3, material3Amount, material4, material4Amount)

        {
            

        }
        

    }
    public class Desert : Food
    {
        int kind; //1->milk 2->sugar
        public Desert(int kind, string name, float price, int tax, string material1, float material1Amount, string material2, float material2Amount, string material3, float material3Amount, string material4, float material4Amount) : base(kind, name, price, tax, material1, material1Amount, material2, material2Amount, material3, material3Amount, material4, material4Amount)

        {
            

        }
    }
    
    public class Meal : Food
    {
        int vegan; //1->vegan 2->non-vegan
        public Meal(int kind, string name, float price, int tax, string material1, float material1Amount, string material2, float material2Amount, string material3, float material3Amount, string material4, float material4Amount) : base(kind, name, price, tax, material1, material1Amount, material2, material2Amount, material3, material3Amount, material4, material4Amount)

        {
            
        }
    }
    public class Snack : Food
    {
        int hot; //1->hot service 2->cold service
        public Snack(int kind, string name, float price, int tax, string material1, float material1Amount, string material2, float material2Amount, string material3, float material3Amount, string material4, float material4Amount) : base(kind, name, price, tax, material1, material1Amount, material2, material2Amount, material3, material3Amount, material4, material4Amount)

        {

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    abstract public class Food
    {
        public static List<Salad> salads = new List<Salad>();
        public static List<Desert> deserts = new List<Desert>();
        public static List<Meal> meals = new List<Meal>();
        public static List<Snack> snacks = new List<Snack>();

        public int kind;
        public string name { get; set; }
        public float price { get; set; }
        public int tax { get; set; }

        public Food(int kind, string name, float price, int tax)
        {
            this.kind = kind;
            this.name = name;
            this.price = price;
            this.tax = tax;
        }
 
    }
    public class Salad : Food
    {
        public string material1 { get; set; }
        public string material2 { get; set; }
        public string material3 { get; set; }

        public Salad(int kind, string name, float price, int tax, string material1, string material2, string material3) : base(kind, name, price, tax)

        {
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;

        }
        public static List<Salad> ReadSalad(string filePath)
        {
            List<Salad> salads = new List<Salad>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length == 7)
                    {
                        int kind = int.Parse(data[0]);
                        string name = data[1];
                        int price = int.Parse(data[2]);
                        int tax = int.Parse(data[3]);
                        string material1 = data[4];
                        string material2 = data[5];
                        string material3 = data[6];

                        Salad salad = new Salad(kind, name, price, tax, material1, material2, material3);
                        salads.Add(salad);
                    }
                }
            }
            return salads;
        }
        //write salad yazılacak

    }
    public class Desert : Food
    {
        public Material material1 { get; set; }
        public Material material2 { get; set; }
        public Material material3 { get; set; }

        public Desert(int kind, string name, float price, int tax, Material material1, Material material2, Material material3) : base(kind, name, price, tax)

        {
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;

        }
    }
    
    public class Meal : Food
    {
        public Material material1 { get; set; }
        public Material material2 { get; set; }
        public Material material3 { get; set; }
        public Material material4 { get; set; }
        public Material material5 { get; set; }

        public Meal(int kind, string name, float price, int tax, Material material1, Material material2, Material material3, Material material4, Material material5) : base(kind, name, price, tax)

        {
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;
            this.material4 = material4;
            this.material5 = material5;
        }
    }
    public class Snack : Food
    {
        public Material material1 { get; set; }
        public Material material2 { get; set; }
        public Material material3 { get; set; }

        public Snack(int kind, string name, float price, int tax, Material material1, Material material2, Material material3) : base(kind, name, price, tax)

        {
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;
        }
    }

}

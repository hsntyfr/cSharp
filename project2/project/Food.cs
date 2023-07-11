using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    abstract public class Food
    {
        public string name { get; set; }
        public float price { get; set; }
        public int tax { get; set; }

        public Food(string name, float price, int tax)
        {
            this.name = name;
            this.price = price;
            this.tax = tax;
        }
    }
    public class Salad : Food
    {
        public Material material1 { get; set; }
        public Material material2 { get; set; }
        public Material material3 { get; set; }

        public Salad(string name, float price, int tax, Material material1, Material material2, Material material3) : base(name, price, tax)

        {
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;

        }
    }
    public class Desert : Food
    {
        public Material material1 { get; set; }
        public Material material2 { get; set; }
        public Material material3 { get; set; }

        public Desert(string name, float price, int tax, Material material1, Material material2, Material material3) : base(name, price, tax)

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

        public Meal(string name, float price, int tax, Material material1, Material material2, Material material3, Material material4, Material material5) : base(name, price, tax)

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

        public Snack(string name, float price, int tax, Material material1, Material material2, Material material3) : base(name, price, tax)

        {
            this.material1 = material1;
            this.material2 = material2;
            this.material3 = material3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace project
{
    public class Material
    {
        public static Dictionary<Material, float> materialShopList = new Dictionary<Material, float>();
        public static List<Material> materials = new List<Material>();
        public string name { get; set; }
        public DateTime productionDate { get; set; }
        public DateTime expirationDate { get; set; }
        public float stock { get; set; }
        public float price { get; set; }

        public Material(string name, DateTime productionDate, DateTime expirationDate, float stock, float price)
        {
            this.name = name;
            this.productionDate = productionDate;
            this.expirationDate = expirationDate;
            this.stock = stock;
            this.price = price;
        }
        public static void Write(List<Material> materials, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Material material in materials)
                {
                    writer.WriteLine($"{material.name},{material.productionDate},{material.expirationDate},{material.stock},{material.price}");
                }
            }
        }
        public static List<Material> ReadMaterial(string filePath)
        {
            List<Material> materials = new List<Material>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length == 5)
                    {
                        string name = data[0];
                        DateTime productionDate = DateTime.Parse(data[1]);
                        DateTime expirationDate = DateTime.Parse(data[2]);
                        float stock = float.Parse(data[3]);
                        float price = float.Parse(data[4]);

                        Material material = new Material(name, productionDate, expirationDate, stock, price);
                        materials.Add(material);
                    }
                }
            }

            return materials;
        }
        public static void StockLowToHighMaterial()
        {
            Form6 form6 = new Form6();
            List<Material> sortedMaterials = new List<Material>();
            sortedMaterials = materials.OrderBy(x =>  x.stock).ToList();
            form6.reportRichTextbox.Text = $"{"Name", -10}{"Stock", 20}\r";

            foreach (Material material in sortedMaterials)
            {
                string sortedList = string.Format($"{material.name, -10}{material.stock, 20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void StockHighToLowMaterial()
        {
            Form6 form6 = new Form6();
            List<Material> sortedMaterials = new List<Material>();
            sortedMaterials = materials.OrderByDescending(x => x.stock).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Stock",20}\r";

            foreach (Material material in sortedMaterials)
            {
                string sortedList = string.Format($"{material.name,-10}{material.stock,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void OldestMaterial()
        {
            Form6 form6 = new Form6();
            List<Material> sortedMaterials = new List<Material>();
            sortedMaterials = materials.OrderBy(x => x.productionDate).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Production Date",20}\r";

            foreach (Material material in sortedMaterials)
            {
                string sortedList = string.Format($"{material.name,-10}{material.productionDate,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void NewestMaterial()
        {
            Form6 form6 = new Form6();
            List<Material> sortedMaterials = new List<Material>();
            sortedMaterials = materials.OrderByDescending(x => x.productionDate).ToList();
            form6.reportRichTextbox.Text = $"{"Name",-10}{"Production Date",20}\r";

            foreach (Material material in sortedMaterials)
            {
                string sortedList = string.Format($"{material.name,-10}{material.productionDate,20}\r");
                form6.reportRichTextbox.Text += sortedList;
            }
            form6.Show();
        }
        public static void WriteShopList(Dictionary<Material, float> shopList, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (KeyValuePair<Material, float> materialShopList in shopList)
                {
                    string line = $"{materialShopList.Key.name},{materialShopList.Value}";
                    writer.WriteLine(line);
                }
            }
        }
        public static bool SearchMaterial(string materialName)
        {
            foreach (Material item in materials)
            {
                if (item.name == materialName)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}

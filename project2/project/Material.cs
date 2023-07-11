using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project
{
    public class Material
    {
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

        //public static void LoadMaterials(List<Material> materials)
        //{
        //    Form3 form3 = new Form3();

        //    foreach (Material material in materials)
        //    {
        //        form3.materialCombobox.Items.Add(material.name);
        //    }
        //}
    }
}

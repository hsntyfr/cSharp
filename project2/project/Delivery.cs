using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Delivery
    {
        private List<Food> siparisListesi;

        public Delivery()
        {
            siparisListesi = new List<Food>();
        }

        public void YemekEkle(Food food)
        {
            siparisListesi.Add(food);
        }
        public void YemekSil(Food food)
        {
            siparisListesi.Remove(food);
        }

        public void SiparisiYazdir()
        {
            Console.WriteLine("Sipariş Listesi:");
            foreach (Food food in siparisListesi)
            {
                Console.WriteLine($"{food.name} - {food.price}");
            }
        }
    }
}

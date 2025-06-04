using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{
    internal class ienumerable
    {
        static void Main()
        {
            //int[] values = { 1, 2, 3 };
            //List<int> values2 = new List<int>() { 1, 2, 3 };
            //Display(values);
            //Display(values2);

            List<calisan> list=new List<calisan>();
            list.Add(new calisan() {Ad="Ali",Maas=10000 });
            list.Add(new calisan() { Ad = "Veli", Maas = 20000 });
            list.Add(new calisan() { Ad = "Ayse", Maas = 50000 });
            list.Add(new calisan() { Ad = "Metin", Maas = 40000 });
            list.Add(new calisan() {Ad="Yilmaz",Maas=10000 });

            //IComparable.CompareTo() Fonksiyonuna gore siralama yapar.
            list.Sort();
             
            //Clisan.ToString kullanir.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }





        }

        static void Display(IEnumerable<int> values)
        {
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
    public class calisan : IComparable<calisan>
    {
        public int Maas { get; set; }
        public string Ad { get; set; }

        public int CompareTo(calisan digerCalisan)
        {   //Maas esitse alfabetik siralama yapar.
            if (this.Maas == digerCalisan.Maas)
            {
                return this.Ad.CompareTo(digerCalisan.Ad);
            }
            //Degilse buyukten kucuge siralar.
            return digerCalisan.Maas.CompareTo(this.Maas);
        }
        public override string ToString()
        {
            return this.Maas.ToString()+" ,"+this.Ad;
        }
    }
}

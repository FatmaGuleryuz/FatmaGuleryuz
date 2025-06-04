using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{
    public class Personel1
    {
        private const Decimal AsgariUcret = 2000;
        private const Decimal AileGecimIndirimi = 500;

        public string Isim { get; set; }
        protected Decimal maas;

        public Decimal Maas
        {
            get
            {
                return maas;
            }
        }
        public Personel1()
        {

        }
        public virtual void maasHesapla()
        {
            maas = AsgariUcret + AileGecimIndirimi;
            



        }
    }
    public class Calisan : Personel1
    {
        public Calisan()
        {
        }
        public override void maasHesapla()
        {
            base.maasHesapla();
            maas *= 1.5M;
            Console.WriteLine("Calisan maas:"+maas);
        }
    }
    public class Mudur : Personel1
    {
        public Mudur()
        {

        }
        public override void maasHesapla()
        {
            base.maasHesapla();
            maas *= 4M;
            Console.WriteLine("Mudur maas:" + maas);


        }
    }
    public class Program
    {
        //static void Main()
        //{
           
        //    Calisan calisan = new Calisan();
        //    Mudur mudur = new Mudur();
           
        //    calisan.maasHesapla();
        //    mudur.maasHesapla();
        //}

    }
}

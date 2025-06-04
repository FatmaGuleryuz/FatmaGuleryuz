using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{

    //Assocation kisi-araba arasinda sahiplik iliskisi 
    //kisinin bir arabasi olabilir veya olmayabilir gevsek iliski birbilerine tam bagimli degiller
    //bir nesne yok olursa digeri var olamya devam edebilir.
    internal class Araba
    {
        private string plaka;
        private Kisi sahip;
        public Araba(string plaka,Kisi sahip)
        {
            this.plaka = plaka;
            this.sahip = sahip;
        }
        public string Plaka
        {
            get { return plaka; }
            set { plaka = value; }
        }
        public Kisi Sahip
        {
            get { return sahip; }
            set { sahip = value; }
        }
        public string kendinitanit()
        {
            string intro;
            intro = "[Araba] plaka numaram: " + Plaka;
            if (sahip != null)
            {
                intro += " ve sahibim: " + Sahip.Isim;
            }
            return intro;
        }

    }
    class Kisi
    {
        private string isim;
        private Araba arac;

        public Kisi(string isim)
        {
            this.isim = isim;
            
        }
        public Araba Arac
        {
            get { return arac; }
            set { arac = value; }
        }
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string kendiniTanit()
        {
            string intro;
            intro = "Merahaba ismim " + Isim;
            if (arac != null)
            {
                intro += arac.Plaka + " plakali aracim var.";
            }
            else
            {
                intro += "herhangi bir aracim yok";
            }
             return intro;
            
        }
    }
    class Galeri
    {
        private string galeriAd;
        private List<Araba> arabalar;
        private Kisi galerisahibi;
        public Galeri(string galeriAd,  Kisi galerisahibi)
        {
            this.galeriAd = galeriAd;
            this.galerisahibi = galerisahibi;
            arabalar = new List<Araba>();
        }
        public string GaleriAd
        {
            get { return galeriAd; }
            set { galeriAd = value;}
        }

        public bool ekle(Araba a)
        {
            if (!arabalar.Contains(a))
            {
                arabalar.Add(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string KendiniTanit()
        {
            string intro = "Galeri Adi:" + galeriAd;
            intro += " ,galeri sahibi:" + galerisahibi;
            intro += " olup galerideki araba sayisi:" + arabalar.Count;
            return intro;
        }
        public void aracListele()
        {
            foreach (Araba a in arabalar)
            {
                Console.WriteLine(a.Plaka+ " "+a.Sahip.Isim);
            }
        }
        public bool aracSil(Araba a)
        {
            if (arabalar.Contains(a))
            {
                arabalar.Remove(a);
                Console.WriteLine(a.Plaka + " plakali arac silindi.");
                return true;
            }
            else
                return false;
        }
        public void aracSat(Araba a,Kisi sahip)
        {
            if (aracSil(a))
            {
                a.Sahip = sahip;
            }
            else
            {
                Console.WriteLine("Arac bulunamadi.");
            }
        }
    }

    class Ana_
    {
        //static void Main()
        //{
           
        //    Kisi oktay = new Kisi("Oktay Sinanoglu");
        //    Araba rover = new Araba("34 OS 1934",oktay);
        //    oktay.Arac = rover;
        //    rover.Sahip = oktay;
        //    //Console.WriteLine(oktay.kendiniTanit());
        //    //Console.WriteLine(rover.kendinitanit());

        //    Galeri g = new Galeri("Elazig23", new Kisi("Ahmet Tasar"));
        //    Araba a1 = new Araba("23 ER 087",oktay);
        //    Araba a2 = new Araba("34 CN 423", oktay);

        //    if (g.ekle(a1))
        //        Console.WriteLine("1.Arac Eklendi.");
        //    if (g.ekle(a2))
        //        Console.WriteLine("2.Arac Eklendi.");
        //    g.aracListele();

        //    g.aracSat(a1, oktay);

        //    g.aracListele();

        //    Console.ReadKey();





        //}
    }
}

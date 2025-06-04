using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{
    interface ICalisabilen
    {
        public string Calis();
    }
    interface IOynayabilen
    {
        string Oyna();
    }


    public abstract class kisi
    {
        public string Isim { get; set; }
        public virtual string BilgiGoster()
        {
            return "Ismim " + Isim;
        }
    }

    public class Ogretmen : kisi, ICalisabilen
    {
        public string Calis()
        {
            return "Ogretirim..";
        }
        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        }

    }
    public class satisci : kisi, ICalisabilen
    {
        public string Calis()
        {
            return "Satis yaparim..";
        }
        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        }


    }
    public class mudur : kisi, ICalisabilen
    {
        public string Calis()
        {
            return "Idarecilik yaparim..";
        }
        public override string BilgiGoster()
        {
            return base.BilgiGoster();
        }
    }
    public class Cocuk : kisi, ICalisabilen, IOynayabilen 
    { 
        public string Calis()
        {
            return "Ders Calisirim..";
        }
        public string Oyna()
        {
            return "Oyun Oynarim..";
        }
    }



    //public class ustSinif
    //{
    //    //static void Main()
        //{
        //    Ogretmen ogretmen = new Ogretmen();
        //    ogretmen.Isim = "Ahmet Demir";
        //    mudur mudur= new mudur();
        //    mudur.Isim = "Mehmet Celik";
        //    satisci satisci= new satisci();
        //    satisci.Isim = "Ismet Gumus";
        //    Cocuk cocuk = new Cocuk();
        //    cocuk.Isim = "Fatma Guleryuz";

        //    Console.WriteLine(ogretmen.BilgiGoster()+" "+ogretmen.Calis());
        //    Console.WriteLine(mudur.BilgiGoster()+" "+mudur.Calis());
        //    Console.WriteLine(satisci.BilgiGoster() + " " + satisci.Calis());
        //    Console.WriteLine(cocuk.BilgiGoster()+" "+cocuk.Oyna()+" "+cocuk.Calis());
        //}
    //}
}

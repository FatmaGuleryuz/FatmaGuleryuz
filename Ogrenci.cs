using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{
    public class Ogrenci
    {
        private const Decimal BirimDersUcreti = 60;

        public string Isim { get; set; }
        public short KrediSayisi { get; set; }
        public Decimal ToplamDersUcreti { get; protected set; }

        public Ogrenci()
        {

        }

        public virtual void DersUcretiHesapla()
        {
            ToplamDersUcreti = BirimDersUcreti + KrediSayisi;
        }
    }
    public class BursluOgrenci : Ogrenci
    {
        public short BursOrani { get;set; }
        public Decimal BursIndirimi { get; private set; }
        public BursluOgrenci() 
        { 

        }
        public override void DersUcretiHesapla()
        {
            base.DersUcretiHesapla();
            BursIndirimi = (ToplamDersUcreti * BursOrani) / 100;
            ToplamDersUcreti-=BursIndirimi;
            Console.WriteLine("Burs indirimi:" + BursIndirimi);
            Console.WriteLine("toplam ders Ucreti:" + ToplamDersUcreti);
        }
    }
    class Ana
    {
        //static void Main(string[] args)
        //{
        //    Ogrenci ogrenci = new Ogrenci();
        //    ogrenci.KrediSayisi = 23;
        //    ogrenci.DersUcretiHesapla();

        //    BursluOgrenci burslu_ogrenci=new BursluOgrenci();
        //    burslu_ogrenci.BursOrani = 20;
        //    burslu_ogrenci.DersUcretiHesapla();


        //}
    }

}

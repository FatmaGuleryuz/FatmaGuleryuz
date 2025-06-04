using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{
    public abstract class Sirket
    {
        public string Isim { get; set; }
        public const Decimal asgariucret = 2000;
        public decimal Maas { get; protected set; }
        public Sirket(string isim) 
        {
            this.Isim = isim;
        }

        public abstract void MaasHesapla();
    }

    public class Standart : Sirket
    {   public Standart(string isim) :base(isim)
        {

        }
        public override void MaasHesapla() 
        {
            Maas = asgariucret * 2;
            Console.WriteLine($"{Isim} adli standart calisanin maasi: {Maas} Tl");
        }
    }
    public class Muhasebeci : Sirket 
    {
        public int fazlaMesaiGunSayisi { get; set; }
        public Muhasebeci(string isim,int fazlaMesaiGunSayisi) : base(isim)
        {
            this.fazlaMesaiGunSayisi= fazlaMesaiGunSayisi;
        }
        public override void MaasHesapla()
        {   Maas = asgariucret * 2;
            Maas+=fazlaMesaiGunSayisi * (Maas / 21);
            Console.WriteLine($"{Isim}  adli muhasebecinin maasi:{Maas} Tl (Fazla Mesai:{fazlaMesaiGunSayisi} gun.)");

            
        }
    }
    public class Satisci : Sirket
    {   public decimal Yaptigisatis { get; set; }
        public Satisci(string isim,decimal yaptigisatis): base(isim)
        {
            this.Yaptigisatis = yaptigisatis;
        }
        public override void MaasHesapla()
        {
            Maas = asgariucret * 2 + Yaptigisatis * 0.1m;
            Console.WriteLine($"{Isim} adli satiscinin maasi:{Maas} Tl (satis primi:{Yaptigisatis*0.1m} Tl)");
        }
    }
    public class Super
    {
        //static void Main()
        //{
        //    Standart VeliGumus= new Standart("Veli Gumus");
        //    Muhasebeci ahmetdemir= new Muhasebeci("Ahmet Demir",3);
        //    Satisci mehmetcelik= new Satisci("Mehmet Celik",1000);

        //    List<Sirket> calisanlar = new List<Sirket>
        //    {
        //        VeliGumus,
        //        ahmetdemir,
        //        mehmetcelik 
        //    };

        //    decimal toplammaas = 0;
        //    foreach(var calisan in calisanlar)
        //    {
        //        calisan.MaasHesapla();
        //        toplammaas+=calisan.Maas;
        //    }
        //    Console.WriteLine($"Toplam maas odemsi:{toplammaas}");
            


        //}
    }

}

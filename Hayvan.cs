using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_alistirma
{
    public abstract class Hayvan
    {
        public string Adi { get; set; }
        public string Cins { get; set; }

        public Hayvan()
        {
            //
        }
        public abstract string SesCikar();

        public static void HayvanBilgisiGoster(Hayvan hayvan)
        {
            Console.WriteLine("Hayvan Adi:"+hayvan.Adi+"\n"+hayvan.SesCikar());
        }

    }
    public class Kopek : Hayvan
    {
        public override string SesCikar()
        {
            return "havHav";
        }

    }
    public class Kedi : Hayvan
    {
        public override string SesCikar()
        {
            return "Miyav";
        }
    }
    public class Temel
    {
        //static void Main()
        //{
        //    Kopek kopek = new Kopek();
        //    kopek.Adi = "Enzo";

        //    Kedi kedi=new Kedi();
        //    kedi.Adi = "Boncuk";

        //    Hayvan.HayvanBilgisiGoster(kopek);
        //    Hayvan.HayvanBilgisiGoster(kedi);




        //}
    }
}

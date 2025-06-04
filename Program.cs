using System;

//int[] dizi = { 1, 2, 3, 4 };

//Console.WriteLine(dizi.Length);

//int x = 1;
//int y = 4;

//while (x > y)
//{

//}
//kapali tur donusumu 
//int myInt = 9;
//double myDouble = myInt;       // Automatic casting: int to double

//Console.WriteLine(myInt);      // Outputs 9
//Console.WriteLine(myDouble);   // Outputs 9

//acik tur donusumu
//double myDouble2 = 9.78;
//int myInt2 = (int)myDouble2;    // Manual casting: double to int

//Console.WriteLine(myDouble2);   // Outputs 9.78
//Console.WriteLine(myInt2);      // Outputs 9

//Convert.ToBoolean,
//Convert.ToDouble,
//Convert.ToString,
//Convert.ToInt32( int)
//Convert.ToInt64( )

//Constructor overloading 
public class X 
{
    private int m;

    public X()
    {
        m = 0;
    }
    public X(int k)
    {
        m = k;
    }
    public X(int k,int z)
    {
        m = k + z;
    }
    public int m_get()
    {
        return m;
    }
}
//class Program
//{
    //static void Main(string[] args)
    //{
    //    //    X x1 = new X();
    //    //    Console.WriteLine(x1.m_get());

    //    //    X x2 = new X(8);
    //    //    Console.WriteLine(x2.m_get());

    //    //    X x3 = new X(3,4);
    //    //    Console.WriteLine(x3.m_get());

    //    //    Console.ReadLine();


    //    DateTime baslangic = new DateTime();
    //    baslangic = DateTime.Now;

    //    for(int i = 0; i < 1000000000; i++)
    //    {

    //    }

    //    DateTime bitis = new DateTime();
    //    bitis = DateTime.Now;

    //    Console.WriteLine("baslangic zamani:" + baslangic.ToString());
    //    Console.WriteLine("Bitis zamani:" + bitis);

    //    TimeSpan timeSpan = bitis - baslangic;
    //    Console.WriteLine(timeSpan);
    //    Console.ReadKey();


    //}
//}

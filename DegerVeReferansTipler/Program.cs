using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // Console.WriteLine(sayi1);// değer tip stack

            int[] sayilar1 = new int[] { 10, 20, 30 };

            int[] sayilar2= new int[] { 100,200,300};

            sayilar1 = sayilar2;// sayilar1 in referans nosu ile sayilar2 nin referans no su eşitlenir.Adres kopyalaması
            sayilar2[0] = 999;
            //Console.WriteLine(sayilar1[0]); referans tip diziler(arrayler) heap
            // sayilar1 i stackte alan olusur new dediğin anda heap adres değeri tutar
            





        }
    }
}

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır METHODLAR..
            //DRY - Do not Repeat Yourself -Kendini tekrar etme
            // Clean Code --- temiz kod
            //Best practise --- en iyi pratikler

            string[] meyveler = new string[] {"elma","karpuz"}; //kısıtlı alabiliyoruz diziye


            Urun urun1 = new Urun(); //ürün oluşturduk
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2}; // sınıfın özelliklerini alır

            // tip güvenliği type safety
            foreach (Urun urun in urunler) // veri tipi yerine var da yazsan olur...
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("-----------------Methodlar-------------");
            
            // instance -örnek
            //encapsulation düzensiz yapıyı düzene sokma

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
                                                                       //encapsulation hali class içinde oluşturmaktır.
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);          //encapsulation hali class içinde oluşturmaktır.
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15,8);            //encapsulation hali class içinde oluşturmaktır.
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20,15); //encapsulation hali class içinde oluşturmaktır.








        }
    }
}

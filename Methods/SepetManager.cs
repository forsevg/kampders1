using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention-- methodlar büyük harfle başlar
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(" Tebrikler...Sepete eklendi:"+urun.Adi);
            
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler.... Sepete eklendi:"+urunAdi);

        }
    }
}

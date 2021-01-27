using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       
        public void MusteriEkle(Musteri musteri, List<Musteri> musteriler)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.MusteriAdi+" "+ musteri.MusteriSoyadi+" eklendi!!");
        }
        public void musteriSil(Musteri musteri)
        {
         
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " silindi!!");
        }
        public void musteriListele(List<Musteri> musteriler)
        {
            Console.WriteLine("-------------Listeleniyor-------------");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            }   
        }


    }
}

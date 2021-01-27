using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri> { };

            // Müşteriler

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "KARADAĞ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "PAPUÇ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Kemal";
            musteri3.MusteriSoyadi = "YILMAZ";

            //Müşteri ekleme

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1,musteriler);
            musteriManager.MusteriEkle(musteri3,musteriler);

            //Müşteri sil

            musteriManager.musteriSil(musteri2);

            //Müşteri listeleme

            musteriManager.musteriListele(musteriler);

            Console.ReadKey();
        }
    }
}

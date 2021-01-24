using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Mehmet";
            musteri1.MusteriSoyadi = "Ağkuş";
            musteri1.MusteriTc = "00000000001";
            musteri1.MusteriHesapNo = "1000 101010";
            musteri1.MusteriBakiye = 1000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Steve";
            musteri2.MusteriSoyadi = "Jobs";
            musteri2.MusteriTc = "00000000002";
            musteri2.MusteriHesapNo = "2000 202020";
            musteri2.MusteriBakiye = 2000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Bill";
            musteri3.MusteriSoyadi = "Gates";
            musteri3.MusteriTc = "00000000003";
            musteri3.MusteriHesapNo = "3000 303030";
            musteri3.MusteriBakiye = 3000;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAdi = "Ada";
            musteri4.MusteriSoyadi = "Lovelace";
            musteri4.MusteriTc = "00000000004";
            musteri4.MusteriHesapNo = "4000 404040";
            musteri4.MusteriBakiye = 4000;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Sil(musteri1);
            Console.WriteLine("***************************************");
            musteriManager.Ekle(musteri2);
            Console.WriteLine("***************************************");

            musteriManager.Listele(musteri1);
            Console.WriteLine("-------------------------------------");
            musteriManager.Listele(musteri2);
            Console.WriteLine("-------------------------------------");
            musteriManager.Listele(musteri3);
            Console.WriteLine("-------------------------------------");
            musteriManager.Listele(musteri4);
        }
    }
}

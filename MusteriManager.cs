using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Hoş geldiniz! " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Bankamıza katıldı.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Güle güle! " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " Bankazmızdan ayrıldı!");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri");
            Console.WriteLine("Müşteri Adı Soyadı : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine("Hesap No : " + musteri.MusteriHesapNo);
            Console.WriteLine("Bakiye : " + musteri.MusteriBakiye + "TL");
        }  
    }  
}

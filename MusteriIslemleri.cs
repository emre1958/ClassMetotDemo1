using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriIslemleri
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " " + musteri.Tc + "  " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Adres + "  Musteri Bilgileri Eklendi");

        }
        public void MusteriSilindi(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " " + musteri.Tc + "  " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Adres + " Musteri Bilgileri Silindi");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.id + " " + musteri.Tc + "  " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Adres);

            }

        }
    }
}

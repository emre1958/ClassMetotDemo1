using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.Tc = 46464646;
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Adres = "Ankara";
            Console.WriteLine(musteri1.id + " " + musteri1.Tc + "  " + musteri1.Adi + " " + musteri1.Soyadi + " " + musteri1.Adres);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.Tc = 46546464;
            musteri2.Adi = "Emre";
            musteri2.Soyadi = "Dagdeviren";
            musteri2.Adres = "Sivas";
            Console.WriteLine(musteri2.id + " " + musteri2.Tc + "  " + musteri2.Adi + " " + musteri2.Soyadi + " " + musteri2.Adres);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, };

            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            Console.WriteLine("------Musteri Listesi--------");
            musteriIslemleri.MusteriListele(musteriler);
            Console.WriteLine("------------------------------");
            Musteri musteri3 = new Musteri();
            musteri3.id = 3;
            musteri3.Tc = 654646;
            musteri3.Adi = "ALEYNA";
            musteri3.Soyadi = "DEMİR";
            musteri3.Adres = "GİRESUN";
            musteriIslemleri.MusteriEkle(musteri3);

            Console.WriteLine("-------Güncel Müsteri Listesi----");
            Musteri[] musteriler1 = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriIslemleri.MusteriListele(musteriler1);





        }
    
    }
}

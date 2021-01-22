using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 01234;
            musteri1.Adi = "Fatih İlhami";
            musteri1.Soyadi = "TAŞKIRAN";
            musteri1.Yas = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 01235;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "DEMİROĞ";
            musteri2.Yas = 32;

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            Musteri[] listeleme = new Musteri[]
            { musteri1, musteri2};
            musterimanager.Liste(listeleme);
            musterimanager.Silme(musteri1);
            musterimanager.Silme(musteri2);
        }
    }
}

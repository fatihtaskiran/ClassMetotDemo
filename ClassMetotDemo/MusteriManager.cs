using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id +" "+ musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yas + " Bilgilerine sahip müşteri eklendi");
        }
        public void Liste(Musteri[] musteriler)
        {
            //foreach (Musteri customer in musteriler)
            //{
            //    Console.WriteLine(customer.Id);
            //    Console.WriteLine(customer.Adi);
            //    Console.WriteLine(customer.Soyadi);
            //    Console.WriteLine(customer.Yas);
            //    Console.WriteLine("****************");
            //}
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].Id);
                Console.WriteLine(musteriler[i].Adi);
                Console.WriteLine(musteriler[i].Soyadi);
                Console.WriteLine(musteriler[i].Yas);
            }
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yas + " Bilgilerine sahip müşteri silindi");
        }
    }
}

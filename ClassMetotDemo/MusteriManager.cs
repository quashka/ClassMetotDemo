using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: "+ musteri.Ad+" "+musteri.Soyad);
        }
        public void Ekle(Musteri[] musteri)
        {
            for(int i=0;i<musteri.Length;i++)
            Console.WriteLine(i+1+")Müşteri eklendi: " + musteri[i].Ad + " " + musteri[i].Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Sil(Musteri[] musteriler)
        {
            for(int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Müşteri silindi: " + musteriler[i].Ad + " " + musteriler[i].Soyad);
            }
        }
        public void Listele(Musteri[] musteriler)
        {
            int i = 1;
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad+" "+musteri.Soyad);
                i++;
            }
        }
    }
}

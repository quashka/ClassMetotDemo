using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Berkay";
            musteri1.Soyad = "Şahin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Sezer";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Engin";
            musteri3.Soyad = "Demiroğ";

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            
            
            Console.WriteLine("-----Ekleme-----");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-----Toplu Ekleme-----");
            musteriManager.Ekle(musteriler);

            
            
            Console.WriteLine("-----Silme-----");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            Console.WriteLine("-----Toplu Silme-----");
            musteriManager.Sil(musteriler);




            Console.WriteLine("Listeleme");
            musteriManager.Listele(musteriler);




        }
    }
}

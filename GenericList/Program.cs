using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Sarı");
            renkListesi.Add("Kırmızı");

            // Count  => Eleman sayısını verir.
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach(var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach(var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Remove => Listeden eleman çıkarma
            sayiListesi.Remove(23);
            renkListesi.Remove("Sarı");
            sayiListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Contains => Liste içerisinde arama
            if (renkListesi.Contains("Kırmızı"))
            {
                Console.WriteLine("Kırmızı liste içerisinde bulundu");
            }

            // Eleman ile index'e erişme
            renkListesi.IndexOf("Kırmızı");

            // Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> animals = new List<string>(hayvanlar);

            // Listeyi temizleme
            animals.Clear();

            // List içerisinde nesne tutmak istiyorsak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Burak";
            kullanıcı1.Soyisim = "Beştaş";
            kullanıcı1.Yas = 30;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Zikriye";
            kullanıcı2.Soyisim = "Ürkmez";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Pınar",
                Yas = 21
            });

            foreach(var kullanici in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
            }
        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private string yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}

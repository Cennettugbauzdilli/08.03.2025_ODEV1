using ODEV2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Çalışanları listeye ekleyelim
        List<Calisan> calisanlar = new List<Calisan>
        {
            new GenelMudur("Ahmet"),
            new Mudur("Mehmet"),
            new Programci("Ayşe"),
            new Stajyer("Ali"),
            new Programci("Fatma"),
            new Mudur("Kemal")
        };

        // Toplam maaşı hesaplamak için değişken
        decimal toplamMaas = 0;

        Console.WriteLine("Çalışanların Maaşları:");
        foreach (var calisan in calisanlar)
        {
            decimal maas = calisan.MaasinizNedir();
            toplamMaas += maas;

            Console.WriteLine($"{calisan.Ad} - {calisan.Pozisyon}: {maas} TL");
        }

        // Toplam maaşı ekrana yazdır
        Console.WriteLine("\nToplam Ödenecek Maaş: " + toplamMaas + " TL");
    }
}

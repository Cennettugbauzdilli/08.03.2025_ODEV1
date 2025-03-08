using ODEV3;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Arabaları listeye ekleyelim
        List<Araba> arabalar = new List<Araba>
        {
            new BMW(),
            new Mercedes(),
            new Porsche(),
            new BMW(),
            new Mercedes()
        };

        // Toplam yakıt tüketimini hesaplamak için değişken
        double toplamYakitTuketimi = 0;

        Console.WriteLine("Arabaların Yakıt Tüketimleri:");
        foreach (var araba in arabalar)
        {
            double yakitTuketimi = araba.YakitTuketimiHesapla();
            toplamYakitTuketimi += yakitTuketimi;

            Console.WriteLine($"{araba.Marka} - 1 Saatlik Yakıt Tüketimi: {yakitTuketimi} L");
        }

        // Toplam yakıt tüketimini ekrana yazdır
        Console.WriteLine("\nToplam Yakıt Tüketimi: " + toplamYakitTuketimi + " L");
    }
}


using _08._03._2025_ODEV;
using System;

class Program
{
    static void Main()
    {
        // BMW Nesnesi Oluştur
        IHareket bmw = new BMW();
        Console.WriteLine("BMW Hareketleri:");
        bmw.Git();
        bmw.Yuz();
        bmw.Uc();
        Console.WriteLine();

        // Mercedes Nesnesi Oluştur
        IHareket mercedes = new Mercedes();
        Console.WriteLine("Mercedes Hareketleri:");
        mercedes.Git();
        mercedes.Yuz();
        mercedes.Uc();
        Console.WriteLine();

        // Porsche Nesnesi Oluştur
        IHareket porsche = new Porsche();
        Console.WriteLine("Porsche Hareketleri:");
        porsche.Git();
        porsche.Yuz();
        porsche.Uc();
        Console.WriteLine();
    }
}

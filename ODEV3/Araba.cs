using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3
{
    // Araba sınıfı tüm arabalar için ortak olan yapıları içerir
    public abstract class Araba : IYakitTuketimi
    {
        public string Marka { get; set; }
        public double SaatlikYakitTuketimi { get; set; }

        // Kurucu metod (Constructor)
        public Araba(string marka, double saatlikYakitTuketimi)
        {
            Marka = marka;
            SaatlikYakitTuketimi = saatlikYakitTuketimi;
        }

        // Yakıt tüketimini hesaplayan metod (Interface metodunun uygulanması)
        public double YakitTuketimiHesapla()
        {
            return SaatlikYakitTuketimi;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV2
{
    // Calisan sınıfı tüm çalışanlar için ortak olan yapıları içerir
    public abstract class Calisan : IMaasHesaplayici
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        // Kurucu metod (Constructor)
        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        // Her çalışan kendi maaşını belirlemelidir (Abstract metod)
        public abstract decimal MaasinizNedir();
    }

}

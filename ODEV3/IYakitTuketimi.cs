using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3
{
    // IYakıtTuketimi interface'i, arabaların yakıt tüketimini hesaplayan metodu içerir
    public interface IYakitTuketimi
    {
        double YakitTuketimiHesapla(); // 1 saatlik yakıt tüketimini döndürecek
    }

}

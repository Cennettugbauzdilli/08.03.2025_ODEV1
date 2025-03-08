using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._2025_ODEV
{
    // IHareket interface'i, araçların yapabileceği hareketleri tanımlar
    public interface IHareket
    {
        void Git();  // Karada gitme özelliği
        void Yuz();  // Denizde yüzme özelliği
        void Uc();   // Havada uçma özelliği
    }

}

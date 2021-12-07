using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesapla
{
    class Triangle : Shapes
    {
        double taban, uzunluk = 0;
        public Triangle(double taban,double uzunluk)
        {
            this.taban = taban;
            this.uzunluk = uzunluk;
        }
        public double AlanHesapla()
        {
            return (taban*uzunluk)/2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesapla
{
    class Rectangle:Shapes
    {
        double kisaKenar, uzunKenar = 0;
        public Rectangle(double kisaKenar,double uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public double AlanHesapla()
        {
            return kisaKenar * uzunKenar;
        }
    }
}

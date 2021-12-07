using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesapla
{
    class Square :Shapes
    {
        double kenar=0;
        public Square(double kenar)
        {
            this.kenar = kenar;
        }

        public double AlanHesapla()
        {
            return kenar * kenar;
        }
    }
}

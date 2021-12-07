using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesapla
{
    class Circle : Shapes
    {
        double yaricap=0;
        
        public Circle(double yaricap )
            {
            this.yaricap = yaricap;
            }
        public double AlanHesapla()
        {
            return yaricap * yaricap * Math.PI;
        }
    }
}

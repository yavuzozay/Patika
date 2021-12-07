using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesapla
{
    
     class fibonacci
    {
       public static int[] fib(int n)
        {
            int []results = new int[n + 2]; 
            int i;
            results[0] = 0;
            results[1] = 1;

            for (i = 2; i <= n; i++)
            {
                results[i] = results[i - 1] + results[i - 2];
             
            }
          

            return results;
        }
        public static int Total(int n)
        {
            int result = 0;
            foreach (var item in fib(n))
            {
                result += item;
            }
            return result;
        }

        public static double Ortalama(int n)
        {
            return Convert.ToDouble(Total(n)/Convert.ToDouble(n));
        }

    }
}

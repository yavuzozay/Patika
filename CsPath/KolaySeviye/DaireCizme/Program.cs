using System;

namespace DaireCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yarıçap giriniz..");
            int r = Convert.ToInt32(Console.ReadLine());
           
            
            DrawCircle(r,'.');
        }
        static void DrawCircle(int yaricap,char sembol)
        {
            int cap = yaricap * 2;
            int x, y;
            for (int i = 0; i <= cap ; i++)

            {
                for (int j = 0; j <= cap ; j++)
                {
                    x = yaricap-i;
                    y =  yaricap-j;

                    if (x * x + y * y == yaricap * yaricap)  Console.Write(sembol);
                    
                    else Console.Write("  ");
                   
                        
                }

                Console.WriteLine();

            }

        }
         
    }
    
}
    
    


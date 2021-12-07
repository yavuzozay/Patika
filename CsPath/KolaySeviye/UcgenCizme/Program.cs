using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir değer giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            DrawTriangle(n);  
        }
        static void DrawTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j =1; j < n*2; j++)
                {
                    if (i==1 && j==n )
                        Console.Write(" ");
                    else if (n - i + 1 == j  )
                        Console.Write(" /");
                    else if(n + i - 1 == j)
                        Console.Write(@"\");

                    else if (n == i)
                        Console.Write("_");

                    else
                        Console.Write(" ");
                }
            
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace KarakterTerstenYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            TerstenYazdir("Hello World !");
        }
        static void TerstenYazdir(string message)
        {
            for (int i = message.Length-1; i>= 0; i--)
            {
                Console.Write(message[i]);
            }
        }
    }
}

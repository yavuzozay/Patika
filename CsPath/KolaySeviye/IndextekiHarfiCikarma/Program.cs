using System;

namespace IndextekiHarfiCikarma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kelimenizi ve silmek istediğiniz indexi arasına virgül koyarak giriniz");
            string[] message = Console.ReadLine().Split(',');
            string word = message[0];
            int index = Convert.ToInt32(message[1]);
            HarfCikar(word, index);

        }
        static void HarfCikar(string mesaj,int index)
        {
            string result="";
            for (int i = 0; i < mesaj.Length; i++)
            {
                if(i!=index)
                {
                    result += mesaj[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}

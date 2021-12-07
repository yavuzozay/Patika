using System;

namespace AlanHesapla
{
    class Program
    {
      static  Shapes secilenObje = null;

        static void Main(string[] args)
        {
            SecimEkrani();
        }
      

        static void SecimEkrani()
        {
            Console.WriteLine("Şeklinizi seçiniz:\n Daire :1,Üçgen 2, Kare 3, Dikdörtgen 4 ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    {
                        Console.WriteLine("Lütfen yarıçap değerini giriniz");
                        double yaricap = Convert.ToDouble(Console.ReadLine());
                        secilenObje = new Circle(yaricap);
                        Console.WriteLine("Çemberin alanı :"+secilenObje.AlanHesapla());

                        SecimEkrani();

                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Lütfen sırasıyla uzunluk ve tabanı değerlerini giriniz");
                        double uzunluk = Convert.ToDouble(Console.ReadLine());
                        double taban = Convert.ToDouble(Console.ReadLine());
                        secilenObje = new Triangle(uzunluk, taban);
                        Console.WriteLine("Üçgenin alanı :" + secilenObje.AlanHesapla());


                        SecimEkrani();


                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Lütfen 1 kenarı giriniz");
                        double kenar = Convert.ToDouble(Console.ReadLine());
                        secilenObje = new Square(kenar);
                        Console.WriteLine("Karenin alanı :" + secilenObje.AlanHesapla());


                        SecimEkrani();

                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Lütfen sırasıyla kısa kenar ve uzun kenar değerlerini giriniz");
                        double kisaKenar = Convert.ToDouble(Console.ReadLine());
                        double uzunKenar = Convert.ToDouble(Console.ReadLine());
                        secilenObje = new Rectangle(kisaKenar, uzunKenar);
                        Console.WriteLine("Dikdörtgenin alanı :" + secilenObje.AlanHesapla());


                        SecimEkrani();

                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("başarıyla sonlandırıldı.");
                    } break;
                default: break;
            }
          
        }
        
    }
}

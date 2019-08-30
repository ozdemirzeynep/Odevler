using System;
using System.Threading;

namespace ThreadWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            while (i)
            {
                Console.WriteLine("zar atmak için a'ya basınız çıkış için c:");
                string giris = Console.ReadLine();
                if (giris == "a")
                {
                    Thread thread1 = new Thread(Throw);
                    thread1.Start();

                    Thread thread2 = new Thread(Throw2);
                    thread2.Start();
                }
                else
                {
                    if (giris.ToLower() == "c")
                    {
                        break;
                    }

                }
                Console.WriteLine("Yeniden zar atmak için y'ye çıkış için c'ye basınız:");
                string devammi = Console.ReadLine();
                if (devammi == "y")
                {
                    i = true;

                }
                else
                {
                    i = false;
                    if (devammi.ToLower() == "c")
                    {
                        break;
                    }



                }
            }


        }

        public static void Throw()
        {
            Random randomSayi = new Random();
            int sayi = randomSayi.Next(1, 100);
            Console.WriteLine("1.zar :" + sayi);
        }
        public static void Throw2()
        {
            Random randomSayi2 = new Random();
            int sayi2 = randomSayi2.Next(1, 100);
            Console.WriteLine("2. zar :" + sayi2);
        }
    }
}

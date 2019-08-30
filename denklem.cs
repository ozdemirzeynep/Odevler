using System;

namespace denklem
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            double a;
            double b;
            double c;
            double d;

            Console.WriteLine("Denklemin a, b, c değerlerini girin");

            Console.WriteLine("a değerini girin: ");
             a = double.Parse(Console.ReadLine());

            Console.WriteLine("b değerini giriniz: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("c değerini girin: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("denklem: " + a + "x^+" + b +"x+" + c);
            



            d = b*b - 4 * a * c;
            double kdelta = Math.Sqrt(d);
            if (d > 0)
            {
                x1 = (-b + kdelta) / 2 * a;
                x2 = (-b - kdelta) / 2 * a;
                Console.WriteLine("kök 1: " + x1 +" " + "kök 2: "+ " " + x2);

            }
            else if (d == 0)
            {
                x1 = -b / 2 * a;
                
                Console.WriteLine("denklemin kökleri x1=x2=" + x1);
            }
            else
            {
                Console.WriteLine("denklemin gerçel kökü yoktur");
            }

            Console.WriteLine("işlem tamamlandı.");






            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RepeatStr("zeynep");
            AnagramString("zeynep", "penyez");
            ReverseStr("zeynep");
            NumberOfWords("bu cümlenin kelime sayısı nedir");
            RemoveStr("zeynep");
           
            ArraySort();
            UniqueChar("zeynp");
            ChangeStr("boşluk yerine tire koyacak ");
            Add(new int[]{2,3,4,5 }, new int[] {3,6,7,8,10,9,9 });
            sıfırla();
            numeric();
            Console.Read();
        }

        // 1- bir stringede yinelenen karakteri yazdırın

        public static void RepeatStr(string str)
        {
            

            for (int i = 0; i < str.Length - 1; i++)
            {
                int sayac = 0;
                for (int j = 1; j < str.Length - 1; j++)
                {
                    if (str[i] == str[j])
                    {
                        sayac++;

                    }
                }
                if (sayac > 1)
                {
                    Console.WriteLine(str[i] + "harfinden" + sayac + " tane vardır.");
                }
            }
            
        }

        //2- iki stringin birbirinin anagramı olup olmadığını kontrol ediniz.

        public static void AnagramString(string a, string b)
        {
            bool flag = true;
            if (a.Length == b.Length)
            {
                foreach (char c in a)
                {
                    int i = b.IndexOf(c);
                    if (i == -1)
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                flag = false;
            }

            if(flag)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("anagram değiller");
            }
        }

        //3- string reverse methodu kullanılmadan nasıl ters çevrilir

        public static void ReverseStr(string str)
        {
            string newStr="";
            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr += str[i];

            }
            Console.WriteLine(newStr);
        }

        //4- stringdeki kelime sayısını yazdırın

        public static void NumberOfWords(string str)
        {
            string[] words = str.Split(" ");
            Console.WriteLine("kelime sayısı: " + words.Length);
        }

        //5-stringdeki tekrar eden karakterleri çıkarın

        public static void RemoveStr(string str)
        {
            string sonHali = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if(sonHali.IndexOf(str[i])== -1)
                {
                    sonHali += str[i];
                }
            }
            Console.WriteLine(sonHali);
        }

        //6- stringdeki karakterlerin birbirinden benzersiz olduğunu doğrulayın.

        public static void UniqueChar(string str)
        {
            bool flag = true;
            int sayac;
            for (int i = 0; i < str.Length; i++)
            {
                sayac=0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        sayac++;
                    }
                }
                if(sayac >1)
                {
                    flag = false;
                }
            }

            if(flag)
            {
                Console.WriteLine("benzersiz");
            }
            else
            {
                Console.WriteLine("benzersiz değil");
            }

        }

        //7- stringdeki boşluk karakterlerini tire ile değiştirin.


        public static void ChangeStr(string str)
        {
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==' ')
                {
                    arr[i] = '-';
                }
            }

            string updatedPhrase = new string(arr);

            Console.WriteLine(arr);
        }


        //8- 2 int arraydeki sayıları ayrı ayrı toplatın, array toplamlarını birbirinden çıkartın.
        public static void Add(int[] arr1, int[] arr2)
        {
            int toplam1 = 0;
            int toplam2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                toplam1 += arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                toplam2 += arr2[i];
            }

            Console.WriteLine(toplam1 - toplam2);
        }


        //9-array i büyükten küçüğe sıarlayın
        public static void ArraySort()
        {
            int[] arr = new int[] { 33, 44, 13, 87 };

            int tut;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tut = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tut;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }



        //10- int arraydeki 0 ları arrayin sonuna taşıyın.
        public static void sıfırla()
        {
            int[] arr = new int[] { 0,33,0, 44, 13,0,0, 87 };

            int tut;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tut = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tut;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();

        }
        //11- geçici değişken kullanmadan 2 nümerik değeri birbiri ile yer değişrin.
        public static void numeric()
        {
            int a = 5;
            int b = 8;
            Console.WriteLine("a=" + a + " b=" + b);
            a = a + b;//a = 13 b = 8
            b = a - b;//a=13 b=5
            a = a - b;//a = 8 b =5
            Console.WriteLine("a="+a+" b="+b);

        }

    }
}

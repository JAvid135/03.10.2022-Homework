using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerOfTwo(16);
        }
        //=============================================================================
        //1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
        //=============================================================================
        public static void Task1(int n)
        {

            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("3e ve 7 ye bolunur");
            }
            else
            {
                Console.WriteLine("3e ve 7ye bolunmur");
            }
        }

        //==============================================================================

        //==============================================================================
        //2) n və m ədədləri verilir.
        //Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
        //==============================================================================
        public static int EvenNumbers(int n,int m)
        {
            int cemi = 0;
            if (n%2 == 0 && m%2 == 0)
            {
                cemi = n + m;
                Console.WriteLine("Ikiside cutdur");
            }
            return cemi;
        }

        //==============================================================================
        //3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
        //==============================================================================

        public static int AmountSimple (int n, int m)
        {
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if(i % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }

        //=============================================================================
        //4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
        //=============================================================================
        public static int SumSimple (int n,int m)
        {
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }

        //============================================================================
        //5)Verilmish arrayin icindeki tek ededlerin cemini tapin.
        //============================================================================

        public static int ArrSimpleSum(int[] num)
        {
            int[] numbers = new int[num.Length];
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]%2 == 1)
                {
                    sum += num[i];
                }
            }
            return sum;
        }

        //============================================================================
        //6)Verilmish arrayin icindeki cut ededlerin sayini tapin.
        //============================================================================
        public static int ArrEvenAmount(int[] num)
        {
            int[] numbers = new int[num.Length];
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        //===========================================================================
        //7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
        //===========================================================================

        public static void SimpleOrСomplex(int n)
        {
            if (n > 1)
            {
                if (n == 2 || n == 3 || n == 5 || n == 7)
                {
                    Console.WriteLine("Sadedir");
                }
                else
                {
                    if (n%2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7== 0)
                    {
                        Console.WriteLine("Murekkebdir");
                    }
                    else
                    {
                        Console.WriteLine("Sadedir");
                    }
                }
            }
            else
            {
                Console.WriteLine("Yeniden daxil eliyin");
            }
        }

        //========================================================================================
        //8)8) n ededi gelir.
        //2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
        //========================================================================================

        public static void PowerOfTwo (int n)
        {   
            int i = 2;
            while (i<n)
            {
                i *= 2;
            }
            if(i == n)
            {
                Console.WriteLine("Beraberdi");
            }
            else
            {
                Console.WriteLine("Beraber deyil");
            }
        }

        //========================================================================================
        //9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.
        //========================================================================================

        public static int ArrElement(int[] elements)
        {
            int multiply = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i]>1 || elements[i] < 20)
                {
                    multiply*=elements[i];
                }
            }
            return multiply;
        }

        //=======================================================================================
        //10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
        //=======================================================================================

        public static int ArrComplexSum (int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    sum += numbers[i];
                }
            }
            return sum*sum;
        }
        //======================================================================================
    }
}

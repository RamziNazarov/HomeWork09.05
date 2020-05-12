using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace HomeWork09._05
{
    class Program
    {
        static void Show<T>(T array)
        {
            foreach (var items in (dynamic)array)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();
        }
        static int[] NumberToArray(ulong a)
        {
            return a.ToString().Select(x => int.Parse(x.ToString())).ToArray().Reverse().ToArray();
        }
        static int[] GetSummAndCount(int[] array)
        {
            int[] arr = new int[2];
            arr[0] = array.Where(x => x >= 0).Count();
            arr[1] = array.Where(x => x < 0).Sum();
            return arr;
        }
        static void GetSortArrayByLength(ref string[] array)
        {
            array = array.OrderBy(x => x.Length).ToArray();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            ulong chislo = ulong.Parse(Console.ReadLine());
            var aa = NumberToArray(chislo);
            Show<int[]>(aa);
            int[] rr = { 1,2,3,4,5,6,7,8,9,10,-11,-12,-13,-14,-15 };
            var arr2 = GetSummAndCount(rr);
            Show<int[]>(arr2);
            string[] arr = { "Telescopes","Glasses","Eyes","Monocles"};
            GetSortArrayByLength(ref arr);
            Show<string[]>(arr);
            double[] asd1 = { 1, 1, 2, 1, 1 };
            double[] asd = { 0,0,0.54,0,0 };
            double a = GetUnic(asd);
            double b = GetUnic(asd1);
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static double GetUnic(double[] array)
        {
            var a = array.GroupBy(g => g).Where(g => g.Count() < 2).Select(g => g.Key).ToArray();
            return a[0];
        }
    }
}

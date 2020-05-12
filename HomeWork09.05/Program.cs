using System;
using System.Linq;

namespace HomeWork09._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            ulong chislo = ulong.Parse(Console.ReadLine());
            string ads = "1231a4";
            int[] hg = ads.Select(x=>int.Parse(x.ToString())).ToArray();
            for(int i = 0; i < hg.Length;i++)
            {
                hg[i] += 100;
                Console.Write(hg[i] + " ");
            }
            Console.WriteLine();
            var digitArray = chislo.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Reverse();
            foreach (var sd in digitArray)
            {
                Console.Write(sd + " ");
            }
            Console.WriteLine();
            int[] array = { 2,1,1};
            int[] rr = { 1, 2, 3, 4, 5, 6, 87, 9, 7, 5, 4, 3, 23, 1, 2, -10000,-1,-100,-10 };
            var sum = rr.Where(x => x < 0).Sum();
            var coun = rr.Where(x => x >= 0).Count();
            Console.WriteLine(coun);
            Console.WriteLine(sum);
            string[] arr = { "1","123","33","45621","1234","135431513","0"};
            var a = arr.OrderBy(x => x.Length);
            foreach(var it in a)
            {
                Console.WriteLine(it);
            }
            var b = array.Distinct();
            foreach (var s in b)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
        static int[] Massiv(int[] array)
        {
            int[] arr = new int[2];
            for (int i = 0; i < array.Length; i++)
            {
                
            }
            return arr;
        }
    }
}

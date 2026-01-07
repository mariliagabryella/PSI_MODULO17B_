using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17BEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, -3, 17, 42, 42, 0, -1, 100 };
            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];
            int count42 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];
                sum += n;
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
                if (n == 42)
                    count42++;
            }
            double average = (double)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Count of 42: " + count42);
        }
    }
}


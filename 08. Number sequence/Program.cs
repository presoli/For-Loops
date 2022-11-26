using System;
using System.Linq;
namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            
            int[] num = new int[numberCount];
            int x = 0;
            for (int i = 0; i < numberCount; i++)
            {
                num[x] = int.Parse(Console.ReadLine());
                x++;
            }
            
            Console.WriteLine($"Max number: {num.Max()}");
            Console.WriteLine($"Min number: {num.Min()}");
        }
    }
}
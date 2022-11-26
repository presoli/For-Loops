using System;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < nums; i++)
            {
                int a = int.Parse(Console.ReadLine());
                total += a;
            }
            Console.WriteLine(total);
        }
    }
}
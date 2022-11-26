using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum1 += num[i];
                }
                else
                {
                    sum2 += num[i];
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes \nSum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No \nDiff = {Math.Abs(sum1 - sum2)}");
            }

        }
    }
}
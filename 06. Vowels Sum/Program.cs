using System;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;
            string word = Console.ReadLine();
            int points = 0;
            for (int p = 0; p < word.Length; p++)
            {
                char vowel = word[p];
                switch (vowel)
                {
                    case 'a':
                        points++;
                        break;
                    case 'e':
                        points += 2;
                        break;
                    case 'i':
                        points += 3;
                        break;
                    case 'o':
                        points += 4;
                        break;
                    case 'u':
                        points += 5;
                        break;
                }

            }
            Console.WriteLine(points);
        }
    }
}

using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int diameter;
            Console.WriteLine("Enter the width of circle:");
            String input = Console.ReadLine();
            diameter = Int32.Parse(input);
            Console.WriteLine("\n");
            diameter /= 2;
            int x; int y; int a;
            a = (2 * diameter) + 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    y=j-diameter;
                    x=i-diameter;

                    if (x*x + y*y <= (diameter*diameter + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}

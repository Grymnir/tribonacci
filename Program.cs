using System;

namespace tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Tribonacci!");
            Console.WriteLine("How many numbers do you want?");
            int tribo = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int c = 1;

            int d = a + b + c;
            Console.WriteLine("Tribonacci series: ");
            Console.Write(a + "\t" + b + "\t" + c);

            for (int i = 4; i <= tribo; i++)
            {
                Console.Write("\t" + d);
                a = b;
                b = c;
                c = d;
                d = a + b + c;
            }
        }
    }
}

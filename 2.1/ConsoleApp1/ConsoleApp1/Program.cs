using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string J, S;
            J = Console.ReadLine();
            S = Console.ReadLine();

            int count = 0;
            foreach (var el_1 in J)
            {
                foreach (var el_2 in S)
                {
                    if (el_1 == el_2)
                    {
                        count++;
                    }
                }
            }
            
            Console.WriteLine("Драгоценных камней: " + count);
        }
    }
}
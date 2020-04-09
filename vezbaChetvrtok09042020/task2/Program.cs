using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] G1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] G2 = new string[] { "Cvetko", "Darko", "Mete", "Ante" };


            while (true)
            {
                Console.WriteLine("Enter numer of group:");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    foreach (var student in G1)
                    {
                        Console.WriteLine(student);
                    }
                    continue;
                }
                else if (input == "2")
                {
                    foreach (var student in G2)
                    {
                        Console.WriteLine(student);
                    }
                    continue;
                }
                else

                {
                    Console.WriteLine("invalid input");
                    continue;
                }
            }

            Console.ReadLine();
        }
    }
}

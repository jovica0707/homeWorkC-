using System;

namespace Task2
{
    class Program
    {
        
       //////Isto taka i za ovaa mi trebashe pomosh mislev deka pomalce treba da se kuca kod ama iskochi deka poveke treba

        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int Difference(int num1, int num2)
        {
            int diff = num1 - num2;
            return diff;
        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter - or +");
                bool operationSucces = char.TryParse(Console.ReadLine(), out char operation);


                if (!operationSucces || operation != '-' && operation != '+')
                {
                    Console.WriteLine("Invalid");
                    continue;
                }
                int input1;

                while (true)
                {
                    Console.WriteLine("Enter the first number");
                    bool num1Success = int.TryParse(Console.ReadLine(), out input1);

                    if (!num1Success)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    break;
                }

                int input2;

                while (true)
                {
                    Console.WriteLine("Enter the second number");
                    bool num2Success = int.TryParse(Console.ReadLine(), out input2);

                    if (!num2Success)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    break;
                }

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"The sum of {input1} and {input2} is {Sum(input1, input2)}");
                        break;
                    case '-':
                        Console.WriteLine($"The difference of {input1} and {input2} is {Difference(input1, input2)}");
                        break;
                }
                break;

            }
            Console.ReadLine();
        }
    }
}
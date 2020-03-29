using System;

namespace Task1
{
    class Program
    {
        static void Substrings(int num)
        {
            string sedc = "Hello from SEDC Codecademy v7.0";

            if (num > sedc.Length)
            {
                Console.WriteLine($"Input a number lower than {sedc.Length}");

            }
            else
            {
                string sedcNew = sedc.Substring(0, num);

                Console.WriteLine($"The fist characters from the new string are '{sedcNew}' and their length is {sedcNew.Length}");
            }


        }
        
        /////Do tuka mi e jasno za podole reshenieto, pobarav pomosh 
      
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
                bool Sucenssn = int.TryParse(Console.ReadLine(), out int n);

                if (Sucenssn)
                {
                    Substrings(n);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

            Console.ReadLine();
        }
    }
}

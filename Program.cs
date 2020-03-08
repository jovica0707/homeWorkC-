using System;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Task 1: RealCalculator
            ///


            //Console.WriteLine("Please enter the first number: ");
            //string inputFurstNumber = Console.ReadLine();

            //int Furstnumber = int.Parse(inputFurstNumber);

            //Console.WriteLine("Please enter the second number: ");
            //string inputSecondNumber = Console.ReadLine();

            //int Secondnumber = int.Parse(inputSecondNumber);

            //Console.WriteLine("Please choose the operation would you want to be done (+, -, *, /)");
            //string inputOperation =(Console.ReadLine());


            //int result = 0;
            //switch (inputOperation)
            //{
            //    case "+":

            //        result = Furstnumber + Secondnumber;

            //        Console.WriteLine(result);
            //        break;

            //    case "-":
            //        result = Furstnumber - Secondnumber;
            //        Console.WriteLine(result);
            //        break;

            //    case "*":
            //        result = Furstnumber * Secondnumber ;
            //        Console.WriteLine(result);
            //        break;

            //    case "/":
            //        result = Furstnumber / Secondnumber;
            //        Console.WriteLine(result);
            //        break;

            //    default:
            //               Console.WriteLine("You have entered wrong operation !");
            //                break;
            //}


            //Console.WriteLine("Result = " + result);


            //Task 2: AverageNumber

            //Console.WriteLine("Please enter the first number: ");
            //string inputFurstNumber = Console.ReadLine();

            //int Furstnumber = int.Parse(inputFurstNumber);

            //Console.WriteLine("Please enter the second number: ");
            //string inputSecondNumber = Console.ReadLine();

            //int Secondnumber = int.Parse(inputSecondNumber);

            //Console.WriteLine("Please enter the third number");

            //string inputThirdNumber = Console.ReadLine();

            //int Thirdnumber = int.Parse(inputThirdNumber);

            //Console.WriteLine("Please enter the fourth number");

            //string inputFourthNumber = Console.ReadLine();

            //int Fourthnumber = int.Parse(inputFourthNumber);

            //int result = Furstnumber + Secondnumber + Thirdnumber + Fourthnumber /4;

            //Console.WriteLine("The average is " + result);

            Console.WriteLine("Please enter the first number: ");
            string inputFurstNumber = Console.ReadLine();

            int Furstnumber = int.Parse(inputFurstNumber);
            int tempFirst = Furstnumber;

            Console.WriteLine("Please enter the second number: ");
            string inputSecondNumber = Console.ReadLine();

            int Secondnumber = int.Parse(inputSecondNumber);

            int tempSecond = int.Parse(inputSecondNumber);

            Furstnumber = tempSecond;

            Secondnumber = tempFirst;

            Console.WriteLine(Furstnumber);
            Console.WriteLine(Secondnumber);







            Console.ReadLine();
        }
    }
}

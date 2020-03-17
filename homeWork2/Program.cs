using System;

namespace homeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Task 4
            //string[] stringArray = new string[5];
            //float[] floatArray = new float[5];
            //char[] charArray = new char[5];
            //bool[] boolArray = new bool[5];

            //int[] list1 = new int[2];
            //int[] list2 = new int[2];
            //int[] list3 = new int[2];
            //int[] list4 = new int[2];
            //int[] list5 = new int[2];

            //int[][] lists = new int[][] { list1, list2, list3, list4, list5 };
            //Console.WriteLine(lists);



            ////Task 5
            ///
            //int[] intArray = new int[5];

            //int input;
            //int sum = 0;
            //int counter;

            //for (int i = 0; i < 5; i++)
            //{
            //    counter = i + 1;
            //    Console.WriteLine("Input number " + counter + ".");
            //    input = int.Parse(Console.ReadLine());
            //    sum += input;
            //}

            //Console.WriteLine("The result is " + sum);


            ////task 6


            string[] namesArr = new string[1];

            Console.WriteLine("Enter the first name");
            namesArr[0] = Console.ReadLine();

            char inputch;


            while (true)
            {
                Console.WriteLine("Do you want to enter another name? Y/N ");
                inputch = char.Parse(Console.ReadLine());



                if (inputch == 'Y' || inputch == 'y')
                {
                    Console.WriteLine("Enter new name");
                    Array.Resize(ref namesArr, namesArr.Length + 1);
                    namesArr[namesArr.Length - 1] = Console.ReadLine();
                }

                if (inputch == 'N' || inputch == 'n')
                {

                    break;
                }

                if (inputch != 'Y' && inputch != 'y' && inputch != 'N' && inputch != 'n') ;
                {
                    continue;
                }
            }

            for (int i = 0; i < namesArr.Length; i++)
            {
                Console.WriteLine(namesArr[i]);
            }



            Console.ReadLine();

        }
    }
}
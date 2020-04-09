using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            User student1 = new User(01, "Jovica", "jovica0707", new string[] { "hi" });
            User student2 = new User(02, "Cvetko", "Cvetko123", new string[] { "hallo" });
            User student3 = new User(03, "Darko", "Darko456", new string[] { "nice day" });



            User[] arrayOfUsers = new User[] { student1, student2, student3 };


            #endregion

            //while (true)
            //{
            //    Console.WriteLine("Enter id number:");
            //    string input = Console.ReadLine();
            //    if (input == "1")
            //    {
            //        foreach (var student in student1)
            //        {
            //            Console.WriteLine(student);
            //        }
            //    }
            //    continue;

                
            //else if (input == "2")
            //{
            //    foreach (var student in student2)
            //    {
            //        Console.WriteLine(student);
            //    }
            //    continue;
            //}
            //else if (input == "3")
            //{
            //    foreach (var student in student3)
            //    {
            //        Console.WriteLine(student);
            //    }
            //    continue;
            //}
            //else

            //{
            //    Console.WriteLine("invalid input");
            //    continue;
            //}

            //}


            Console.ReadLine();

        }
    }
}

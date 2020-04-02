using System;

namespace homeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            DateTime TreeDays = currentDate.AddDays(3);
            DateTime OneMonth = currentDate.AddMonths(1);
            DateTime oneMonthTreeDays = currentDate.AddDays(3).AddMonths(1);
            DateTime past = currentDate.AddMonths(-3).AddYears(-1);
            var currentMonth = currentDate.Month;
            var currentYear = currentDate.Year;




            Console.WriteLine($"The date that is 3 days from now: {TreeDays}");
            Console.WriteLine($"The date that is one month from now: {OneMonth}");
            Console.WriteLine($"The date that is one month and 3 days from now: {oneMonthTreeDays}");
            Console.WriteLine($"1 year and 2 months ago from today: {past}");
            Console.WriteLine($"The only current month of today: {currentMonth}");
            Console.WriteLine($"The only current year of today {currentYear}");


            Console.ReadLine();
        }
    }
}

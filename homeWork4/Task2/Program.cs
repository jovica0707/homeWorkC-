using System;

namespace Task2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine("The dog is now eating");
        }

        public void Play()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine("The dog is now chasing its tail");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Dog myDog = new Dog();

                Console.WriteLine("Enter the dog's name:");
                myDog.Name = Console.ReadLine();

                if (myDog.Name == "")
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Enter the dog's race:");
                    myDog.Race = Console.ReadLine();

                    if (myDog.Race == "")
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the dog's color:");
                    myDog.Color = Console.ReadLine();

                    if (myDog.Color == "")
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    break;
                }

                Console.WriteLine($"Your dog name is {myDog.Name}, its race is {myDog.Race} and his color is {myDog.Color}");

                while (true)
                {
                    Console.WriteLine(@"Choose the activity you want for your dog For your dog to eat press: 1 For your dog to play press: 2 For your dog to chase his tail press: 3");

                    bool activitySuccess = int.TryParse(Console.ReadLine(), out int activity);

                    if (!activitySuccess || activity < 1 || activity > 3)
                    {
                        Console.WriteLine("Ivalid input");
                        continue;
                    }

                    switch (activity)
                    {
                        case 1:
                            myDog.Eat();
                            break;
                        case 2:
                            myDog.Play();
                            break;
                        case 3:
                            myDog.ChaseTail();
                            break;
                    }

                    break;
                }
                break;
            }

            Console.ReadLine();
        }
    }
}
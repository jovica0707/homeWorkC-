using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Homework.Linq
{
	public class Person
	{
		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }

	}
	class Program
	{
		static void Main(string[] args)
		{

			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			List<Person> ageMore50 = people
										.Where(x => x.Age >= 50)
										.ToList();
			ageMore50.ForEach(x => Console.WriteLine(x.FirstName));


			// Task 02
			// all people name starts with B
			List<Person> nameStartsB = people
											.Where(x => x.FirstName.StartsWith("B"))
											.ToList();
			nameStartsB.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 03
			// first person whose surname starts with T
			Person firstPersonSurnameT = people
											.Where(x => x.LastName.StartsWith("T"))
											.First();
			Console.WriteLine($"Surname: {firstPersonSurnameT.LastName}");


			// Task 04
			// find youngest and oldest person

			Person youngPerson = people
										.Where(x => x.Age.Equals(people.Min(y => y.Age)))
								.First();
			Person oldPerson = people
										.Where(x => x.Age.Equals(people.Max(y => y.Age)))
										.First();

			//.Min(x => x.Age)
			//.Max(x => x.Age)
			//.ToList();

			//youngAndOldestPerson.ForEach( x=> Console.WriteLine("Min {0}", people.Min()));
			//Console.WriteLine("Max {0}", people.Max());

			//Person firstyung = people
			//							.Min(x=> x.Age)
			//							.Max(x=> x.Age)

			// Task 05
			// find all male people aged 45 or more
			List<Person> allMale45more = people
												.Where(x => x.Gender == 'M')
												.Where(x => x.Age >= 45)
												
												.ToList();

			allMale45more.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} {x.Age} years old"));
			// Task 06
			// find all females whose name starts with V
			List<Person> femaleStartV = people
											.Where(x => x.FirstName.StartsWith("V"))
											.ToList();

			
			femaleStartV.ForEach(x => Console.WriteLine($"{x.FirstName}"));


			// Task 07
			// find last female person older than 30 whose name starts with p

			Person FemaleOver30NameP = people
						.Where(x => x.Gender == 'F')
						.Where(x => x.Age > 30)
						.Where(x => x.FirstName.StartsWith("P"))
						.LastOrDefault();


			Console.WriteLine( $"{FemaleOver30NameP.FirstName} {FemaleOver30NameP.LastName} {FemaleOver30NameP.Age} years old");



			// Task 08
			// find first male younger than 40

			Person firstMaleYounger40 = people
												.Where(x => x.Gender == 'M')
												.Where(x => x.Age < 40)
												.FirstOrDefault();

			
			Console.WriteLine( $"{firstMaleYounger40.FirstName} {firstMaleYounger40.LastName} {firstMaleYounger40.Age} years old");

			// Task 09
			// print the names of the male persons that have firstName longer than lastName

	



			// Task 10
			// print the lastNames of the female persons that have odd number of ages


			Console.ReadLine();
		}
	}
}

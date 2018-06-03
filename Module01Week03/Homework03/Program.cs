using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework03;
using static Homework03.ClassLibrary;
using static Homework03.ClassLibrary.Person;

/*
Create the classes from the following requirements:
•	Create an application that allows users to post messages on a common board.
•	A person can create an account using his email and personal information like first name, last name, birthdate.
•	Each post should have an author
•	The board should display all the posts, created by all the users, chronologically, in descending order(latest first)
Notes: 
•No implementation for methods, we will continue next week with that
•Create 2 projects in the same solution: a class library and a console app
*/

namespace Homework03
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person("Ivan", "Emilia-Ioana", new DateTime(18,01,1997));
			Person person2 = new Person("Purcaru", "Emanuel", new DateTime(28, 08, 1997));
			Person person3 = new Person("Georgescu", "Alexandra", new DateTime(01, 12, 1997));
			Person person4 = new Person("Ivanescu", "Roxana", new DateTime(12, 05, 1997));

			Account account1 = new Account("ioanae18@yahoo.com", "Ivan", "Emilia-Ioana", new DateTime(18, 01, 1997));
			Account account2 = new Account("purcaruemanuel@yahoo.com", "Purcaru", "Emanuel", new DateTime(28, 08, 1997));
			Account account3 = new Account("georgescualexandra@gmail.com", "Georgescu", "Alexandra", new DateTime(01, 12, 1997));
			Account account4 = new Account("ivanescuroxana@windowslive.com", "Ivanescu", "Roxana", new DateTime(12, 05, 1997));

			Post post1 = new Post(account1, "Hello. This is me.", new DateTime(18, 01, 1997));
			Post post2 = new Post(account2, "I'm glad to post my first message!", new DateTime(01, 01, 1997));
			Post post3 = new Post(account3, "This is my second message.", new DateTime(14, 01, 1997));
			Post post4 = new Post(account4, "This is my new message!", new DateTime(21, 01, 1997));

			post1.ShowPosts();
			post1.ShowCommonBoard();
			post2.ShowPosts();
			post2.ShowCommonBoard(); 
			post3.ShowCommonBoard(); 
			post3.ShowCommonBoard();
			post4.ShowPosts();
			post4.ShowCommonBoard();

			Console.ReadKey();

		}
	}
}

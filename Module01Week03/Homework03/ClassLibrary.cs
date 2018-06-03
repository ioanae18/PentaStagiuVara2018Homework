using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
	class ClassLibrary
	{
		public class Person
		{
			public string LastName { get; private set; }
			public string FirstName { get; private set; }
			public DateTime BirthDate { get; private set; }
			public static List<Person> persons = new List<Person>();

			public Person(string lastName, string firstName, DateTime birthDate)
			{
				this.LastName = lastName;
				this.FirstName = firstName;
				this.BirthDate = birthDate;
			}


			public class Account : Person
			{
				public string Email { get; set; }

				public Account(string email, string lastName, string firstName, DateTime birthDate) :
					base(lastName, firstName, birthDate)
				{
					this.Email = email;
				}
			}

			public class Post
			{
				public Account Author;
				public string Message;
				public DateTime PostTime;
				public static List<Post> posts = new List<Post>();

				public Post(Account author, string message, DateTime postTime)
				{
					this.Author = author;
					this.Message = message;
					this.PostTime = postTime;
				}

				//showing posts
				public void ShowPosts()
				{
					int count = 0;
					foreach (Post post in posts)
					{
						Console.WriteLine();
						Console.WriteLine(count++ + "Author: " + post.Author + "The message is: " + post.Message 
							+ "The time when the message was posted : " + post.PostTime);
					}
				}

				//showing the posts in descending order
				public void ShowInDescOrder()
				{
					int count = 0;
					List<Post> aux = posts;
					aux.Reverse();
					foreach (Post post in posts)
					{
						Console.WriteLine();
						Console.WriteLine(count++ + "The author is: " + post.Author + "The message is: " + post.Message 
							+ "The time when the message was posted: " + post.PostTime);
					}
				}
			}

			class CommonBoard : Post
			{
				public CommonBoard(Account author, string message, DateTime postTime) :
					base(author, message, postTime)
				{

				}
			}
		}
	}
}

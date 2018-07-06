using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Post
    {
		public Person Author { get; private set; }
		public string Message { get; private set; }
		public DateTime PostTime { get; private set; }
		public static List<Post> posts = new List<Post>();
		public static List<Person> persons = new List<Person>();
		private bool changed = false;

		//Constructor for Post
		public Post(Person author, string message, DateTime postTime)
		{
			this.Author = author;
			this.Message = message;
			this.PostTime = postTime;
		}

		//Method for showing posts
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

		//Method for showing posts in descending order
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

		public static void CreatePost()
		{
			string author = Person.LoggedInUser();

			Console.Write("Please enter your post body: ");
			string postMessage = Console.ReadLine();

			Post post = new Post(author, postMessage, DateTime.Now);
			AddToBoard(post);

			Console.WriteLine();
		}

		public static void AddToBoard(Post post)
		{
			posts.Add(post);
		}


		public void EditPost(string newText)
		{
			changed = true;
			this.Message = newText;
		}

		//@override display method
		public override string ToString()
		{
			return "Message: " + Message;
		}
	}
}

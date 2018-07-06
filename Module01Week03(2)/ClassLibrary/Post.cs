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
		public string Text { get; private set; }
		public static List<Post> posts = new List<Post>();
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

		public void EditPost(string newText)
		{
			changed = true;
			this.Text = newText;
		}

		//@override display method
		public override string ToString()
		{
			return "Message: " + Text;
		}
	}
}

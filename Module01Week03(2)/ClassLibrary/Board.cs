using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	class Board
	{
		private List<Post> postList;
		private List<Person> personList;

		public delegate void NewMessageEventHandler(object source, EventArgs args);
		public event NewMessageEventHandler NewPostedMessage;
		// Event handler for new users:
		private event EventHandler NewAddedUser;

		//Creating an index for Person List
		public Person this[int index]
		{
			get
			{
				return personList[index];
			}
		}

		// Method for adding a new user in User List.
		public void AddPerson(string email, string firstName, string lastName, DateTime birthDate)
		{
			Person newPerson = new Person(lastName, firstName, birthDate, email);
			personList.Add(newPerson);
			NewAddedUser += PostNewUserAdded;
			NewUserJoined(newPerson);
		}

		//Method for adding a new post
		public void AddPost(string message, Person author)
		{
			DateTime postTime = DateTime.Now;
			Post newPost = new Post(author, message, postTime);
			postList.Add(newPost);
			NewPostPosted(author);
		}

		//Method for showing posts
		public void ShowBoard()
		{
			postList.Sort();
			int count = 0;
			foreach (Post post in postList)
			{
				Console.WriteLine();
				Console.WriteLine(count++ + "Author: " + post.Author + "The message is: " + post.Message
					+ "The time when the message was posted : " + post.PostTime);
			}
		}

		//Method to fire when a post is added
		protected virtual void NewPostAdded(Person sender)
		{
			NewPostedMessage?.Invoke(sender, EventArgs.Empty);
		}

		//Method to fire all users about new post added to the board
		public void NewPost(Person sender)
		{
			foreach (var pers in personList)
			{
				if (pers != sender)
				{
					pers.Messages++;
				}
			}
		}

		//Method to post a message when a new user joins the board
		private void PostNewUserAdded(object sender, EventArgs args)
		{
			Person newPerson = (Person)sender;
			this.AddPost(newPerson.ToString() + " has joined the board!", null);
			NewAddedUser -= PostNewUserAdded;
		}

		//Method to announce when a new message was posted
		protected virtual void NewPostPosted(Person sender)
		{
			NewPostedMessage?.Invoke(sender, EventArgs.Empty);
		}

		//Method to announce when a new user joined the board
		protected virtual void NewUserJoined(Person newPerson)
		{
			if (NewAddedUser != null)
			{
				NewAddedUser(newPerson, EventArgs.Empty);
			}
		}
	}
}

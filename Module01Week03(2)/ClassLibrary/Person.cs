using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Person
	{
		public string LastName { get; private set; }
		public string FirstName { get; private set; }
		public DateTime BirthDate { get; private set; }
		public string Email { get; private set; }
		public static List<Person> persons = new List<Person>();

		public int Messages { get; set; } = 0;

		//Constructor for Person
		public Person(string lastName, string firstName, DateTime birthDate, string email)
		{
			this.LastName = lastName;
			this.FirstName = firstName;
			this.BirthDate = birthDate;
			this.Email = email;
		}

		//Method for editing the Person's Information
		public void EditPersonInfo(string firstName, string lastName, DateTime birthDate, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.BirthDate = birthDate;
			this.Email = email;
		}

		//Method for creating person's ID
		private string CreatePersonId(string firstName, string lastName)
		{
			Random randomNumber = new Random();
			string randomizeAccount = randomNumber.Next(1, 500).ToString();
			string userId = firstName.Substring(0, 3) + lastName.Substring(0, 3) + randomizeAccount;
			return userId;
		}

		//@override display method
		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}

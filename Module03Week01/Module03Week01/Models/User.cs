using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module03Week01.Models
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public bool IsEmployee { get; set; }
		public Gender Gender { get; set; }
	}

	public enum Gender
	{
		Male,
		Female
	}
}
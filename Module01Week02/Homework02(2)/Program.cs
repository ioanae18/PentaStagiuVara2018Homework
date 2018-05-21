using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The first build-in functionality is : ");
			string[] words = { "The ", "book ", "is ", "awesome." };

			var s = string.Concat(words);

			Console.WriteLine(s);



			Console.WriteLine("The second build-in functionality is : ");
			string s1 = " PLaN00e.t";
			string s2 = "Planet";

			Console.WriteLine("Comparison of '{0}' and '{1}' : {2}", s1, s2, String.Compare(s1, s2, true));



			Console.WriteLine("The third build-in functionality is : ");
			Console.WriteLine("The initial string: '{0}'", s1);
			s1 = s1.Replace("0", "e").Replace("0", "e").Replace(".", "t");
			Console.WriteLine("The final string: '{0}'", s1);




			Console.WriteLine("The fourth build-in functionality is : ");
			string str = "Tom has been very ill this morning so he couldn't reach the train.";
			string substr = "Irina";

			Console.WriteLine("Does '{0}' contains '{1}'?", str, substr);
			StringComparison comp = StringComparison.Ordinal;
			Console.WriteLine("{0:G}: {1}", comp, str.Contains(substr));




			Console.WriteLine("The fifth build-in functionality is : ");
			char[] chars = { 'a', 'E', 'i', 'o', 'U', '6', '.', '7' };

			foreach (var ch in chars)
			{
				Console.WriteLine("{0} --> {1} {2}", ch, char.ToUpper(ch), ch == Char.ToUpper(ch) ? "(Same character)" : "");
			}




			Console.WriteLine("The sixth build-in functionality is : ");
			String s4 = null;

			Console.WriteLine("The value of the string is '{0}'", s4);

			try
			{
				Console.WriteLine("String length is {0}", s4.Length);
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine(e.Message);
			}




			Console.WriteLine("The seventh build-in functionality is : ");
			Console.Write("Enter your first name: ");
			string firstName = Console.ReadLine();

			Console.Write("Enter your middle name or initial: ");
			string middleName = Console.ReadLine();

			Console.Write("Enter your last name: ");
			string lastName = Console.ReadLine();

			Console.WriteLine();
			Console.WriteLine("You entered '{0}', '{1}', and '{2}'.", firstName, middleName, lastName);

			string name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " + lastName.Trim()).Trim();
			Console.WriteLine("The result is " + name + ".");


			Console.ReadKey();
		}
	}
}

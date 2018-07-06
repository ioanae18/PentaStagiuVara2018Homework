using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * Load list of names from file with name people.txt.
 * Add remove one of the name and add 2 new names to the list.
 * Save modified list in the new file.
 * In case file not exist throw and catch exception. When exception is catch create missing file.
 * If one of the name is invalid then display message and don’t add name to the list. Valid names contains only letters.
 * */

namespace Module02Week01
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStreamRun();
			StreamReaderRun();
			StreamWriterRun();
		}

		private static void FileStreamRun()
		{
			try
			{
				FileStream fileStream = new FileStream("test.txt", FileMode.OpenOrCreate,
				  FileAccess.ReadWrite);

				for (int i = 1; i <= 20; i++)
				{
					fileStream.WriteByte((byte)i);
				}

				fileStream.Position = 0;
				for (int i = 0; i <= 20; i++)
				{
					Console.Write(fileStream.ReadByte() + " ");
				}
				fileStream.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("The file could not be read: {0}", ex.ToString());
			}

			Console.ReadKey();
		}

		//output
		//writing and saving names in people.txt file
		private static void StreamWriterRun()
		{
			string[] people = new string[] { "Tom", "Anna", "John", "Rick2000" };

			using (StreamWriter sw = new StreamWriter("people.txt"))
			{
				foreach (string p in people)
				{
					sw.WriteLine(p);
				}
			}

			string line = " ";
			using (StreamReader sr = new StreamReader("people.txt"))
			{
				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
			}

			Console.ReadKey();

		}

		//input
		//reading line with line from people.txt file
		private static void StreamReaderRun()
		{
			using (StreamReader sr = new StreamReader("../../people.txt"))
			{
				string line;

				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}

				Console.ReadKey();
			}
		}

		//Method for removing names
		public void RemovePerson(int index)
		{
			int i = index;

			using (StreamReader rf = new StreamReader("people.txt"))
			{
				string line;
				int counter = 1;
				while ((line = rf.ReadLine()) != null)
				{
					if (counter == index)
					{
						using (StreamWriter wf = new StreamWriter("people.txt"))
						{
							wf.WriteLine("");
						}
					}
					counter += 1;
				}
			}
		}

		//Method for displaying message if the name is not valid
		public string Choice()
		{
			Console.WriteLine();
			Console.WriteLine("Please choose one of the options: ");
			Console.WriteLine("1)Insert a new person");
			Console.WriteLine("2)Delete a person");
			Console.WriteLine("3)Exit Application");
			Console.WriteLine();
			Console.Write("Enter your option: ");
			string choice = Console.ReadLine();
			return choice;
		}
	}
}

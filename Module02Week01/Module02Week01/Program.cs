using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
	}
}
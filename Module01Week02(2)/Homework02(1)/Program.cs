using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
	Read from the console 3 integers representing the year, month and day of a person and a letter(M/F) representing the gender
of the person
•	Convert the 3 integers and create a DateTime for the birthdate
•	Compute the age of the person, based on the birthdate
•	Create an enum for the genders(Female, Male)
•	Using the input for gender, set the value of a nullable variable to one of the enum values or to null (if the user wrote an 
invalid character, other than M or F)
•	If there’s a valid Gender, then display a message if the person is retired or at what age he/she will retire(Female at 63, 
Male at 65)
*/


namespace Homework02_1_
{

	public enum Gender
	{
		Male,
		Female
	}

	class Program
	{
		static void Main(string[] args)
		{
			int birthDay, birthMonth, birthYear;

			Console.WriteLine("Insert person's born year: ");
			birthYear = int.Parse(Console.ReadLine());
			Console.WriteLine("Insert person's born month: ");
			birthMonth = int.Parse(Console.ReadLine());
			Console.WriteLine("Insert person's born day: ");
			birthDay = int.Parse(Console.ReadLine());
			Console.WriteLine("Insert person's gender(M/F): ");
			char gender = char.Parse(Console.ReadLine());


			//Computing the age of the person based on the birthdate
			DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
			DateTime now = DateTime.Now;
			TimeSpan difference = now - birthDate;
			Console.WriteLine(difference);

			//Converting the days into years, months and days
			var totalDays = difference.TotalDays;
			var totalYears = Math.Truncate(totalDays / 365);
			var totalMonths = Math.Truncate((totalDays % 365) / 30);
			var remainingDays = Math.Truncate((totalDays % 365) % 30);
			Console.WriteLine("Estimated duration is {0} year(s), {1} month(s) and {2} day(s)", totalYears, totalMonths, remainingDays);

			Gender? personGender;
			bool validGender = false;
			if (gender.Equals('M'))
			{
				personGender = Gender.Male;
				validGender = true;
			}
			else if (gender.Equals('F'))
			{
				personGender = Gender.Female;
				validGender = true;
			}
			else
			{
				personGender = null;
			}

			//The years until retirement
			if(validGender)
            {
				if (gender.Equals('M'))
                {
                    if(totalYears >= 65)
                    {
                        Console.WriteLine("The man is already retired!");
                    }
                    else
                    {
                        var yearsUntillRetirementM = totalYears - 65;
                        Console.WriteLine("The man has {0} more years until he get retired.", yearsUntillRetirementM);
                    }
                }
                else if (gender.Equals('F'))
                {
                    if (totalYears >= 63)
                    {
                        Console.WriteLine("The woman is already retired!");
                    }
                    else
                    {
                        var yearsUntillRetirementF = totalYears - 63;
                        Console.WriteLine("The woman has {0} more years until she get retired.", yearsUntillRetirementF);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter M/F!");
            }

			Console.ReadKey();
		}
	}
}


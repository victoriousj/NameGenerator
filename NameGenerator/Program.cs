using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
	class Program
	{
		static string path = System.IO.Path.GetFullPath(@"..\..\");
		static string LASTNAMES = path + @"lastNames.txt";
		static string FIRSTNAMES = path + @"maleAndFemaleNames.txt";

		static Random random = new Random();

		static void Main(string[] args)
		{
			string firstNamesString = File.ReadAllText(FIRSTNAMES);
			List<string> firstNameList = firstNamesString.Split(' ').ToList();
			int firstNameCount = firstNameList.Count();

			string lastNamesString = File.ReadAllText(LASTNAMES);
			List<string> lastNameList = lastNamesString.Split(' ').OrderBy(c => c).ToList();
			int lastNameCount = lastNameList.Count();

			for (int i = 0; i < 10000; i++)
			{
				string randomFirstName = firstNameList[random.Next(firstNameCount)];
				string randomLastName = lastNameList[random.Next(lastNameCount)];

				string Person = $"{randomFirstName} {randomLastName}";

				//string Person = $"new Customer() {{ FirstName = {randomFirstName}, LastName = {randomLastName} }},";

				Console.WriteLine(Person);
			}
			Console.ReadLine();
		}
	}
}

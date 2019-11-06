using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
		{
			string[] names = new string[5] { "Ksenia", "Britta", "Britta", "Andri", "Bogdan" };

			string searchName = "Britta";

			CountNames(names, searchName);

		}
		public static void CountNames(string[] searchArray, string searchWord)
		{
			int counter = 0;
			foreach (string word in searchArray)
			{

				if (word == searchWord)
				{
					counter++;
				}

			}
			Console.WriteLine($"There are {counter} {searchWord} in the array.");

		}
	}
}

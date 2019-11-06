using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim() võtab tühikud mõlemalt poolt ära, keskelt ei võta
            //IndexOf()
            //Substring()
            //Split() võtab keskelt tühiku, eraldab 2 sõna

            string fullName = " Britta Panker ";
            Console.WriteLine($"Full name lenght before trim: {fullName.Length}");

            fullName = fullName.Trim();
            Console.WriteLine($"Full name lenght before trim: {fullName.Length}");

            Console.WriteLine($"{fullName[0]}");

            int indexOfSpace = fullName.IndexOf(' ');
            Console.WriteLine($"The position of the space is {indexOfSpace}.");

            string firstName = fullName.Substring(0, indexOfSpace);
            Console.WriteLine($"First name: {firstName}");

            string lastName = fullName.Substring(indexOfSpace + 1);
            Console.WriteLine($"Last name: {lastName}");

            //Split() 
            string [] personalData = fullName.Split(' ');
            foreach(string value in personalData)
            {
                Console.WriteLine($"Value from personalData: {value}");
            }


        }
    }
}

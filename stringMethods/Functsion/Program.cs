using System;

namespace Functsion
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            Console.WriteLine("Please enter your name: ");
            fullName = Console.ReadLine();

            GetName(fullName);

        }
        public static void GetName(string stringToSplit)
        {
            string[] personalData = stringToSplit.Split(' ');
            Console.WriteLine($"First name: {personalData[0]}");
            Console.WriteLine($"Last name: {personalData[1]}");
            foreach (string value in personalData)
            {
                Console.WriteLine($"Value from personalData: {value}");
            }

        }
   
    }
}

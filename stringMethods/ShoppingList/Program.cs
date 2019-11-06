using System;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the list of supplies separated by comma: ");
            string userList = Console.ReadLine();

            string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}: {shoppingList[i]}");
            }*/

            Console.WriteLine("Enter your first name, last name, year of birth: ");
            string userAnswer = Console.ReadLine();
            Form(userAnswer);
        }
        public static void Form(string items)
        {
            string[] personalData = items.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            /*for (int i = 0; i < personalData.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}: {personalData[i]}");
            }*/
            Console.WriteLine($"First name: {personalData[0]}");
            Console.WriteLine($"Last name: {personalData[1]}");
            Console.WriteLine($"Age : {2019 - int.Parse(personalData[2])}");



        }
    }
}

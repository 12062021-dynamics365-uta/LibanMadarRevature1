
using System;

namespace NewProject0
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There How are you?");
            Console.WriteLine("This is a Test");
            ///
            /// 
            
            
                //PrintMainMenu();
                //string input = Console.ReadLine();
                //MainMenuSelection(input, ref cont);
            
        
             public static void AddCustomerConsole()
        {
            Console.Clear();
            Console.WriteLine("Please provide first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please provide last name:");
            string lastName = Console.ReadLine();
            AddCustomer(firstName, lastName);
        }

        /// <summary>
        /// Prints list of all customers
        /// </summary>
        public static void PrintAllCustomersConsole()
        {
            Console.Clear();

            if (!(NumOfCurrentCustomers() == 0))
            {
                var customers = GetAllCustomers();
                foreach (var c in customers)
                {
                    Console.WriteLine("FirstName\t|LastName\t | CustomerID");
                    Console.WriteLine($"{c.FirstName,16}|{c.LastName,16}| {c.Id}");
                    Console.WriteLine("----------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No Customers Currently in System.");
            }
        }

    }



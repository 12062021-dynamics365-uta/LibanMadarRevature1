
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
            bool cont = true;

            while (cont)
            {
                PrintMainMenu();
                string input = Console.ReadLine();
                //MainMenuSelection(input, ref cont);
            }
        }

        /// <summary>
        /// Prints the main menu
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Store!");
            Console.WriteLine("Please Select From the Following Options: ");
            Console.WriteLine("(1) Add Customer");
            Console.WriteLine("(2) View All Customers");
            Console.WriteLine("(3) Change Customer");
            Console.WriteLine("(4) Add Location");
            Console.WriteLine("(5) View All Locations");
            Console.WriteLine("(6) Select Location");
            Console.WriteLine("(7) View Inventory at Location");
            Console.WriteLine("(8) Modify Inventory at Location");
            Console.WriteLine("(9) View All Orders");
            Console.WriteLine("(10) View All Orders By Customer");
            Console.WriteLine("(11) View All Orders At Location");
            Console.WriteLine("(12) Make New Order");
            Console.WriteLine("(13) View an Order's Details");
            Console.WriteLine("E(x)it");
            Console.Write("Selection: ");
        }

    }

}

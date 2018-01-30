/*
 * ITSE 1430
 * 
 * Section 1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Nile.host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                //Display menu
                char choice = DisplayMenu();
                //Process mennu selection
                switch (choice)
                {
                    case 'l':
                    case 'L': ListProducts(); break;
                    case 'a':
                    case 'A': AddProduct(); break;
                    case 'q':
                    case 'Q':quit = true; break;
                };
            };

        }
        static void AddProduct()
        {
            //Get name
            _name = ReadString("Enter Name: ", true);

            //Get price
            _price = ReadDecimal("Enter Price: ", 0);

            //Get description
            _description = ReadString("Enter oiptional description ", false);
        }
        private static decimal ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();
                               
                if (Decimal.TryParse(value, out decimal result))
                {
                    //If not required or not empty
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine("Value must be >= {0}" + minValue);
            } while (true);
        }
        private static string ReadString( string message, bool isRequired )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                //If not required or not empty
                if (isRequired || value != "")
                    return value;

                Console.WriteLine("Value is Required");
            } while (true);
        }

        private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("L)ist Products");
                Console.WriteLine("A)dd Product");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                if (input == "L" || input == "l")
                    return input[0];
                else if (input == "A" || input == "a")
                    return input[0];
                else if (input == "Q" || input == "q")
                    return input[0];
                
                    Console.WriteLine("Please Choose A Valid Option");
            } while (true);
        }

        static void ListProducts()
        {
            if (_name != null && _name != "")
            {
                // Display a product
                Console.WriteLine(_name);
                Console.WriteLine(_price);
                Console.WriteLine(_description);
            } else
                Console.WriteLine("No Products");
        }

        // Data for a Product
        static string _name;
        static decimal _price;
        static string _description;

        static void PlayingWithPrimitives ()
        {
            //Primitive
            decimal unitPrice = 10.5M;

            // Real declaration
            //System.Decimal unitPrice2 = 10.5M;
            Decimal unitPrice2 = 10.5M;

            //Current Time
            System.DateTime now = DateTime.Now;

            System.Collections.ArrayList items;
        }
        static void PlayingWithVariables ()
        {
            // single decls
            int hours = 0;
            double rate = 10.25;

            int hours2 = hours;
            //multiple decls
            string firstName, lastName;

            // string @class;

            // Single assignement
            firstName = "Bob";
            lastName = "Miller";

            // Multiple Assingment
            firstName = lastName = "Sue";

            // Math Ops
            int x = 0, y = 20;
            int add = x + y;
            int sunbtract = x - y;
            int multiply = x * y;
            int divide = x / y;
            int modulus = x % y;

            // x = x + 10;
            x += 10;
            double ceiling = Math.Ceiling(rate);
            double floor = ceiling;


        }
    }
}

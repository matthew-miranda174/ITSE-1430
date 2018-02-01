﻿/*Matthew Miranda
 * ITSE 1430 - Spring 2018
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
                //Equality
                bool IsEqual = quit.Equals(10);

                //Display menu
                char choice = DisplayMenu();
                //Process mennu selection
                switch (Char.ToUpper(choice))
                {
                    //case 'l':
                    case 'L': ListProducts(); break;
                    //case 'a':
                    case 'A': AddProduct(); break;
                    //case 'q':
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
        //ReadDecimal
        private static decimal ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();
                 
                //If (Decimal.Try.Parse(value, out decimal result) && result >=
                // return result;

                if (Decimal.TryParse(value, out decimal result))
                {
                    //If not required or not empty
                    if (result >= minValue)
                        return result;
                };

                //Formatting Strings
                //Console.WriteLine("Value must be >= {0}" + minValue);
                string msg = String.Format("Value must be >= {0}" + minValue);
                Console.WriteLine(msg);
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

                //Remove White SPace
                input = input.Trim();
                //input.ToLower();
                input = input.ToUpper();

                //Padding
                //input = input.PadLeft(10);

                //Starts With
                //input.StartWith(@"\");


                //Substring
                //string newValue = input.Substring(0, 10);

               // if (input == "L")

                if(String.Compare(input, "L", true) == 0)
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "Q")
                    return input[0];
                
                    Console.WriteLine("Please Choose A Valid Option");
            } while (true);
        }

        //List Product
        static void ListProducts()
        {
            //if (_name != null && _name != "")
            if(!String.IsNullOrEmpty(_name))
            {
                // Display a product - name[$price]
                //                      <description

                //String Formatting
                //var msg = String.Format("(0) [$(1)]", _name, _price);


                //String Contatenation
                //var msg = _name + " [$" + _price + "]";

                //string concat part 2
                //var msg = String.Concat(_name, "[$", _price, "]");

                //String Interolation
                string msg = $"{_name} [$(_price)]";
                Console.WriteLine(msg);
                            
                //Console.WriteLine(_name);
                //Console.WriteLine(_price);

                if (!String.IsNullOrEmpty(_description))
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

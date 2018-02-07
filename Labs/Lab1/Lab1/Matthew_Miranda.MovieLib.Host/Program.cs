/* Matthew Miranda
 * ITSE 1430 - Spring 2018
 * Section 1
 * Lab - 1
 * Due February 5
 */


using System;

namespace Matthew_Miranda.MovieLib.Host
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
                    case 'L':
                    ListMovies();
                    break;
                    //case 'a':
                    case 'A':
                    AddMovies();
                    break;
                    //case 'R'
                    case 'R':
                    _name = null;
                    break;
                    //case 'q':
                    case 'Q':
                    quit = true;
                    break;
                };
            };

        }
        static void AddMovies()
        {
            //Get name
            _name = ReadString("Enter Name of Movie: ", true);
            //Get price
            _time = ReadDecimal("Enter Length of Movie: ", 0);
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
                Console.WriteLine("L)ist Movie");
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("R)emove Movie");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                //Remove White SPace
                input = input.Trim();
                //Converts User Input to Upper Case
                input = input.ToUpper();

                if (String.Compare(input, "L", true) == 0)
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "R")
                    return input[0];
                else if (input == "Q")
                    return input[0];

                Console.WriteLine("Please Choose A Valid Option");
            } while (true);
        }

        //List Product
        static void ListMovies()
        {
            //if (_name != null && _name != "")
            if (!String.IsNullOrEmpty(_name))
            {


                Console.WriteLine(_name);
                Console.WriteLine(_time);

                if (!String.IsNullOrEmpty(_description))
                    Console.WriteLine(_description);
            } else
                Console.WriteLine("No Movies");
        }

        // Data for a Movie
        static string _name;
        static decimal _time;
        static string _description;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized

namespace Nile.host
{
    class Program
    {
        static void Main( string[] args )
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary> Provides information about a product.</summary>
    public class Product
    {
        internal decimal discountPercentage = 0.10M;

        
      
/// <summary>Get the product name.
/// <returns>The name.</returns>
        public string GetName ()
        {
            return _name ?? "";
        }

        /// <summary>
        /// Sets the product Name.</summary>
        /// <param name="value">The name.</param>
        public void SetName (string value)
        {
            _name = value ?? "";
        }

        /// <summary>
        /// Validates the product
        /// </summary>
        /// <returns>Error Message, if any</returns>
        public string Validate()
        {
            // Name is required
            if (String.IsNullOrEmpty(_name))
                return "Name Cannot be empty";

            // Price >= 0
            if (_price < 0)
                return "price must be >= 0";

            return "";
        }



        /// <summary>
        /// Not local variables, they are fields. Outside of the function it is a field.
        /// Fields are always Private. Generally camel case.
        /// </summary>
        private string _name = "";
        private string _description;
        private decimal _price;
        private bool _isDiscontinued;
    }
}

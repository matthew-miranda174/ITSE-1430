using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class ProductDetailForm : Form
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        public Product Product { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            // Create Product
            var product = new Product();
            product.Name = _TextName.Text;
            product.Description = _TextDescription.Text;
            product.Price = ConvertToPrice(_TextPrice);
            product.IsDiscontinued = _checkIsDiscontinued.Checked;

            //retutrn from form
            Product = product;


            DialogResult = DialogResult.OK;
            //DialogResult = DialogResult.None;

            Close();
        }

        private void OnCancle( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private decimal ConvertToPrice (TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }
    }
}

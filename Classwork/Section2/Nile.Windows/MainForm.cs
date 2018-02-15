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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
        

            var product = new Product();

            Decimal.TryParse("123", out decimal _price);

            var name = product.Name;
            //var name = product.GetName();
            product.Name = "Product A";
            product.Price = 50;
            product.IsDiscontinued = true;

            //product.ActualPrice = 10;
            var price2 = product.ActualPrice;

            //product.SetName("Product A");
            //product.Description = "Name";
            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();
            //productB.Name = "Product B";
            //productB.SetName("Product B");
            //productB.Description = product.Description;
            error = productB.Validate();
        }

        private void menuStrip1_ItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var form = new ProductDetailForm();
            form.Text = "Add Product";

            // Show Form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            _product = form.Product;
        }

        private void OnProductRemove( object sender, EventArgs e )
        {
            if (MessageBox.Show(this, "Are you sure?", "Remove Product"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Remove Product
            MessageBox.Show("Not Implemented");
        }

        private void miProductEdit_Click( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not implemented", "Product Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void miFileExit_Click( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not implemented", "File Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not implemented", "About Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private bool ShowConformation (string message, string title)
        {
            return MessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }


        private Product _product;
    }
}

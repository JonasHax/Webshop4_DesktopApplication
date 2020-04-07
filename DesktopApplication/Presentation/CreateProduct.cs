using DesktopApplication.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApplication
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal price = decimal.Parse(txtPrice.Text);
            bool inputIsOk = !(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description));  //der skal laves et check på at decimal ikke er tom!  

            if (inputIsOk)
            {
                ProductController pc = new ProductController();
                pc.CreateProduct(name, description, price);
                //bool wasOk =(dbId > 0);
                //if (wasOk)
                //{
                    lblSuccess.Text = $"Produktet er oprettet!";
                //}
                //else
                //{
                //    lblError.Text = $"Der opstod en fejl!";
                //}

            }
            else {
                lblError.Text = $"Forkert data indtastet";
            }


        }

    }
}

using DesktopApplication.Controller;
using DesktopApplication.Model;
using DesktopApplication.ProductService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopApplication.Model.CompanyEnum;

namespace DesktopApplication {

    public partial class CreateProduct : Form {

        public CreateProduct() {
            InitializeComponent();
            ProductController pc = new ProductController();
            List<string> colors = pc.GetAllColors();
            foreach (string color in colors) {
                comboBox_Color.Items.Add(color);
            }

            List<string> sizes = pc.GetAllSizes();
            foreach (string size in sizes) {
                comboBox_Size.Items.Add(size);
            }

            List<string> categories = pc.GetAllCategories();
            foreach (string category in categories) {
                comboBox_Category.Items.Add(category);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal price = decimal.Parse(txtPrice.Text);  // skal måske være en string og parses til decimal senere??

            Product newProduct = new Product() {
                Name = name,
                Description = description,
                Price = price,
                State = true
            };

            ProductController pc = new ProductController();
            bool result = pc.InsertProduct(newProduct);

            if (result) {
                lblSuccess.Text = "Success";
            } else {
                lblError.Text = "FEJL";
            }
        }

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            int id;

            try {
                int.TryParse(txtSearchProd.Text, out id);
                ProductController pc = new ProductController();
                CompanyProduct product = pc.GetProductById(id);
                lblName.Text = product.Name;
                lblDescription.Text = product.Description;
                lblPrice.Text = product.Price.ToString();
            } catch (Exception) {
                lblError.Text = "Indtast et varenummer";
            }
        }
    }
}
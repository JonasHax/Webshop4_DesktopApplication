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
        private readonly ProductController pc = new ProductController();

        public CreateProduct() {
            InitializeComponent();
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

            // populate productlist
            List<CompanyProduct> productList = pc.GetAllProducts();
            gridViewProduct.DataSource = productList;
            //foreach (CompanyProduct companyProduct in productList) {
            //    //gridViewProduct.Rows.Add(companyProduct);
            //    listBoxProduct.Items.Add(companyProduct);
            //}
        }

        //private void btnSearch_Click(object sender, EventArgs e) {
        //    int id;

        //    try {
        //        int.TryParse(txtSearchProd.Text, out id);
        //        ProductController pc = new ProductController();
        //        CompanyProduct product = pc.GetProductById(id);
        //        if (product != null) {
        //            txtName.Text = product.Name;
        //            txtDescription.Text = product.Description;
        //            txtPrice.Text = product.Price.ToString();
        //        } else {
        //            //lblError.Text = "Produktet findes ikke";
        //        }
        //    } catch (Exception) {
        //        //lblError.Text = "Indtast et varenummer";
        //    }
        //}

        private void gridViewProduct_SelectionChanged(object sender, EventArgs e) {
            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

            // get the productversions on the selected product
            List<CompanyProductVersion> listOfProdVer = selectedProduct.ProductVersions;

            // populate productversion list - clear it first
            //gridViewProdVer.Rows.Clear();
            gridViewProdVer.DataSource = listOfProdVer;
        }

        private void UpdateProductList() {
            List<CompanyProduct> productList = pc.GetAllProducts();
            gridViewProduct.DataSource = productList;
        }

        private void UpdateProductVersionList() {
            UpdateProductList();
            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

            // get the productversions on the selected product
            List<CompanyProductVersion> listOfProdVer = selectedProduct.ProductVersions;

            // populate productversion list - clear it first
            //gridViewProdVer.Rows.Clear();
            gridViewProdVer.DataSource = listOfProdVer;
        }

        private void btnCreateProdVer_Click_1(object sender, EventArgs e) {
            lblInserProductVersion.Text = "";

            string size = comboBox_Size.SelectedItem.ToString();
            string color = comboBox_Color.SelectedItem.ToString();
            int stock = int.Parse(txtStock.Text);

            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;
            //Console.WriteLine(stock + size + color);
            //Console.WriteLine(selectedProduct.StyleNumber);

            CompanyProductVersion newProdVer = new CompanyProductVersion() {
                ColorCode = color,
                SizeCode = size,
                Stock = stock,
                Product = selectedProduct
            };

            bool result = pc.InsertProductVersion(newProdVer, selectedProduct.StyleNumber);
            if (result) {
                UpdateProductVersionList();
                lblInserProductVersion.Text = "Underprodukt indsat!";
            } else {
                lblInserProductVersion.Text = "Fejl med oprettelse";
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e) {
            lblInsertProduct.Text = "";

            //string category = "";
            //if (comboBox_Category.SelectedIndex > -1)
            //{
            //    category = comboBox_Category.SelectedItem.ToString();
            //}
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal price = -1;
            try
            {
                price = decimal.Parse(txtPrice.Text);

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
                {
                    CompanyProduct newProduct = new CompanyProduct()
                    {
                        Name = name,
                        Description = description,
                        Price = price,
                        State = true
                    };

                    ProductController pc = new ProductController();
                    bool result = pc.InsertProduct(newProduct);

                    if (result)
                    {
                        UpdateProductList();
                        lblInsertProduct.Text = "Produkt oprettet";
                    }
                    else
                    {
                        lblInsertProduct.Text = "Fejl under oprettelse";
                    }
                }
                else
                {
                    lblInsertProduct.Text = "Udfyld alle felter";
                }
            }
            catch (Exception)
            {
                lblInsertProduct.Text = "Prisen skal være et tal";
            }
        }

        private void btnAddCategoryToProduct_Click(object sender, EventArgs e)
        {
            lblInsertProduct.Text = "";

            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;
            int styleNumber = selectedProduct.StyleNumber;
            string category = "";

            if (comboBox_Category.SelectedIndex > -1)
            {
                category = comboBox_Category.SelectedItem.ToString();
            }

            if (!string.IsNullOrEmpty(category))
            {
                if(pc.InsertProductCategoryRelation(styleNumber, category))
                {
                    lblInsertProduct.Text = "Kategori er tilføjet produkt";
                } else
                {
                    lblInsertProduct.Text = "Kategori er allerede på produkt";
                }
            }
        }
    }
}
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

            // set selection mode on gridviews:
            gridViewProduct.MultiSelect = false;
            //gridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewProdVer.MultiSelect = false;
        }

        private void gridViewProduct_SelectionChanged(object sender, EventArgs e) {
            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

            // get the productversions on the selected product
            List<CompanyProductVersion> listOfProdVer = selectedProduct.ProductVersions;

            // populate productversion list - clear it first
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

            // populate productversion list
            gridViewProdVer.DataSource = listOfProdVer;
        }

        private void btnCreateProdVer_Click_1(object sender, EventArgs e) {
            lblInserProductVersion.Text = "";

            string size = comboBox_Size.SelectedItem.ToString();
            string color = comboBox_Color.SelectedItem.ToString();
            int stock = int.Parse(txtStock.Text);

            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

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

            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal price = -1;
            try {
                price = decimal.Parse(txtPrice.Text);

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description)) {
                    CompanyProduct newProduct = new CompanyProduct() {
                        Name = name,
                        Description = description,
                        Price = price,
                        State = true
                    };

                    ProductController pc = new ProductController();
                    bool result = pc.InsertProduct(newProduct);

                    if (result) {
                        UpdateProductList();
                        lblInsertProduct.Text = "Produkt oprettet";
                    } else {
                        lblInsertProduct.Text = "Fejl under oprettelse";
                    }
                } else {
                    lblInsertProduct.Text = "Udfyld alle felter";
                }
            } catch (Exception) {
                lblInsertProduct.Text = "Prisen skal være et tal";
            }
        }

        private void btnAddCategoryToProduct_Click(object sender, EventArgs e) {
            lblInsertProduct.Text = "";

            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;
            int styleNumber = selectedProduct.StyleNumber;
            string category = "";

            if (comboBox_Category.SelectedIndex > -1) {
                category = comboBox_Category.SelectedItem.ToString();
            }

            if (!string.IsNullOrEmpty(category)) {
                if (pc.InsertProductCategoryRelation(styleNumber, category)) {
                    lblInsertProduct.Text = "Kategori er tilføjet produkt";
                } else {
                    lblInsertProduct.Text = "Kategori er allerede på produkt";
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) {
            bool result = false;
            // Get the selected product
            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

            if (selectedProduct != null) {
                result = pc.DeleteProduct(selectedProduct.StyleNumber);
            }

            if (result) {
                lblInsertProduct.Text = "Product fjernet";
                UpdateProductList();
            } else {
                lblInsertProduct.Text = "Fejl under sletning";
            }
        }

        private void btnClear2_Click(object sender, EventArgs e) {
            txtStock.Text = "";
            comboBox_Size.SelectedIndex = -1;
            comboBox_Color.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            comboBox_Category.SelectedIndex = -1;
            txtDescription.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void btnDeleteProdVer_Click(object sender, EventArgs e) {
            bool result = false;

            CompanyProductVersion selectedProdVer = (CompanyProductVersion)gridViewProdVer.CurrentRow.DataBoundItem;

            if (selectedProdVer != null) {
                try {
                    result = pc.DeleteProductVersion(selectedProdVer.Product.StyleNumber, selectedProdVer.SizeCode, selectedProdVer.ColorCode);
                } catch (Exception ex) {
                    lblInserProductVersion.Text = ex.Message;
                }
            }

            if (result) {
                lblInserProductVersion.Text = "Underprodukt fjernet";
                UpdateProductVersionList();
            } else {
                lblInserProductVersion.Text = "Fejl ved sletning";
            }
        }

        private void gridViewProdVer_CellClick(object sender, DataGridViewCellEventArgs e) {
            lblInserProductVersion.Text = "";
            lblInsertProduct.Text = "";

            CompanyProductVersion selectedProdVer = (CompanyProductVersion)gridViewProdVer.CurrentRow.DataBoundItem;

            txtStock.Text = selectedProdVer.Stock.ToString();
            comboBox_Size.SelectedItem = selectedProdVer.SizeCode;
            comboBox_Color.SelectedItem = selectedProdVer.ColorCode;
        }

        private void gridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e) {
            lblInsertProduct.Text = "";
            lblInserProductVersion.Text = "";

            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

            txtName.Text = selectedProduct.Name;
            txtDescription.Text = selectedProduct.Description;
            txtPrice.Text = selectedProduct.Price.ToString();
            checkBox_ProductState.Checked = selectedProduct.State;

            btnClear2_Click(this, new EventArgs());
        }

        private void btnUpdateProdVer_Click(object sender, EventArgs e) {
            bool result = false;

            CompanyProductVersion selectedProdVer = (CompanyProductVersion)gridViewProdVer.CurrentRow.DataBoundItem;
            int newStock = -1;

            try {
                newStock = int.Parse(txtStock.Text);

                if (selectedProdVer != null && newStock >= 0) {
                    result = pc.UpdateProductVersion(selectedProdVer.Product.StyleNumber, selectedProdVer.SizeCode, selectedProdVer.ColorCode, newStock);
                }

                if (result) {
                    lblInserProductVersion.Text = "Underprodukt opdateret!";
                    UpdateProductVersionList();
                } else {
                    lblInserProductVersion.Text = "Fejl under opdatering";
                }
            } catch (System.FormatException) {
                lblInserProductVersion.Text = "Stock skal være et tal";
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e) {
            bool result = false;
            CompanyProduct selectedProduct = (CompanyProduct)gridViewProduct.CurrentRow.DataBoundItem;

            try {
                string name = txtName.Text;
                string desc = txtDescription.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                bool state = checkBox_ProductState.Checked;

                CompanyProduct product = new CompanyProduct() {
                    Name = name,
                    Description = desc,
                    Price = price,
                    State = state,
                    StyleNumber = selectedProduct.StyleNumber
                };

                result = pc.UpdateProduct(product);

                if (result) {
                    lblInsertProduct.Text = "Produkt opdateret";
                    UpdateProductList();
                } else {
                    lblInsertProduct.Text = "Fejl ved opdatering";
                }
            } catch (FormatException) {
                lblInsertProduct.Text = "Pris skal være et tal";
            }
        }
    }
}
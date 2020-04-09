using DesktopApplication.Controller;
using DesktopApplication.Model;
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

namespace DesktopApplication
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
            comboBox_Size.DataSource = Enum.GetValues(typeof(ClothesSize));
            comboBox_Color.DataSource = Enum.GetValues(typeof(ClothColors));
            comboBox_Category.DataSource = Enum.GetValues(typeof(ShopCategory));
        }

        private void label2_Click(object sender, EventArgs e)   // Kan ikke finde ud af at slette den :)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            decimal price = decimal.Parse(txtPrice.Text);  // skal måske være en string og parses til decimal senere??
            CompanyEnum.ClothesSize rawSize = (CompanyEnum.ClothesSize)comboBox_Size.SelectedItem;
            CompanyEnum.ClothColors rawColor = (CompanyEnum.ClothColors)comboBox_Color.SelectedItem;
            CompanyEnum.ShopCategory rawCat = (CompanyEnum.ShopCategory)comboBox_Category.SelectedItem;

            bool inputIsOk = !((string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description) && rawSize != CompanyEnum.ClothesSize.size
                && rawColor != CompanyEnum.ClothColors.Color && rawCat != CompanyEnum.ShopCategory.Category));  // Der skal kontrolleres at pris er indtastet. Decimal
            
            if (inputIsOk)
            {
                ProductController prodCtrl = new ProductController();
                prodCtrl.CreateProduct(name, description, price);
                lblSuccess.Text = "Product created";
            }
            else
            {
                lblError.Text = $"Input valid values!";
            }
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

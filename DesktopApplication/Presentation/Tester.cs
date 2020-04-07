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

namespace DesktopApplication {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //ProductServiceClient proxy = new ProductServiceClient();
            //ProductService.Product product = proxy.GetProduct(3);

            ProductController pc = new ProductController();
            //CompanyProduct product = pc.GetProductById(3);
            //DesktopApplication.ProductService.Product prod = pc.GetProductById(3);
            CompanyProduct prod = pc.GetProductById(3);

            //listBox1.Items.Add($"Name: {prod.Name}, price: {prod.Price}");

            listBox1.Items.Add(prod);
            foreach (var item in prod.ProductVersions) {
                listBox1.Items.Add(item);
            }
        }
    }
}
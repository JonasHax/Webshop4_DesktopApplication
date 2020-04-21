using System;
using System.Collections.Generic;
using DesktopApplication.Controller;
using DesktopApplication.Model;
using DesktopApplication.ProductService;
using DesktopApplication.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test {

    [TestClass]
    public class TestProductServiceConnection {
        ProductController controller = new ProductController();

        [TestMethod]
        public void TestGetAllProducts() {
            List<CompanyProduct> products = controller.GetAllProducts();
            Assert.IsTrue(products.Count > 0);
        }

        [TestMethod]
        public void TestGetProductById() {
            CompanyProduct product = controller.GetProductById(1);

            Assert.IsNotNull(product.Name);
            Assert.IsNotNull(product.Description);
            Assert.IsNotNull(product.StyleNumber);
            Assert.IsNotNull(product.ProductVersions);
            Assert.IsNotNull(product.Price);
        }

        [TestMethod]
        public void TestGetAllSizes() {
            List<string> sizes = controller.GetAllSizes();
            Assert.IsTrue(sizes.Count > 0);
        }

        [TestMethod]
        public void TestGetAllCategories() {
            List<string> categories = controller.GetAllCategories();
            Assert.IsTrue(categories.Count > 0);
        }

        [TestMethod]
        public void TestGetAllColors() {
            List<string> colors = controller.GetAllColors();
            Assert.IsTrue(colors.Count > 0);
        }



    }
}

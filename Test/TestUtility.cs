using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesktopApplication.Utility;
using DesktopApplication.ProductService;
using DesktopApplication.Model;

namespace Test {

    [TestClass]
    public class TestUtility {
        ConvertDataModel converter = new ConvertDataModel();

        [TestMethod]
        public void TestConvertFromServiceProduct() {
            // Create service product
            List<ProductVersion> list = new List<ProductVersion>();
            Product product = new Product() {
                Name = "Test",
                Description = "Test",
                Price = 0,
                State = true,
                StyleNumber = 999,
                ProductVersions = list.ToArray()
            };

            // Convert
            CompanyProduct compProd = converter.ConvertFromServiceProduct(product);

            // Assert
            Assert.IsInstanceOfType(product, typeof(Product));
            // assert converted product
            Assert.IsInstanceOfType(compProd, typeof(CompanyProduct));
            Assert.IsNotNull(compProd.Name);
            Assert.IsNotNull(compProd.Description);
            Assert.IsNotNull(compProd.Price);
            Assert.IsNotNull(compProd.ProductVersions);
            Assert.IsNotNull(compProd.StyleNumber);
        }

        [TestMethod]
        public void TestConvertFromCompanyProduct() {
            CompanyProduct product = new CompanyProduct() {
                Name = "Test",
                Description = "Test",
                Price = 0,
                State = true,
                StyleNumber = 999,
            };

            Assert.IsInstanceOfType(product, typeof(CompanyProduct));

            // convert
            Product convertedProduct = converter.ConvertToServiceProduct(product);

            // assert
            Assert.IsInstanceOfType(convertedProduct, typeof(Product));
        }
    }
}

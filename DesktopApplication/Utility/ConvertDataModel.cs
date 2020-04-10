using DesktopApplication.Model;
using DesktopApplication.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Utility {

    public class ConvertDataModel : IModelConvert {

        public ConvertDataModel() {
        }

        public CompanyProduct ConvertFromServiceProduct(ProductService.Product productToConvert) {
            CompanyProduct convertedProduct = null;
            if (productToConvert != null) {
                convertedProduct = new CompanyProduct() {
                    Name = productToConvert.Name,
                    Description = productToConvert.Description,
                    Price = productToConvert.Price,
                    State = productToConvert.State,
                    StyleNumber = productToConvert.StyleNumber
                };
                foreach (var prodVer in productToConvert.ProductVersions) {
                    CompanyProductVersion convertedProdVer = new CompanyProductVersion() {
                        ColorCode = prodVer.ColorCode,
                        SizeCode = prodVer.SizeCode,
                        Stock = prodVer.Stock,
                        Product = convertedProduct
                    };
                    convertedProduct.ProductVersions.Add(convertedProdVer);
                }
            }
            return convertedProduct;
        }

        public List<CompanyProduct> ConvertListFromServiceProduct(List<Product> productsToConvert) {
            List<CompanyProduct> convertedList = new List<CompanyProduct>();

            foreach (Product product in productsToConvert) {
                CompanyProduct convertedProduct = ConvertFromServiceProduct(product);
                convertedList.Add(convertedProduct);
            }

            return convertedList;
        }

        public Product ConvertToServiceProduct(CompanyProduct product) {
            Product foundProduct = null;
            if (product != null) {
                foundProduct = new Product {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    State = product.State
                };
            }
            return foundProduct;
        }

        public ProductVersion ConvertToServiceProductVersion(CompanyProductVersion prodVerToConvert) {
            Product prod = ConvertToServiceProduct(prodVerToConvert.Product);
            ProductVersion prodVer = new ProductVersion() {
                Stock = prodVerToConvert.Stock,
                ColorCode = prodVerToConvert.ColorCode,
                SizeCode = prodVerToConvert.SizeCode,
            };
            prodVer.Product = prod;

            return prodVer;
        }
    }
}
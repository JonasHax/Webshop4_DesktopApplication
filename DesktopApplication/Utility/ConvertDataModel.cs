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

        // Metode der konvertere produktet fra servicen til et produkt som kan anvendes i klienten.
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

        // Konvertere listen af produkter så det kan anvendes i desktop klienten.
        public List<CompanyProduct> ConvertListFromServiceProduct(List<Product> productsToConvert) {
            List<CompanyProduct> convertedList = new List<CompanyProduct>();

            foreach (Product product in productsToConvert) {
                CompanyProduct convertedProduct = ConvertFromServiceProduct(product);
                convertedList.Add(convertedProduct);
            }

            return convertedList;
        }

        // Konvertere det enkelte produkt fra service til at kunne blive anvendt i klienten.
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

            if (product.StyleNumber != 0) {
                foundProduct.StyleNumber = product.StyleNumber;
            }

            return foundProduct;
        }

        // Konvertere underprodukter fra servicen så den kan bruges i klienten.
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
using DesktopApplication.Model;
using DesktopApplication.ProductService;
using DesktopApplication.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public class ServiceProduct : IUseProductService {

        public ServiceProduct() {
        }

        public List<string> GetAllCategories() {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.GetAllCategories().ToList();
        }

        public List<string> GetAllColors() {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.GetAllColors().ToList();
        }

        public List<string> GetAllSizes() {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.GetAllSizes().ToList();
        }

        public CompanyProduct GetProductById(int id) {
            ProductServiceClient proxy = new ProductServiceClient();
            ConvertDataModel converter = new ConvertDataModel();
            CompanyProduct product = converter.ConvertFromServiceProduct(proxy.GetProduct(id));

            return product;
        }

        public bool InsertProduct(CompanyProduct productToInsert) {
            ProductServiceClient proxy = new ProductServiceClient();

            ConvertDataModel converter = new ConvertDataModel();
            Product convertedProd = converter.ConvertToServiceProduct(productToInsert);

            return proxy.InsertProduct(convertedProd);
        }

        public List<CompanyProduct> GetAllProducts() {
            List<CompanyProduct> productList;

            ProductServiceClient proxy = new ProductServiceClient();
            ConvertDataModel converter = new ConvertDataModel();
            productList = converter.ConvertListFromServiceProduct(proxy.GetAllProducts().ToList());
            //productList = converter.

            return productList;
        }

        public bool InsertProductVersion(CompanyProductVersion prodVerToInsert, int styleNumber) {
            ProductServiceClient proxy = new ProductServiceClient();
            // Convert
            ConvertDataModel converter = new ConvertDataModel();
            ProductVersion convertedProdVer = converter.ConvertToServiceProductVersion(prodVerToInsert);

            return proxy.InsertProductVersion(convertedProdVer, styleNumber);
        }

        public bool InsertProductCategoryRelation(int styleNumber, string category) {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.InsertProductCategoryRelation(styleNumber, category);
        }

        public bool DeleteProduct(int styleNumber) {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.DeleteProduct(styleNumber);
        }

        public bool DeleteProductVersion(int styleNumber, string sizeCode, string colorCode) {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.DeleteProductVersion(styleNumber, sizeCode, colorCode);
        }

        public bool UpdateProductVersion(int styleNumber, string sizeCode, string colorCode, int newStock) {
            ProductServiceClient proxy = new ProductServiceClient();
            return proxy.UpdateProductVersion(styleNumber, sizeCode, colorCode, newStock);
        }

        public bool UpdateProduct(CompanyProduct productToUpdate) {
            ProductServiceClient proxy = new ProductServiceClient();

            // convert
            ConvertDataModel converter = new ConvertDataModel();
            Product product = converter.ConvertToServiceProduct(productToUpdate);

            return proxy.UpdateProduct(product);
        }
    }
}
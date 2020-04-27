using DesktopApplication.Model;
using DesktopApplication.Service;
using System.Collections.Generic;

namespace DesktopApplication.Controller {

    public class ProductController {

        public CompanyProduct GetProductById(int id) {
            ServiceProduct service = new ServiceProduct();
            return service.GetProductById(id);
        }

        public bool InsertProduct(CompanyProduct productToInsert) {
            ServiceProduct service = new ServiceProduct();
            return service.InsertProduct(productToInsert);
        }

        public bool InsertProductVersion(CompanyProductVersion prodVerToInsert, int styleNumber) {
            ServiceProduct service = new ServiceProduct();
            return service.InsertProductVersion(prodVerToInsert, styleNumber);
        }

        public List<string> GetAllColors() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllColors();
        }

        public List<string> GetAllSizes() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllSizes();
        }

        public List<string> GetAllCategories() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllCategories();
        }

        public List<CompanyProduct> GetAllProducts() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllProducts();
        }

        public bool InsertProductCategoryRelation(int styleNumber, string category) {
            ServiceProduct service = new ServiceProduct();
            return service.InsertProductCategoryRelation(styleNumber, category);
        }

        public bool DeleteProduct(int styleNumber) {
            ServiceProduct service = new ServiceProduct();
            return service.DeleteProduct(styleNumber);
        }

        public bool DeleteProductVersion(int styleNumber, string sizeCode, string colorCode) {
            ServiceProduct service = new ServiceProduct();
            return service.DeleteProductVersion(styleNumber, sizeCode, colorCode);
        }

        public bool UpdateProductVersion(int styleNumber, string sizeCode, string colorCode, int newStock) {
            ServiceProduct service = new ServiceProduct();
            return service.UpdateProductVersion(styleNumber, sizeCode, colorCode, newStock);
        }

        public bool UpdateProduct(CompanyProduct productToUpdate) {
            ServiceProduct service = new ServiceProduct();
            return service.UpdateProduct(productToUpdate);
        }
    }
}
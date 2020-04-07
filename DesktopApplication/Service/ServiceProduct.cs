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

        public CompanyProduct CreateProduct(Product prod)
        {
            ProductServiceClient proxy = new ProductServiceClient();
            ConvertDataModel converter = new ConvertDataModel();
            CompanyProduct product = converter.ConvertFromServiceProduct(proxy.CreateProduct(prod));

            return product;
        }

        public CompanyProduct GetProductById(int id) {
            ProductServiceClient proxy = new ProductServiceClient();
            ConvertDataModel converter = new ConvertDataModel();
            CompanyProduct product = converter.ConvertFromServiceProduct(proxy.GetProduct(id));

            return product;
        }
    }
}
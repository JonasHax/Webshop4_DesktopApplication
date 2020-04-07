using DesktopApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApplication.Service;
using DesktopApplication.ProductService;

namespace DesktopApplication.Controller {

    public class ProductController {

        public CompanyProduct GetProductById(int id) {
            ServiceProduct service = new ServiceProduct();
            return service.GetProductById(id);
        }

        public CompanyProduct CreateProduct(string name, string description, decimal price)
        {
            Product prod = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                State = true
               
            };

            ServiceProduct service = new ServiceProduct();
            return service.CreateProduct(prod);
        }
    }        
}
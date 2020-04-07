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
    }
}
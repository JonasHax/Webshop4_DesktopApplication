using DesktopApplication.Model;
using DesktopApplication.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public interface IUseProductService {
        //CompanyProduct GetProductById(int id);

        CompanyProduct GetProductById(int id);

        //CompanyProduct CreateProduct(Product prod);

        bool InsertProduct(CompanyProduct productToInsert);

        bool InsertProductVersion(CompanyProductVersion prodVerToInsert, int styleNumber);

        List<string> GetAllSizes();

        List<string> GetAllColors();

        List<string> GetAllCategories();
    }
}
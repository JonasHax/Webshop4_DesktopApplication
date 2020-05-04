using DesktopApplication.Model;
using DesktopApplication.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public interface IUseProductService {

        CompanyProduct GetProductById(int id);

        bool InsertProduct(CompanyProduct productToInsert);

        bool InsertProductVersion(CompanyProductVersion prodVerToInsert, int styleNumber);

        List<string> GetAllSizes();

        List<string> GetAllColors();

        List<string> GetAllCategories();

        bool InsertProductCategoryRelation(int styleNumber, string category);

        bool DeleteProduct(int styleNumber);

        bool DeleteProductVersion(int styleNumber, string sizeCode, string colorCode);

        bool UpdateProductVersion(int styleNumber, string sizeCode, string colorCode, int newStock);

        bool UpdateProduct(CompanyProduct productToUpdate);
    }
}
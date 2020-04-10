using DesktopApplication.Model;
using DesktopApplication.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Utility {

    public interface IModelConvert {

        CompanyProduct ConvertFromServiceProduct(ProductService.Product productToConvert);

        Product ConvertToServiceProduct(CompanyProduct product);

        List<CompanyProduct> ConvertListFromServiceProduct(List<Product> productsToConvert);

        ProductVersion ConvertToServiceProductVersion(CompanyProductVersion prodVerToConvert);
    }
}
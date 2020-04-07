using DesktopApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Utility {

    public interface IModelConvert {

        CompanyProduct ConvertFromServiceProduct(ProductService.Product productToConvert);
    }
}
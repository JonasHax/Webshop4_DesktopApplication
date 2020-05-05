using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public interface IUseOrderService {

        List<OrderService.Order> GetAllOrders();

        List<OrderService.SalesLineItem> GetSalesLineItemsFromOrderID(int id);
    }
}
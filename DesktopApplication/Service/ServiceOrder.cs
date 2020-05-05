using DesktopApplication.Controller;
using DesktopApplication.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public class ServiceOrder : IUseOrderService {

        public List<Order> GetAllOrders() {
            OrderServiceClient proxy = new OrderServiceClient();
            return proxy.GetAllOrders().ToList();
        }

        public List<SalesLineItem> GetSalesLineItemsFromOrderID(int id) {
            OrderServiceClient proxy = new OrderServiceClient();
            return proxy.GetSalesLineItemsFromOrderID(id).ToList();
        }
    }
}
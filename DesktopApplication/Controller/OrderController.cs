using DesktopApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Controller {

    public class OrderController {

        public List<OrderService.Order> GetAllOrders() {
            ServiceOrder service = new ServiceOrder();
            return service.GetAllOrders();
        }
    }
}
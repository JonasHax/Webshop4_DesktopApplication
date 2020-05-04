using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApplication.Service {

    public interface IUseOrderService {

        List<OrderService.Order> GetAllOrders();
    }
}
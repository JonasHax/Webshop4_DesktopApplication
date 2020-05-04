using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApplication.Controller;
using DesktopApplication.Presentation;

namespace DesktopApplication.Presentation {

    public partial class OrderGUI : Form {
        private readonly OrderController controller = new OrderController();

        public OrderGUI() {
            InitializeComponent();

            List<OrderService.Order> orders = controller.GetAllOrders();

            foreach (var item in orders) {
                listBox1.Items.Add(item);
            }
        }
    }
}
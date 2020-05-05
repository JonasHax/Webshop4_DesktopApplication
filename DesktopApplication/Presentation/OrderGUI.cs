using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            gridViewOrders.DataSource = orders;

            foreach (var item in orders) {
                listBoxSalesLineItems.Items.Add(item);
            }
        }

        private void gridViewOrders_SelectionChanged(object sender, EventArgs e) {
            listBoxSalesLineItems.Items.Clear();

            OrderService.Order selectedOrder = (OrderService.Order)gridViewOrders.CurrentRow.DataBoundItem;

            List<OrderService.SalesLineItem> salesLineItems = controller.GetSalesLineItemsFromOrderID(selectedOrder.OrderId);

            // smid på listen
            UpdateListBox(salesLineItems);
        }

        private void btnShowPaid_Click(object sender, EventArgs e) {
            List<OrderService.Order> orders = controller.GetAllOrders();
            List<OrderService.Order> paidOrders = new List<OrderService.Order>();
            foreach (OrderService.Order order in orders) {
                if (order.Status == true) {
                    paidOrders.Add(order);
                }
            }
            gridViewOrders.DataSource = paidOrders;
        }

        private void UpdateListBox(List<OrderService.SalesLineItem> list) {
            listBoxSalesLineItems.Items.Add("----- Salgslinjer: -----");
            listBoxSalesLineItems.Items.Add("");
            int totalAmount = 0;
            decimal totalPrice = 0;

            foreach (var item in list) {
                totalAmount += item.amount;
                totalPrice += item.Price;

                string fullString = item.amount + "x - " + item.Product.Name + ", størrelse: " + item.ProductVersion.SizeCode
                    + ", farve: " + item.ProductVersion.ColorCode + ", pris pr. styk: " + item.Product.Price + ", deltotal: " + item.Price;
                listBoxSalesLineItems.Items.Add(fullString);
            }

            listBoxSalesLineItems.Items.Add("");
            listBoxSalesLineItems.Items.Add("----- Antal varer: " + totalAmount);
            listBoxSalesLineItems.Items.Add("----- Total pris: " + totalPrice);
        }
    }
}
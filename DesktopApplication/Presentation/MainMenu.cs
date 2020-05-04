using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Presentation {

    public partial class MainMenu : Form {

        public MainMenu() {
            InitializeComponent();
        }

        private void btnProductGUI_Click(object sender, EventArgs e) {
            ProductGUI productGUI = new ProductGUI();
            productGUI.Show();
        }

        private void btnOrderGUI_Click(object sender, EventArgs e) {
            OrderGUI orderGUI = new OrderGUI();
            orderGUI.Show();
        }
    }
}
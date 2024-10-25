using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryWinFormsApp
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void SortForm_Load(object sender, EventArgs e)
        {
            var orders = OrderStorage.GetOrders();
            foreach (var order in orders)
            {
                ordersDataGridView.Rows.Add(order.Weight, order.District.Name, order.OrderDeliveryDate.ToString());
            }

        }
    }
}

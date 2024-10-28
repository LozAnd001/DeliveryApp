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
            var orders = OrderStorage.GetAll();
            foreach (var order in orders)
            {
                ordersDataGridView.Rows.Add(order.Weight, order.District.Name, order.OrderDeliveryDate.ToString());
            }

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            ordersDataGridView.Rows.Clear();
            var orders = OrderStorage.GetAll();
            var startTime = startDateTimePicker.Value;
            var finishTime = finishDateTimePicker.Value;
            var district = districtTextBox.Text;
            foreach (var order in orders)
            {
                if(startTime <= order.OrderDeliveryDate && order.OrderDeliveryDate <= finishTime && (district == order.District.Name || district == "Все"))
                    ordersDataGridView.Rows.Add(order.Weight, order.District.Name, order.OrderDeliveryDate.ToString());
            }
        }
    }
}

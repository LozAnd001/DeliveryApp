using DeliveryWinFormsApp.Models;
using Excel = Microsoft.Office.Interop.Excel;
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
            orders.Sort(delegate (OrderViewModel order1, OrderViewModel order2)
            {
                if (DateTime.Compare(order1.OrderDeliveryDate, order2.OrderDeliveryDate) > 0 || (DateTime.Compare(order1.OrderDeliveryDate, order2.OrderDeliveryDate) == 0 && string.Compare(order1.District.Name, order2.District.Name) > 0))
                {
                    return 1;
                }
                if (DateTime.Compare(order1.OrderDeliveryDate, order2.OrderDeliveryDate) == 0 && string.Compare(order1.District.Name, order2.District.Name) == 0)
                {
                    return 0;
                }
                return -1;
            }
            );
            foreach (var order in orders)
            {
                if (startTime.Day <= order.OrderDeliveryDate.Day && order.OrderDeliveryDate.Day <= finishTime.Day && (district == order.District.Name || district == "Все"))
                    ordersDataGridView.Rows.Add(order.Weight, order.District.Name, order.OrderDeliveryDate.ToString());
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            for(int i = 0; i <= ordersDataGridView.RowCount-2; ++i)
            {
                for(int j = 0; j <= ordersDataGridView.ColumnCount-1; ++j)
                {
                    wsh.Cells[i+1][j+1] = ordersDataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}

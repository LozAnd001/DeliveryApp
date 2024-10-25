using DeliveryWinFormsApp.Models;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(weightTextBox.Text, out int weight, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                var newOrder = new OrderViewModel
                {
                    Id = Guid.NewGuid(),
                    Weight = weight,
                    District = new DistrictViewModel(districtTextBox.Text),
                    OrderCreationDate = DateTime.Now,
                    OrderDeliveryDate = dateDeliveryOrderPicker.Value
                };
                OrderStorage.AddOrder(newOrder);
                Close();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }


}

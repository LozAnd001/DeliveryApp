namespace DeliveryWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAddedOrder = new AddForm();
            newAddedOrder.ShowDialog();
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listOrders = new SortForm();
            listOrders.ShowDialog();
        }
    }
}

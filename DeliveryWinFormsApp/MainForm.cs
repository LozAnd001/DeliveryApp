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
            var newOrder = new AddForm();
            newOrder.ShowDialog();
        }
    }
}

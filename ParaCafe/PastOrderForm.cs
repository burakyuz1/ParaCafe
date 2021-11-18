using ParaCafe.Data.Concrete;
using System.Windows.Forms;

namespace ParaCafe
{
    public partial class PastOrderForm : Form
    {
        private readonly CafeData db;

        public PastOrderForm(CafeData db)
        {
            InitializeComponent();
            this.db = db;
            dgvOrders.DataSource = db.PastOrders;
        }

        private void dgvOrders_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                dgvOrderDetails.DataSource = null;
                return;
            }
            Order order = (Order)dgvOrders.SelectedRows[0].DataBoundItem;
            dgvOrderDetails.DataSource = order.OrderDetail;
        }
    }
}

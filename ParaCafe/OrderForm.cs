using ParaCafe.Data.Concrete;
using ParaCafe.Data.Enums;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ParaCafe
{
    public partial class OrderForm : Form
    {
        public event EventHandler<TableMovedEventArgs> TableMoved;
        private readonly Order order;
        private readonly CafeData db;
        private readonly BindingList<OrderDetail> orderDetails;

        public OrderForm(Order order, CafeData cafeData)
        {
            this.order = order;
            db = cafeData;
            orderDetails = new BindingList<OrderDetail>(order.OrderDetail);
            orderDetails.ListChanged += OrderDetails_ListChanged;
            InitializeComponent();
            dgwOrderDetails.AutoGenerateColumns = false;
            dgwOrderDetails.DataSource = orderDetails;
            ShowProducts();
            RefreshTableNo();
            RefreshTotalPrice();
        }

        private void OrderDetails_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshTotalPrice();
        }

        private void RefreshTotalPrice()
        {
            lblTotalPrice.Text = order.TotalPrice;
        }

        private void RefreshTableNo()
        {
            this.Text = $"Masa {order.TableNo} (Açılış Zamani : {order.OpenTime})";
            lblTableNo.Text = order.TableNo.ToString("00");
            int[] busyTables = db.ActiveOrders.Select(x => x.TableNo).ToArray();
            cmbTableNo.DataSource = Enumerable
                .Range(1, db.TableQuantity)
                .Where(x => !busyTables.Contains(x))
                .ToList();
        }

        private void ShowProducts()
        {
            cmbProduct.DataSource = db.Products;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var orderDetail = new OrderDetail();
            Product product = (Product)cmbProduct.SelectedItem;
            orderDetail.ProductName = product.ProductName;
            orderDetail.UnitPrice = product.UnitPrice;
            orderDetail.ProductQuantity = (int)nmuProductQuantity.Value;

            orderDetails.Add(orderDetail);


        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            EndTheOrder(OrderStatus.Cancel, 0);
        }

        private void btnGetPay_Click(object sender, EventArgs e)
        {
            EndTheOrder(OrderStatus.Paid, order.GetTotalPrice());

        }

        private void EndTheOrder(OrderStatus status, decimal price)
        {
            order.CloseTime = DateTime.Now;
            order.Status = status;
            db.ActiveOrders.Remove(order);
            order.PaidPrice = price;
            db.PastOrders.Add(order);
            Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedIndex == -1) return;
            int oldTableNo = order.TableNo;
            int targetTableNo = (int)cmbTableNo.SelectedItem;
            order.TableNo = targetTableNo;
            RefreshTableNo();
            if (TableMoved != null)
                TableMoved(this, new TableMovedEventArgs(oldTableNo, targetTableNo));
        }
    }
}

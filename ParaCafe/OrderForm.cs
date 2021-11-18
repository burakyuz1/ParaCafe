using ParaCafe.Data.Concrete;
using ParaCafe.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaCafe
{
    public partial class OrderForm : Form
    {
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
            this.Text = $"Table {order.TableNo}";
            lblTableNo.Text = order.TableNo.ToString("00");
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
            EndTheOrder(OrderStatus.Iptal, 0);
        }

        private void btnGetPay_Click(object sender, EventArgs e)
        {
            EndTheOrder(OrderStatus.Odendi, order.GetTotalPrice());

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
    }
}

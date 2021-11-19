using Newtonsoft.Json;
using ParaCafe.Data.Concrete;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ParaCafe
{
    public partial class MainForm : Form
    {
        CafeData db = new CafeData();

        public MainForm()
        {
            InitializeComponent();
            ReadDatas();
            CreateTables();
        }

        private void InstallSampleProducts()
        {
            db.Products.Add(new Product() { ProductName = "Ayran", UnitPrice = 4.50m });
            db.Products.Add(new Product() { ProductName = "Kola", UnitPrice = 5.50m });
        }

        private void CreateTables()
        {
            for (int i = 1; i <= db.TableQuantity; i++)
            {
                ListViewItem lvi = new ListViewItem($"T - {i}");
                lvi.Tag = i;
                lvi.ImageKey = db.ActiveOrders.Any(x => x.TableNo == i) ? "dolu" : "bos";
                lstTables.Items.Add(lvi);
            }
        }

        private void lstTables_DoubleClick(object sender, System.EventArgs e)
        {
            ListViewItem lvi = lstTables.SelectedItems[0];
            int no = (int)lvi.Tag;
            Order order = db.ActiveOrders.FirstOrDefault(x => x.TableNo == no); //eğer masa aktif order'ın içinde varsa  onu oluşturduğum instance'ın içine aktar.
            if (order == null)
            { // eğer order boş ise, o masaya ait sipariş yok  demektir.
                order = new Order();
                order.TableNo = no;
                db.ActiveOrders.Add(order); // olan order'ı activeOrder'ın içine aktar.
                lvi.ImageKey = "dolu";//Renk değişimi.
            }
            OrderForm orderForm = new OrderForm(order, db);
            orderForm.TableMoved += OrderForm_TableMoved;
            orderForm.ShowDialog();


            if (order.Status != Data.Enums.OrderStatus.Active)
                lvi.ImageKey = "bos";
        }

        private void OrderForm_TableMoved(object sender, TableMovedEventArgs e)
        {
            foreach (ListViewItem listView in lstTables.Items)
            {
                if ((int)listView.Tag == e.OldTable) listView.ImageKey = "bos";
                if ((int)listView.Tag == e.NewTable) listView.ImageKey = "dolu";
            }
        }

        private void tsmiPastOrders_Click(object sender, EventArgs e)
        {
            new PastOrderForm(db).ShowDialog();
        }

        private void tsmiProducts_Click(object sender, EventArgs e)
        {
            new ProductsForm(db).ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDatas();
        }

        private void SaveDatas()
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }

        private void ReadDatas()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<CafeData>(json);
            }
            catch (Exception)
            {
                db = new CafeData();
                InstallSampleProducts();
            }
        }
    }
}

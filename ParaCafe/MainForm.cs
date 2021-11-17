using ParaCafe.Data.Concrete;
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
    public partial class MainForm : Form
    {
        CafeData db = new CafeData();

        public MainForm()
        {
            InitializeComponent();
            CreateTables();
        }

        private void CreateTables()
        {
            for (int i = 0; i <= db.TableQuantity; i++)
            {
                ListViewItem lvi = new ListViewItem($"T - {i}");
                lvi.ImageKey = "bos";
                lstTables.Items.Add(lvi);
            }
        }
    }
}

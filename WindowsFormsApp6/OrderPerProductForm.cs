using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class OrderPerProductForm : Form
    {
        public OrderPerProductForm()
        {
            InitializeComponent();
        }

        private void OrderPerProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "saleDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.saleDataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "saleDataSet.OrderPerProduct". При необходимости она может быть перемещена или удалена.
            this.orderPerProductTableAdapter.Fill(this.saleDataSet.OrderPerProduct);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.orderPerProductTableAdapter.FillBy(this.saleDataSet.OrderPerProduct, saleDataSet.product[listBox1.SelectedIndex].key_product);
        }
    }
}

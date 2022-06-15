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
    public partial class OrderPerClientForm : Form
    {
        public OrderPerClientForm()
        {
            InitializeComponent();
        }

        private void OrderPerClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "saleDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.saleDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "saleDataSet.OrderPerClient". При необходимости она может быть перемещена или удалена.
            this.orderPerClientTableAdapter.Fill(this.saleDataSet.OrderPerClient);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.orderPerClientTableAdapter.FillBy(this.saleDataSet.OrderPerClient, saleDataSet.client[comboBox1.SelectedIndex].key_client);
        }
    }
}

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
    public partial class OrderPerDateForm : Form
    {
        public OrderPerDateForm()
        {
            InitializeComponent();
        }

        private void OrderPerDateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "saleDataSet.OrderPerDate". При необходимости она может быть перемещена или удалена.
            this.orderPerDateTableAdapter.Fill(this.saleDataSet.OrderPerDate);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.orderPerDateTableAdapter.FillBy(this.saleDataSet.OrderPerDate, dateTimePicker1.Value.Date);
        }
    }
}

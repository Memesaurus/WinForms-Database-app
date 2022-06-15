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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
        }

        private void firmBtn_Click(object sender, EventArgs e)
        {
            FirmForm form = new FirmForm();
            form.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Show();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.Show();
        }

        private void orderPerClientBtn_Click(object sender, EventArgs e)
        {
            OrderPerClientForm form = new OrderPerClientForm();
            form.Show();
        }

        private void orderPerDateBtn_Click(object sender, EventArgs e)
        {
            OrderPerDateForm form = new OrderPerDateForm();
            form.Show();
        }

        private void orderPerProductBtn_Click(object sender, EventArgs e)
        {
            OrderPerProductForm form = new OrderPerProductForm();
            form.Show();
        }
    }
}

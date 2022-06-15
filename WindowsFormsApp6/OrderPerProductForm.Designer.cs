namespace WindowsFormsApp6
{
    partial class OrderPerProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataSet = new WindowsFormsApp6.SaleDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеФирмыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияЗаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказаноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проданоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderPerProductTableAdapter = new WindowsFormsApp6.SaleDataSetTableAdapters.OrderPerProductTableAdapter();
            this.productTableAdapter = new WindowsFormsApp6.SaleDataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPerProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.productBindingSource;
            this.listBox1.DisplayMember = "key_product";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 56);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "key_product";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.saleDataSet;
            // 
            // saleDataSet
            // 
            this.saleDataSet.DataSetName = "SaleDataSet";
            this.saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.наименованиеФирмыDataGridViewTextBoxColumn,
            this.фамилияЗаказчикаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.заказаноDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.проданоDataGridViewTextBoxColumn,
            this.keyproductDataGridViewTextBoxColumn,
            this.nameproductDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderPerProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // наименованиеФирмыDataGridViewTextBoxColumn
            // 
            this.наименованиеФирмыDataGridViewTextBoxColumn.DataPropertyName = "Наименование фирмы";
            this.наименованиеФирмыDataGridViewTextBoxColumn.HeaderText = "Наименование фирмы";
            this.наименованиеФирмыDataGridViewTextBoxColumn.Name = "наименованиеФирмыDataGridViewTextBoxColumn";
            // 
            // фамилияЗаказчикаDataGridViewTextBoxColumn
            // 
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия заказчика";
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.HeaderText = "Фамилия заказчика";
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.Name = "фамилияЗаказчикаDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // заказаноDataGridViewTextBoxColumn
            // 
            this.заказаноDataGridViewTextBoxColumn.DataPropertyName = "Заказано";
            this.заказаноDataGridViewTextBoxColumn.HeaderText = "Заказано";
            this.заказаноDataGridViewTextBoxColumn.Name = "заказаноDataGridViewTextBoxColumn";
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            // 
            // проданоDataGridViewTextBoxColumn
            // 
            this.проданоDataGridViewTextBoxColumn.DataPropertyName = "Продано";
            this.проданоDataGridViewTextBoxColumn.HeaderText = "Продано";
            this.проданоDataGridViewTextBoxColumn.Name = "проданоDataGridViewTextBoxColumn";
            // 
            // keyproductDataGridViewTextBoxColumn
            // 
            this.keyproductDataGridViewTextBoxColumn.DataPropertyName = "key_product";
            this.keyproductDataGridViewTextBoxColumn.HeaderText = "Идентификатор товара";
            this.keyproductDataGridViewTextBoxColumn.Name = "keyproductDataGridViewTextBoxColumn";
            this.keyproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameproductDataGridViewTextBoxColumn
            // 
            this.nameproductDataGridViewTextBoxColumn.DataPropertyName = "name_product";
            this.nameproductDataGridViewTextBoxColumn.HeaderText = "Название товара";
            this.nameproductDataGridViewTextBoxColumn.Name = "nameproductDataGridViewTextBoxColumn";
            // 
            // orderPerProductBindingSource
            // 
            this.orderPerProductBindingSource.DataMember = "OrderPerProduct";
            this.orderPerProductBindingSource.DataSource = this.saleDataSet;
            // 
            // orderPerProductTableAdapter
            // 
            this.orderPerProductTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // OrderPerProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 460);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "OrderPerProductForm";
            this.Text = "OrderPerProductForm";
            this.Load += new System.EventHandler(this.OrderPerProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPerProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SaleDataSet saleDataSet;
        private System.Windows.Forms.BindingSource orderPerProductBindingSource;
        private SaleDataSetTableAdapters.OrderPerProductTableAdapter orderPerProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеФирмыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияЗаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказаноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn проданоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SaleDataSetTableAdapters.productTableAdapter productTableAdapter;
    }
}
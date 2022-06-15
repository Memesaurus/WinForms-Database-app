namespace WindowsFormsApp6
{
    partial class OrderForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleDataSet = new WindowsFormsApp6.SaleDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new WindowsFormsApp6.SaleDataSetTableAdapters.orderTableAdapter();
            this.keyclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitysaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyclientDataGridViewTextBoxColumn,
            this.keyproductDataGridViewTextBoxColumn,
            this.dateorderDataGridViewTextBoxColumn,
            this.quantityorderDataGridViewTextBoxColumn,
            this.datesaleDataGridViewTextBoxColumn,
            this.quantitysaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // saleDataSet
            // 
            this.saleDataSet.DataSetName = "SaleDataSet";
            this.saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.saleDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // keyclientDataGridViewTextBoxColumn
            // 
            this.keyclientDataGridViewTextBoxColumn.DataPropertyName = "key_client";
            this.keyclientDataGridViewTextBoxColumn.HeaderText = "Идентификатор клиента";
            this.keyclientDataGridViewTextBoxColumn.Name = "keyclientDataGridViewTextBoxColumn";
            this.keyclientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyproductDataGridViewTextBoxColumn
            // 
            this.keyproductDataGridViewTextBoxColumn.DataPropertyName = "key_product";
            this.keyproductDataGridViewTextBoxColumn.HeaderText = "Идентификатор товара";
            this.keyproductDataGridViewTextBoxColumn.Name = "keyproductDataGridViewTextBoxColumn";
            this.keyproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateorderDataGridViewTextBoxColumn
            // 
            this.dateorderDataGridViewTextBoxColumn.DataPropertyName = "date_order";
            this.dateorderDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.dateorderDataGridViewTextBoxColumn.Name = "dateorderDataGridViewTextBoxColumn";
            // 
            // quantityorderDataGridViewTextBoxColumn
            // 
            this.quantityorderDataGridViewTextBoxColumn.DataPropertyName = "quantity_order";
            this.quantityorderDataGridViewTextBoxColumn.HeaderText = "Размер заказа";
            this.quantityorderDataGridViewTextBoxColumn.Name = "quantityorderDataGridViewTextBoxColumn";
            // 
            // datesaleDataGridViewTextBoxColumn
            // 
            this.datesaleDataGridViewTextBoxColumn.DataPropertyName = "date_sale";
            this.datesaleDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.datesaleDataGridViewTextBoxColumn.Name = "datesaleDataGridViewTextBoxColumn";
            // 
            // quantitysaleDataGridViewTextBoxColumn
            // 
            this.quantitysaleDataGridViewTextBoxColumn.DataPropertyName = "quantity_sale";
            this.quantitysaleDataGridViewTextBoxColumn.HeaderText = "Размер продажи";
            this.quantitysaleDataGridViewTextBoxColumn.Name = "quantitysaleDataGridViewTextBoxColumn";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 333);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SaleDataSet saleDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private SaleDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitysaleDataGridViewTextBoxColumn;
    }
}
namespace WindowsFormsApp6
{
    partial class OrderPerClientForm
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
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказаноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проданоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPerClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDataSet = new WindowsFormsApp6.SaleDataSet();
            this.orderPerClientTableAdapter = new WindowsFormsApp6.SaleDataSetTableAdapters.OrderPerClientTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp6.SaleDataSetTableAdapters.clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPerClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.наименованиеТовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.заказаноDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.проданоDataGridViewTextBoxColumn,
            this.keyclientDataGridViewTextBoxColumn,
            this.famDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderPerClientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1055, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "Код товара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            // 
            // наименованиеТовараDataGridViewTextBoxColumn
            // 
            this.наименованиеТовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.Name = "наименованиеТовараDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
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
            // keyclientDataGridViewTextBoxColumn
            // 
            this.keyclientDataGridViewTextBoxColumn.DataPropertyName = "key_client";
            this.keyclientDataGridViewTextBoxColumn.HeaderText = "Идентификатор клиента";
            this.keyclientDataGridViewTextBoxColumn.Name = "keyclientDataGridViewTextBoxColumn";
            // 
            // famDataGridViewTextBoxColumn
            // 
            this.famDataGridViewTextBoxColumn.DataPropertyName = "fam";
            this.famDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
            this.famDataGridViewTextBoxColumn.Name = "famDataGridViewTextBoxColumn";
            // 
            // orderPerClientBindingSource
            // 
            this.orderPerClientBindingSource.DataMember = "OrderPerClient";
            this.orderPerClientBindingSource.DataSource = this.saleDataSet;
            // 
            // saleDataSet
            // 
            this.saleDataSet.DataSetName = "SaleDataSet";
            this.saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderPerClientTableAdapter
            // 
            this.orderPerClientTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "key_client";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "key_client";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.saleDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // OrderPerClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 448);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderPerClientForm";
            this.Text = "OrderPerClientForm";
            this.Load += new System.EventHandler(this.OrderPerClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPerClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SaleDataSet saleDataSet;
        private System.Windows.Forms.BindingSource orderPerClientBindingSource;
        private SaleDataSetTableAdapters.OrderPerClientTableAdapter orderPerClientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказаноDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn проданоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private SaleDataSetTableAdapters.clientTableAdapter clientTableAdapter;
    }
}
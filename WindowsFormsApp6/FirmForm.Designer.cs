namespace WindowsFormsApp6
{
    partial class FirmForm
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
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmTableAdapter = new WindowsFormsApp6.SaleDataSetTableAdapters.firmTableAdapter();
            this.namefirmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directfirmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namefirmDataGridViewTextBoxColumn,
            this.directfirmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // saleDataSet
            // 
            this.saleDataSet.DataSetName = "SaleDataSet";
            this.saleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataMember = "firm";
            this.firmBindingSource.DataSource = this.saleDataSet;
            // 
            // firmTableAdapter
            // 
            this.firmTableAdapter.ClearBeforeFill = true;
            // 
            // namefirmDataGridViewTextBoxColumn
            // 
            this.namefirmDataGridViewTextBoxColumn.DataPropertyName = "name_firm";
            this.namefirmDataGridViewTextBoxColumn.HeaderText = "Название фирмы";
            this.namefirmDataGridViewTextBoxColumn.Name = "namefirmDataGridViewTextBoxColumn";
            this.namefirmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directfirmDataGridViewTextBoxColumn
            // 
            this.directfirmDataGridViewTextBoxColumn.DataPropertyName = "direct_firm";
            this.directfirmDataGridViewTextBoxColumn.HeaderText = "Директор";
            this.directfirmDataGridViewTextBoxColumn.Name = "directfirmDataGridViewTextBoxColumn";
            // 
            // FirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 358);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FirmForm";
            this.Text = "FirmForm";
            this.Load += new System.EventHandler(this.FirmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SaleDataSet saleDataSet;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private SaleDataSetTableAdapters.firmTableAdapter firmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefirmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directfirmDataGridViewTextBoxColumn;
    }
}
namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientBtn = new System.Windows.Forms.Button();
            this.orderPerClientBtn = new System.Windows.Forms.Button();
            this.firmBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.orderPerDateBtn = new System.Windows.Forms.Button();
            this.orderPerProductBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных: \"Продажи\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(201, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Представления";
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(29, 104);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(101, 50);
            this.clientBtn.TabIndex = 3;
            this.clientBtn.Text = "Клиенты";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // orderPerClientBtn
            // 
            this.orderPerClientBtn.Location = new System.Drawing.Point(219, 104);
            this.orderPerClientBtn.Name = "orderPerClientBtn";
            this.orderPerClientBtn.Size = new System.Drawing.Size(101, 50);
            this.orderPerClientBtn.TabIndex = 4;
            this.orderPerClientBtn.Text = "Заказы клиентов";
            this.orderPerClientBtn.UseVisualStyleBackColor = true;
            this.orderPerClientBtn.Click += new System.EventHandler(this.orderPerClientBtn_Click);
            // 
            // firmBtn
            // 
            this.firmBtn.Location = new System.Drawing.Point(29, 160);
            this.firmBtn.Name = "firmBtn";
            this.firmBtn.Size = new System.Drawing.Size(101, 50);
            this.firmBtn.TabIndex = 5;
            this.firmBtn.Text = "Фирмы";
            this.firmBtn.UseVisualStyleBackColor = true;
            this.firmBtn.Click += new System.EventHandler(this.firmBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(29, 216);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(101, 50);
            this.orderBtn.TabIndex = 6;
            this.orderBtn.Text = "Заказы";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Location = new System.Drawing.Point(29, 272);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(101, 50);
            this.productBtn.TabIndex = 7;
            this.productBtn.Text = "Товары";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // orderPerDateBtn
            // 
            this.orderPerDateBtn.Location = new System.Drawing.Point(219, 175);
            this.orderPerDateBtn.Name = "orderPerDateBtn";
            this.orderPerDateBtn.Size = new System.Drawing.Size(101, 50);
            this.orderPerDateBtn.TabIndex = 8;
            this.orderPerDateBtn.Text = "Заказы по датам";
            this.orderPerDateBtn.UseVisualStyleBackColor = true;
            this.orderPerDateBtn.Click += new System.EventHandler(this.orderPerDateBtn_Click);
            // 
            // orderPerProductBtn
            // 
            this.orderPerProductBtn.Location = new System.Drawing.Point(219, 247);
            this.orderPerProductBtn.Name = "orderPerProductBtn";
            this.orderPerProductBtn.Size = new System.Drawing.Size(101, 50);
            this.orderPerProductBtn.TabIndex = 9;
            this.orderPerProductBtn.Text = "Заказы товаров";
            this.orderPerProductBtn.UseVisualStyleBackColor = true;
            this.orderPerProductBtn.Click += new System.EventHandler(this.orderPerProductBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 336);
            this.Controls.Add(this.orderPerProductBtn);
            this.Controls.Add(this.orderPerDateBtn);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.firmBtn);
            this.Controls.Add(this.orderPerClientBtn);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button orderPerClientBtn;
        private System.Windows.Forms.Button firmBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button orderPerDateBtn;
        private System.Windows.Forms.Button orderPerProductBtn;
    }
}


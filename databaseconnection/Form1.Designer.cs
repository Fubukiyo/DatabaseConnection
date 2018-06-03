namespace databaseconnection
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.showAddress = new System.Windows.Forms.Button();
            this.showCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.showPCategory = new System.Windows.Forms.Button();
            this.showPDescription = new System.Windows.Forms.Button();
            this.showPModel = new System.Windows.Forms.Button();
            this.showPModelPDesc = new System.Windows.Forms.Button();
            this.showSalesOrderDetail = new System.Windows.Forms.Button();
            this.showSalesOrderHeader = new System.Windows.Forms.Button();
            this.customQuery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1173, 393);
            this.dataGridView2.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(284, 72);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Product";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // showAddress
            // 
            this.showAddress.Location = new System.Drawing.Point(12, 72);
            this.showAddress.Name = "showAddress";
            this.showAddress.Size = new System.Drawing.Size(75, 23);
            this.showAddress.TabIndex = 3;
            this.showAddress.Text = "Address";
            this.showAddress.UseVisualStyleBackColor = true;
            this.showAddress.Click += new System.EventHandler(this.showAddress_Click);
            // 
            // showCustomer
            // 
            this.showCustomer.Location = new System.Drawing.Point(93, 72);
            this.showCustomer.Name = "showCustomer";
            this.showCustomer.Size = new System.Drawing.Size(75, 23);
            this.showCustomer.TabIndex = 4;
            this.showCustomer.Text = "Customer";
            this.showCustomer.UseVisualStyleBackColor = true;
            this.showCustomer.Click += new System.EventHandler(this.showCustomer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Customer Address";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // showPCategory
            // 
            this.showPCategory.Location = new System.Drawing.Point(365, 72);
            this.showPCategory.Name = "showPCategory";
            this.showPCategory.Size = new System.Drawing.Size(75, 23);
            this.showPCategory.TabIndex = 6;
            this.showPCategory.Text = "P.Category";
            this.showPCategory.UseVisualStyleBackColor = true;
            this.showPCategory.Click += new System.EventHandler(this.showPCategory_Click);
            // 
            // showPDescription
            // 
            this.showPDescription.Location = new System.Drawing.Point(447, 72);
            this.showPDescription.Name = "showPDescription";
            this.showPDescription.Size = new System.Drawing.Size(85, 23);
            this.showPDescription.TabIndex = 7;
            this.showPDescription.Text = "P.Description";
            this.showPDescription.UseVisualStyleBackColor = true;
            this.showPDescription.Click += new System.EventHandler(this.showPDescription_Click);
            // 
            // showPModel
            // 
            this.showPModel.Location = new System.Drawing.Point(539, 72);
            this.showPModel.Name = "showPModel";
            this.showPModel.Size = new System.Drawing.Size(75, 23);
            this.showPModel.TabIndex = 8;
            this.showPModel.Text = "P.Model";
            this.showPModel.UseVisualStyleBackColor = true;
            this.showPModel.Click += new System.EventHandler(this.showPModel_Click);
            // 
            // showPModelPDesc
            // 
            this.showPModelPDesc.Location = new System.Drawing.Point(621, 72);
            this.showPModelPDesc.Name = "showPModelPDesc";
            this.showPModelPDesc.Size = new System.Drawing.Size(94, 23);
            this.showPModelPDesc.TabIndex = 9;
            this.showPModelPDesc.Text = "P.Model/P.Desc";
            this.showPModelPDesc.UseVisualStyleBackColor = true;
            this.showPModelPDesc.Click += new System.EventHandler(this.showPModelPDesc_Click);
            // 
            // showSalesOrderDetail
            // 
            this.showSalesOrderDetail.Location = new System.Drawing.Point(722, 72);
            this.showSalesOrderDetail.Name = "showSalesOrderDetail";
            this.showSalesOrderDetail.Size = new System.Drawing.Size(103, 23);
            this.showSalesOrderDetail.TabIndex = 10;
            this.showSalesOrderDetail.Text = "Sales Order Detail";
            this.showSalesOrderDetail.UseVisualStyleBackColor = true;
            this.showSalesOrderDetail.Click += new System.EventHandler(this.showSalesOrderDetail_Click);
            // 
            // showSalesOrderHeader
            // 
            this.showSalesOrderHeader.Location = new System.Drawing.Point(831, 72);
            this.showSalesOrderHeader.Name = "showSalesOrderHeader";
            this.showSalesOrderHeader.Size = new System.Drawing.Size(114, 23);
            this.showSalesOrderHeader.TabIndex = 11;
            this.showSalesOrderHeader.Text = "Sales Order Header";
            this.showSalesOrderHeader.UseVisualStyleBackColor = true;
            this.showSalesOrderHeader.Click += new System.EventHandler(this.showSalesOrderHeader_Click);
            // 
            // customQuery
            // 
            this.customQuery.Location = new System.Drawing.Point(12, 43);
            this.customQuery.Name = "customQuery";
            this.customQuery.Size = new System.Drawing.Size(156, 23);
            this.customQuery.TabIndex = 12;
            this.customQuery.Text = "Custom Query";
            this.customQuery.UseVisualStyleBackColor = true;
            this.customQuery.Click += new System.EventHandler(this.customQuery_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1197, 506);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customQuery);
            this.Controls.Add(this.showSalesOrderHeader);
            this.Controls.Add(this.showSalesOrderDetail);
            this.Controls.Add(this.showPModelPDesc);
            this.Controls.Add(this.showPModel);
            this.Controls.Add(this.showPDescription);
            this.Controls.Add(this.showPCategory);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showCustomer);
            this.Controls.Add(this.showAddress);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showProducts;
        private System.Windows.Forms.Button viewProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button showAddress;
        private System.Windows.Forms.Button showCustomer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button showPCategory;
        private System.Windows.Forms.Button showPDescription;
        private System.Windows.Forms.Button showPModel;
        private System.Windows.Forms.Button showPModelPDesc;
        private System.Windows.Forms.Button showSalesOrderDetail;
        private System.Windows.Forms.Button showSalesOrderHeader;
        private System.Windows.Forms.Button customQuery;
        private System.Windows.Forms.TextBox textBox1;
    }
}


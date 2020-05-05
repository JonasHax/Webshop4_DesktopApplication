namespace DesktopApplication.Presentation {
    partial class OrderGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listBoxSalesLineItems = new System.Windows.Forms.ListBox();
            this.gridViewOrders = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesLineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesLineItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSalesLineItems
            // 
            this.listBoxSalesLineItems.FormattingEnabled = true;
            this.listBoxSalesLineItems.Location = new System.Drawing.Point(12, 304);
            this.listBoxSalesLineItems.Name = "listBoxSalesLineItems";
            this.listBoxSalesLineItems.Size = new System.Drawing.Size(726, 277);
            this.listBoxSalesLineItems.TabIndex = 0;
            // 
            // gridViewOrders
            // 
            this.gridViewOrders.AllowUserToAddRows = false;
            this.gridViewOrders.AllowUserToDeleteRows = false;
            this.gridViewOrders.AutoGenerateColumns = false;
            this.gridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.gridViewOrders.DataSource = this.orderBindingSource;
            this.gridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.gridViewOrders.Name = "gridViewOrders";
            this.gridViewOrders.ReadOnly = true;
            this.gridViewOrders.Size = new System.Drawing.Size(461, 286);
            this.gridViewOrders.TabIndex = 1;
            this.gridViewOrders.SelectionChanged += new System.EventHandler(this.gridViewOrders_SelectionChanged);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Kunde ID";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Købsdato";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Ordre ID";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Betalt";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DesktopApplication.OrderService.Order);
            // 
            // salesLineItemBindingSource
            // 
            this.salesLineItemBindingSource.DataSource = typeof(DesktopApplication.OrderService.SalesLineItem);
            // 
            // btnShowPaid
            // 
            this.btnShowPaid.Location = new System.Drawing.Point(513, 12);
            this.btnShowPaid.Name = "btnShowPaid";
            this.btnShowPaid.Size = new System.Drawing.Size(204, 30);
            this.btnShowPaid.TabIndex = 2;
            this.btnShowPaid.Text = "Vis kun aktive ordre";
            this.btnShowPaid.UseVisualStyleBackColor = true;
            this.btnShowPaid.Click += new System.EventHandler(this.btnShowPaid_Click);
            // 
            // OrderGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 590);
            this.Controls.Add(this.btnShowPaid);
            this.Controls.Add(this.gridViewOrders);
            this.Controls.Add(this.listBoxSalesLineItems);
            this.Name = "OrderGUI";
            this.Text = "OrderGUI";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesLineItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSalesLineItems;
        private System.Windows.Forms.DataGridView gridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource salesLineItemBindingSource;
        private System.Windows.Forms.Button btnShowPaid;
    }
}
namespace DesktopApplication
{
    partial class ProductGUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_ProductState = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddCategoryToProduct = new System.Windows.Forms.Button();
            this.lblInsertProduct = new System.Windows.Forms.Label();
            this.gridViewProduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateProdVer = new System.Windows.Forms.Button();
            this.btnDeleteProdVer = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.lblInserProductVersion = new System.Windows.Forms.Label();
            this.gridViewProdVer = new System.Windows.Forms.DataGridView();
            this.btnCreateProdVer = new System.Windows.Forms.Button();
            this.sizeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyProductVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 278);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 281);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Produktnavn";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(33, 311);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(62, 347);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Pris";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 308);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(407, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 344);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(28, 461);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(519, 34);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Opret Produkt";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(47, 289);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(48, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Størrelse";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(47, 327);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Farve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategori";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(99, 374);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Category.TabIndex = 14;
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(143, 324);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Color.TabIndex = 16;
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(143, 286);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Size.TabIndex = 17;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(47, 368);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(72, 13);
            this.lblStock.TabIndex = 18;
            this.lblStock.Text = "Antal på lager";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(143, 365);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 20);
            this.txtStock.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.checkBox_ProductState);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdateProduct);
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnAddCategoryToProduct);
            this.groupBox1.Controls.Add(this.lblInsertProduct);
            this.groupBox1.Controls.Add(this.gridViewProduct);
            this.groupBox1.Controls.Add(this.comboBox_Category);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.btnCreateProduct);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 563);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkter";
            // 
            // checkBox_ProductState
            // 
            this.checkBox_ProductState.AutoSize = true;
            this.checkBox_ProductState.Location = new System.Drawing.Point(315, 346);
            this.checkBox_ProductState.Name = "checkBox_ProductState";
            this.checkBox_ProductState.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ProductState.TabIndex = 26;
            this.checkBox_ProductState.Text = "Aktiv";
            this.checkBox_ProductState.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(99, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 20);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Ryd";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(276, 513);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(271, 31);
            this.btnUpdateProduct.TabIndex = 23;
            this.btnUpdateProduct.Text = "Opdater Produkt";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(28, 513);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(233, 31);
            this.btnDeleteProduct.TabIndex = 22;
            this.btnDeleteProduct.Text = "Slet Produkt";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddCategoryToProduct
            // 
            this.btnAddCategoryToProduct.Location = new System.Drawing.Point(315, 374);
            this.btnAddCategoryToProduct.Name = "btnAddCategoryToProduct";
            this.btnAddCategoryToProduct.Size = new System.Drawing.Size(232, 23);
            this.btnAddCategoryToProduct.TabIndex = 18;
            this.btnAddCategoryToProduct.Text = "Tilføj kategori til det valgte produkt";
            this.btnAddCategoryToProduct.UseVisualStyleBackColor = true;
            this.btnAddCategoryToProduct.Click += new System.EventHandler(this.btnAddCategoryToProduct_Click);
            // 
            // lblInsertProduct
            // 
            this.lblInsertProduct.AutoSize = true;
            this.lblInsertProduct.Location = new System.Drawing.Point(204, 432);
            this.lblInsertProduct.Name = "lblInsertProduct";
            this.lblInsertProduct.Size = new System.Drawing.Size(11, 13);
            this.lblInsertProduct.TabIndex = 17;
            this.lblInsertProduct.Text = "*";
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.AutoGenerateColumns = false;
            this.gridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.styleNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.stateDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.gridViewProduct.DataSource = this.companyProductBindingSource;
            this.gridViewProduct.Location = new System.Drawing.Point(7, 19);
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.Size = new System.Drawing.Size(553, 240);
            this.gridViewProduct.TabIndex = 16;
            this.gridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProduct_CellClick);
            this.gridViewProduct.SelectionChanged += new System.EventHandler(this.gridViewProduct_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.btnUpdateProdVer);
            this.groupBox2.Controls.Add(this.btnDeleteProdVer);
            this.groupBox2.Controls.Add(this.btnClear2);
            this.groupBox2.Controls.Add(this.lblInserProductVersion);
            this.groupBox2.Controls.Add(this.gridViewProdVer);
            this.groupBox2.Controls.Add(this.btnCreateProdVer);
            this.groupBox2.Controls.Add(this.comboBox_Color);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.comboBox_Size);
            this.groupBox2.Location = new System.Drawing.Point(595, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 563);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Underprodukter";
            // 
            // btnUpdateProdVer
            // 
            this.btnUpdateProdVer.Location = new System.Drawing.Point(204, 515);
            this.btnUpdateProdVer.Name = "btnUpdateProdVer";
            this.btnUpdateProdVer.Size = new System.Drawing.Size(139, 31);
            this.btnUpdateProdVer.TabIndex = 26;
            this.btnUpdateProdVer.Text = "Opdater Underprodukt";
            this.btnUpdateProdVer.UseVisualStyleBackColor = true;
            this.btnUpdateProdVer.Click += new System.EventHandler(this.btnUpdateProdVer_Click);
            // 
            // btnDeleteProdVer
            // 
            this.btnDeleteProdVer.Location = new System.Drawing.Point(50, 515);
            this.btnDeleteProdVer.Name = "btnDeleteProdVer";
            this.btnDeleteProdVer.Size = new System.Drawing.Size(139, 31);
            this.btnDeleteProdVer.TabIndex = 25;
            this.btnDeleteProdVer.Text = "Slet Underprodukt";
            this.btnDeleteProdVer.UseVisualStyleBackColor = true;
            this.btnDeleteProdVer.Click += new System.EventHandler(this.btnDeleteProdVer_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(50, 403);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(51, 20);
            this.btnClear2.TabIndex = 25;
            this.btnClear2.Text = "Ryd";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // lblInserProductVersion
            // 
            this.lblInserProductVersion.AutoSize = true;
            this.lblInserProductVersion.Location = new System.Drawing.Point(152, 434);
            this.lblInserProductVersion.Name = "lblInserProductVersion";
            this.lblInserProductVersion.Size = new System.Drawing.Size(11, 13);
            this.lblInserProductVersion.TabIndex = 21;
            this.lblInserProductVersion.Text = "*";
            // 
            // gridViewProdVer
            // 
            this.gridViewProdVer.AutoGenerateColumns = false;
            this.gridViewProdVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProdVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeCodeDataGridViewTextBoxColumn,
            this.colorCodeDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.gridViewProdVer.DataSource = this.companyProductVersionBindingSource;
            this.gridViewProdVer.Location = new System.Drawing.Point(21, 19);
            this.gridViewProdVer.Name = "gridViewProdVer";
            this.gridViewProdVer.Size = new System.Drawing.Size(345, 240);
            this.gridViewProdVer.TabIndex = 20;
            this.gridViewProdVer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProdVer_CellClick);
            // 
            // btnCreateProdVer
            // 
            this.btnCreateProdVer.Location = new System.Drawing.Point(50, 459);
            this.btnCreateProdVer.Name = "btnCreateProdVer";
            this.btnCreateProdVer.Size = new System.Drawing.Size(293, 38);
            this.btnCreateProdVer.TabIndex = 15;
            this.btnCreateProdVer.Text = "Opret Underprodukt";
            this.btnCreateProdVer.UseVisualStyleBackColor = true;
            this.btnCreateProdVer.Click += new System.EventHandler(this.btnCreateProdVer_Click_1);
            // 
            // sizeCodeDataGridViewTextBoxColumn
            // 
            this.sizeCodeDataGridViewTextBoxColumn.DataPropertyName = "SizeCode";
            this.sizeCodeDataGridViewTextBoxColumn.HeaderText = "Str.";
            this.sizeCodeDataGridViewTextBoxColumn.Name = "sizeCodeDataGridViewTextBoxColumn";
            // 
            // colorCodeDataGridViewTextBoxColumn
            // 
            this.colorCodeDataGridViewTextBoxColumn.DataPropertyName = "ColorCode";
            this.colorCodeDataGridViewTextBoxColumn.HeaderText = "Farve";
            this.colorCodeDataGridViewTextBoxColumn.Name = "colorCodeDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Lager";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // companyProductVersionBindingSource
            // 
            this.companyProductVersionBindingSource.DataSource = typeof(DesktopApplication.Model.CompanyProductVersion);
            // 
            // styleNumberDataGridViewTextBoxColumn
            // 
            this.styleNumberDataGridViewTextBoxColumn.DataPropertyName = "StyleNumber";
            this.styleNumberDataGridViewTextBoxColumn.HeaderText = "Varenummer";
            this.styleNumberDataGridViewTextBoxColumn.Name = "styleNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Produkt";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Beskrivelse";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            this.stateDataGridViewCheckBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewCheckBoxColumn.HeaderText = "Tilgængelig";
            this.stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // companyProductBindingSource
            // 
            this.companyProductBindingSource.DataSource = typeof(DesktopApplication.Model.CompanyProduct);
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(994, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateProduct";
            this.Text = "Produkt Side";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductVersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateProdVer;
        private System.Windows.Forms.DataGridView gridViewProduct;
        private System.Windows.Forms.BindingSource companyProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridViewProdVer;
        private System.Windows.Forms.BindingSource companyProductVersionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInsertProduct;
        private System.Windows.Forms.Label lblInserProductVersion;
        private System.Windows.Forms.Button btnAddCategoryToProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateProdVer;
        private System.Windows.Forms.Button btnDeleteProdVer;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.CheckBox checkBox_ProductState;
    }
}
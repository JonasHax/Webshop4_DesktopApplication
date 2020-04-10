namespace DesktopApplication
{
    partial class CreateProduct
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
            this.gridViewProduct = new System.Windows.Forms.DataGridView();
            this.styleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewProdVer = new System.Windows.Forms.DataGridView();
            this.sizeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyProductVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreateProdVer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 277);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 280);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Produktnavn";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(46, 310);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Beskrivelse";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(75, 346);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Pris";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 307);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(407, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 343);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(156, 409);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(293, 34);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Opret Produkt";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(45, 286);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(48, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Størrelse";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(45, 324);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Farve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategori";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(112, 373);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Category.TabIndex = 14;
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(141, 321);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Color.TabIndex = 16;
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(141, 283);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Size.TabIndex = 17;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(45, 365);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(72, 13);
            this.lblStock.TabIndex = 18;
            this.lblStock.Text = "Antal på lager";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(141, 362);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 20);
            this.txtStock.TabIndex = 19;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(580, 457);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkter";
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
            this.gridViewProduct.SelectionChanged += new System.EventHandler(this.gridViewProduct_SelectionChanged);
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
            // groupBox2
            // 
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
            this.groupBox2.Size = new System.Drawing.Size(390, 457);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Underprodukter";
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
            // btnCreateProdVer
            // 
            this.btnCreateProdVer.Location = new System.Drawing.Point(103, 409);
            this.btnCreateProdVer.Name = "btnCreateProdVer";
            this.btnCreateProdVer.Size = new System.Drawing.Size(176, 38);
            this.btnCreateProdVer.TabIndex = 15;
            this.btnCreateProdVer.Text = "Opret Underprodukt";
            this.btnCreateProdVer.UseVisualStyleBackColor = true;
            this.btnCreateProdVer.Click += new System.EventHandler(this.btnCreateProdVer_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(412, 499);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Søg Produkt";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Location = new System.Drawing.Point(313, 501);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(79, 20);
            this.txtSearchProd.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Opret eller find et produkt for at tilføje underprodukter";
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchProd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateProduct";
            this.Text = "CreateProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyProductVersionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchProd;
        private System.Windows.Forms.Label label2;
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
    }
}
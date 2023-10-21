namespace supermarket.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            TxtSearch = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            btnClose = new Button();
            btnDelet = new Button();
            btnEdit = new Button();
            btnsave = new Button();
            DgProduct = new DataGridView();
            tabPageProductDetail = new TabPage();
            btnCancel = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            TxtProductStock = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductCategory_id = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 51);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Controls.Add(btnSearch);
            tabPageProductList.Controls.Add(btnClose);
            tabPageProductList.Controls.Add(btnDelet);
            tabPageProductList.Controls.Add(btnEdit);
            tabPageProductList.Controls.Add(btnsave);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 322);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(29, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(360, 23);
            TxtSearch.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 18);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 6;
            label2.Text = "Search Pay Mode";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(461, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(662, 233);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 38);
            btnClose.TabIndex = 4;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(662, 175);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(97, 38);
            btnDelet.TabIndex = 3;
            btnDelet.Text = "DELET";
            btnDelet.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(662, 116);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(97, 38);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(662, 53);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(97, 38);
            btnsave.TabIndex = 1;
            btnsave.Text = "NEW";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(29, 79);
            DgProduct.Name = "DgProduct";
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(607, 192);
            DgProduct.TabIndex = 0;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductCategory_id);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(btnCancel);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 322);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(396, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(33, 167);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "stock";
            TxtProductStock.Size = new Size(301, 23);
            TxtProductStock.TabIndex = 11;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(33, 109);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "name";
            TxtProductName.Size = new Size(301, 23);
            TxtProductName.TabIndex = 10;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(33, 55);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.PlaceholderText = "id";
            TxtProductId.Size = new Size(100, 23);
            TxtProductId.TabIndex = 9;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(33, 219);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "prices";
            TxtProductPrice.Size = new Size(301, 23);
            TxtProductPrice.TabIndex = 12;
            // 
            // TxtProductCategory_id
            // 
            TxtProductCategory_id.Location = new Point(33, 270);
            TxtProductCategory_id.Name = "TxtProductCategory_id";
            TxtProductCategory_id.PlaceholderText = "id category";
            TxtProductCategory_id.Size = new Size(301, 23);
            TxtProductCategory_id.TabIndex = 13;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private DataGridView DgProduct;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnsave;
        private Button btnEdit;
        private Button btnDelet;
        private Button btnClose;
        private Button btnSearch;
        private Label label2;
        private TextBox TxtSearch;
        private Button btnCancel;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtProductId;
        private TextBox TxtProductStock;
        private TextBox TxtProductName;
        private TextBox TxtProductPrice;
        private TextBox TxtProductCategory_id;
    }
}
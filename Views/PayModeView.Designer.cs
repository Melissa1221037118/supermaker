namespace supermarket.Views
{
    partial class PayModeView
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
            TxtPayModeId = new TabControl();
            tabControl1 = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModelId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            TxtPayModeId.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPage2.SuspendLayout();
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
            label1.Location = new Point(178, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.Click += label1_Click;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Controls.Add(tabControl1);
            TxtPayModeId.Controls.Add(tabPage2);
            TxtPayModeId.Dock = DockStyle.Fill;
            TxtPayModeId.Location = new Point(0, 100);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.SelectedIndex = 0;
            TxtPayModeId.Size = new Size(800, 350);
            TxtPayModeId.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(BtnClose);
            tabControl1.Controls.Add(BtnDelete);
            tabControl1.Controls.Add(BtnEdit);
            tabControl1.Controls.Add(BtnNew);
            tabControl1.Controls.Add(DgPayMode);
            tabControl1.Controls.Add(BtnSearch);
            tabControl1.Controls.Add(TxtSearch);
            tabControl1.Controls.Add(label2);
            tabControl1.Location = new Point(4, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Padding(3);
            tabControl1.Size = new Size(792, 322);
            tabControl1.TabIndex = 0;
            tabControl1.Text = " Pay Mode List";
            tabControl1.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(701, 234);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 7;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(701, 187);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "Delet";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(701, 141);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Location = new Point(701, 94);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 23);
            BtnNew.TabIndex = 4;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(25, 94);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(670, 209);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(391, 52);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(25, 52);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(360, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 25);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtPayModeObservation);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TxtPayModeName);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtPayModelId);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " Pay Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(159, 278);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(57, 278);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(55, 162);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Name";
            TxtPayModeObservation.Size = new Size(301, 82);
            TxtPayModeObservation.TabIndex = 5;
            TxtPayModeObservation.TextChanged += TxtPayModeObservation_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 144);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            label5.Click += label5_Click;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(55, 104);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(301, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 86);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModelId
            // 
            TxtPayModelId.Location = new Point(55, 50);
            TxtPayModelId.Name = "TxtPayModelId";
            TxtPayModelId.Size = new Size(100, 23);
            TxtPayModelId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 32);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            label3.Click += label3_Click;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtPayModeId);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "PayModeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TxtPayModeId.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl TxtPayModeId;
        private TabPage tabControl1;
        private TabPage tabPage2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Label label3;
        private TextBox TxtPayModelId;
        private Label label4;
        private TextBox TxtPayModeName;
        private Label label5;
        private TextBox TxtPayModeObservation;
        private Button BtnSave;
        private Button BtnCancel;
    }
}
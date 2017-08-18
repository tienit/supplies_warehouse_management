namespace VKTIM
{
    partial class frmExcelImportWinz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcelImportWinz));
            this.btn_File = new System.Windows.Forms.Button();
            this.txt_File = new System.Windows.Forms.TextBox();
            this.com_Sheet = new System.Windows.Forms.ComboBox();
            this.lbl_dis_Sheet = new System.Windows.Forms.Label();
            this.grv_Merge = new System.Windows.Forms.DataGridView();
            this.btn_Refres = new System.Windows.Forms.Button();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_Main = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_Total = new System.Windows.Forms.DataGridView();
            this.vatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Datatable = new System.Windows.Forms.Button();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Merge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Total)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.btn_Datatable);
            this.pn_Form.Controls.Add(this.grv_Total);
            this.pn_Form.Controls.Add(this.grv_Main);
            this.pn_Form.Controls.Add(this.btn_Refres);
            this.pn_Form.Controls.Add(this.grv_Merge);
            this.pn_Form.Controls.Add(this.lbl_dis_Sheet);
            this.pn_Form.Controls.Add(this.com_Sheet);
            this.pn_Form.Controls.Add(this.txt_File);
            this.pn_Form.Controls.Add(this.btn_File);
            this.pn_Form.Size = new System.Drawing.Size(919, 475);
            this.pn_Form.Controls.SetChildIndex(this.btn_File, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_File, 0);
            this.pn_Form.Controls.SetChildIndex(this.com_Sheet, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_Sheet, 0);
            this.pn_Form.Controls.SetChildIndex(this.grv_Merge, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Refres, 0);
            this.pn_Form.Controls.SetChildIndex(this.grv_Main, 0);
            this.pn_Form.Controls.SetChildIndex(this.grv_Total, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Datatable, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(732, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // btn_File
            // 
            this.btn_File.Location = new System.Drawing.Point(28, 60);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(155, 23);
            this.btn_File.TabIndex = 52;
            this.btn_File.Text = "1. Chọn tập tin excel";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // txt_File
            // 
            this.txt_File.Location = new System.Drawing.Point(200, 62);
            this.txt_File.Name = "txt_File";
            this.txt_File.Size = new System.Drawing.Size(293, 20);
            this.txt_File.TabIndex = 53;
            // 
            // com_Sheet
            // 
            this.com_Sheet.FormattingEnabled = true;
            this.com_Sheet.Location = new System.Drawing.Point(694, 60);
            this.com_Sheet.Name = "com_Sheet";
            this.com_Sheet.Size = new System.Drawing.Size(188, 21);
            this.com_Sheet.TabIndex = 54;
            // 
            // lbl_dis_Sheet
            // 
            this.lbl_dis_Sheet.AutoSize = true;
            this.lbl_dis_Sheet.Location = new System.Drawing.Point(552, 65);
            this.lbl_dis_Sheet.Name = "lbl_dis_Sheet";
            this.lbl_dis_Sheet.Size = new System.Drawing.Size(136, 13);
            this.lbl_dis_Sheet.TabIndex = 55;
            this.lbl_dis_Sheet.Text = "2. Chọn Sheet chứa dữ liệu";
            // 
            // grv_Merge
            // 
            this.grv_Merge.AllowUserToAddRows = false;
            this.grv_Merge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Merge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.grv_Merge.Location = new System.Drawing.Point(28, 101);
            this.grv_Merge.Name = "grv_Merge";
            this.grv_Merge.Size = new System.Drawing.Size(853, 113);
            this.grv_Merge.TabIndex = 56;
            // 
            // btn_Refres
            // 
            this.btn_Refres.Location = new System.Drawing.Point(28, 227);
            this.btn_Refres.Name = "btn_Refres";
            this.btn_Refres.Size = new System.Drawing.Size(155, 23);
            this.btn_Refres.TabIndex = 57;
            this.btn_Refres.Text = "3. Làm mới";
            this.btn_Refres.UseVisualStyleBackColor = true;
            this.btn_Refres.Click += new System.EventHandler(this.btn_Refres_Click);
            // 
            // col1
            // 
            this.col1.HeaderText = "Mã cột";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "Tên cột";
            this.col2.Name = "col2";
            // 
            // grv_Main
            // 
            this.grv_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQuantity,
            this.colPrice,
            this.colTotal});
            this.grv_Main.ContextMenuStrip = this.contextMenuStrip1;
            this.grv_Main.Location = new System.Drawing.Point(28, 256);
            this.grv_Main.Name = "grv_Main";
            this.grv_Main.Size = new System.Drawing.Size(849, 155);
            this.grv_Main.TabIndex = 60;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "colName";
            this.colName.HeaderText = "Tên thiết bị";
            this.colName.Name = "colName";
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "colQuantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "colPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.Name = "colPrice";
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "colTotal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "Thành tiền";
            this.colTotal.Name = "colTotal";
            // 
            // grv_Total
            // 
            this.grv_Total.AllowUserToAddRows = false;
            this.grv_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Total.ColumnHeadersVisible = false;
            this.grv_Total.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vatColumn,
            this.totalColumn});
            this.grv_Total.Location = new System.Drawing.Point(28, 417);
            this.grv_Total.Name = "grv_Total";
            this.grv_Total.Size = new System.Drawing.Size(849, 35);
            this.grv_Total.TabIndex = 61;
            // 
            // vatColumn
            // 
            this.vatColumn.DataPropertyName = "VAT";
            this.vatColumn.HeaderText = "VAT";
            this.vatColumn.Name = "vatColumn";
            // 
            // totalColumn
            // 
            this.totalColumn.DataPropertyName = "TOTAL";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.Name = "totalColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.delToolStripMenuItem.Text = "Xóa";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // btn_Datatable
            // 
            this.btn_Datatable.Location = new System.Drawing.Point(639, 227);
            this.btn_Datatable.Name = "btn_Datatable";
            this.btn_Datatable.Size = new System.Drawing.Size(238, 23);
            this.btn_Datatable.TabIndex = 62;
            this.btn_Datatable.Text = "4. Lấy dữ liệu ra Datatable";
            this.btn_Datatable.UseVisualStyleBackColor = true;
            this.btn_Datatable.Click += new System.EventHandler(this.btn_Datatable_Click);
            // 
            // frmExcelImportWinz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 491);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 760);
            this.Name = "frmExcelImportWinz";
            this.Text = "";
            this.Controls.SetChildIndex(this.pn_Form, 0);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Merge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Total)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Refres;
        private System.Windows.Forms.DataGridView grv_Merge;
        private System.Windows.Forms.Label lbl_dis_Sheet;
        private System.Windows.Forms.ComboBox com_Sheet;
        private System.Windows.Forms.TextBox txt_File;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridView grv_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridView grv_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.Button btn_Datatable;
    }
}
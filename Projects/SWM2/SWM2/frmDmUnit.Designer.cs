namespace VKTIM
{
    partial class frmDmUnit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmUnit));
            this.lbl_dis_count = new System.Windows.Forms.Label();
            this.lbl_data_count = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_Control = new System.Windows.Forms.Panel();
            this.txt_data_keyword = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_dis_keyword = new System.Windows.Forms.Label();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.pn_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.lbl_dis_count);
            this.pn_Form.Controls.Add(this.lbl_data_count);
            this.pn_Form.Controls.Add(this.dgv_Data);
            this.pn_Form.Controls.Add(this.pn_Control);
            this.pn_Form.Size = new System.Drawing.Size(869, 523);
            this.pn_Form.Controls.SetChildIndex(this.pn_Control, 0);
            this.pn_Form.Controls.SetChildIndex(this.dgv_Data, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_data_count, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_count, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(682, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // lbl_dis_count
            // 
            this.lbl_dis_count.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_dis_count.Location = new System.Drawing.Point(15, 115);
            this.lbl_dis_count.Name = "lbl_dis_count";
            this.lbl_dis_count.Size = new System.Drawing.Size(123, 25);
            this.lbl_dis_count.TabIndex = 57;
            this.lbl_dis_count.Text = "Số lượng:";
            this.lbl_dis_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_data_count
            // 
            this.lbl_data_count.AutoSize = true;
            this.lbl_data_count.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_data_count.Location = new System.Drawing.Point(144, 119);
            this.lbl_data_count.Name = "lbl_data_count";
            this.lbl_data_count.Size = new System.Drawing.Size(16, 16);
            this.lbl_data_count.TabIndex = 56;
            this.lbl_data_count.Text = "0";
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colShortName,
            this.colDescription});
            this.dgv_Data.EnableHeadersVisualStyles = false;
            this.dgv_Data.Location = new System.Drawing.Point(12, 145);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Data.MultiSelect = false;
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Data.RowTemplate.ReadOnly = true;
            this.dgv_Data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(845, 355);
            this.dgv_Data.TabIndex = 54;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "UNIT_NAME";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colShortName
            // 
            this.colShortName.DataPropertyName = "UNIT_SHORT_NAME";
            this.colShortName.HeaderText = "Short Name";
            this.colShortName.Name = "colShortName";
            this.colShortName.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "UNIT_DESCRIPTION";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // pn_Control
            // 
            this.pn_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Control.Controls.Add(this.txt_data_keyword);
            this.pn_Control.Controls.Add(this.btn_Add);
            this.pn_Control.Controls.Add(this.btn_Update);
            this.pn_Control.Controls.Add(this.btn_Delete);
            this.pn_Control.Controls.Add(this.btn_Search);
            this.pn_Control.Controls.Add(this.lbl_dis_keyword);
            this.pn_Control.Location = new System.Drawing.Point(12, 55);
            this.pn_Control.Name = "pn_Control";
            this.pn_Control.Size = new System.Drawing.Size(845, 53);
            this.pn_Control.TabIndex = 55;
            // 
            // txt_data_keyword
            // 
            this.txt_data_keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_keyword.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_data_keyword.Location = new System.Drawing.Point(135, 9);
            this.txt_data_keyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_keyword.Multiline = true;
            this.txt_data_keyword.Name = "txt_data_keyword";
            this.txt_data_keyword.Size = new System.Drawing.Size(211, 35);
            this.txt_data_keyword.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(489, 9);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 35);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add new";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(609, 9);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 35);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(729, 9);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 35);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(353, 9);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 35);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_dis_keyword
            // 
            this.lbl_dis_keyword.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_dis_keyword.Location = new System.Drawing.Point(5, 13);
            this.lbl_dis_keyword.Name = "lbl_dis_keyword";
            this.lbl_dis_keyword.Size = new System.Drawing.Size(124, 25);
            this.lbl_dis_keyword.TabIndex = 2;
            this.lbl_dis_keyword.Text = "Keyword";
            this.lbl_dis_keyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 539);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmDmUnit";
            this.Text = "Unit Management";
            this.Load += new System.EventHandler(this.frmDmUnit_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.pn_Control.ResumeLayout(false);
            this.pn_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_dis_count;
        private System.Windows.Forms.Label lbl_data_count;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Panel pn_Control;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_data_keyword;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_dis_keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}
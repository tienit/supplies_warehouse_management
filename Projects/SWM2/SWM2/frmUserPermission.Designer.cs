namespace VKTIM
{
    partial class frmUserPermission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserPermission));
            this.split_dis_main = new System.Windows.Forms.SplitContainer();
            this.gb_dis_role = new System.Windows.Forms.GroupBox();
            this.tv_data_role = new System.Windows.Forms.TreeView();
            this.gb_dis_forms = new System.Windows.Forms.GroupBox();
            this.dgv_data_form = new System.Windows.Forms.DataGridView();
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FORM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FORM_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FORM_TITLE_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MENU_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IS_SHOW_DIALOG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_SHORTCUT_KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IS_USED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_FORM_ORDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_dis_control = new System.Windows.Forms.Panel();
            this.lbl_data_count = new System.Windows.Forms.Label();
            this.lbl_dis_count = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_UnSelectAll = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_dis_main)).BeginInit();
            this.split_dis_main.Panel1.SuspendLayout();
            this.split_dis_main.Panel2.SuspendLayout();
            this.split_dis_main.SuspendLayout();
            this.gb_dis_role.SuspendLayout();
            this.gb_dis_forms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_form)).BeginInit();
            this.pn_dis_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.split_dis_main);
            this.pn_Form.Size = new System.Drawing.Size(1000, 600);
            this.pn_Form.Controls.SetChildIndex(this.split_dis_main, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(813, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // split_dis_main
            // 
            this.split_dis_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_dis_main.Location = new System.Drawing.Point(0, 45);
            this.split_dis_main.Name = "split_dis_main";
            // 
            // split_dis_main.Panel1
            // 
            this.split_dis_main.Panel1.Controls.Add(this.gb_dis_role);
            // 
            // split_dis_main.Panel2
            // 
            this.split_dis_main.Panel2.Controls.Add(this.gb_dis_forms);
            this.split_dis_main.Size = new System.Drawing.Size(1000, 555);
            this.split_dis_main.SplitterDistance = 279;
            this.split_dis_main.TabIndex = 52;
            // 
            // gb_dis_role
            // 
            this.gb_dis_role.Controls.Add(this.tv_data_role);
            this.gb_dis_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dis_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_dis_role.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gb_dis_role.Location = new System.Drawing.Point(0, 0);
            this.gb_dis_role.Name = "gb_dis_role";
            this.gb_dis_role.Size = new System.Drawing.Size(279, 555);
            this.gb_dis_role.TabIndex = 0;
            this.gb_dis_role.TabStop = false;
            this.gb_dis_role.Text = "Role";
            // 
            // tv_data_role
            // 
            this.tv_data_role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_data_role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tv_data_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_data_role.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tv_data_role.FullRowSelect = true;
            this.tv_data_role.Location = new System.Drawing.Point(3, 23);
            this.tv_data_role.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tv_data_role.Name = "tv_data_role";
            this.tv_data_role.ShowLines = false;
            this.tv_data_role.Size = new System.Drawing.Size(273, 529);
            this.tv_data_role.TabIndex = 3;
            this.tv_data_role.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_data_role_AfterSelect);
            // 
            // gb_dis_forms
            // 
            this.gb_dis_forms.Controls.Add(this.dgv_data_form);
            this.gb_dis_forms.Controls.Add(this.pn_dis_control);
            this.gb_dis_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dis_forms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_dis_forms.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gb_dis_forms.Location = new System.Drawing.Point(0, 0);
            this.gb_dis_forms.Name = "gb_dis_forms";
            this.gb_dis_forms.Size = new System.Drawing.Size(717, 555);
            this.gb_dis_forms.TabIndex = 0;
            this.gb_dis_forms.TabStop = false;
            this.gb_dis_forms.Text = "Functions";
            // 
            // dgv_data_form
            // 
            this.dgv_data_form.AllowUserToAddRows = false;
            this.dgv_data_form.AllowUserToDeleteRows = false;
            this.dgv_data_form.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_data_form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data_form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_data_form.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data_form.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data_form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImg,
            this.col_ID,
            this.col_FORM_NAME,
            this.col_FORM_TITLE,
            this.col_FORM_TITLE_EN,
            this.col_MENU_NAME,
            this.col_IS_SHOW_DIALOG,
            this.col_SHORTCUT_KEY,
            this.col_IS_USED,
            this.col_FORM_ORDER});
            this.dgv_data_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data_form.Location = new System.Drawing.Point(3, 83);
            this.dgv_data_form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_data_form.MultiSelect = false;
            this.dgv_data_form.Name = "dgv_data_form";
            this.dgv_data_form.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_data_form.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data_form.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data_form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_data_form.Size = new System.Drawing.Size(711, 469);
            this.dgv_data_form.TabIndex = 4;
            this.dgv_data_form.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_form_CellClick);
            // 
            // colImg
            // 
            this.colImg.HeaderText = "Img";
            this.colImg.Image = global::VKTIM.Properties.Resources.e_icon_unselect_24;
            this.colImg.Name = "colImg";
            this.colImg.Width = 41;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Visible = false;
            this.col_ID.Width = 49;
            // 
            // col_FORM_NAME
            // 
            this.col_FORM_NAME.DataPropertyName = "FORM_NAME";
            this.col_FORM_NAME.HeaderText = "Name";
            this.col_FORM_NAME.Name = "col_FORM_NAME";
            this.col_FORM_NAME.ReadOnly = true;
            this.col_FORM_NAME.Width = 74;
            // 
            // col_FORM_TITLE
            // 
            this.col_FORM_TITLE.DataPropertyName = "FORM_TITLE";
            this.col_FORM_TITLE.HeaderText = "Title";
            this.col_FORM_TITLE.Name = "col_FORM_TITLE";
            this.col_FORM_TITLE.ReadOnly = true;
            this.col_FORM_TITLE.Width = 63;
            // 
            // col_FORM_TITLE_EN
            // 
            this.col_FORM_TITLE_EN.DataPropertyName = "FORM_TITLE_EN";
            this.col_FORM_TITLE_EN.HeaderText = "Title (EN)";
            this.col_FORM_TITLE_EN.Name = "col_FORM_TITLE_EN";
            this.col_FORM_TITLE_EN.Width = 96;
            // 
            // col_MENU_NAME
            // 
            this.col_MENU_NAME.DataPropertyName = "MENU_NAME";
            this.col_MENU_NAME.HeaderText = "Menu";
            this.col_MENU_NAME.Name = "col_MENU_NAME";
            this.col_MENU_NAME.Width = 71;
            // 
            // col_IS_SHOW_DIALOG
            // 
            this.col_IS_SHOW_DIALOG.DataPropertyName = "IS_SHOW_DIALOG";
            this.col_IS_SHOW_DIALOG.FalseValue = "False";
            this.col_IS_SHOW_DIALOG.HeaderText = "Show Dialog";
            this.col_IS_SHOW_DIALOG.Name = "col_IS_SHOW_DIALOG";
            this.col_IS_SHOW_DIALOG.ReadOnly = true;
            this.col_IS_SHOW_DIALOG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_IS_SHOW_DIALOG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_IS_SHOW_DIALOG.TrueValue = "True";
            this.col_IS_SHOW_DIALOG.Width = 119;
            // 
            // col_SHORTCUT_KEY
            // 
            this.col_SHORTCUT_KEY.DataPropertyName = "SHORTCUT_KEY";
            this.col_SHORTCUT_KEY.HeaderText = "Shortcut";
            this.col_SHORTCUT_KEY.Name = "col_SHORTCUT_KEY";
            this.col_SHORTCUT_KEY.ReadOnly = true;
            this.col_SHORTCUT_KEY.Width = 89;
            // 
            // col_IS_USED
            // 
            this.col_IS_USED.DataPropertyName = "IS_USED";
            this.col_IS_USED.FalseValue = "False";
            this.col_IS_USED.HeaderText = "Used";
            this.col_IS_USED.Name = "col_IS_USED";
            this.col_IS_USED.ReadOnly = true;
            this.col_IS_USED.TrueValue = "True";
            this.col_IS_USED.Width = 48;
            // 
            // col_FORM_ORDER
            // 
            this.col_FORM_ORDER.DataPropertyName = "FORM_ORDER";
            this.col_FORM_ORDER.HeaderText = "Order";
            this.col_FORM_ORDER.Name = "col_FORM_ORDER";
            this.col_FORM_ORDER.ReadOnly = true;
            this.col_FORM_ORDER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_FORM_ORDER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_FORM_ORDER.Width = 53;
            // 
            // pn_dis_control
            // 
            this.pn_dis_control.Controls.Add(this.lbl_data_count);
            this.pn_dis_control.Controls.Add(this.lbl_dis_count);
            this.pn_dis_control.Controls.Add(this.btn_Save);
            this.pn_dis_control.Controls.Add(this.btn_UnSelectAll);
            this.pn_dis_control.Controls.Add(this.btn_SelectAll);
            this.pn_dis_control.Controls.Add(this.btn_Refresh);
            this.pn_dis_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_dis_control.Location = new System.Drawing.Point(3, 23);
            this.pn_dis_control.Name = "pn_dis_control";
            this.pn_dis_control.Size = new System.Drawing.Size(711, 60);
            this.pn_dis_control.TabIndex = 0;
            // 
            // lbl_data_count
            // 
            this.lbl_data_count.AutoSize = true;
            this.lbl_data_count.Location = new System.Drawing.Point(145, 24);
            this.lbl_data_count.Name = "lbl_data_count";
            this.lbl_data_count.Size = new System.Drawing.Size(17, 20);
            this.lbl_data_count.TabIndex = 97;
            this.lbl_data_count.Text = "0";
            this.lbl_data_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_count
            // 
            this.lbl_dis_count.Location = new System.Drawing.Point(12, 21);
            this.lbl_dis_count.Name = "lbl_dis_count";
            this.lbl_dis_count.Size = new System.Drawing.Size(127, 27);
            this.lbl_dis_count.TabIndex = 96;
            this.lbl_dis_count.Text = "Quantity:";
            this.lbl_dis_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Image = global::VKTIM.Properties.Resources.e_icon_save_24;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Save.Location = new System.Drawing.Point(596, 4);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 52);
            this.btn_Save.TabIndex = 95;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_UnSelectAll
            // 
            this.btn_UnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UnSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_UnSelectAll.FlatAppearance.BorderSize = 0;
            this.btn_UnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UnSelectAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UnSelectAll.ForeColor = System.Drawing.Color.Black;
            this.btn_UnSelectAll.Image = global::VKTIM.Properties.Resources.e_icon_unselect_24;
            this.btn_UnSelectAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_UnSelectAll.Location = new System.Drawing.Point(485, 4);
            this.btn_UnSelectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UnSelectAll.Name = "btn_UnSelectAll";
            this.btn_UnSelectAll.Size = new System.Drawing.Size(90, 52);
            this.btn_UnSelectAll.TabIndex = 94;
            this.btn_UnSelectAll.Text = "Unselect";
            this.btn_UnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_UnSelectAll.UseVisualStyleBackColor = false;
            this.btn_UnSelectAll.Click += new System.EventHandler(this.btn_UnSelectAll_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_SelectAll.FlatAppearance.BorderSize = 0;
            this.btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectAll.ForeColor = System.Drawing.Color.Black;
            this.btn_SelectAll.Image = global::VKTIM.Properties.Resources.e_icon_select_24;
            this.btn_SelectAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SelectAll.Location = new System.Drawing.Point(374, 4);
            this.btn_SelectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(90, 52);
            this.btn_SelectAll.TabIndex = 93;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_SelectAll.UseVisualStyleBackColor = false;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Image = global::VKTIM.Properties.Resources.e_icon_refresh_24;
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Refresh.Location = new System.Drawing.Point(263, 4);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(90, 52);
            this.btn_Refresh.TabIndex = 92;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frmUserPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmUserPermission";
            this.Text = "frmUserPermission";
            this.Load += new System.EventHandler(this.frmUserPermission_Load);
            this.pn_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.split_dis_main.Panel1.ResumeLayout(false);
            this.split_dis_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_dis_main)).EndInit();
            this.split_dis_main.ResumeLayout(false);
            this.gb_dis_role.ResumeLayout(false);
            this.gb_dis_forms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_form)).EndInit();
            this.pn_dis_control.ResumeLayout(false);
            this.pn_dis_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_dis_main;
        private System.Windows.Forms.GroupBox gb_dis_role;
        private System.Windows.Forms.GroupBox gb_dis_forms;
        private System.Windows.Forms.DataGridView dgv_data_form;
        private System.Windows.Forms.Panel pn_dis_control;
        private System.Windows.Forms.TreeView tv_data_role;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_UnSelectAll;
        private System.Windows.Forms.Label lbl_data_count;
        private System.Windows.Forms.Label lbl_dis_count;
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FORM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FORM_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FORM_TITLE_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MENU_NAME;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_IS_SHOW_DIALOG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SHORTCUT_KEY;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_IS_USED;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FORM_ORDER;
    }
}
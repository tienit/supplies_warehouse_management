namespace VKTIM
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.split_dis_main = new System.Windows.Forms.SplitContainer();
            this.gb_dis_role = new System.Windows.Forms.GroupBox();
            this.tv_data_role = new System.Windows.Forms.TreeView();
            this.pn_role_control = new System.Windows.Forms.Panel();
            this.chk_data_role_is_default = new System.Windows.Forms.CheckBox();
            this.btn_Update_Role = new System.Windows.Forms.Button();
            this.btn_Add_Role = new System.Windows.Forms.Button();
            this.txt_data_role_description = new System.Windows.Forms.TextBox();
            this.lbl_dis_role_description = new System.Windows.Forms.Label();
            this.txt_data_role_id = new System.Windows.Forms.TextBox();
            this.lbl_dis_role_id = new System.Windows.Forms.Label();
            this.lbl_dis_role_name = new System.Windows.Forms.Label();
            this.txt_data_role_name = new System.Windows.Forms.TextBox();
            this.gb_dis_users = new System.Windows.Forms.GroupBox();
            this.dgv_data_users = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IS_BLOCKED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_LAST_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IP_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NUMBER_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_REMARKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ROLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_user_control = new System.Windows.Forms.Panel();
            this.btn_Update_User = new System.Windows.Forms.Button();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.txt_data_user_remark = new System.Windows.Forms.TextBox();
            this.lbl_dis_user_remark = new System.Windows.Forms.Label();
            this.lbl_dis_user_role = new System.Windows.Forms.Label();
            this.chk_data_user_is_blocked = new System.Windows.Forms.CheckBox();
            this.cmb_data_user_roles = new System.Windows.Forms.ComboBox();
            this.txt_data_user_pass = new System.Windows.Forms.TextBox();
            this.lbl_dis_user_pass = new System.Windows.Forms.Label();
            this.txt_data_user_id = new System.Windows.Forms.TextBox();
            this.lbl_dis_user_id = new System.Windows.Forms.Label();
            this.lbl_dis_user_name = new System.Windows.Forms.Label();
            this.txt_data_user_name = new System.Windows.Forms.TextBox();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split_dis_main)).BeginInit();
            this.split_dis_main.Panel1.SuspendLayout();
            this.split_dis_main.Panel2.SuspendLayout();
            this.split_dis_main.SuspendLayout();
            this.gb_dis_role.SuspendLayout();
            this.pn_role_control.SuspendLayout();
            this.gb_dis_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_users)).BeginInit();
            this.pn_user_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.split_dis_main);
            this.pn_Form.Size = new System.Drawing.Size(1030, 650);
            this.pn_Form.Controls.SetChildIndex(this.split_dis_main, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(843, 37);
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
            this.split_dis_main.Panel2.Controls.Add(this.gb_dis_users);
            this.split_dis_main.Size = new System.Drawing.Size(1030, 605);
            this.split_dis_main.SplitterDistance = 343;
            this.split_dis_main.TabIndex = 52;
            // 
            // gb_dis_role
            // 
            this.gb_dis_role.Controls.Add(this.tv_data_role);
            this.gb_dis_role.Controls.Add(this.pn_role_control);
            this.gb_dis_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dis_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_dis_role.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gb_dis_role.Location = new System.Drawing.Point(0, 0);
            this.gb_dis_role.Name = "gb_dis_role";
            this.gb_dis_role.Size = new System.Drawing.Size(343, 605);
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
            this.tv_data_role.Name = "tv_data_role";
            this.tv_data_role.ShowLines = false;
            this.tv_data_role.Size = new System.Drawing.Size(337, 269);
            this.tv_data_role.TabIndex = 4;
            this.tv_data_role.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_data_role_AfterSelect);
            // 
            // pn_role_control
            // 
            this.pn_role_control.Controls.Add(this.chk_data_role_is_default);
            this.pn_role_control.Controls.Add(this.btn_Update_Role);
            this.pn_role_control.Controls.Add(this.btn_Add_Role);
            this.pn_role_control.Controls.Add(this.txt_data_role_description);
            this.pn_role_control.Controls.Add(this.lbl_dis_role_description);
            this.pn_role_control.Controls.Add(this.txt_data_role_id);
            this.pn_role_control.Controls.Add(this.lbl_dis_role_id);
            this.pn_role_control.Controls.Add(this.lbl_dis_role_name);
            this.pn_role_control.Controls.Add(this.txt_data_role_name);
            this.pn_role_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_role_control.Location = new System.Drawing.Point(3, 292);
            this.pn_role_control.Name = "pn_role_control";
            this.pn_role_control.Size = new System.Drawing.Size(337, 310);
            this.pn_role_control.TabIndex = 3;
            // 
            // chk_data_role_is_default
            // 
            this.chk_data_role_is_default.AutoSize = true;
            this.chk_data_role_is_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_data_role_is_default.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chk_data_role_is_default.Location = new System.Drawing.Point(144, 197);
            this.chk_data_role_is_default.Name = "chk_data_role_is_default";
            this.chk_data_role_is_default.Size = new System.Drawing.Size(88, 24);
            this.chk_data_role_is_default.TabIndex = 112;
            this.chk_data_role_is_default.Text = "Is Default";
            this.chk_data_role_is_default.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Role
            // 
            this.btn_Update_Role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update_Role.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Update_Role.FlatAppearance.BorderSize = 0;
            this.btn_Update_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Role.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_Role.Image = global::VKTIM.Properties.Resources.e_icon_edit_24;
            this.btn_Update_Role.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Update_Role.Location = new System.Drawing.Point(220, 241);
            this.btn_Update_Role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update_Role.Name = "btn_Update_Role";
            this.btn_Update_Role.Size = new System.Drawing.Size(90, 52);
            this.btn_Update_Role.TabIndex = 91;
            this.btn_Update_Role.Text = "Update";
            this.btn_Update_Role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Update_Role.UseVisualStyleBackColor = false;
            this.btn_Update_Role.Click += new System.EventHandler(this.btn_Update_Role_Click);
            // 
            // btn_Add_Role
            // 
            this.btn_Add_Role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Role.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Add_Role.FlatAppearance.BorderSize = 0;
            this.btn_Add_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Role.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Role.Image = global::VKTIM.Properties.Resources.e_icon_add_24;
            this.btn_Add_Role.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add_Role.Location = new System.Drawing.Point(125, 241);
            this.btn_Add_Role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add_Role.Name = "btn_Add_Role";
            this.btn_Add_Role.Size = new System.Drawing.Size(90, 52);
            this.btn_Add_Role.TabIndex = 90;
            this.btn_Add_Role.Text = "Add new";
            this.btn_Add_Role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add_Role.UseVisualStyleBackColor = false;
            this.btn_Add_Role.Click += new System.EventHandler(this.btn_Add_Role_Click);
            // 
            // txt_data_role_description
            // 
            this.txt_data_role_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_role_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_role_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_role_description.Location = new System.Drawing.Point(144, 101);
            this.txt_data_role_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_role_description.Multiline = true;
            this.txt_data_role_description.Name = "txt_data_role_description";
            this.txt_data_role_description.Size = new System.Drawing.Size(166, 78);
            this.txt_data_role_description.TabIndex = 89;
            // 
            // lbl_dis_role_description
            // 
            this.lbl_dis_role_description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_role_description.Location = new System.Drawing.Point(7, 99);
            this.lbl_dis_role_description.Name = "lbl_dis_role_description";
            this.lbl_dis_role_description.Size = new System.Drawing.Size(126, 24);
            this.lbl_dis_role_description.TabIndex = 88;
            this.lbl_dis_role_description.Text = "Description";
            this.lbl_dis_role_description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_role_id
            // 
            this.txt_data_role_id.AccessibleDescription = "";
            this.txt_data_role_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_role_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_data_role_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_role_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_role_id.Location = new System.Drawing.Point(144, 11);
            this.txt_data_role_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_role_id.Name = "txt_data_role_id";
            this.txt_data_role_id.ReadOnly = true;
            this.txt_data_role_id.Size = new System.Drawing.Size(166, 27);
            this.txt_data_role_id.TabIndex = 87;
            // 
            // lbl_dis_role_id
            // 
            this.lbl_dis_role_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_role_id.Location = new System.Drawing.Point(5, 9);
            this.lbl_dis_role_id.Name = "lbl_dis_role_id";
            this.lbl_dis_role_id.Size = new System.Drawing.Size(128, 24);
            this.lbl_dis_role_id.TabIndex = 86;
            this.lbl_dis_role_id.Text = "ID";
            this.lbl_dis_role_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_role_name
            // 
            this.lbl_dis_role_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_role_name.Location = new System.Drawing.Point(5, 54);
            this.lbl_dis_role_name.Name = "lbl_dis_role_name";
            this.lbl_dis_role_name.Size = new System.Drawing.Size(128, 24);
            this.lbl_dis_role_name.TabIndex = 84;
            this.lbl_dis_role_name.Text = "Name";
            this.lbl_dis_role_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_role_name
            // 
            this.txt_data_role_name.AccessibleDescription = "1";
            this.txt_data_role_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_role_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_role_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_role_name.Location = new System.Drawing.Point(144, 56);
            this.txt_data_role_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_role_name.Name = "txt_data_role_name";
            this.txt_data_role_name.Size = new System.Drawing.Size(166, 27);
            this.txt_data_role_name.TabIndex = 85;
            // 
            // gb_dis_users
            // 
            this.gb_dis_users.Controls.Add(this.dgv_data_users);
            this.gb_dis_users.Controls.Add(this.pn_user_control);
            this.gb_dis_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dis_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_dis_users.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gb_dis_users.Location = new System.Drawing.Point(0, 0);
            this.gb_dis_users.Name = "gb_dis_users";
            this.gb_dis_users.Size = new System.Drawing.Size(683, 605);
            this.gb_dis_users.TabIndex = 0;
            this.gb_dis_users.TabStop = false;
            this.gb_dis_users.Text = "Users";
            // 
            // dgv_data_users
            // 
            this.dgv_data_users.AllowUserToAddRows = false;
            this.dgv_data_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_data_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_data_users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_USER_NAME,
            this.col_PASSWORD,
            this.col_IS_BLOCKED,
            this.col_LAST_LOGIN,
            this.col_IP_LOGIN,
            this.col_NUMBER_LOGIN,
            this.col_REMARKS,
            this.col_ROLE_ID});
            this.dgv_data_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data_users.Location = new System.Drawing.Point(3, 23);
            this.dgv_data_users.MultiSelect = false;
            this.dgv_data_users.Name = "dgv_data_users";
            this.dgv_data_users.ReadOnly = true;
            this.dgv_data_users.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_data_users.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data_users.RowTemplate.ReadOnly = true;
            this.dgv_data_users.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_users.Size = new System.Drawing.Size(677, 269);
            this.dgv_data_users.TabIndex = 3;
            this.dgv_data_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_users_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Width = 49;
            // 
            // col_USER_NAME
            // 
            this.col_USER_NAME.DataPropertyName = "USER_NAME";
            this.col_USER_NAME.HeaderText = "Username";
            this.col_USER_NAME.Name = "col_USER_NAME";
            this.col_USER_NAME.ReadOnly = true;
            // 
            // col_PASSWORD
            // 
            this.col_PASSWORD.DataPropertyName = "PASSWORD";
            this.col_PASSWORD.HeaderText = "Password";
            this.col_PASSWORD.Name = "col_PASSWORD";
            this.col_PASSWORD.ReadOnly = true;
            this.col_PASSWORD.Width = 95;
            // 
            // col_IS_BLOCKED
            // 
            this.col_IS_BLOCKED.DataPropertyName = "IS_BLOCKED";
            this.col_IS_BLOCKED.FalseValue = "False";
            this.col_IS_BLOCKED.HeaderText = "Is Blocked";
            this.col_IS_BLOCKED.Name = "col_IS_BLOCKED";
            this.col_IS_BLOCKED.ReadOnly = true;
            this.col_IS_BLOCKED.TrueValue = "True";
            this.col_IS_BLOCKED.Width = 82;
            // 
            // col_LAST_LOGIN
            // 
            this.col_LAST_LOGIN.DataPropertyName = "LAST_LOGIN";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            this.col_LAST_LOGIN.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_LAST_LOGIN.HeaderText = "Last Login";
            this.col_LAST_LOGIN.Name = "col_LAST_LOGIN";
            this.col_LAST_LOGIN.ReadOnly = true;
            this.col_LAST_LOGIN.Width = 101;
            // 
            // col_IP_LOGIN
            // 
            this.col_IP_LOGIN.DataPropertyName = "IP_LOGIN";
            this.col_IP_LOGIN.HeaderText = "IP Login";
            this.col_IP_LOGIN.Name = "col_IP_LOGIN";
            this.col_IP_LOGIN.ReadOnly = true;
            this.col_IP_LOGIN.Width = 87;
            // 
            // col_NUMBER_LOGIN
            // 
            this.col_NUMBER_LOGIN.DataPropertyName = "NUMBER_LOGIN";
            this.col_NUMBER_LOGIN.HeaderText = "Login Count";
            this.col_NUMBER_LOGIN.Name = "col_NUMBER_LOGIN";
            this.col_NUMBER_LOGIN.ReadOnly = true;
            this.col_NUMBER_LOGIN.Width = 114;
            // 
            // col_REMARKS
            // 
            this.col_REMARKS.DataPropertyName = "REMARKS";
            this.col_REMARKS.HeaderText = "Remark";
            this.col_REMARKS.Name = "col_REMARKS";
            this.col_REMARKS.ReadOnly = true;
            this.col_REMARKS.Width = 84;
            // 
            // col_ROLE_ID
            // 
            this.col_ROLE_ID.DataPropertyName = "ROLE_ID";
            this.col_ROLE_ID.HeaderText = "RoleID";
            this.col_ROLE_ID.Name = "col_ROLE_ID";
            this.col_ROLE_ID.ReadOnly = true;
            this.col_ROLE_ID.Visible = false;
            this.col_ROLE_ID.Width = 79;
            // 
            // pn_user_control
            // 
            this.pn_user_control.BackColor = System.Drawing.Color.White;
            this.pn_user_control.Controls.Add(this.btn_Update_User);
            this.pn_user_control.Controls.Add(this.btn_Delete_User);
            this.pn_user_control.Controls.Add(this.btn_Add_User);
            this.pn_user_control.Controls.Add(this.txt_data_user_remark);
            this.pn_user_control.Controls.Add(this.lbl_dis_user_remark);
            this.pn_user_control.Controls.Add(this.lbl_dis_user_role);
            this.pn_user_control.Controls.Add(this.chk_data_user_is_blocked);
            this.pn_user_control.Controls.Add(this.cmb_data_user_roles);
            this.pn_user_control.Controls.Add(this.txt_data_user_pass);
            this.pn_user_control.Controls.Add(this.lbl_dis_user_pass);
            this.pn_user_control.Controls.Add(this.txt_data_user_id);
            this.pn_user_control.Controls.Add(this.lbl_dis_user_id);
            this.pn_user_control.Controls.Add(this.lbl_dis_user_name);
            this.pn_user_control.Controls.Add(this.txt_data_user_name);
            this.pn_user_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_user_control.Location = new System.Drawing.Point(3, 292);
            this.pn_user_control.Name = "pn_user_control";
            this.pn_user_control.Size = new System.Drawing.Size(677, 310);
            this.pn_user_control.TabIndex = 1;
            // 
            // btn_Update_User
            // 
            this.btn_Update_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Update_User.FlatAppearance.BorderSize = 0;
            this.btn_Update_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_User.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_User.Image = global::VKTIM.Properties.Resources.e_icon_edit_24;
            this.btn_Update_User.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Update_User.Location = new System.Drawing.Point(512, 92);
            this.btn_Update_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update_User.Name = "btn_Update_User";
            this.btn_Update_User.Size = new System.Drawing.Size(90, 52);
            this.btn_Update_User.TabIndex = 116;
            this.btn_Update_User.Text = "Update";
            this.btn_Update_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Update_User.UseVisualStyleBackColor = false;
            this.btn_Update_User.Click += new System.EventHandler(this.btn_Update_User_Click);
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete_User.FlatAppearance.BorderSize = 0;
            this.btn_Delete_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete_User.Image = global::VKTIM.Properties.Resources.e_icon_del2_24;
            this.btn_Delete_User.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Delete_User.Location = new System.Drawing.Point(512, 170);
            this.btn_Delete_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(90, 52);
            this.btn_Delete_User.TabIndex = 118;
            this.btn_Delete_User.Text = "Delete";
            this.btn_Delete_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_User.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Add_User.FlatAppearance.BorderSize = 0;
            this.btn_Add_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_User.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_User.Image = global::VKTIM.Properties.Resources.e_icon_add_24;
            this.btn_Add_User.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add_User.Location = new System.Drawing.Point(512, 14);
            this.btn_Add_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(90, 52);
            this.btn_Add_User.TabIndex = 115;
            this.btn_Add_User.Text = "Add new";
            this.btn_Add_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add_User.UseVisualStyleBackColor = false;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // txt_data_user_remark
            // 
            this.txt_data_user_remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_user_remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_user_remark.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_user_remark.Location = new System.Drawing.Point(165, 243);
            this.txt_data_user_remark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_user_remark.Name = "txt_data_user_remark";
            this.txt_data_user_remark.Size = new System.Drawing.Size(315, 27);
            this.txt_data_user_remark.TabIndex = 114;
            // 
            // lbl_dis_user_remark
            // 
            this.lbl_dis_user_remark.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_user_remark.Location = new System.Drawing.Point(28, 241);
            this.lbl_dis_user_remark.Name = "lbl_dis_user_remark";
            this.lbl_dis_user_remark.Size = new System.Drawing.Size(126, 24);
            this.lbl_dis_user_remark.TabIndex = 113;
            this.lbl_dis_user_remark.Text = "Remark";
            this.lbl_dis_user_remark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_user_role
            // 
            this.lbl_dis_user_role.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_user_role.Location = new System.Drawing.Point(28, 198);
            this.lbl_dis_user_role.Name = "lbl_dis_user_role";
            this.lbl_dis_user_role.Size = new System.Drawing.Size(126, 24);
            this.lbl_dis_user_role.TabIndex = 112;
            this.lbl_dis_user_role.Text = "Role";
            this.lbl_dis_user_role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk_data_user_is_blocked
            // 
            this.chk_data_user_is_blocked.AutoSize = true;
            this.chk_data_user_is_blocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_data_user_is_blocked.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chk_data_user_is_blocked.Location = new System.Drawing.Point(165, 155);
            this.chk_data_user_is_blocked.Name = "chk_data_user_is_blocked";
            this.chk_data_user_is_blocked.Size = new System.Drawing.Size(78, 24);
            this.chk_data_user_is_blocked.TabIndex = 111;
            this.chk_data_user_is_blocked.Text = "Blocked";
            this.chk_data_user_is_blocked.UseVisualStyleBackColor = true;
            // 
            // cmb_data_user_roles
            // 
            this.cmb_data_user_roles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_data_user_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_data_user_roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_data_user_roles.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmb_data_user_roles.FormattingEnabled = true;
            this.cmb_data_user_roles.Location = new System.Drawing.Point(165, 197);
            this.cmb_data_user_roles.Name = "cmb_data_user_roles";
            this.cmb_data_user_roles.Size = new System.Drawing.Size(313, 28);
            this.cmb_data_user_roles.TabIndex = 110;
            // 
            // txt_data_user_pass
            // 
            this.txt_data_user_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_user_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_user_pass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_user_pass.Location = new System.Drawing.Point(165, 104);
            this.txt_data_user_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_user_pass.Name = "txt_data_user_pass";
            this.txt_data_user_pass.Size = new System.Drawing.Size(315, 27);
            this.txt_data_user_pass.TabIndex = 95;
            // 
            // lbl_dis_user_pass
            // 
            this.lbl_dis_user_pass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_user_pass.Location = new System.Drawing.Point(28, 102);
            this.lbl_dis_user_pass.Name = "lbl_dis_user_pass";
            this.lbl_dis_user_pass.Size = new System.Drawing.Size(126, 24);
            this.lbl_dis_user_pass.TabIndex = 94;
            this.lbl_dis_user_pass.Text = "Password";
            this.lbl_dis_user_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_user_id
            // 
            this.txt_data_user_id.AccessibleDescription = "";
            this.txt_data_user_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_user_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_data_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_user_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_user_id.Location = new System.Drawing.Point(165, 14);
            this.txt_data_user_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_user_id.Name = "txt_data_user_id";
            this.txt_data_user_id.ReadOnly = true;
            this.txt_data_user_id.Size = new System.Drawing.Size(315, 27);
            this.txt_data_user_id.TabIndex = 93;
            // 
            // lbl_dis_user_id
            // 
            this.lbl_dis_user_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_user_id.Location = new System.Drawing.Point(26, 12);
            this.lbl_dis_user_id.Name = "lbl_dis_user_id";
            this.lbl_dis_user_id.Size = new System.Drawing.Size(128, 24);
            this.lbl_dis_user_id.TabIndex = 92;
            this.lbl_dis_user_id.Text = "ID";
            this.lbl_dis_user_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_user_name
            // 
            this.lbl_dis_user_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_user_name.Location = new System.Drawing.Point(26, 57);
            this.lbl_dis_user_name.Name = "lbl_dis_user_name";
            this.lbl_dis_user_name.Size = new System.Drawing.Size(128, 24);
            this.lbl_dis_user_name.TabIndex = 90;
            this.lbl_dis_user_name.Text = "Username";
            this.lbl_dis_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_user_name
            // 
            this.txt_data_user_name.AccessibleDescription = "1";
            this.txt_data_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_user_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_user_name.Location = new System.Drawing.Point(165, 59);
            this.txt_data_user_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_user_name.Name = "txt_data_user_name";
            this.txt_data_user_name.Size = new System.Drawing.Size(315, 27);
            this.txt_data_user_name.TabIndex = 91;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 666);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.pn_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.split_dis_main.Panel1.ResumeLayout(false);
            this.split_dis_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_dis_main)).EndInit();
            this.split_dis_main.ResumeLayout(false);
            this.gb_dis_role.ResumeLayout(false);
            this.pn_role_control.ResumeLayout(false);
            this.pn_role_control.PerformLayout();
            this.gb_dis_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_users)).EndInit();
            this.pn_user_control.ResumeLayout(false);
            this.pn_user_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split_dis_main;
        private System.Windows.Forms.GroupBox gb_dis_role;
        private System.Windows.Forms.TreeView tv_data_role;
        private System.Windows.Forms.Panel pn_role_control;
        private System.Windows.Forms.GroupBox gb_dis_users;
        private System.Windows.Forms.Panel pn_user_control;
        private System.Windows.Forms.DataGridView dgv_data_users;
        public System.Windows.Forms.TextBox txt_data_role_description;
        private System.Windows.Forms.Label lbl_dis_role_description;
        public System.Windows.Forms.TextBox txt_data_role_id;
        private System.Windows.Forms.Label lbl_dis_role_id;
        private System.Windows.Forms.Label lbl_dis_role_name;
        public System.Windows.Forms.TextBox txt_data_role_name;
        private System.Windows.Forms.Button btn_Update_Role;
        private System.Windows.Forms.Button btn_Add_Role;
        public System.Windows.Forms.TextBox txt_data_user_pass;
        private System.Windows.Forms.Label lbl_dis_user_pass;
        public System.Windows.Forms.TextBox txt_data_user_id;
        private System.Windows.Forms.Label lbl_dis_user_id;
        private System.Windows.Forms.Label lbl_dis_user_name;
        public System.Windows.Forms.TextBox txt_data_user_name;
        public System.Windows.Forms.CheckBox chk_data_user_is_blocked;
        public System.Windows.Forms.ComboBox cmb_data_user_roles;
        private System.Windows.Forms.Label lbl_dis_user_role;
        public System.Windows.Forms.TextBox txt_data_user_remark;
        private System.Windows.Forms.Label lbl_dis_user_remark;
        private System.Windows.Forms.Button btn_Update_User;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Button btn_Add_User;
        public System.Windows.Forms.CheckBox chk_data_role_is_default;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PASSWORD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_IS_BLOCKED;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LAST_LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IP_LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NUMBER_LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_REMARKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ROLE_ID;
    }
}
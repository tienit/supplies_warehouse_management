namespace VKTIM
{
    partial class CommonFormAdminOrigin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_TOP = new System.Windows.Forms.Panel();
            this.btn_Maximized = new System.Windows.Forms.Button();
            this.btn_Minimized = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pic_Header = new System.Windows.Forms.PictureBox();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.pn_Border_Top = new System.Windows.Forms.Panel();
            this.pn_Border_Left = new System.Windows.Forms.Panel();
            this.pn_Border_Right = new System.Windows.Forms.Panel();
            this.pn_Border_Bottom = new System.Windows.Forms.Panel();
            this.pn_Form = new System.Windows.Forms.Panel();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.lbl_dis_count = new System.Windows.Forms.Label();
            this.lbl_data_count = new System.Windows.Forms.Label();
            this.pn_Control = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_data_keyword = new System.Windows.Forms.TextBox();
            this.btn_Export_Excel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.lbl_dis_keyword = new System.Windows.Forms.Label();
            this.mainHelp = new System.Windows.Forms.HelpProvider();
            this.mainError = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainTip = new System.Windows.Forms.ToolTip(this.components);
            this.pn_TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.pn_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_TOP
            // 
            this.pn_TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pn_TOP.BackgroundImage = global::VKTIM.Properties.Resources.e_titlebar_blue2;
            this.pn_TOP.Controls.Add(this.btn_Maximized);
            this.pn_TOP.Controls.Add(this.btn_Minimized);
            this.pn_TOP.Controls.Add(this.btn_Help);
            this.pn_TOP.Controls.Add(this.btn_Close);
            this.pn_TOP.Controls.Add(this.pic_Header);
            this.pn_TOP.Controls.Add(this.lbl_FormTitle);
            this.pn_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_TOP.Location = new System.Drawing.Point(0, 0);
            this.pn_TOP.Name = "pn_TOP";
            this.pn_TOP.Size = new System.Drawing.Size(878, 45);
            this.pn_TOP.TabIndex = 51;
            this.pn_TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_TOP_MouseDown);
            // 
            // btn_Maximized
            // 
            this.btn_Maximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximized.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximized.BackgroundImage = global::VKTIM.Properties.Resources.e_maximized_32;
            this.btn_Maximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maximized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Maximized.FlatAppearance.BorderSize = 0;
            this.btn_Maximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Maximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Maximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximized.Location = new System.Drawing.Point(802, 7);
            this.btn_Maximized.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximized.Name = "btn_Maximized";
            this.btn_Maximized.Size = new System.Drawing.Size(32, 32);
            this.btn_Maximized.TabIndex = 29;
            this.btn_Maximized.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Maximized, "Maximized");
            this.btn_Maximized.UseVisualStyleBackColor = false;
            this.btn_Maximized.Click += new System.EventHandler(this.bt_Maximized_Click);
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimized.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.BackgroundImage = global::VKTIM.Properties.Resources.e_minimized_32;
            this.btn_Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.Location = new System.Drawing.Point(768, 7);
            this.btn_Minimized.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(32, 32);
            this.btn_Minimized.TabIndex = 28;
            this.btn_Minimized.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Minimized, "Minimized");
            this.btn_Minimized.UseVisualStyleBackColor = false;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImage = global::VKTIM.Properties.Resources.e_help_32;
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Location = new System.Drawing.Point(734, 7);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(32, 32);
            this.btn_Help.TabIndex = 27;
            this.btn_Help.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Help, "Help");
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::VKTIM.Properties.Resources.e_close_32;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(836, 7);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 32);
            this.btn_Close.TabIndex = 26;
            this.btn_Close.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Close, "Close");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pic_Header
            // 
            this.pic_Header.BackColor = System.Drawing.Color.Transparent;
            this.pic_Header.Image = global::VKTIM.Properties.Resources.e_logo_64;
            this.pic_Header.Location = new System.Drawing.Point(3, 7);
            this.pic_Header.Name = "pic_Header";
            this.pic_Header.Size = new System.Drawing.Size(32, 32);
            this.pic_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Header.TabIndex = 25;
            this.pic_Header.TabStop = false;
            this.mainTip.SetToolTip(this.pic_Header, "VKT Inventory Management System");
            this.pic_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Header_MouseDown);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_FormTitle.Location = new System.Drawing.Point(40, 4);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(691, 37);
            this.lbl_FormTitle.TabIndex = 24;
            this.lbl_FormTitle.Text = "Common Form Admin";
            this.lbl_FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_FormTitle_MouseDown);
            // 
            // pn_Border_Top
            // 
            this.pn_Border_Top.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Border_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Border_Top.Name = "pn_Border_Top";
            this.pn_Border_Top.Size = new System.Drawing.Size(880, 1);
            this.pn_Border_Top.TabIndex = 52;
            // 
            // pn_Border_Left
            // 
            this.pn_Border_Left.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Border_Left.Location = new System.Drawing.Point(0, 1);
            this.pn_Border_Left.Name = "pn_Border_Left";
            this.pn_Border_Left.Size = new System.Drawing.Size(1, 549);
            this.pn_Border_Left.TabIndex = 53;
            // 
            // pn_Border_Right
            // 
            this.pn_Border_Right.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_Border_Right.Location = new System.Drawing.Point(879, 1);
            this.pn_Border_Right.Name = "pn_Border_Right";
            this.pn_Border_Right.Size = new System.Drawing.Size(1, 549);
            this.pn_Border_Right.TabIndex = 54;
            // 
            // pn_Border_Bottom
            // 
            this.pn_Border_Bottom.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Border_Bottom.Location = new System.Drawing.Point(1, 549);
            this.pn_Border_Bottom.Name = "pn_Border_Bottom";
            this.pn_Border_Bottom.Size = new System.Drawing.Size(878, 1);
            this.pn_Border_Bottom.TabIndex = 55;
            // 
            // pn_Form
            // 
            this.pn_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Form.BackColor = System.Drawing.Color.Transparent;
            this.pn_Form.Controls.Add(this.dgv_Data);
            this.pn_Form.Controls.Add(this.lbl_dis_count);
            this.pn_Form.Controls.Add(this.lbl_data_count);
            this.pn_Form.Controls.Add(this.pn_Control);
            this.pn_Form.Controls.Add(this.pn_TOP);
            this.pn_Form.Location = new System.Drawing.Point(1, 1);
            this.pn_Form.Name = "pn_Form";
            this.pn_Form.Size = new System.Drawing.Size(878, 534);
            this.pn_Form.TabIndex = 56;
            this.pn_Form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Form_MouseDown);
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.EnableHeadersVisualStyles = false;
            this.dgv_Data.Location = new System.Drawing.Point(13, 166);
            this.dgv_Data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Data.MultiSelect = false;
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Data.RowTemplate.ReadOnly = true;
            this.dgv_Data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(855, 352);
            this.dgv_Data.TabIndex = 61;
            // 
            // lbl_dis_count
            // 
            this.lbl_dis_count.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_dis_count.Location = new System.Drawing.Point(24, 136);
            this.lbl_dis_count.Name = "lbl_dis_count";
            this.lbl_dis_count.Size = new System.Drawing.Size(123, 25);
            this.lbl_dis_count.TabIndex = 60;
            this.lbl_dis_count.Text = "Quantity:";
            this.lbl_dis_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_data_count
            // 
            this.lbl_data_count.AutoSize = true;
            this.lbl_data_count.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_data_count.Location = new System.Drawing.Point(153, 140);
            this.lbl_data_count.Name = "lbl_data_count";
            this.lbl_data_count.Size = new System.Drawing.Size(17, 19);
            this.lbl_data_count.TabIndex = 59;
            this.lbl_data_count.Text = "0";
            // 
            // pn_Control
            // 
            this.pn_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Control.BackColor = System.Drawing.Color.White;
            this.pn_Control.Controls.Add(this.btn_Update);
            this.pn_Control.Controls.Add(this.btn_Delete);
            this.pn_Control.Controls.Add(this.btn_Add);
            this.pn_Control.Controls.Add(this.txt_data_keyword);
            this.pn_Control.Controls.Add(this.btn_Export_Excel);
            this.pn_Control.Controls.Add(this.btn_Search);
            this.pn_Control.Controls.Add(this.btn_Print);
            this.pn_Control.Controls.Add(this.lbl_dis_keyword);
            this.pn_Control.Location = new System.Drawing.Point(3, 49);
            this.pn_Control.Name = "pn_Control";
            this.pn_Control.Size = new System.Drawing.Size(872, 75);
            this.pn_Control.TabIndex = 58;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Image = global::VKTIM.Properties.Resources.e_icon_edit_24;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Update.Location = new System.Drawing.Point(488, 11);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(90, 52);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = global::VKTIM.Properties.Resources.e_icon_del2_24;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Delete.Location = new System.Drawing.Point(583, 11);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(90, 52);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Image = global::VKTIM.Properties.Resources.e_icon_add_24;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(393, 11);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 52);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add new";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // txt_data_keyword
            // 
            this.txt_data_keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_keyword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_keyword.Location = new System.Drawing.Point(113, 18);
            this.txt_data_keyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_keyword.Name = "txt_data_keyword";
            this.txt_data_keyword.Size = new System.Drawing.Size(151, 35);
            this.txt_data_keyword.TabIndex = 3;
            // 
            // btn_Export_Excel
            // 
            this.btn_Export_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export_Excel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Export_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Export_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export_Excel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export_Excel.ForeColor = System.Drawing.Color.Black;
            this.btn_Export_Excel.Image = global::VKTIM.Properties.Resources.e_icon_excel_24;
            this.btn_Export_Excel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Export_Excel.Location = new System.Drawing.Point(678, 11);
            this.btn_Export_Excel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Export_Excel.Name = "btn_Export_Excel";
            this.btn_Export_Excel.Size = new System.Drawing.Size(90, 52);
            this.btn_Export_Excel.TabIndex = 58;
            this.btn_Export_Excel.Text = "Export excel";
            this.btn_Export_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Export_Excel.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Image = global::VKTIM.Properties.Resources.e_icon_search_24;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search.Location = new System.Drawing.Point(271, 11);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 52);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.Black;
            this.btn_Print.Image = global::VKTIM.Properties.Resources.e_icon_printer_24;
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Print.Location = new System.Drawing.Point(773, 11);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(90, 52);
            this.btn_Print.TabIndex = 59;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Print.UseVisualStyleBackColor = false;
            // 
            // lbl_dis_keyword
            // 
            this.lbl_dis_keyword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_dis_keyword.Location = new System.Drawing.Point(7, 19);
            this.lbl_dis_keyword.Name = "lbl_dis_keyword";
            this.lbl_dis_keyword.Size = new System.Drawing.Size(100, 34);
            this.lbl_dis_keyword.TabIndex = 2;
            this.lbl_dis_keyword.Text = "Keyword";
            this.lbl_dis_keyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainHelp
            // 
            this.mainHelp.HelpNamespace = "Help\\vktim_help.chm";
            // 
            // mainError
            // 
            this.mainError.ContainerControl = this;
            // 
            // CommonFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.pn_Form);
            this.Controls.Add(this.pn_Border_Bottom);
            this.Controls.Add(this.pn_Border_Right);
            this.Controls.Add(this.pn_Border_Left);
            this.Controls.Add(this.pn_Border_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "CommonFormAdminOrigin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonFormAdminOrigin";
            this.Load += new System.EventHandler(this.CommonFormAdminOrigin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommonFormAdminOrigin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonForm_MouseDown);
            this.pn_TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.pn_Control.ResumeLayout(false);
            this.pn_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_TOP;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pn_Border_Top;
        private System.Windows.Forms.Panel pn_Border_Left;
        private System.Windows.Forms.Panel pn_Border_Right;
        private System.Windows.Forms.Panel pn_Border_Bottom;
        protected System.Windows.Forms.Panel pn_Form;
        protected System.Windows.Forms.Label lbl_FormTitle;
        protected System.Windows.Forms.PictureBox pic_Header;
        private System.Windows.Forms.Button btn_Minimized;
        private System.Windows.Forms.Button btn_Maximized;
        protected System.Windows.Forms.HelpProvider mainHelp;
        protected System.Windows.Forms.ErrorProvider mainError;
        protected System.Windows.Forms.ToolTip mainTip;
        private System.Windows.Forms.Label lbl_dis_count;
        private System.Windows.Forms.Panel pn_Control;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_data_keyword;
        private System.Windows.Forms.Button btn_Export_Excel;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label lbl_dis_keyword;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Label lbl_data_count;
    }
}
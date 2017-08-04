namespace VKTIM
{
    partial class frmConnectionSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectionSetting));
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.txt_data_username = new System.Windows.Forms.TextBox();
            this.txt_data_server = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.lbl_dis_server = new System.Windows.Forms.Label();
            this.lbl_dis_username = new System.Windows.Forms.Label();
            this.txt_data_database = new System.Windows.Forms.TextBox();
            this.txt_data_password = new System.Windows.Forms.TextBox();
            this.lbl_dis_password = new System.Windows.Forms.Label();
            this.lbl_dis_database = new System.Windows.Forms.Label();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.txt_data_database);
            this.pn_Form.Controls.Add(this.txt_data_password);
            this.pn_Form.Controls.Add(this.lbl_dis_password);
            this.pn_Form.Controls.Add(this.lbl_dis_database);
            this.pn_Form.Controls.Add(this.picLoading);
            this.pn_Form.Controls.Add(this.txt_data_username);
            this.pn_Form.Controls.Add(this.txt_data_server);
            this.pn_Form.Controls.Add(this.btn_Save);
            this.pn_Form.Controls.Add(this.btn_Test);
            this.pn_Form.Controls.Add(this.lbl_dis_server);
            this.pn_Form.Controls.Add(this.lbl_dis_username);
            this.pn_Form.Size = new System.Drawing.Size(548, 357);
            this.pn_Form.TabIndex = 0;
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_username, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_server, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Test, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Save, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_server, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_username, 0);
            this.pn_Form.Controls.SetChildIndex(this.picLoading, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_database, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_password, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_password, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_database, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(361, 37);
            this.lbl_FormTitle.TabIndex = 0;
            this.lbl_FormTitle.Text = "";
            // 
            // picLoading
            // 
            this.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoading.Image = global::VKTIM.Properties.Resources.e_icon_loading;
            this.picLoading.Location = new System.Drawing.Point(180, 275);
            this.picLoading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(32, 38);
            this.picLoading.TabIndex = 94;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // txt_data_username
            // 
            this.txt_data_username.AccessibleDescription = "1";
            this.txt_data_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_username.Location = new System.Drawing.Point(218, 120);
            this.txt_data_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_username.Name = "txt_data_username";
            this.txt_data_username.Size = new System.Drawing.Size(254, 27);
            this.txt_data_username.TabIndex = 3;
            // 
            // txt_data_server
            // 
            this.txt_data_server.AccessibleDescription = "1";
            this.txt_data_server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_server.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_server.Location = new System.Drawing.Point(218, 75);
            this.txt_data_server.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_server.Name = "txt_data_server";
            this.txt_data_server.Size = new System.Drawing.Size(254, 27);
            this.txt_data_server.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(352, 273);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 40);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Test.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_Test.ForeColor = System.Drawing.Color.White;
            this.btn_Test.Location = new System.Drawing.Point(218, 273);
            this.btn_Test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(120, 40);
            this.btn_Test.TabIndex = 8;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // lbl_dis_server
            // 
            this.lbl_dis_server.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_server.Location = new System.Drawing.Point(49, 75);
            this.lbl_dis_server.Name = "lbl_dis_server";
            this.lbl_dis_server.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_server.TabIndex = 0;
            this.lbl_dis_server.Text = "Server";
            this.lbl_dis_server.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_username
            // 
            this.lbl_dis_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_username.Location = new System.Drawing.Point(49, 120);
            this.lbl_dis_username.Name = "lbl_dis_username";
            this.lbl_dis_username.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_username.TabIndex = 2;
            this.lbl_dis_username.Text = "Username";
            this.lbl_dis_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_database
            // 
            this.txt_data_database.AccessibleDescription = "1";
            this.txt_data_database.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_database.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_database.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_database.Location = new System.Drawing.Point(218, 214);
            this.txt_data_database.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_database.Name = "txt_data_database";
            this.txt_data_database.Size = new System.Drawing.Size(254, 27);
            this.txt_data_database.TabIndex = 7;
            // 
            // txt_data_password
            // 
            this.txt_data_password.AccessibleDescription = "1";
            this.txt_data_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_password.Location = new System.Drawing.Point(218, 169);
            this.txt_data_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_password.Name = "txt_data_password";
            this.txt_data_password.PasswordChar = '*';
            this.txt_data_password.Size = new System.Drawing.Size(254, 27);
            this.txt_data_password.TabIndex = 5;
            // 
            // lbl_dis_password
            // 
            this.lbl_dis_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_password.Location = new System.Drawing.Point(49, 169);
            this.lbl_dis_password.Name = "lbl_dis_password";
            this.lbl_dis_password.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_password.TabIndex = 4;
            this.lbl_dis_password.Text = "Password";
            this.lbl_dis_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_database
            // 
            this.lbl_dis_database.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_database.Location = new System.Drawing.Point(49, 214);
            this.lbl_dis_database.Name = "lbl_dis_database";
            this.lbl_dis_database.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_database.TabIndex = 6;
            this.lbl_dis_database.Text = "Database";
            this.lbl_dis_database.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmConnectionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 373);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmConnectionSetting";
            this.Text = "frmConnectionSetting";
            this.Load += new System.EventHandler(this.frmConnectionSetting_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txt_data_database;
        public System.Windows.Forms.TextBox txt_data_password;
        private System.Windows.Forms.Label lbl_dis_password;
        private System.Windows.Forms.Label lbl_dis_database;
        private System.Windows.Forms.PictureBox picLoading;
        public System.Windows.Forms.TextBox txt_data_username;
        public System.Windows.Forms.TextBox txt_data_server;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Label lbl_dis_server;
        private System.Windows.Forms.Label lbl_dis_username;
    }
}
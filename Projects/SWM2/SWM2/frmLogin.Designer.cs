namespace VKTIM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txt_data_password = new System.Windows.Forms.TextBox();
            this.txt_data_username = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_dis_username = new System.Windows.Forms.Label();
            this.lbl_dis_password = new System.Windows.Forms.Label();
            this.lbl_dis_error = new System.Windows.Forms.Label();
            this.bwMain = new System.ComponentModel.BackgroundWorker();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.picLoading);
            this.pn_Form.Controls.Add(this.lbl_dis_error);
            this.pn_Form.Controls.Add(this.txt_data_password);
            this.pn_Form.Controls.Add(this.txt_data_username);
            this.pn_Form.Controls.Add(this.btn_Cancel);
            this.pn_Form.Controls.Add(this.btn_Submit);
            this.pn_Form.Controls.Add(this.lbl_dis_username);
            this.pn_Form.Controls.Add(this.lbl_dis_password);
            this.pn_Form.Size = new System.Drawing.Size(498, 270);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_password, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_username, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Submit, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_username, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_password, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_error, 0);
            this.pn_Form.Controls.SetChildIndex(this.picLoading, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(311, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // txt_data_password
            // 
            this.txt_data_password.AccessibleDescription = "1";
            this.txt_data_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_password.Location = new System.Drawing.Point(180, 123);
            this.txt_data_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_password.Name = "txt_data_password";
            this.txt_data_password.PasswordChar = '*';
            this.txt_data_password.Size = new System.Drawing.Size(254, 27);
            this.txt_data_password.TabIndex = 85;
            // 
            // txt_data_username
            // 
            this.txt_data_username.AccessibleDescription = "1";
            this.txt_data_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_username.Location = new System.Drawing.Point(180, 78);
            this.txt_data_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_username.Name = "txt_data_username";
            this.txt_data_username.Size = new System.Drawing.Size(254, 27);
            this.txt_data_username.TabIndex = 83;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(314, 184);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 40);
            this.btn_Cancel.TabIndex = 81;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(72)))));
            this.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(180, 184);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(120, 40);
            this.btn_Submit.TabIndex = 80;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_dis_username
            // 
            this.lbl_dis_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_username.Location = new System.Drawing.Point(11, 78);
            this.lbl_dis_username.Name = "lbl_dis_username";
            this.lbl_dis_username.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_username.TabIndex = 82;
            this.lbl_dis_username.Text = "Username";
            this.lbl_dis_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_password
            // 
            this.lbl_dis_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_password.Location = new System.Drawing.Point(11, 123);
            this.lbl_dis_password.Name = "lbl_dis_password";
            this.lbl_dis_password.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_password.TabIndex = 84;
            this.lbl_dis_password.Text = "Password";
            this.lbl_dis_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dis_error
            // 
            this.lbl_dis_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_dis_error.AutoSize = true;
            this.lbl_dis_error.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_dis_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_dis_error.Location = new System.Drawing.Point(177, 239);
            this.lbl_dis_error.Name = "lbl_dis_error";
            this.lbl_dis_error.Size = new System.Drawing.Size(51, 15);
            this.lbl_dis_error.TabIndex = 86;
            this.lbl_dis_error.Text = "[ERROR]";
            // 
            // bwMain
            // 
            this.bwMain.WorkerReportsProgress = true;
            this.bwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMain_DoWork);
            this.bwMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMain_ProgressChanged);
            this.bwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMain_RunWorkerCompleted);
            // 
            // picLoading
            // 
            this.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoading.Image = global::VKTIM.Properties.Resources.e_icon_loading;
            this.picLoading.Location = new System.Drawing.Point(142, 184);
            this.picLoading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(32, 38);
            this.picLoading.TabIndex = 87;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 286);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txt_data_password;
        public System.Windows.Forms.TextBox txt_data_username;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_dis_username;
        private System.Windows.Forms.Label lbl_dis_password;
        private System.Windows.Forms.Label lbl_dis_error;
        private System.ComponentModel.BackgroundWorker bwMain;
        private System.Windows.Forms.PictureBox picLoading;
    }
}
namespace VKTIM
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.txt_data_password_current = new System.Windows.Forms.TextBox();
            this.lbl_dis_password_current = new System.Windows.Forms.Label();
            this.txt_data_username = new System.Windows.Forms.TextBox();
            this.lbl_dis_username = new System.Windows.Forms.Label();
            this.txt_data_password_new = new System.Windows.Forms.TextBox();
            this.lbl_dis_password_new = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.btn_Cancel);
            this.pn_Form.Controls.Add(this.btn_Submit);
            this.pn_Form.Controls.Add(this.txt_data_password_new);
            this.pn_Form.Controls.Add(this.lbl_dis_password_new);
            this.pn_Form.Controls.Add(this.txt_data_password_current);
            this.pn_Form.Controls.Add(this.lbl_dis_password_current);
            this.pn_Form.Controls.Add(this.txt_data_username);
            this.pn_Form.Controls.Add(this.lbl_dis_username);
            this.pn_Form.Size = new System.Drawing.Size(498, 281);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_username, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_username, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_password_current, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_password_current, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_password_new, 0);
            this.pn_Form.Controls.SetChildIndex(this.txt_data_password_new, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Submit, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Cancel, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(311, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // txt_data_password_current
            // 
            this.txt_data_password_current.AccessibleDescription = "1";
            this.txt_data_password_current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_password_current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_password_current.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_password_current.Location = new System.Drawing.Point(201, 120);
            this.txt_data_password_current.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_password_current.Name = "txt_data_password_current";
            this.txt_data_password_current.PasswordChar = '*';
            this.txt_data_password_current.Size = new System.Drawing.Size(254, 27);
            this.txt_data_password_current.TabIndex = 100;
            // 
            // lbl_dis_password_current
            // 
            this.lbl_dis_password_current.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_password_current.Location = new System.Drawing.Point(32, 120);
            this.lbl_dis_password_current.Name = "lbl_dis_password_current";
            this.lbl_dis_password_current.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_password_current.TabIndex = 99;
            this.lbl_dis_password_current.Text = "Current password";
            this.lbl_dis_password_current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_username
            // 
            this.txt_data_username.AccessibleDescription = "";
            this.txt_data_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_username.Location = new System.Drawing.Point(201, 71);
            this.txt_data_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_username.Name = "txt_data_username";
            this.txt_data_username.ReadOnly = true;
            this.txt_data_username.Size = new System.Drawing.Size(254, 27);
            this.txt_data_username.TabIndex = 98;
            // 
            // lbl_dis_username
            // 
            this.lbl_dis_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_username.Location = new System.Drawing.Point(32, 71);
            this.lbl_dis_username.Name = "lbl_dis_username";
            this.lbl_dis_username.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_username.TabIndex = 97;
            this.lbl_dis_username.Text = "Username";
            this.lbl_dis_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_data_password_new
            // 
            this.txt_data_password_new.AccessibleDescription = "1";
            this.txt_data_password_new.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_data_password_new.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_data_password_new.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_password_new.Location = new System.Drawing.Point(201, 166);
            this.txt_data_password_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_data_password_new.Name = "txt_data_password_new";
            this.txt_data_password_new.PasswordChar = '*';
            this.txt_data_password_new.Size = new System.Drawing.Size(254, 27);
            this.txt_data_password_new.TabIndex = 102;
            // 
            // lbl_dis_password_new
            // 
            this.lbl_dis_password_new.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_password_new.Location = new System.Drawing.Point(32, 166);
            this.lbl_dis_password_new.Name = "lbl_dis_password_new";
            this.lbl_dis_password_new.Size = new System.Drawing.Size(163, 24);
            this.lbl_dis_password_new.TabIndex = 101;
            this.lbl_dis_password_new.Text = "New password";
            this.lbl_dis_password_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(335, 216);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 35);
            this.btn_Cancel.TabIndex = 104;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(111)))), ((int)(((byte)(19)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(201, 216);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(120, 35);
            this.btn_Submit.TabIndex = 103;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 297);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmChangePass";
            this.Text = "frmChangePass";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txt_data_password_new;
        private System.Windows.Forms.Label lbl_dis_password_new;
        public System.Windows.Forms.TextBox txt_data_password_current;
        private System.Windows.Forms.Label lbl_dis_password_current;
        public System.Windows.Forms.TextBox txt_data_username;
        private System.Windows.Forms.Label lbl_dis_username;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
    }
}
namespace VKTIM
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            this.lbl_dis_name = new System.Windows.Forms.Label();
            this.lbl_dis_version = new System.Windows.Forms.Label();
            this.lbl_dis_copy_right = new System.Windows.Forms.Label();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.lbl_dis_copy_right);
            this.pn_Form.Controls.Add(this.lbl_dis_version);
            this.pn_Form.Controls.Add(this.lbl_dis_name);
            this.pn_Form.Controls.Add(this.pic_Icon);
            this.pn_Form.Size = new System.Drawing.Size(528, 244);
            this.pn_Form.Controls.SetChildIndex(this.pic_Icon, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_name, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_version, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_copy_right, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(341, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // pic_Icon
            // 
            this.pic_Icon.Image = global::VKTIM.Properties.Resources.e_icon_warehouse_256;
            this.pic_Icon.Location = new System.Drawing.Point(11, 70);
            this.pic_Icon.Name = "pic_Icon";
            this.pic_Icon.Size = new System.Drawing.Size(147, 147);
            this.pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Icon.TabIndex = 52;
            this.pic_Icon.TabStop = false;
            // 
            // lbl_dis_name
            // 
            this.lbl_dis_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_name.ForeColor = System.Drawing.Color.White;
            this.lbl_dis_name.Location = new System.Drawing.Point(180, 74);
            this.lbl_dis_name.Name = "lbl_dis_name";
            this.lbl_dis_name.Size = new System.Drawing.Size(322, 66);
            this.lbl_dis_name.TabIndex = 53;
            this.lbl_dis_name.Text = "HỆ THỐNG QUẢN LÝ KHO/VẬT TƯ\r\nVIỆN KỸ THUẬT PK-KQ";
            this.lbl_dis_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dis_version
            // 
            this.lbl_dis_version.AutoSize = true;
            this.lbl_dis_version.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_dis_version.ForeColor = System.Drawing.Color.White;
            this.lbl_dis_version.Location = new System.Drawing.Point(182, 157);
            this.lbl_dis_version.Name = "lbl_dis_version";
            this.lbl_dis_version.Size = new System.Drawing.Size(150, 19);
            this.lbl_dis_version.TabIndex = 54;
            this.lbl_dis_version.Text = "Phiên bản: 1.0.2017.18";
            // 
            // lbl_dis_copy_right
            // 
            this.lbl_dis_copy_right.AutoSize = true;
            this.lbl_dis_copy_right.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_dis_copy_right.ForeColor = System.Drawing.Color.White;
            this.lbl_dis_copy_right.Location = new System.Drawing.Point(182, 189);
            this.lbl_dis_copy_right.Name = "lbl_dis_copy_right";
            this.lbl_dis_copy_right.Size = new System.Drawing.Size(327, 19);
            this.lbl_dis_copy_right.TabIndex = 55;
            this.lbl_dis_copy_right.Text = "© 2017 VIỆN KỸ THUẬT PK-KQ. All rights reserved. ";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(530, 260);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Icon;
        private System.Windows.Forms.Label lbl_dis_copy_right;
        private System.Windows.Forms.Label lbl_dis_version;
        private System.Windows.Forms.Label lbl_dis_name;
    }
}
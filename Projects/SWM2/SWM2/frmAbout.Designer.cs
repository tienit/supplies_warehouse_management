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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            this.lbl_dis_name = new System.Windows.Forms.Label();
            this.lbl_dis_version = new System.Windows.Forms.Label();
            this.lbl_dis_copy_right = new System.Windows.Forms.Label();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
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
            this.lbl_FormTitle.TabIndex = 0;
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
            this.lbl_dis_name.TabIndex = 0;
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
            this.lbl_dis_version.TabIndex = 1;
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
            this.lbl_dis_copy_right.TabIndex = 2;
            this.lbl_dis_copy_right.Text = "© 2017 VIỆN KỸ THUẬT PK-KQ. All rights reserved. ";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.printPreviewStaticItem1,
            this.barStaticItem1,
            this.barButtonItem1,
            this.printPreviewStaticItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 125;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemZoomTrackBar1});
            this.ribbonControl1.Size = new System.Drawing.Size(530, 47);
            this.ribbonControl1.TransparentEditors = true;
            // 
            // printPreviewStaticItem1
            // 
            this.printPreviewStaticItem1.Caption = "Nothing";
            this.printPreviewStaticItem1.Id = 118;
            this.printPreviewStaticItem1.LeftIndent = 1;
            this.printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            this.printPreviewStaticItem1.RightIndent = 1;
            this.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 119;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 122;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // printPreviewStaticItem2
            // 
            this.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.printPreviewStaticItem2.Caption = "100%";
            this.printPreviewStaticItem2.Id = 123;
            this.printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            this.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.printPreviewStaticItem2.Type = "ZoomFactorText";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 180;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(530, 260);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.pn_Form, 0);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Icon;
        private System.Windows.Forms.Label lbl_dis_copy_right;
        private System.Windows.Forms.Label lbl_dis_version;
        private System.Windows.Forms.Label lbl_dis_name;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
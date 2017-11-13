namespace TASKWORKING
{
    partial class TaskItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picStatus = new DevExpress.XtraEditors.PictureEdit();
            this.lblTaskContent = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picStatus
            // 
            this.picStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.picStatus.EditValue = global::TASKWORKING.Properties.Resources.uncheck_bold;
            this.picStatus.Location = new System.Drawing.Point(5, 2);
            this.picStatus.Name = "picStatus";
            this.picStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.picStatus.Properties.Appearance.Options.UseForeColor = true;
            this.picStatus.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picStatus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picStatus.Properties.ZoomAccelerationFactor = 1D;
            this.picStatus.Size = new System.Drawing.Size(25, 25);
            this.picStatus.TabIndex = 0;
            this.picStatus.Click += new System.EventHandler(this.picStatus_Click);
            // 
            // lblTaskContent
            // 
            this.lblTaskContent.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskContent.Appearance.Options.UseFont = true;
            this.lblTaskContent.Location = new System.Drawing.Point(37, 7);
            this.lblTaskContent.Name = "lblTaskContent";
            this.lblTaskContent.Size = new System.Drawing.Size(146, 16);
            this.lblTaskContent.TabIndex = 1;
            this.lblTaskContent.Text = "Làm công việc gì đấy...";
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTaskContent);
            this.Controls.Add(this.picStatus);
            this.Name = "TaskItem";
            this.Size = new System.Drawing.Size(568, 30);
            this.Load += new System.EventHandler(this.TaskItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.PictureEdit picStatus;
        private DevExpress.XtraEditors.LabelControl lblTaskContent;
    }
}

namespace VKTIM
{
    partial class frmTaskList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskList));
            this.grv_Data = new System.Windows.Forms.DataGridView();
            this.colTaskchk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTaskContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskEndDate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.grv_Data);
            this.pn_Form.Size = new System.Drawing.Size(495, 513);
            this.pn_Form.Controls.SetChildIndex(this.grv_Data, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(308, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // grv_Data
            // 
            this.grv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskchk,
            this.colTaskContents,
            this.colTaskCode,
            this.colTaskControl,
            this.colTaskStartDate,
            this.colTaskEndDate,
            this.colTaskStatus,
            this.colTaskFinished,
            this.colTaskRemarks,
            this.Column2});
            this.grv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_Data.Location = new System.Drawing.Point(0, 45);
            this.grv_Data.Name = "grv_Data";
            this.grv_Data.Size = new System.Drawing.Size(495, 468);
            this.grv_Data.TabIndex = 52;
            // 
            // colTaskchk
            // 
            this.colTaskchk.HeaderText = "Hoàn thành";
            this.colTaskchk.Name = "colTaskchk";
            this.colTaskchk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaskchk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTaskchk.Width = 50;
            // 
            // colTaskContents
            // 
            this.colTaskContents.HeaderText = "Công việc";
            this.colTaskContents.Name = "colTaskContents";
            this.colTaskContents.Width = 300;
            // 
            // colTaskCode
            // 
            this.colTaskCode.HeaderText = "colTaskCode";
            this.colTaskCode.Name = "colTaskCode";
            this.colTaskCode.Visible = false;
            // 
            // colTaskControl
            // 
            this.colTaskControl.HeaderText = "colTaskControl";
            this.colTaskControl.Name = "colTaskControl";
            this.colTaskControl.Visible = false;
            // 
            // colTaskStartDate
            // 
            this.colTaskStartDate.HeaderText = "colTaskStartDate";
            this.colTaskStartDate.Name = "colTaskStartDate";
            this.colTaskStartDate.Visible = false;
            // 
            // colTaskEndDate
            // 
            this.colTaskEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colTaskEndDate.HeaderText = "Hạn";
            this.colTaskEndDate.Name = "colTaskEndDate";
            this.colTaskEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaskEndDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTaskStatus
            // 
            this.colTaskStatus.HeaderText = "colTaskStatus";
            this.colTaskStatus.Name = "colTaskStatus";
            this.colTaskStatus.Visible = false;
            // 
            // colTaskFinished
            // 
            this.colTaskFinished.HeaderText = "colTaskFinished";
            this.colTaskFinished.Name = "colTaskFinished";
            this.colTaskFinished.Visible = false;
            // 
            // colTaskRemarks
            // 
            this.colTaskRemarks.HeaderText = "colTaskRemarks";
            this.colTaskRemarks.Name = "colTaskRemarks";
            this.colTaskRemarks.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // frmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 526);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 760);
            this.Name = "frmTaskList";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTaskList_FormClosing);
            this.Load += new System.EventHandler(this.frmTaskList_Load);
            this.pn_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_Data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTaskchk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskStartDate;
        private System.Windows.Forms.DataGridViewButtonColumn colTaskEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
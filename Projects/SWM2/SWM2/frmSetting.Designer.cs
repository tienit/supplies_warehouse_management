﻿namespace VKTIM
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Size = new System.Drawing.Size(948, 600);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(761, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 616);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
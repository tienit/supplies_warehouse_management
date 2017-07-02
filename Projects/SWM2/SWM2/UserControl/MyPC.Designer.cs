namespace VKTIM.UserControl
{
    partial class MyPC
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.timerPC = new System.Windows.Forms.Timer(this.components);
            this.pic_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Name.Location = new System.Drawing.Point(2, 54);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(140, 25);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = ".";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPC
            // 
            this.timerPC.Interval = 10000;
            this.timerPC.Tick += new System.EventHandler(this.timerPC_Tick);
            // 
            // pic_Main
            // 
            this.pic_Main.Location = new System.Drawing.Point(47, 2);
            this.pic_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_Main.Name = "pic_Main";
            this.pic_Main.Size = new System.Drawing.Size(48, 48);
            this.pic_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Main.TabIndex = 1;
            this.pic_Main.TabStop = false;
            // 
            // MyPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pic_Main);
            this.Controls.Add(this.lbl_Name);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyPC";
            this.Size = new System.Drawing.Size(144, 81);
            this.Load += new System.EventHandler(this.MyPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox pic_Main;
        private System.Windows.Forms.Timer timerPC;
    }
}

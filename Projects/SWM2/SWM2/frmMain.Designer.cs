namespace VKTIM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbl_Demo = new System.Windows.Forms.Label();
            this.btnUnit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Title = new System.Windows.Forms.Button();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.btn_Title);
            this.pn_Form.Controls.Add(this.textBox1);
            this.pn_Form.Controls.Add(this.btnUnit);
            this.pn_Form.Controls.Add(this.lbl_Demo);
            this.pn_Form.Size = new System.Drawing.Size(1098, 700);
            this.pn_Form.Controls.SetChildIndex(this.lbl_Demo, 0);
            this.pn_Form.Controls.SetChildIndex(this.btnUnit, 0);
            this.pn_Form.Controls.SetChildIndex(this.textBox1, 0);
            this.pn_Form.Controls.SetChildIndex(this.btn_Title, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(911, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // lbl_Demo
            // 
            this.lbl_Demo.AutoSize = true;
            this.lbl_Demo.Location = new System.Drawing.Point(42, 100);
            this.lbl_Demo.Name = "lbl_Demo";
            this.lbl_Demo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Demo.TabIndex = 52;
            this.lbl_Demo.Text = "label1";
            // 
            // btnUnit
            // 
            this.btnUnit.Location = new System.Drawing.Point(45, 142);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(75, 23);
            this.btnUnit.TabIndex = 53;
            this.btnUnit.Text = "Unit";
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 54;
            // 
            // btn_Title
            // 
            this.btn_Title.Location = new System.Drawing.Point(166, 142);
            this.btn_Title.Name = "btn_Title";
            this.btn_Title.Size = new System.Drawing.Size(75, 23);
            this.btn_Title.TabIndex = 55;
            this.btn_Title.Text = "Title";
            this.btn_Title.UseVisualStyleBackColor = true;
            this.btn_Title.Click += new System.EventHandler(this.btn_Title_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 716);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Is_Show_Help = true;
            this.Is_Show_Maximized = true;
            this.Is_Show_Minimized = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "frmMain";
            this.Text = "Supplies Warehouse Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Demo;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Title;
    }
}


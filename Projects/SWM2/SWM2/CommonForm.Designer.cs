namespace VKTIM
{
    partial class CommonForm
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
            this.pn_TOP = new System.Windows.Forms.Panel();
            this.btn_Maximized = new System.Windows.Forms.Button();
            this.btn_Minimized = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pic_Header = new System.Windows.Forms.PictureBox();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.pn_Border_Top = new System.Windows.Forms.Panel();
            this.pn_Border_Left = new System.Windows.Forms.Panel();
            this.pn_Border_Right = new System.Windows.Forms.Panel();
            this.pn_Border_Bottom = new System.Windows.Forms.Panel();
            this.pn_Form = new System.Windows.Forms.Panel();
            this.mainHelp = new System.Windows.Forms.HelpProvider();
            this.mainError = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainTip = new System.Windows.Forms.ToolTip(this.components);
            this.pn_TOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_TOP
            // 
            this.pn_TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.pn_TOP.BackgroundImage = global::eSWS.Properties.Resources.e_titlebar_back;
            this.pn_TOP.Controls.Add(this.btn_Maximized);
            this.pn_TOP.Controls.Add(this.btn_Minimized);
            this.pn_TOP.Controls.Add(this.btn_Help);
            this.pn_TOP.Controls.Add(this.btn_Close);
            this.pn_TOP.Controls.Add(this.pic_Header);
            this.pn_TOP.Controls.Add(this.lbl_FormTitle);
            this.pn_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_TOP.Location = new System.Drawing.Point(0, 0);
            this.pn_TOP.Name = "pn_TOP";
            this.pn_TOP.Size = new System.Drawing.Size(598, 45);
            this.pn_TOP.TabIndex = 51;
            this.pn_TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_TOP_MouseDown);
            // 
            // btn_Maximized
            // 
            this.btn_Maximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximized.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximized.BackgroundImage = global::eSWS.Properties.Resources.e_maximized_32;
            this.btn_Maximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maximized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Maximized.FlatAppearance.BorderSize = 0;
            this.btn_Maximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Maximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Maximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximized.Location = new System.Drawing.Point(522, 7);
            this.btn_Maximized.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximized.Name = "btn_Maximized";
            this.btn_Maximized.Size = new System.Drawing.Size(32, 32);
            this.btn_Maximized.TabIndex = 29;
            this.btn_Maximized.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Maximized, "Maximized");
            this.btn_Maximized.UseVisualStyleBackColor = false;
            this.btn_Maximized.Click += new System.EventHandler(this.bt_Maximized_Click);
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimized.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.BackgroundImage = global::eSWS.Properties.Resources.e_minimized_32;
            this.btn_Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.Location = new System.Drawing.Point(488, 7);
            this.btn_Minimized.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(32, 32);
            this.btn_Minimized.TabIndex = 28;
            this.btn_Minimized.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Minimized, "Minimized");
            this.btn_Minimized.UseVisualStyleBackColor = false;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImage = global::eSWS.Properties.Resources.e_help_32;
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Location = new System.Drawing.Point(454, 7);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(32, 32);
            this.btn_Help.TabIndex = 27;
            this.btn_Help.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Help, "Help");
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::eSWS.Properties.Resources.e_close_32;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(556, 7);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 32);
            this.btn_Close.TabIndex = 26;
            this.btn_Close.TabStop = false;
            this.mainTip.SetToolTip(this.btn_Close, "Close");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pic_Header
            // 
            this.pic_Header.BackColor = System.Drawing.Color.Transparent;
            this.pic_Header.Image = global::eSWS.Properties.Resources.e_about;
            this.pic_Header.Location = new System.Drawing.Point(3, 7);
            this.pic_Header.Name = "pic_Header";
            this.pic_Header.Size = new System.Drawing.Size(32, 32);
            this.pic_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Header.TabIndex = 25;
            this.pic_Header.TabStop = false;
            this.pic_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Header_MouseDown);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_FormTitle.Location = new System.Drawing.Point(40, 4);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(411, 37);
            this.lbl_FormTitle.TabIndex = 24;
            this.lbl_FormTitle.Text = "Common Form";
            this.lbl_FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_FormTitle_MouseDown);
            // 
            // pn_Border_Top
            // 
            this.pn_Border_Top.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Border_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Border_Top.Name = "pn_Border_Top";
            this.pn_Border_Top.Size = new System.Drawing.Size(600, 1);
            this.pn_Border_Top.TabIndex = 52;
            // 
            // pn_Border_Left
            // 
            this.pn_Border_Left.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Border_Left.Location = new System.Drawing.Point(0, 1);
            this.pn_Border_Left.Name = "pn_Border_Left";
            this.pn_Border_Left.Size = new System.Drawing.Size(1, 299);
            this.pn_Border_Left.TabIndex = 53;
            // 
            // pn_Border_Right
            // 
            this.pn_Border_Right.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_Border_Right.Location = new System.Drawing.Point(599, 1);
            this.pn_Border_Right.Name = "pn_Border_Right";
            this.pn_Border_Right.Size = new System.Drawing.Size(1, 299);
            this.pn_Border_Right.TabIndex = 54;
            // 
            // pn_Border_Bottom
            // 
            this.pn_Border_Bottom.BackColor = System.Drawing.Color.Black;
            this.pn_Border_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Border_Bottom.Location = new System.Drawing.Point(1, 299);
            this.pn_Border_Bottom.Name = "pn_Border_Bottom";
            this.pn_Border_Bottom.Size = new System.Drawing.Size(598, 1);
            this.pn_Border_Bottom.TabIndex = 55;
            // 
            // pn_Form
            // 
            this.pn_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Form.Controls.Add(this.pn_TOP);
            this.pn_Form.Location = new System.Drawing.Point(1, 1);
            this.pn_Form.Name = "pn_Form";
            this.pn_Form.Size = new System.Drawing.Size(598, 284);
            this.pn_Form.TabIndex = 56;
            this.pn_Form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Form_MouseDown);
            // 
            // mainHelp
            // 
            this.mainHelp.HelpNamespace = "Help\\mws.chm";
            // 
            // mainError
            // 
            this.mainError.ContainerControl = this;
            // 
            // CommonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.pn_Form);
            this.Controls.Add(this.pn_Border_Bottom);
            this.Controls.Add(this.pn_Border_Right);
            this.Controls.Add(this.pn_Border_Left);
            this.Controls.Add(this.pn_Border_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "CommonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonForm";
            this.Load += new System.EventHandler(this.CommonForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommonForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonForm_MouseDown);
            this.pn_TOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            this.pn_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_TOP;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pn_Border_Top;
        private System.Windows.Forms.Panel pn_Border_Left;
        private System.Windows.Forms.Panel pn_Border_Right;
        private System.Windows.Forms.Panel pn_Border_Bottom;
        protected System.Windows.Forms.Panel pn_Form;
        protected System.Windows.Forms.Label lbl_FormTitle;
        protected System.Windows.Forms.PictureBox pic_Header;
        private System.Windows.Forms.Button btn_Minimized;
        private System.Windows.Forms.Button btn_Maximized;
        protected System.Windows.Forms.HelpProvider mainHelp;
        protected System.Windows.Forms.ErrorProvider mainError;
        protected System.Windows.Forms.ToolTip mainTip;
    }
}
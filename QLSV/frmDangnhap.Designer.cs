namespace QLSV
{
    partial class frmDangnhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btnDn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "tài khoản";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(218, 47);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(398, 26);
            this.txttk.TabIndex = 1;
            this.txttk.Text = "levanteo";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(453, 235);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 65);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Thoát";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(218, 101);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(398, 26);
            this.txtmk.TabIndex = 1;
            this.txtmk.Text = "123";
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(240, 235);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(141, 65);
            this.btnDn.TabIndex = 2;
            this.btnDn.Text = "Đăng nhập";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangnhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btnDn;
    }
}
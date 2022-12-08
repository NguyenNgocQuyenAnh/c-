namespace QLSV
{
    partial class frmSV
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
            this.txttensv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmblop = new System.Windows.Forms.ComboBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên sv";
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(108, 51);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(367, 26);
            this.txttensv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "dtb";
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(108, 107);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(367, 26);
            this.txtdtb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(108, 164);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(367, 26);
            this.txtemail.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(71, 210);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 53);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(242, 210);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(115, 53);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(391, 210);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 53);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(539, 210);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(115, 53);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dgvSV
            // 
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.id,
            this.id_lop,
            this.tensv,
            this.dtb,
            this.email});
            this.dgvSV.Location = new System.Drawing.Point(31, 302);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowTemplate.Height = 28;
            this.dgvSV.Size = new System.Drawing.Size(781, 245);
            this.dgvSV.TabIndex = 3;
            this.dgvSV.Click += new System.EventHandler(this.dgvSV_Click);
            // 
            // tt
            // 
            this.tt.DataPropertyName = "tt";
            this.tt.HeaderText = "TT";
            this.tt.Name = "tt";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // id_lop
            // 
            this.id_lop.DataPropertyName = "id_lop";
            this.id_lop.HeaderText = "ID lớp";
            this.id_lop.Name = "id_lop";
            this.id_lop.Visible = false;
            // 
            // tensv
            // 
            this.tensv.DataPropertyName = "tensv";
            this.tensv.HeaderText = "Tên SV";
            this.tensv.Name = "tensv";
            this.tensv.Width = 150;
            // 
            // dtb
            // 
            this.dtb.DataPropertyName = "dtb";
            this.dtb.HeaderText = "ĐTB";
            this.dtb.Name = "dtb";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "chọn lớp";
            // 
            // cmblop
            // 
            this.cmblop.FormattingEnabled = true;
            this.cmblop.Items.AddRange(new object[] {
            "*"});
            this.cmblop.Location = new System.Drawing.Point(642, 51);
            this.cmblop.Name = "cmblop";
            this.cmblop.Size = new System.Drawing.Size(205, 28);
            this.cmblop.TabIndex = 5;
            this.cmblop.Text = "*";
            this.cmblop.SelectionChangeCommitted += new System.EventHandler(this.cmblop_SelectionChangeCommitted);
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Items.AddRange(new object[] {
            "*"});
            this.cmbid.Location = new System.Drawing.Point(644, 103);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(202, 28);
            this.cmbid.TabIndex = 6;
            this.cmbid.Text = "*";
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 568);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.cmblop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.label1);
            this.Name = "frmSV";
            this.Text = "frmSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmblop;
        private System.Windows.Forms.ComboBox cmbid;
    }
}
namespace QLSV
{
    partial class frmTracuuSV
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
            this.raddtb = new System.Windows.Forms.RadioButton();
            this.radten = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // raddtb
            // 
            this.raddtb.AutoSize = true;
            this.raddtb.Location = new System.Drawing.Point(74, 102);
            this.raddtb.Name = "raddtb";
            this.raddtb.Size = new System.Drawing.Size(153, 24);
            this.raddtb.TabIndex = 0;
            this.raddtb.Text = "Tra cứu theo Đtb";
            this.raddtb.UseVisualStyleBackColor = true;
            // 
            // radten
            // 
            this.radten.AutoSize = true;
            this.radten.Checked = true;
            this.radten.Location = new System.Drawing.Point(74, 55);
            this.radten.Name = "radten";
            this.radten.Size = new System.Drawing.Size(150, 24);
            this.radten.TabIndex = 0;
            this.radten.TabStop = true;
            this.radten.Text = "Tra cứu theo tên";
            this.radten.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập thông tin cần tìm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(301, 96);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(333, 26);
            this.txttim.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(306, 163);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(91, 51);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
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
            this.dgvSV.Location = new System.Drawing.Point(31, 240);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowTemplate.Height = 28;
            this.dgvSV.Size = new System.Drawing.Size(781, 270);
            this.dgvSV.TabIndex = 4;
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
            // frmTracuuSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 551);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radten);
            this.Controls.Add(this.raddtb);
            this.Name = "frmTracuuSV";
            this.Text = "frmTracuuSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton raddtb;
        private System.Windows.Forms.RadioButton radten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}
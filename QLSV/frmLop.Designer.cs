namespace QLSV
{
    partial class frmLop
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
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(136, 51);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(307, 26);
            this.txttenlop.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(45, 112);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 50);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(178, 112);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 50);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(303, 112);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 50);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(423, 112);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(95, 50);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.id,
            this.tenlop});
            this.dgvLop.Location = new System.Drawing.Point(61, 234);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowTemplate.Height = 28;
            this.dgvLop.Size = new System.Drawing.Size(718, 262);
            this.dgvLop.TabIndex = 3;
            this.dgvLop.Click += new System.EventHandler(this.dgvLop_Click);
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
            this.id.Width = 150;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên Lớp";
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 200;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 535);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label1);
            this.Name = "frmLop";
            this.Text = "Quản lý lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
    }
}
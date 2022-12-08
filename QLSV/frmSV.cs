using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmSV : Form
    {
        int Id_lop, Id;
        SV model = new SV();
        public frmSV()
        {
            InitializeComponent();
            loadDataToGrv("*");
            loadDataToCmb();
        }
        void loadDataToGrv(string s)
        {
            dgvSV.AutoGenerateColumns = false;
            using (QLSVEntities db = new QLSVEntities())
            {   if (s == "*")
                    dgvSV.DataSource = Luu.CreateDataTable<SV>(db.SVs.ToList<SV>());
                else
                    dgvSV.DataSource = Luu.CreateDataTable<SV>(db.SVs.SqlQuery("select * from sv where id_lop="+s).ToList());
            }
        }
        void loadDataToCmb()
        {
            using (QLSVEntities db = new QLSVEntities())
            {
                var list = db.Lops.ToList();
                foreach(var item in list)
                {
                    cmblop.Items.Add(item.tenlop);
                    cmbid.Items.Add(item.id);
                }
            }
        }

        private void cmblop_SelectionChangeCommitted(object sender, EventArgs e)
        {    
            if(cmblop.SelectedIndex != 0)
            {
                Id_lop = int.Parse(cmbid.Items[cmblop.SelectedIndex].ToString());
                btnadd.Enabled = true;
                btndelete.Enabled = btnupdate.Enabled = false;
            }
            else
            {
                btnadd.Enabled = false;
                btndelete.Enabled = btnupdate.Enabled = false;
            }
            loadDataToGrv(cmbid.Items[cmblop.SelectedIndex].ToString());
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvSV_Click(object sender, EventArgs e)
        {
            int i = dgvSV.CurrentRow.Index;
            Id = int.Parse(dgvSV[1, i].Value.ToString());
            Id_lop= int.Parse(dgvSV[2, i].Value.ToString());
            txttensv.Text = dgvSV[3, i].Value.ToString();
            txtdtb.Text = dgvSV[4, i].Value.ToString();
            txtemail.Text = dgvSV[5, i].Value.ToString();
            btnadd.Enabled = false;
            btndelete.Enabled = btnupdate.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            model.id = Id;
            model.id_lop = Id_lop;
            model.tensv = txttensv.Text;
            model.dtb = decimal.Parse(txtdtb.Text);
            model.email = txtemail.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("upadte thành công", "thông báo");
                txttensv.Text = txtdtb.Text = txtemail.Text = "";
                btnadd.Enabled = false;
                btndelete.Enabled = btnupdate.Enabled = false;
                if (cmblop.Text == "*") loadDataToGrv("*");
                else loadDataToGrv(Id_lop.ToString());
            }
        }
        
        private void btndelete_Click(object sender, EventArgs e)
        {
            model.id = Id;
            model.id_lop = Id_lop;
            model.tensv = txttensv.Text;
            model.dtb = decimal.Parse(txtdtb.Text);
            model.email = txtemail.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("upadte thành công", "thông báo");
                txttensv.Text = txtdtb.Text = txtemail.Text = "";
                btnadd.Enabled = false;
                if (cmblop.Text == "*") loadDataToGrv("*");
                else loadDataToGrv(Id_lop.ToString());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            model.id_lop = Id_lop;
            model.tensv = txttensv.Text;
            model.dtb = decimal.Parse(txtdtb.Text);
            model.email = txtemail.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.SVs.Add(model);
                db.SaveChanges();
                MessageBox.Show("thêm thành công", "thông báo");
                txttensv.Text = txtdtb.Text =txtemail.Text = "";
                loadDataToGrv(Id_lop.ToString());
            }
        }
    }
}

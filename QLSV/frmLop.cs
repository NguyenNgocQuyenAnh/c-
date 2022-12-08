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
    public partial class frmLop : Form
    {
        int Id;
        Lop model = new Lop();
        public frmLop()
        {
            InitializeComponent();
            loadDataToGrv();
        }
        void loadDataToGrv()
        {
            dgvLop.AutoGenerateColumns = false;
            using(QLSVEntities db = new QLSVEntities())
            {
                dgvLop.DataSource = Luu.CreateDataTable<Lop>(db.Lops.ToList<Lop>());
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            model.tenlop = txttenlop.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Lops.Add(model);
                db.SaveChanges();
                MessageBox.Show("thêm thành công", "thông báo");
                txttenlop.Text = "";
                loadDataToGrv();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLop_Click(object sender, EventArgs e)
        {
            int i = dgvLop.CurrentRow.Index;
            Id = int.Parse(dgvLop[1, i].Value.ToString());
            txttenlop.Text = dgvLop[2, i].Value.ToString();
            btndelete.Enabled = btnupdate.Enabled = true;
            btnadd.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            model.id = Id;
            model.tenlop = txttenlop.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("update thành công", "thông báo");
                txttenlop.Text = "";
                btndelete.Enabled = btnupdate.Enabled = false;
                btnadd.Enabled = true;
                loadDataToGrv();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            model.id = Id;
            model.tenlop = txttenlop.Text;
            using (QLSVEntities db = new QLSVEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("update thành công", "thông báo");
                txttenlop.Text = "";
                btndelete.Enabled = btnupdate.Enabled = false;
                btnadd.Enabled = true;
                loadDataToGrv();
            }
        }
    }
}

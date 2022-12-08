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
    public partial class frmTracuuSV : Form
    {
        public frmTracuuSV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radten.Checked)
            {
                using(QLSVEntities db = new QLSVEntities())
                {
                    dgvSV.DataSource = Luu.CreateDataTable<SV>(db.SVs.SqlQuery("select * from sv where tensv like N'" 
                    + txttim.Text + "'").ToList());
                }
            }
            if (raddtb.Checked)
            {
                using (QLSVEntities db = new QLSVEntities())
                {
                    dgvSV.DataSource = Luu.CreateDataTable<SV>(db.SVs.SqlQuery("select * from sv where dtb="
                    + txttim.Text).ToList());
                }
            }
        }
    }
}

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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            lock_unlock(Luu.KT);
        }
        void lock_unlock(bool kt)
        {
            mnuDangnhap.Enabled = mnuThoat.Enabled = kt;
            mnuDangxuat.Enabled =mnuTracuu.Enabled = mnuDanhmuc.Enabled = mnuBaocao.Enabled = !kt;
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {

        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangnhap f = new frmDangnhap();
            f.Show();
        }

        private void frmChinh_Activated(object sender, EventArgs e)
        {
            lock_unlock(Luu.KT);
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.Show();
        }

        private void mnuSinhvien_Click(object sender, EventArgs e)
        {
            frmSV f = new frmSV();
            f.Show();
        }

        private void mnuTracuuSinhVien_Click(object sender, EventArgs e)
        {
            frmTracuuSV f = new frmTracuuSV();
            f.Show();
        }
    }
}

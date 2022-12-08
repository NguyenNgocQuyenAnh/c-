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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            using (QLSVEntities db = new QLSVEntities())
            {
                string s = "select * from _User where convert(varchar(100),DecryptByPassPhrase('bbb',password))='" +
                    txtmk.Text + "' and username='"+ txttk.Text +"'";
                var list = db.C_User.SqlQuery(s).ToList();
                if(list.Count > 0)
                {
                    MessageBox.Show("đăng nhập thành công", "thông báo");
                    Luu.KT = !Luu.KT;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username hoặc password không đúng", "thông báo");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

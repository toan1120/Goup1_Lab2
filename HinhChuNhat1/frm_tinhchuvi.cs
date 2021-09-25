using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HinhChuNhat1
{
    public partial class frm_tinhchuvi : Form
    {
        public frm_tinhchuvi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_chieudai.Text);
            int b = int.Parse(txt_chieurong.Text);
            CongThuc.A = double.Parse(txt_chieudai.Text);
            CongThuc.B = double.Parse(txt_chieurong.Text);
            txt_ketqua.Text = CongThuc.tinhChuVi().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

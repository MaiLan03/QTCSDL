using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class main : Form
    {
        string Ten = "", MatKhau = "", Quyen = "";
        string ketnoi = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public main()
        {
            InitializeComponent();
        }

        public main(string Ten, string MatKhau, string Quyen)
        {
            InitializeComponent();
            this.Ten = Ten;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }


        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien();
            nhanvien.Show();
        }

        private void côngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cong cong = new Cong();
            cong.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.Show();
        }

        private void bảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangchamcong bangchamcong = new bangchamcong();
            bangchamcong.Show();
        }

        private void bảngTổngHợpChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "quanly")
            {
                bangthcc bangthcc = new bangthcc();
                bangthcc.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem bảng tổng hợp chấm công", "Thông báo");
            }
        }

        private void bảngTổngHợpLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "quanly")
            {
                bangthluong bangthluong = new bangthluong();
                bangthluong.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem bảng tổng hợp lương", "Thông báo");
            }
        }
    }
}

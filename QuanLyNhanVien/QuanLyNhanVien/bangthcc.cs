using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    public partial class bangthcc : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";

        public static void hienthi(DataGridView datagridbangthcc)
        {
            try
            {
                string chuoi = "SELECT * FROM BANGTHCC";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridbangthcc.DataSource = dt;
                datagridbangthcc.Columns[0].HeaderText = "Mã TH công";
                datagridbangthcc.Columns[1].HeaderText = "Ngày TH công";
                datagridbangthcc.Columns[2].HeaderText = "Mã nhân viên";
                datagridbangthcc.Columns[3].HeaderText = "Số công tết";
                datagridbangthcc.Columns[4].HeaderText = "Số công thường";
                datagridbangthcc.Columns[5].HeaderText = "Tổng công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }

        public static void timkiem(DataGridView datagridbangthcc, string tukhoa, string luachon)
        {
            try
            {

                string chuoi = "SELECT * FROM BANGTHCC where '" + luachon + "' like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridbangthcc.DataSource = dt;
                datagridbangthcc.Columns[0].HeaderText = "Mã TH công";
                datagridbangthcc.Columns[1].HeaderText = "Ngày TH công";
                datagridbangthcc.Columns[2].HeaderText = "Mã nhân viên";
                datagridbangthcc.Columns[3].HeaderText = "Số công thường";
                datagridbangthcc.Columns[4].HeaderText = "Số công tết";
                datagridbangthcc.Columns[5].HeaderText = "Tổng công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public bangthcc()
        {
            InitializeComponent();
            hienthi(datagridbangthcc);
        }

        private void datagridbangthcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = datagridbangthcc.CurrentRow.Index;
            mathc_txt.Text = datagridbangthcc.Rows[curow].Cells[0].Value.ToString();
            ngaythc_txt.Text = datagridbangthcc.Rows[curow].Cells[1].Value.ToString();
            manv_txt.Text = datagridbangthcc.Rows[curow].Cells[2].Value.ToString();
            socth_txt.Text = datagridbangthcc.Rows[curow].Cells[3].Value.ToString();
            soct_txt.Text = datagridbangthcc.Rows[curow].Cells[4].Value.ToString();
            tong_txt.Text = datagridbangthcc.Rows[curow].Cells[5].Value.ToString();
            bt_them.Enabled = false;
            mathc_txt.Enabled = false;
            manv_txt.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into BANGTHCC(MaTHC,NgayTHC,MaNV,SoCongThuong,SoCongTet) values ('" + mathc_txt.Text + "',N'" + ngaythc_txt.Text + "', '" + manv_txt.Text + "','" + socth_txt.Text + "','" + soct_txt.Text + "')";
                if (mathc_txt.Text == "" || ngaythc_txt.Text == "" || manv_txt.Text == "" || socth_txt.Text == "" || soct_txt.Text =="")
                {
                    MessageBox.Show("Bạn chưa nhập đủ dữ liệu. Hãy kiểm tra lại!!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    com = new SqlCommand(sql1, mycon);
                    ad = new SqlDataAdapter(com);
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    datagridbangthcc.DataSource = tb;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    hienthi(datagridbangthcc);
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "update BANGTHCC set MaTHC='" + mathc_txt.Text + "', NgayTHC='" + ngaythc_txt.Text + "', MaNV='" + manv_txt.Text + "', SoCongThuong='" + socth_txt.Text + "', SoCongTet='"+soct_txt.Text+"'";
                if (manv_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã nhân viên để sửa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql2, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    hienthi(datagridbangthcc);
                    bt_them.Enabled = true;
                    mathc_txt.Enabled = true;
                    bt_xoa.Enabled = false;
                    bt_sua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql3 = "delete BANGTHCC where MaTHC='" + mathc_txt.Text + "'";
                if (mathc_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã tổng hợp công để xóa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql3, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    hienthi(datagridbangthcc);
                    bt_them.Enabled = true;
                    mathc_txt.Enabled = true;
                    bt_xoa.Enabled = false;
                    bt_sua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            mathc_txt.Clear();
            ngaythc_txt.Clear();
            manv_txt.Clear();
            socth_txt.Clear();
            soct_txt.Clear();
            tong_txt.Clear();
            mathc_txt.Focus();
            bt_them.Enabled = true;
            mathc_txt.Enabled = true;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = search_txt.Text;
            if (cb_search.SelectedItem == "Mã TH công")
            {
                string luachon = "MaTHC";
                timkiem(datagridbangthcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Ngày TH công")
            {
                string luachon = "NgayTHC";
                timkiem(datagridbangthcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Mã nhân viên")
            {
                string luachon = "MaNV";
                timkiem(datagridbangthcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Số công thường")
            {
                string luachon = "SoCongThuong";
                timkiem(datagridbangthcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Số công tết")
            {
                string luachon = "SoCongTet";
                timkiem(datagridbangthcc, tukhoa, luachon);
            }
            else
            {
                string luachon = "TongCong";
                timkiem(datagridbangthcc, tukhoa, luachon);
            }

        }
    }
}

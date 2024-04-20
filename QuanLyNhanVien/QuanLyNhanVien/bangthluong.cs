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
    public partial class bangthluong : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";

        public static void hienthi(DataGridView datagridbangthluong)
        {
            try
            {
                string chuoi = "SELECT * FROM BANGTHLUONG";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridbangthluong.DataSource = dt;
                datagridbangthluong.Columns[0].HeaderText = "Mã phiếu lương";
                datagridbangthluong.Columns[1].HeaderText = "Ngày TH lương";
                datagridbangthluong.Columns[2].HeaderText = "Mã nhân viên";
                datagridbangthluong.Columns[3].HeaderText = "Mã lương";
                datagridbangthluong.Columns[4].HeaderText = "Tổng công";
                datagridbangthluong.Columns[5].HeaderText = "Thành tiền";
                datagridbangthluong.Columns[6].HeaderText = "Thưởng";
                datagridbangthluong.Columns[7].HeaderText = "Khấu trừ";
                datagridbangthluong.Columns[8].HeaderText = "Thực lĩnh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public static void timkiem(DataGridView datagridbangthluong, string tukhoa, string luachon)
        {
            try
            {

                string chuoi = "SELECT * FROM BANGTHLUONG where '" + luachon + "' like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridbangthluong.DataSource = dt;
                datagridbangthluong.Columns[0].HeaderText = "Mã phiếu lương";
                datagridbangthluong.Columns[1].HeaderText = "Ngày TH lương";
                datagridbangthluong.Columns[2].HeaderText = "Mã nhân viên";
                datagridbangthluong.Columns[3].HeaderText = "Mã lương";
                datagridbangthluong.Columns[4].HeaderText = "Tổng công";
                datagridbangthluong.Columns[5].HeaderText = "Thành tiền";
                datagridbangthluong.Columns[6].HeaderText = "Thưởng";
                datagridbangthluong.Columns[7].HeaderText = "Khấu trừ";
                datagridbangthluong.Columns[8].HeaderText = "Thực lĩnh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public bangthluong()
        {
            InitializeComponent();
            hienthi(datagridbangthluong);
        }

        private void datagridbangthluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = datagridbangthluong.CurrentRow.Index;
            mapl_txt.Text = datagridbangthluong.Rows[curow].Cells[0].Value.ToString();
            ngaythl_txt.Text = datagridbangthluong.Rows[curow].Cells[1].Value.ToString();
            manv_txt.Text = datagridbangthluong.Rows[curow].Cells[2].Value.ToString();
            maluong_txt.Text = datagridbangthluong.Rows[curow].Cells[3].Value.ToString();
            tong_txt.Text = datagridbangthluong.Rows[curow].Cells[4].Value.ToString();
            tien_txt.Text = datagridbangthluong.Rows[curow].Cells[5].Value.ToString();
            thuong_txt.Text = datagridbangthluong.Rows[curow].Cells[6].Value.ToString();
            tru_txt.Text = datagridbangthluong.Rows[curow].Cells[7].Value.ToString();
            linh_txt.Text = datagridbangthluong.Rows[curow].Cells[8].Value.ToString();
            bt_them.Enabled = false;
            mapl_txt.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into BANGTHLUONG(MaPL,NgayTHL,MaNV,MaLuong) values ('" + mapl_txt.Text + "','" + ngaythl_txt.Text + "', '" + manv_txt.Text + "','" + maluong_txt.Text + "')";
                if (mapl_txt.Text == "" || ngaythl_txt.Text == "" || manv_txt.Text == "" || maluong_txt.Text == "")
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
                    datagridbangthluong.DataSource = tb;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    hienthi(datagridbangthluong);
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
                string sql2 = "update BANGTHLUONG set MaPL='" + mapl_txt.Text + "', NgayTHL='" + ngaythl_txt.Text + "', MaNV='" + manv_txt.Text + "', MaLuong='" + maluong_txt.Text + "', TongCong='"+tong_txt.Text+"', Thuong='"+thuong_txt.Text+"', KhauTru='"+tru_txt.Text+"'";
                if (manv_txt.Text == "" || mapl_txt.Text =="")
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
                    hienthi(datagridbangthluong);
                    bt_them.Enabled = true;
                    manv_txt.Enabled = true;
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
                string sql3 = "delete BANGTHLUONG where MaNV='" + manv_txt.Text + "'";
                if (manv_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã nhân viên để xóa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql3, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    hienthi(datagridbangthluong);
                    bt_them.Enabled = true;
                    mapl_txt.Enabled = true;
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
            mapl_txt.Clear();
            ngaythl_txt.Clear();
            manv_txt.Clear();
            maluong_txt.Clear();
            tong_txt.Clear();
            tien_txt.Clear();
            thuong_txt.Clear();
            tru_txt.Clear();
            linh_txt.Clear();
            mapl_txt.Focus();
            bt_them.Enabled = true;
            mapl_txt.Enabled = true;
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
            if (cb_bthl.SelectedItem == "Mã phiếu lương")
            {
                string luachon = "MaPL";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Ngày TH lương")
            {
                string luachon = "NgayTHL";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Mã nhân viên")
            {
                string luachon = "MaNV";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Mã lương")
            {
                string luachon = "MaLuong";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Tổng công")
            {
                string luachon = "TongCong";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Thành tiền")
            {
                string luachon = "ThanhTien";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Thưởng")
            {
                string luachon = "Thuong";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else if (cb_bthl.SelectedItem == "Khấu trừ")
            {
                string luachon = "KhauTru";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
            else
            {
                string luachon = "Thực lĩnh";
                timkiem(datagridbangthluong, tukhoa, luachon);
            }
        }
    }
}


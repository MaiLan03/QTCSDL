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
    public partial class Luong : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";
        public static void hienthi(DataGridView datagridluong)
        {
            try
            {
                string chuoi = "SELECT * FROM LUONG";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridluong.DataSource = dt;
                datagridluong.Columns[0].HeaderText = "Mã lương";
                datagridluong.Columns[1].HeaderText = "Tên lương";
                datagridluong.Columns[2].HeaderText = "Mức lương";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public static void timkiem(DataGridView datagridluong, string tukhoa, string luachon)
        {
            try
            {

                string chuoi = "SELECT * FROM LUONG where '" + luachon + "' like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridluong.DataSource = dt;
                datagridluong.Columns[0].HeaderText = "Mã lương";
                datagridluong.Columns[1].HeaderText = "Tên lương";
                datagridluong.Columns[2].HeaderText = "Mức lương";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public Luong()
        {
            InitializeComponent();
            hienthi(datagridluong);
        }

        private void datagridluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = datagridluong.CurrentRow.Index;
            maluong_txt.Text = datagridluong.Rows[curow].Cells[0].Value.ToString();
            tenluong_txt.Text = datagridluong.Rows[curow].Cells[1].Value.ToString();
            mucluong_txt.Text = datagridluong.Rows[curow].Cells[2].Value.ToString();
            bt_theml.Enabled = false;
            maluong_txt.Enabled = false;
            bt_sual.Enabled = true;
            bt_xoal.Enabled = true;
        }

        private void bt_theml_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into LUONG values ('" + maluong_txt.Text + "',N'" + tenluong_txt.Text + "', '" + mucluong_txt.Text + "')";
                if (maluong_txt.Text == "" || tenluong_txt.Text == "" || mucluong_txt.Text == "")
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
                    datagridluong.DataSource = tb;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    hienthi(datagridluong);
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_sual_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "update LUONG set MaLuong='" + maluong_txt.Text + "', TenLuong=N'" + tenluong_txt.Text + "', MucLuong='" + mucluong_txt.Text + "'";
                if (maluong_txt.Text == "")
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
                    hienthi(datagridluong);
                    bt_theml.Enabled = true;
                    maluong_txt.Enabled = true;
                    bt_sual.Enabled = false;
                    bt_xoal.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_xoal_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql3 = "delete LUONG where MaLuong='" + maluong_txt.Text + "'";
                if (maluong_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã lương để xóa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql3, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    hienthi(datagridluong);
                    bt_theml.Enabled = true;
                    maluong_txt.Enabled = true;
                    bt_xoal.Enabled = false;
                    bt_sual.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_lammoil_Click_1(object sender, EventArgs e)
        {
            maluong_txt.Clear();
            tenluong_txt.Clear();
            mucluong_txt.Clear();
            maluong_txt.Focus();
            bt_theml.Enabled = true;
            maluong_txt.Enabled = true;
            bt_xoal.Enabled = false;
            bt_sual.Enabled = false;
        }

        private void bt_thoatl_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = search_txt.Text;
            if (cb_search.SelectedItem == "Mã lương")
            {
                string luachon = "MaLuong";
                timkiem(datagridluong, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Tên lương")
            {
                string luachon = "TenLuong";
                timkiem(datagridluong, tukhoa, luachon);
            }
            else
            {
                string luachon = "MucLuong";
                timkiem(datagridluong, tukhoa, luachon);
            }
        }
    }
}

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
    public partial class Cong : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";

        public static void hienthi(DataGridView datagridcong)
        {
            try
            {
                string chuoi = "SELECT * FROM CONG";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridcong.DataSource = dt;
                datagridcong.Columns[0].HeaderText = "Mã công";
                datagridcong.Columns[1].HeaderText = "Loại công";
                datagridcong.Columns[2].HeaderText = "Hệ số công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
            
        }
        public static void timkiem(DataGridView datagridcong, string tukhoa, string luachon)
        {
            try
            {

                string chuoi = "SELECT * FROM CONG where '" + luachon + "' like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridcong.DataSource = dt;
                datagridcong.Columns[0].HeaderText = "Mã công";
                datagridcong.Columns[1].HeaderText = "Loại công";
                datagridcong.Columns[2].HeaderText = "Hệ số công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public Cong()
        {
            InitializeComponent();
            hienthi(datagridcong);            
        }

        private void datagridcong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = datagridcong.CurrentRow.Index;
            macong_txt.Text = datagridcong.Rows[curow].Cells[0].Value.ToString();
            loaicong_txt.Text = datagridcong.Rows[curow].Cells[1].Value.ToString();
            hscong_txt.Text = datagridcong.Rows[curow].Cells[2].Value.ToString();
            bt_them.Enabled = false;
            macong_txt.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
        }

        

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into CONG values ('" + macong_txt.Text + "',N'" + loaicong_txt.Text + "', '" + hscong_txt.Text + "')";
                if (macong_txt.Text == "" || loaicong_txt.Text == "" || hscong_txt.Text == "")
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
                    datagridcong.DataSource = tb;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    hienthi(datagridcong);
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "update CONG set MaCong='" + macong_txt.Text + "', LoaiCong=N'" + loaicong_txt.Text + "', HeSoCong='" + hscong_txt.Text + "'";
                if (macong_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã công để sửa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql2, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    hienthi(datagridcong);
                    bt_them.Enabled = true;
                    macong_txt.Enabled = true;
                    bt_xoa.Enabled = false;
                    bt_sua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql3 = "delete CONG where MaCong='" + macong_txt.Text + "'";
                if (macong_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã công để xóa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql3, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    hienthi(datagridcong);
                    bt_them.Enabled = true;
                    macong_txt.Enabled = true;
                    bt_xoa.Enabled = false;
                    bt_sua.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "ERROR!!", MessageBoxButtons.OK);
            }
        }

        private void bt_lammoi_Click_1(object sender, EventArgs e)
        {
            macong_txt.Clear();
            loaicong_txt.Clear();
            hscong_txt.Clear();
            macong_txt.Focus();
            bt_them.Enabled = true;
            macong_txt.Enabled = true;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
        }

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

            string tukhoa = search_txt.Text;
            if (cb_search.SelectedItem == "Mã công")
            {
                string luachon = "MaCong";
                timkiem(datagridcong, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Loại công")
            {
                string luachon = "LoaiCong";
                timkiem(datagridcong, tukhoa, luachon);
            }
            else
            {
                string luachon = "HeSoCong";
                timkiem(datagridcong, tukhoa, luachon);
            }
        }
    }
}

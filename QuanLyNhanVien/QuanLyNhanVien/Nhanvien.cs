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
    public partial class nhanvien : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";
        
        public static void hienthi( DataGridView datagrid1)
        {
            try
            {
                string chuoi = "SELECT * FROM NHANVIEN";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagrid1.DataSource = dt;
                datagrid1.Columns[0].HeaderText = "Mã nhân viên";
                datagrid1.Columns[1].HeaderText = "Tên nhân viên";
                datagrid1.Columns[2].HeaderText = "Số điện thoại";
                datagrid1.Columns[3].HeaderText = "Mã lương";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public static void timkiem(DataGridView datagrid1, string tukhoa, string luachon)
        {
            try
            {

                string chuoi = "SELECT * FROM NHANVIEN where '"+luachon+"' like N'%"+tukhoa+"%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagrid1.DataSource = dt;
                datagrid1.Columns[0].HeaderText = "Mã nhân viên";
                datagrid1.Columns[1].HeaderText = "Tên nhân viên";
                datagrid1.Columns[2].HeaderText = "Số điện thoại";
                datagrid1.Columns[3].HeaderText = "Mã lương";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public nhanvien()
        {
            InitializeComponent();
            hienthi(datagrid1);
        }

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = datagrid1.CurrentRow.Index;
            manv_txt.Text = datagrid1.Rows[curow].Cells[0].Value.ToString();
            tennv_txt.Text = datagrid1.Rows[curow].Cells[1].Value.ToString();
            sdt_txt.Text = datagrid1.Rows[curow].Cells[2].Value.ToString();
            maluong_txt.Text = datagrid1.Rows[curow].Cells[3].Value.ToString();
            bt_them.Enabled = false;
            manv_txt.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into NHANVIEN values ('" + manv_txt.Text + "',N'" + tennv_txt.Text + "', '" + sdt_txt.Text + "','" + maluong_txt.Text + "')";
                if (manv_txt.Text == "" || tennv_txt.Text == "" || sdt_txt.Text == "" || maluong_txt.Text == "")
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
                    datagrid1.DataSource = tb;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    hienthi(datagrid1);
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
                string sql2 = "update NHANVIEN set MaNV='" + manv_txt.Text + "', TenNV=N'" + tennv_txt.Text + "', Sdt='" + sdt_txt.Text + "', MaLuong='" + maluong_txt.Text + "'";
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
                    MessageBox.Show("Sửa dữ liệu thành công cho nhân viên có mã '" + manv_txt.Text + "'", "Thông báo");
                    hienthi(datagrid1);
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
                string sql3 = "delete NHANVIEN where MaNV='" + manv_txt.Text + "'";
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
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                    hienthi(datagrid1);
                    bt_them.Enabled = true;
                    manv_txt.Enabled = true;
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
            manv_txt.Clear();
            tennv_txt.Clear();
            sdt_txt.Clear();
            maluong_txt.Clear();
            manv_txt.Focus();
            bt_them.Enabled = true;
            manv_txt.Enabled = true;
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

        private void sdt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = search_txt.Text;
            if (cb_search.SelectedItem == "Mã nhân viên")
            {
                string luachon = "MaNV";
                timkiem(datagrid1,tukhoa,luachon);
            }
            else if (cb_search.SelectedItem == "Tên nhân viên")
            {
                string luachon = "TenNV";
                timkiem(datagrid1,tukhoa,luachon);
            }
            else if (cb_search.SelectedItem == "Số điện thoại")
            {
                string luachon = "SDT";
                timkiem(datagrid1,tukhoa,luachon);
            }
            else
            {
                string luachon = "MaLuong";
                timkiem(datagrid1,tukhoa,luachon);
            }

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}

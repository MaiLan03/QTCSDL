﻿using System;
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
    public partial class bangchamcong : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False";

        public static void hienthi(DataGridView datagridbangcc)
        {
            try
            {
                string chuoi = "SELECT * FROM BANGCHAMCONG";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridbangcc.DataSource = dt;
                datagridbangcc.Columns[0].HeaderText = "Mã chấm công";
                datagridbangcc.Columns[1].HeaderText = "Mã nhân viên";
                datagridbangcc.Columns[2].HeaderText = "Ngày công";
                datagridbangcc.Columns[3].HeaderText = "Số giờ";
                datagridbangcc.Columns[4].HeaderText = "Mã công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }

        public static void timkiem(DataGridView datagridbangcc, string tukhoa, string luachon)
        {
            try
            {

                string chuoi = "SELECT * FROM BANGCHAMCONG where '" + luachon + "' like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datagridbangcc.DataSource = dt;
                datagridbangcc.Columns[0].HeaderText = "Mã chấm công";
                datagridbangcc.Columns[1].HeaderText = "Mã nhân viên";
                datagridbangcc.Columns[2].HeaderText = "Ngày công";
                datagridbangcc.Columns[3].HeaderText = "Số giờ";
                datagridbangcc.Columns[4].HeaderText = "Mã công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public bangchamcong()
        {
            InitializeComponent();
            hienthi(datagridbangcc);
        }

        private void datagridbangcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = datagridbangcc.CurrentRow.Index;
            macc_txt.Text = datagridbangcc.Rows[curow].Cells[0].Value.ToString();
            manv_txt.Text = datagridbangcc.Rows[curow].Cells[1].Value.ToString();
            ngay_txt.Text = datagridbangcc.Rows[curow].Cells[2].Value.ToString();
            sogio_txt.Text = datagridbangcc.Rows[curow].Cells[3].Value.ToString();
            macong_txt.Text = datagridbangcc.Rows[curow].Cells[4].Value.ToString();
            bt_them.Enabled = false;
            macc_txt.Enabled = false;
            manv_txt.Enabled = false;
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into BANGCHAMCONG values ('" + macc_txt.Text + "', '" + manv_txt.Text + "', '" + ngay_txt.Text + "','" + sogio_txt.Text + "','" + macong_txt.Text + "')";
                if (macc_txt.Text == "" || manv_txt.Text == "" || ngay_txt.Text == "" || sogio_txt.Text == "" || macong_txt.Text =="")
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
                    datagridbangcc.DataSource = tb;
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");
                    hienthi(datagridbangcc);
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
                string sql2 = "update BANGCHAMCONG set MaCC='" + macc_txt.Text + "', MaNV=N'" + manv_txt.Text + "', NgayCong='" + ngay_txt.Text + "', SoGio='" + sogio_txt.Text + "', MaCong='"+macong_txt.Text+"'";
                if (macc_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã chấm công để sửa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql2, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu chấm công thành công", "Thông báo");
                    hienthi(datagridbangcc);
                    bt_them.Enabled = true;
                    macc_txt.Enabled = true;
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
                string sql3 = "delete BANGCHAMCONG where MaCC='" + macc_txt.Text + "'";
                if (macc_txt.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã chấm công để xóa thông tin", "ERROR!!", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql3, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu chấm công thành công", "Thông báo");
                    hienthi(datagridbangcc);
                    bt_them.Enabled = true;
                    macc_txt.Enabled = true;
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
            macc_txt.Clear();
            manv_txt.Clear();
            ngay_txt.Clear();
            sogio_txt.Clear();
            macong_txt.Clear();
            macc_txt.Focus();
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = search_txt.Text;
            if (cb_search.SelectedItem == "Mã chấm công")
            {
                string luachon = "MaCC";
                timkiem(datagridbangcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Mã nhân viên")
            {
                string luachon = "MaNV";
                timkiem(datagridbangcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Ngày công")
            {
                string luachon = "NgayCong";
                timkiem(datagridbangcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Số giờ")
            {
                string luachon = "SoGio";
                timkiem(datagridbangcc, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Mã công")
            {
                string luachon = "MaCong";
                timkiem(datagridbangcc, tukhoa, luachon);
            }
        }
    }
}

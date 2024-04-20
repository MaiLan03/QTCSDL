namespace QuanLyNhanVien
{
    partial class nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.manv_txt = new System.Windows.Forms.TextBox();
            this.tennv_txt = new System.Windows.Forms.TextBox();
            this.sdt_txt = new System.Windows.Forms.TextBox();
            this.maluong_txt = new System.Windows.Forms.TextBox();
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.cb_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(441, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Lương";
            // 
            // manv_txt
            // 
            this.manv_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manv_txt.Location = new System.Drawing.Point(716, 191);
            this.manv_txt.Multiline = true;
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Size = new System.Drawing.Size(216, 24);
            this.manv_txt.TabIndex = 5;
            // 
            // tennv_txt
            // 
            this.tennv_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tennv_txt.Location = new System.Drawing.Point(716, 241);
            this.tennv_txt.Multiline = true;
            this.tennv_txt.Name = "tennv_txt";
            this.tennv_txt.Size = new System.Drawing.Size(216, 24);
            this.tennv_txt.TabIndex = 6;
            // 
            // sdt_txt
            // 
            this.sdt_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt_txt.Location = new System.Drawing.Point(716, 291);
            this.sdt_txt.Multiline = true;
            this.sdt_txt.Name = "sdt_txt";
            this.sdt_txt.Size = new System.Drawing.Size(216, 24);
            this.sdt_txt.TabIndex = 7;
            this.sdt_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sdt_txt_KeyPress);
            // 
            // maluong_txt
            // 
            this.maluong_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maluong_txt.Location = new System.Drawing.Point(716, 340);
            this.maluong_txt.Multiline = true;
            this.maluong_txt.Name = "maluong_txt";
            this.maluong_txt.Size = new System.Drawing.Size(216, 24);
            this.maluong_txt.TabIndex = 8;
            // 
            // datagrid1
            // 
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(43, 127);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(514, 300);
            this.datagrid1.TabIndex = 9;
            this.datagrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(43, 442);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(85, 34);
            this.bt_them.TabIndex = 10;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(168, 442);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(81, 34);
            this.bt_sua.TabIndex = 11;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Enabled = false;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(274, 442);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 34);
            this.bt_xoa.TabIndex = 12;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoi.Location = new System.Drawing.Point(377, 442);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(85, 34);
            this.bt_lammoi.TabIndex = 13;
            this.bt_lammoi.Text = "Làm mới";
            this.bt_lammoi.UseVisualStyleBackColor = true;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(482, 442);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 34);
            this.bt_thoat.TabIndex = 14;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.search_txt.Location = new System.Drawing.Point(229, 80);
            this.search_txt.Multiline = true;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(311, 27);
            this.search_txt.TabIndex = 16;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Ma nhan vien",
            "Tên nhân viên",
            "Số điện thoại",
            "Mã lương"});
            this.cb_search.Location = new System.Drawing.Point(60, 80);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(145, 27);
            this.cb_search.TabIndex = 17;
            this.cb_search.Text = "Tìm kiếm theo";
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_lammoi);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.maluong_txt);
            this.Controls.Add(this.sdt_txt);
            this.Controls.Add(this.tennv_txt);
            this.Controls.Add(this.manv_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox manv_txt;
        private System.Windows.Forms.TextBox tennv_txt;
        private System.Windows.Forms.TextBox sdt_txt;
        private System.Windows.Forms.TextBox maluong_txt;
        private System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_lammoi;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.ComboBox cb_search;
    }
}


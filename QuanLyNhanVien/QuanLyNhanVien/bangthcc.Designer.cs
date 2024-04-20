namespace QuanLyNhanVien
{
    partial class bangthcc
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
            this.datagridbangthcc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mathc_txt = new System.Windows.Forms.TextBox();
            this.socth_txt = new System.Windows.Forms.TextBox();
            this.soct_txt = new System.Windows.Forms.TextBox();
            this.tong_txt = new System.Windows.Forms.TextBox();
            this.manv_txt = new System.Windows.Forms.TextBox();
            this.ngaythc_txt = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbangthcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG TỔNG HỢP CHẤM CÔNG";
            // 
            // datagridbangthcc
            // 
            this.datagridbangthcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbangthcc.Location = new System.Drawing.Point(34, 134);
            this.datagridbangthcc.Name = "datagridbangthcc";
            this.datagridbangthcc.Size = new System.Drawing.Size(562, 333);
            this.datagridbangthcc.TabIndex = 1;
            this.datagridbangthcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbangthcc_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã TH công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày TH công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số công thường";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số công tết";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tổng công";
            // 
            // mathc_txt
            // 
            this.mathc_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathc_txt.Location = new System.Drawing.Point(770, 171);
            this.mathc_txt.Name = "mathc_txt";
            this.mathc_txt.Size = new System.Drawing.Size(206, 26);
            this.mathc_txt.TabIndex = 8;
            // 
            // socth_txt
            // 
            this.socth_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socth_txt.Location = new System.Drawing.Point(770, 320);
            this.socth_txt.Name = "socth_txt";
            this.socth_txt.Size = new System.Drawing.Size(206, 26);
            this.socth_txt.TabIndex = 9;
            // 
            // soct_txt
            // 
            this.soct_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soct_txt.Location = new System.Drawing.Point(770, 366);
            this.soct_txt.Name = "soct_txt";
            this.soct_txt.Size = new System.Drawing.Size(206, 26);
            this.soct_txt.TabIndex = 10;
            // 
            // tong_txt
            // 
            this.tong_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong_txt.Location = new System.Drawing.Point(770, 414);
            this.tong_txt.Name = "tong_txt";
            this.tong_txt.Size = new System.Drawing.Size(206, 26);
            this.tong_txt.TabIndex = 11;
            // 
            // manv_txt
            // 
            this.manv_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manv_txt.Location = new System.Drawing.Point(770, 272);
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Size = new System.Drawing.Size(206, 26);
            this.manv_txt.TabIndex = 12;
            // 
            // ngaythc_txt
            // 
            this.ngaythc_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythc_txt.Location = new System.Drawing.Point(770, 223);
            this.ngaythc_txt.Name = "ngaythc_txt";
            this.ngaythc_txt.Size = new System.Drawing.Size(206, 26);
            this.ngaythc_txt.TabIndex = 13;
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(58, 485);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(80, 34);
            this.bt_them.TabIndex = 14;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(162, 485);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(80, 34);
            this.bt_sua.TabIndex = 15;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(266, 485);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(80, 34);
            this.bt_xoa.TabIndex = 16;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoi.Location = new System.Drawing.Point(379, 485);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(80, 34);
            this.bt_lammoi.TabIndex = 17;
            this.bt_lammoi.Text = "Làm mới";
            this.bt_lammoi.UseVisualStyleBackColor = true;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(488, 485);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(80, 34);
            this.bt_thoat.TabIndex = 18;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã TH công",
            "Ngày TH công",
            "Mã nhân viên",
            "Số công thường",
            "Số công tết",
            "Tổng công"});
            this.cb_search.Location = new System.Drawing.Point(58, 100);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(184, 27);
            this.cb_search.TabIndex = 19;
            this.cb_search.Text = "Tìm kiếm theo";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(253, 100);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(315, 26);
            this.search_txt.TabIndex = 20;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // bangthcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_lammoi);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.ngaythc_txt);
            this.Controls.Add(this.manv_txt);
            this.Controls.Add(this.tong_txt);
            this.Controls.Add(this.soct_txt);
            this.Controls.Add(this.socth_txt);
            this.Controls.Add(this.mathc_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridbangthcc);
            this.Controls.Add(this.label1);
            this.Name = "bangthcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bangthcc";
            ((System.ComponentModel.ISupportInitialize)(this.datagridbangthcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridbangthcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mathc_txt;
        private System.Windows.Forms.TextBox socth_txt;
        private System.Windows.Forms.TextBox soct_txt;
        private System.Windows.Forms.TextBox tong_txt;
        private System.Windows.Forms.TextBox manv_txt;
        private System.Windows.Forms.TextBox ngaythc_txt;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_lammoi;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox search_txt;
    }
}
namespace QuanLyNhanVien
{
    partial class bangchamcong
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
            this.datagridbangcc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.macc_txt = new System.Windows.Forms.TextBox();
            this.manv_txt = new System.Windows.Forms.TextBox();
            this.ngay_txt = new System.Windows.Forms.TextBox();
            this.sogio_txt = new System.Windows.Forms.TextBox();
            this.macong_txt = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbangcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CHẤM CÔNG";
            // 
            // datagridbangcc
            // 
            this.datagridbangcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridbangcc.Location = new System.Drawing.Point(21, 114);
            this.datagridbangcc.Name = "datagridbangcc";
            this.datagridbangcc.Size = new System.Drawing.Size(593, 292);
            this.datagridbangcc.TabIndex = 1;
            this.datagridbangcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbangcc_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chấm công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày công";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số giờ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã công";
            // 
            // macc_txt
            // 
            this.macc_txt.BackColor = System.Drawing.SystemColors.Window;
            this.macc_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macc_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.macc_txt.Location = new System.Drawing.Point(740, 144);
            this.macc_txt.Multiline = true;
            this.macc_txt.Name = "macc_txt";
            this.macc_txt.Size = new System.Drawing.Size(234, 26);
            this.macc_txt.TabIndex = 7;
            // 
            // manv_txt
            // 
            this.manv_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manv_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.manv_txt.Location = new System.Drawing.Point(740, 200);
            this.manv_txt.Multiline = true;
            this.manv_txt.Name = "manv_txt";
            this.manv_txt.Size = new System.Drawing.Size(234, 26);
            this.manv_txt.TabIndex = 8;
            // 
            // ngay_txt
            // 
            this.ngay_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ngay_txt.Location = new System.Drawing.Point(741, 252);
            this.ngay_txt.Multiline = true;
            this.ngay_txt.Name = "ngay_txt";
            this.ngay_txt.Size = new System.Drawing.Size(233, 26);
            this.ngay_txt.TabIndex = 9;
            // 
            // sogio_txt
            // 
            this.sogio_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sogio_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sogio_txt.Location = new System.Drawing.Point(741, 303);
            this.sogio_txt.Multiline = true;
            this.sogio_txt.Name = "sogio_txt";
            this.sogio_txt.Size = new System.Drawing.Size(233, 26);
            this.sogio_txt.TabIndex = 10;
            // 
            // macong_txt
            // 
            this.macong_txt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macong_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.macong_txt.Location = new System.Drawing.Point(741, 350);
            this.macong_txt.Multiline = true;
            this.macong_txt.Name = "macong_txt";
            this.macong_txt.Size = new System.Drawing.Size(233, 26);
            this.macong_txt.TabIndex = 11;
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(21, 430);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(95, 33);
            this.bt_them.TabIndex = 12;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(135, 430);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(95, 33);
            this.bt_sua.TabIndex = 13;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(257, 430);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(95, 33);
            this.bt_xoa.TabIndex = 14;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoi.Location = new System.Drawing.Point(379, 430);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(95, 33);
            this.bt_lammoi.TabIndex = 15;
            this.bt_lammoi.Text = "Làm mới";
            this.bt_lammoi.UseVisualStyleBackColor = true;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(500, 430);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(95, 33);
            this.bt_thoat.TabIndex = 16;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã chấm công",
            "Mã nhân viên",
            "Ngày công",
            "Số giờ",
            "Mã công"});
            this.cb_search.Location = new System.Drawing.Point(45, 81);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(185, 27);
            this.cb_search.TabIndex = 17;
            this.cb_search.Text = "Tìm kiếm theo";
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.SystemColors.Window;
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.search_txt.Location = new System.Drawing.Point(236, 81);
            this.search_txt.Multiline = true;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(313, 26);
            this.search_txt.TabIndex = 18;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // bangchamcong
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
            this.Controls.Add(this.macong_txt);
            this.Controls.Add(this.sogio_txt);
            this.Controls.Add(this.ngay_txt);
            this.Controls.Add(this.manv_txt);
            this.Controls.Add(this.macc_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridbangcc);
            this.Controls.Add(this.label1);
            this.Name = "bangchamcong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bangchamcong";
            ((System.ComponentModel.ISupportInitialize)(this.datagridbangcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridbangcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_lammoi;
        private System.Windows.Forms.Button bt_thoat;
        internal System.Windows.Forms.TextBox macc_txt;
        internal System.Windows.Forms.TextBox manv_txt;
        internal System.Windows.Forms.TextBox ngay_txt;
        internal System.Windows.Forms.TextBox sogio_txt;
        internal System.Windows.Forms.TextBox macong_txt;
        private System.Windows.Forms.ComboBox cb_search;
        internal System.Windows.Forms.TextBox search_txt;
    }
}
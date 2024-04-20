namespace QuanLyNhanVien
{
    partial class Cong
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
            this.datagridcong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.macong_txt = new System.Windows.Forms.MaskedTextBox();
            this.loaicong_txt = new System.Windows.Forms.MaskedTextBox();
            this.hscong_txt = new System.Windows.Forms.MaskedTextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcong)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridcong
            // 
            this.datagridcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridcong.Location = new System.Drawing.Point(118, 189);
            this.datagridcong.Name = "datagridcong";
            this.datagridcong.Size = new System.Drawing.Size(375, 172);
            this.datagridcong.TabIndex = 1;
            this.datagridcong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hệ số công";
            // 
            // macong_txt
            // 
            this.macong_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macong_txt.Location = new System.Drawing.Point(731, 205);
            this.macong_txt.Name = "macong_txt";
            this.macong_txt.Size = new System.Drawing.Size(190, 27);
            this.macong_txt.TabIndex = 6;
            // 
            // loaicong_txt
            // 
            this.loaicong_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaicong_txt.Location = new System.Drawing.Point(731, 260);
            this.loaicong_txt.Name = "loaicong_txt";
            this.loaicong_txt.Size = new System.Drawing.Size(190, 27);
            this.loaicong_txt.TabIndex = 7;
            // 
            // hscong_txt
            // 
            this.hscong_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hscong_txt.Location = new System.Drawing.Point(731, 315);
            this.hscong_txt.Name = "hscong_txt";
            this.hscong_txt.Size = new System.Drawing.Size(190, 27);
            this.hscong_txt.TabIndex = 8;
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(48, 404);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(85, 27);
            this.bt_them.TabIndex = 9;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(159, 404);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(85, 27);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click_1);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(274, 404);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(85, 27);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_1);
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoi.Location = new System.Drawing.Point(386, 404);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(85, 27);
            this.bt_lammoi.TabIndex = 12;
            this.bt_lammoi.Text = "Làm mới";
            this.bt_lammoi.UseVisualStyleBackColor = true;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click_1);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(494, 404);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(85, 27);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click_1);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã công",
            "Loại công",
            "Hệ số công"});
            this.cb_search.Location = new System.Drawing.Point(118, 147);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(148, 27);
            this.cb_search.TabIndex = 14;
            this.cb_search.Text = "Tìm kiếm theo";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(272, 148);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(221, 26);
            this.search_txt.TabIndex = 15;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // Cong
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
            this.Controls.Add(this.hscong_txt);
            this.Controls.Add(this.loaicong_txt);
            this.Controls.Add(this.macong_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridcong);
            this.Name = "Cong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.datagridcong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridcong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox macong_txt;
        private System.Windows.Forms.MaskedTextBox loaicong_txt;
        private System.Windows.Forms.MaskedTextBox hscong_txt;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_lammoi;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.MaskedTextBox search_txt;
    }
}
namespace QuanLyNhanVien
{
    partial class Luong
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
            this.datagridluong = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maluong_txt = new System.Windows.Forms.TextBox();
            this.mucluong_txt = new System.Windows.Forms.TextBox();
            this.tenluong_txt = new System.Windows.Forms.TextBox();
            this.bt_thoatl = new System.Windows.Forms.Button();
            this.bt_lammoil = new System.Windows.Forms.Button();
            this.bt_xoal = new System.Windows.Forms.Button();
            this.bt_sual = new System.Windows.Forms.Button();
            this.bt_theml = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG LƯƠNG";
            // 
            // datagridluong
            // 
            this.datagridluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridluong.Location = new System.Drawing.Point(141, 171);
            this.datagridluong.Name = "datagridluong";
            this.datagridluong.Size = new System.Drawing.Size(357, 159);
            this.datagridluong.TabIndex = 1;
            this.datagridluong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridluong_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mức lương";
            // 
            // maluong_txt
            // 
            this.maluong_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maluong_txt.Location = new System.Drawing.Point(725, 184);
            this.maluong_txt.Name = "maluong_txt";
            this.maluong_txt.Size = new System.Drawing.Size(185, 26);
            this.maluong_txt.TabIndex = 5;
            // 
            // mucluong_txt
            // 
            this.mucluong_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mucluong_txt.Location = new System.Drawing.Point(725, 292);
            this.mucluong_txt.Name = "mucluong_txt";
            this.mucluong_txt.Size = new System.Drawing.Size(185, 26);
            this.mucluong_txt.TabIndex = 6;
            // 
            // tenluong_txt
            // 
            this.tenluong_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenluong_txt.Location = new System.Drawing.Point(725, 238);
            this.tenluong_txt.Name = "tenluong_txt";
            this.tenluong_txt.Size = new System.Drawing.Size(185, 26);
            this.tenluong_txt.TabIndex = 7;
            // 
            // bt_thoatl
            // 
            this.bt_thoatl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoatl.Location = new System.Drawing.Point(514, 374);
            this.bt_thoatl.Name = "bt_thoatl";
            this.bt_thoatl.Size = new System.Drawing.Size(75, 34);
            this.bt_thoatl.TabIndex = 19;
            this.bt_thoatl.Text = "Thoát";
            this.bt_thoatl.UseVisualStyleBackColor = true;
            this.bt_thoatl.Click += new System.EventHandler(this.bt_thoatl_Click_1);
            // 
            // bt_lammoil
            // 
            this.bt_lammoil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoil.Location = new System.Drawing.Point(393, 374);
            this.bt_lammoil.Name = "bt_lammoil";
            this.bt_lammoil.Size = new System.Drawing.Size(85, 34);
            this.bt_lammoil.TabIndex = 18;
            this.bt_lammoil.Text = "Làm mới";
            this.bt_lammoil.UseVisualStyleBackColor = true;
            this.bt_lammoil.Click += new System.EventHandler(this.bt_lammoil_Click_1);
            // 
            // bt_xoal
            // 
            this.bt_xoal.Enabled = false;
            this.bt_xoal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoal.Location = new System.Drawing.Point(282, 374);
            this.bt_xoal.Name = "bt_xoal";
            this.bt_xoal.Size = new System.Drawing.Size(75, 34);
            this.bt_xoal.TabIndex = 17;
            this.bt_xoal.Text = "Xóa";
            this.bt_xoal.UseVisualStyleBackColor = true;
            this.bt_xoal.Click += new System.EventHandler(this.bt_xoal_Click_1);
            // 
            // bt_sual
            // 
            this.bt_sual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sual.Location = new System.Drawing.Point(173, 374);
            this.bt_sual.Name = "bt_sual";
            this.bt_sual.Size = new System.Drawing.Size(81, 34);
            this.bt_sual.TabIndex = 16;
            this.bt_sual.Text = "Sửa";
            this.bt_sual.UseVisualStyleBackColor = true;
            this.bt_sual.Click += new System.EventHandler(this.bt_sual_Click_1);
            // 
            // bt_theml
            // 
            this.bt_theml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_theml.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_theml.Location = new System.Drawing.Point(56, 374);
            this.bt_theml.Name = "bt_theml";
            this.bt_theml.Size = new System.Drawing.Size(85, 34);
            this.bt_theml.TabIndex = 15;
            this.bt_theml.Text = "Thêm";
            this.bt_theml.UseVisualStyleBackColor = true;
            this.bt_theml.Click += new System.EventHandler(this.bt_theml_Click_1);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã lương",
            "Tên lương",
            "Mức lương"});
            this.cb_search.Location = new System.Drawing.Point(141, 125);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(145, 27);
            this.cb_search.TabIndex = 20;
            this.cb_search.Text = "Tìm kiếm theo";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(292, 126);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(206, 26);
            this.search_txt.TabIndex = 21;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.bt_thoatl);
            this.Controls.Add(this.bt_lammoil);
            this.Controls.Add(this.bt_xoal);
            this.Controls.Add(this.bt_sual);
            this.Controls.Add(this.bt_theml);
            this.Controls.Add(this.tenluong_txt);
            this.Controls.Add(this.mucluong_txt);
            this.Controls.Add(this.maluong_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridluong);
            this.Controls.Add(this.label1);
            this.Name = "Luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luong";
            ((System.ComponentModel.ISupportInitialize)(this.datagridluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maluong_txt;
        private System.Windows.Forms.TextBox mucluong_txt;
        private System.Windows.Forms.TextBox tenluong_txt;
        private System.Windows.Forms.Button bt_thoatl;
        private System.Windows.Forms.Button bt_lammoil;
        private System.Windows.Forms.Button bt_xoal;
        private System.Windows.Forms.Button bt_sual;
        private System.Windows.Forms.Button bt_theml;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox search_txt;
    }
}
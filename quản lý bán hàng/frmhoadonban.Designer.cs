namespace quản_lý_bán_hàng
{
    partial class frmhoadonban
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbomahdban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomakhach = new System.Windows.Forms.ComboBox();
            this.cbomanhanvien = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtngayban = new System.Windows.Forms.DateTimePicker();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbomahang = new System.Windows.Forms.ComboBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvhdnanhang = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.btnhuyhoadon = new System.Windows.Forms.Button();
            this.btnluuhoadon = new System.Windows.Forms.Button();
            this.btnthemhoadon = new System.Windows.Forms.Button();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdnanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.cbomahdban);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 44);
            this.panel1.TabIndex = 0;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(329, 14);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(110, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // cbomahdban
            // 
            this.cbomahdban.FormattingEnabled = true;
            this.cbomahdban.Location = new System.Drawing.Point(119, 14);
            this.cbomahdban.Name = "cbomahdban";
            this.cbomahdban.Size = new System.Drawing.Size(182, 24);
            this.cbomahdban.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(878, 422);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbomakhach);
            this.groupBox1.Controls.Add(this.cbomanhanvien);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenkhach);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.txtngayban);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.txtmahoadon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin chung";
            // 
            // cbomakhach
            // 
            this.cbomakhach.FormattingEnabled = true;
            this.cbomakhach.Location = new System.Drawing.Point(536, 22);
            this.cbomakhach.Name = "cbomakhach";
            this.cbomakhach.Size = new System.Drawing.Size(165, 24);
            this.cbomakhach.TabIndex = 36;
            // 
            // cbomanhanvien
            // 
            this.cbomanhanvien.FormattingEnabled = true;
            this.cbomanhanvien.Location = new System.Drawing.Point(166, 96);
            this.cbomanhanvien.Name = "cbomanhanvien";
            this.cbomanhanvien.Size = new System.Drawing.Size(165, 24);
            this.cbomanhanvien.TabIndex = 35;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(536, 95);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(165, 22);
            this.txtdiachi.TabIndex = 34;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(536, 64);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.ReadOnly = true;
            this.txttenkhach.Size = new System.Drawing.Size(165, 22);
            this.txttenkhach.TabIndex = 31;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(536, 132);
            this.txtdienthoai.Mask = "(999) 000-0000";
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.ReadOnly = true;
            this.txtdienthoai.Size = new System.Drawing.Size(165, 22);
            this.txtdienthoai.TabIndex = 30;
            // 
            // txtngayban
            // 
            this.txtngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngayban.Location = new System.Drawing.Point(166, 59);
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(165, 22);
            this.txtngayban.TabIndex = 11;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(166, 132);
            this.txttennv.Name = "txttennv";
            this.txttennv.ReadOnly = true;
            this.txttennv.Size = new System.Drawing.Size(165, 22);
            this.txttennv.TabIndex = 10;
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(166, 24);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.ReadOnly = true;
            this.txtmahoadon.Size = new System.Drawing.Size(165, 22);
            this.txtmahoadon.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(324, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa đơn bán hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbomahang);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.txtdongiaban);
            this.groupBox2.Controls.Add(this.txtgiamgia);
            this.groupBox2.Controls.Add(this.txttenhang);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dgvhdnanhang);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".";
            // 
            // cbomahang
            // 
            this.cbomahang.FormattingEnabled = true;
            this.cbomahang.Location = new System.Drawing.Point(116, 11);
            this.cbomahang.Name = "cbomahang";
            this.cbomahang.Size = new System.Drawing.Size(165, 24);
            this.cbomahang.TabIndex = 63;
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(683, 42);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(165, 22);
            this.txtthanhtien.TabIndex = 62;
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.Location = new System.Drawing.Point(683, 5);
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.ReadOnly = true;
            this.txtdongiaban.Size = new System.Drawing.Size(165, 22);
            this.txtdongiaban.TabIndex = 61;
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(416, 42);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(165, 22);
            this.txtgiamgia.TabIndex = 60;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(416, 5);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.ReadOnly = true;
            this.txttenhang.Size = new System.Drawing.Size(165, 22);
            this.txttenhang.TabIndex = 59;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(116, 45);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(165, 22);
            this.txtsoluong.TabIndex = 58;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(608, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 56;
            this.label17.Text = "Thành tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(609, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 55;
            this.label16.Text = "Đơn giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Giảm giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 53;
            this.label13.Text = "Tên hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Mã hàng";
            // 
            // dgvhdnanhang
            // 
            this.dgvhdnanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhdnanhang.Location = new System.Drawing.Point(6, 73);
            this.dgvhdnanhang.Name = "dgvhdnanhang";
            this.dgvhdnanhang.RowHeadersWidth = 51;
            this.dgvhdnanhang.RowTemplate.Height = 24;
            this.dgvhdnanhang.Size = new System.Drawing.Size(866, 132);
            this.dgvhdnanhang.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(413, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 5;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(690, 485);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(126, 32);
            this.btndong.TabIndex = 23;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // btninhoadon
            // 
            this.btninhoadon.Location = new System.Drawing.Point(521, 485);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(126, 32);
            this.btninhoadon.TabIndex = 21;
            this.btninhoadon.Text = "In hóa đơn";
            this.btninhoadon.UseVisualStyleBackColor = true;
            // 
            // btnhuyhoadon
            // 
            this.btnhuyhoadon.Location = new System.Drawing.Point(373, 485);
            this.btnhuyhoadon.Name = "btnhuyhoadon";
            this.btnhuyhoadon.Size = new System.Drawing.Size(128, 32);
            this.btnhuyhoadon.TabIndex = 20;
            this.btnhuyhoadon.Text = "Hủy hóa đơn";
            this.btnhuyhoadon.UseVisualStyleBackColor = true;
            // 
            // btnluuhoadon
            // 
            this.btnluuhoadon.Location = new System.Drawing.Point(218, 485);
            this.btnluuhoadon.Name = "btnluuhoadon";
            this.btnluuhoadon.Size = new System.Drawing.Size(128, 32);
            this.btnluuhoadon.TabIndex = 19;
            this.btnluuhoadon.Text = "Lưu hóa đơn";
            this.btnluuhoadon.UseVisualStyleBackColor = true;
            // 
            // btnthemhoadon
            // 
            this.btnthemhoadon.Location = new System.Drawing.Point(65, 485);
            this.btnthemhoadon.Name = "btnthemhoadon";
            this.btnthemhoadon.Size = new System.Drawing.Size(126, 32);
            this.btnthemhoadon.TabIndex = 18;
            this.btnthemhoadon.Text = "Thêm hóa đơn";
            this.btnthemhoadon.UseVisualStyleBackColor = true;
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(39, 437);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(63, 16);
            this.lbltongtien.TabIndex = 24;
            this.lbltongtien.Text = "Bằng chữ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(698, 444);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 18);
            this.label19.TabIndex = 26;
            this.label19.Text = "Tổng tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(773, 440);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(105, 22);
            this.txttongtien.TabIndex = 27;
            // 
            // frmhoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 567);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.btnhuyhoadon);
            this.Controls.Add(this.btnthemhoadon);
            this.Controls.Add(this.btnluuhoadon);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmhoadonban";
            this.Text = "frmhoadonban";
            this.Load += new System.EventHandler(this.frmhoadonban_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdnanhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox cbomahdban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtngayban;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.MaskedTextBox txtdienthoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvhdnanhang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.Button btnhuyhoadon;
        private System.Windows.Forms.Button btnluuhoadon;
        private System.Windows.Forms.Button btnthemhoadon;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cbomakhach;
        private System.Windows.Forms.ComboBox cbomanhanvien;
        private System.Windows.Forms.ComboBox cbomahang;
    }
}
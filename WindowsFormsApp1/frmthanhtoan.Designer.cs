
namespace WindowsFormsApp1
{
    partial class aaa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aaa));
            this.lb1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donggia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dthsd = new System.Windows.Forms.DateTimePicker();
            this.l4 = new System.Windows.Forms.Label();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.txtnsx = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnhapmahd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbmakh = new System.Windows.Forms.ComboBox();
            this.cbbmanv = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.macthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macthh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(43, 93);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(95, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã hàng hóa:";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(43, 140);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(101, 17);
            this.l2.TabIndex = 1;
            this.l2.Text = "Tên hàng hóa:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(43, 186);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(95, 17);
            this.l.TabIndex = 2;
            this.l.Text = "Nhà sản xuất:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahh,
            this.tenhh,
            this.donggia,
            this.nsx,
            this.hsd});
            this.dataGridView1.Location = new System.Drawing.Point(14, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 227);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mahh
            // 
            this.mahh.DataPropertyName = "mahh";
            this.mahh.HeaderText = "Mã hàng hóa";
            this.mahh.MinimumWidth = 6;
            this.mahh.Name = "mahh";
            this.mahh.ReadOnly = true;
            // 
            // tenhh
            // 
            this.tenhh.DataPropertyName = "tenhh";
            this.tenhh.HeaderText = "Tên hàng hóa";
            this.tenhh.MinimumWidth = 6;
            this.tenhh.Name = "tenhh";
            this.tenhh.ReadOnly = true;
            // 
            // donggia
            // 
            this.donggia.DataPropertyName = "donggia";
            this.donggia.HeaderText = "Đồng giá";
            this.donggia.MinimumWidth = 6;
            this.donggia.Name = "donggia";
            this.donggia.ReadOnly = true;
            // 
            // nsx
            // 
            this.nsx.DataPropertyName = "nsx";
            this.nsx.HeaderText = "Nhà sản xuất";
            this.nsx.MinimumWidth = 6;
            this.nsx.Name = "nsx";
            this.nsx.ReadOnly = true;
            // 
            // hsd
            // 
            this.hsd.DataPropertyName = "hsd";
            this.hsd.HeaderText = "Hạn sử dụng";
            this.hsd.MinimumWidth = 6;
            this.hsd.Name = "hsd";
            this.hsd.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.manv,
            this.makh,
            this.ngayhd,
            this.tongtien,
            this.trangthai});
            this.dataGridView2.Location = new System.Drawing.Point(686, 371);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(806, 227);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            // 
            // ngayhd
            // 
            this.ngayhd.DataPropertyName = "ngayhd";
            this.ngayhd.HeaderText = "Ngày hóa đơn";
            this.ngayhd.MinimumWidth = 6;
            this.ngayhd.Name = "ngayhd";
            this.ngayhd.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // dthsd
            // 
            this.dthsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dthsd.Location = new System.Drawing.Point(230, 236);
            this.dthsd.Name = "dthsd";
            this.dthsd.Size = new System.Drawing.Size(120, 22);
            this.dthsd.TabIndex = 5;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(43, 236);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(93, 17);
            this.l4.TabIndex = 6;
            this.l4.Text = "Hạn sử dụng:";
            // 
            // txtmahh
            // 
            this.txtmahh.Location = new System.Drawing.Point(230, 93);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(100, 22);
            this.txtmahh.TabIndex = 7;
            // 
            // txttenhh
            // 
            this.txttenhh.Location = new System.Drawing.Point(230, 135);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(100, 22);
            this.txttenhh.TabIndex = 8;
            this.txttenhh.TextChanged += new System.EventHandler(this.txttenhh_TextChanged);
            // 
            // txtnsx
            // 
            this.txtnsx.Location = new System.Drawing.Point(230, 186);
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(100, 22);
            this.txtnsx.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(230, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1029, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng tiền:";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtongtien.Location = new System.Drawing.Point(1107, 630);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(36, 20);
            this.lbtongtien.TabIndex = 13;
            this.lbtongtien.Text = "$$$";
            this.lbtongtien.Click += new System.EventHandler(this.lbtongtien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nhập mã hóa đơn:";
            // 
            // txtnhapmahd
            // 
            this.txtnhapmahd.Location = new System.Drawing.Point(847, 88);
            this.txtnhapmahd.Name = "txtnhapmahd";
            this.txtnhapmahd.Size = new System.Drawing.Size(100, 22);
            this.txtnhapmahd.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tạo hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "Tìm mã hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Thêm ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã Khách hàng:";
            // 
            // cbbmakh
            // 
            this.cbbmakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmakh.FormattingEnabled = true;
            this.cbbmakh.Location = new System.Drawing.Point(847, 194);
            this.cbbmakh.Name = "cbbmakh";
            this.cbbmakh.Size = new System.Drawing.Size(121, 24);
            this.cbbmakh.TabIndex = 27;
            // 
            // cbbmanv
            // 
            this.cbbmanv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmanv.FormattingEnabled = true;
            this.cbbmanv.Location = new System.Drawing.Point(847, 136);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.Size = new System.Drawing.Size(121, 24);
            this.cbbmanv.TabIndex = 28;
            this.cbbmanv.SelectedIndexChanged += new System.EventHandler(this.cbbmanv_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macthd,
            this.macthh,
            this.soluong});
            this.dataGridView3.Location = new System.Drawing.Point(1013, 88);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(435, 182);
            this.dataGridView3.TabIndex = 29;
            // 
            // macthd
            // 
            this.macthd.DataPropertyName = "mahd";
            this.macthd.HeaderText = "Mã hóa đơn";
            this.macthd.MinimumWidth = 6;
            this.macthd.Name = "macthd";
            this.macthd.ReadOnly = true;
            // 
            // macthh
            // 
            this.macthh.DataPropertyName = "mahh";
            this.macthh.HeaderText = "Mã hàng hóa";
            this.macthh.MinimumWidth = 6;
            this.macthh.Name = "macthh";
            this.macthh.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1135, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chi tiết hóa đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Hàng hóa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1030, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Hóa đơn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1013, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 36);
            this.button4.TabIndex = 33;
            this.button4.Text = "Thanh toán";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Thanh Toán";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 73);
            this.panel1.TabIndex = 35;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 35);
            this.button5.TabIndex = 36;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(484, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 35);
            this.button6.TabIndex = 37;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // aaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1610, 820);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.cbbmanv);
            this.Controls.Add(this.cbbmakh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnhapmahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtnsx);
            this.Controls.Add(this.txttenhh);
            this.Controls.Add(this.txtmahh);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.dthsd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aaa";
            this.Text = "frmthanhtoan";
            this.Load += new System.EventHandler(this.frmthanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dthsd;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.TextBox txtnsx;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnhapmahd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbmakh;
        private System.Windows.Forms.ComboBox cbbmanv;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donggia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn macthh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
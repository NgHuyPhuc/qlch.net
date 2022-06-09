
namespace WindowsFormsApp1
{
    partial class frmkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkho));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtnsx = new System.Windows.Forms.TextBox();
            this.dthsd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahh,
            this.tenhh,
            this.sl,
            this.nsx,
            this.hsd});
            this.dataGridView1.Location = new System.Drawing.Point(513, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 392);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mahh
            // 
            this.mahh.DataPropertyName = "mahh";
            this.mahh.HeaderText = "Mã hàng hóa";
            this.mahh.MinimumWidth = 6;
            this.mahh.Name = "mahh";
            // 
            // tenhh
            // 
            this.tenhh.DataPropertyName = "tenhh";
            this.tenhh.HeaderText = "Tên hàng hóa";
            this.tenhh.MinimumWidth = 6;
            this.tenhh.Name = "tenhh";
            // 
            // sl
            // 
            this.sl.DataPropertyName = "sl";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            // 
            // nsx
            // 
            this.nsx.DataPropertyName = "nsx";
            this.nsx.HeaderText = "Nhà sản xuất";
            this.nsx.MinimumWidth = 6;
            this.nsx.Name = "nsx";
            // 
            // hsd
            // 
            this.hsd.DataPropertyName = "hsd";
            this.hsd.HeaderText = "Hạn sử dụng";
            this.hsd.MinimumWidth = 6;
            this.hsd.Name = "hsd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hạn sử dụng";
            // 
            // txtmahh
            // 
            this.txtmahh.Location = new System.Drawing.Point(182, 123);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(100, 22);
            this.txtmahh.TabIndex = 7;
            // 
            // txttenhh
            // 
            this.txttenhh.Location = new System.Drawing.Point(182, 178);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(100, 22);
            this.txttenhh.TabIndex = 8;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(182, 242);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 22);
            this.txtsl.TabIndex = 9;
            // 
            // txtnsx
            // 
            this.txtnsx.Location = new System.Drawing.Point(182, 298);
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(100, 22);
            this.txtnsx.TabIndex = 10;
            // 
            // dthsd
            // 
            this.dthsd.Location = new System.Drawing.Point(182, 350);
            this.dthsd.Name = "dthsd";
            this.dthsd.Size = new System.Drawing.Size(200, 22);
            this.dthsd.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Clear text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(88, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 77);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kho";
            // 
            // frmkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 820);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dthsd);
            this.Controls.Add(this.txtnsx);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txttenhh);
            this.Controls.Add(this.txtmahh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmkho";
            this.Text = "frmkho";
            this.Load += new System.EventHandler(this.frmkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtnsx;
        private System.Windows.Forms.DateTimePicker dthsd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsd;
    }
}
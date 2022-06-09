using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from hoadon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView1.DataSource = rs.Tables["da"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }

            try
            {
                string sql = "select *from nhanvien";
                conn = new SqlConnection(constr);
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "dta2");
                cbbmanv.DataSource = rs.Tables["dta2"];
                cbbmanv.DisplayMember = "tennv";
                cbbmanv.ValueMember = "manv";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }

            try
            {
                string sql = "select *from khachhang";
                conn = new SqlConnection(constr);
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "dta3");
                cbbmakh.DataSource = rs.Tables["dta3"];
                cbbmakh.DisplayMember = "tenkh";
                cbbmakh.ValueMember = "makh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }

            
        }
        private void load2()
        {
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from hoadon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView1.DataSource = rs.Tables["da"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                string mahd = txtmahd.Text;
                string manv = cbbmanv.SelectedValue.ToString();
                string makh = cbbmakh.SelectedValue.ToString();
                string tongtien = " ";
                string trangthai = "No";
                DateTime nghd = dateTimePicker1.Value;
                string sql = "insert into hoadon values(@mahd,@manv,@makh,@nghd,@tongtien,@trangthai)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@makh", makh));
                cmd.Parameters.Add(new SqlParameter("@nghd", nghd));
                cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
                cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
                cmd.ExecuteNonQuery();
                load2();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
        private void clear()
        {
            txtmahd.Text = " ";
            txttongtien.Text = "";
            cbbmakh.SelectedItem = "";
            cbbmanv.SelectedItem = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtmahd.Text = dataGridView1.Rows[i].Cells["MaHD"].Value.ToString();
                cbbmanv.SelectedValue = dataGridView1.Rows[i].Cells["manv"].Value.ToString();
                cbbmakh.SelectedValue = dataGridView1.Rows[i].Cells["makh"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[i].Cells["ngayhd"].Value.ToString());
                txttongtien.Text = dataGridView1.Rows[i].Cells["tongtien"].Value.ToString();
                if (dataGridView1.Rows[i].Cells["trangthai"].Value.ToString() == "Yes")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                //lbtongtien.Text = dataGridView1.Rows[i].Cells["tongtien"].Value.ToString();
                //string mahd = txtnhapmahd.Text;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void cbbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                string mahd = txtmahd.Text;
                string manv = cbbmanv.SelectedValue.ToString();
                string makh = cbbmakh.SelectedValue.ToString();
                string tongtien = txttongtien.Text;
                string trangthai = radioButton1.Checked ? "Yes":"No";
                DateTime nghd = dateTimePicker1.Value;
                string sql = "update hoadon set mahd=@mahd,manv=@manv,makh=@makh,ngayhd=@nghd,tongtien=@tongtien,trangthai=@trangthai where mahd=@mahd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@makh", makh));
                cmd.Parameters.Add(new SqlParameter("@nghd", nghd));
                cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
                cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
                cmd.ExecuteNonQuery();
                load2();
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtmahd.Text;
                conn = new SqlConnection(constr);
                conn.Open();
                string sql = "delete from hoadon where mahd=@mahd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                int ck = (int)cmd.ExecuteNonQuery();
                conn.Close();
                if (ck == 0)
                {
                    MessageBox.Show("Xoa that bai");
                }
                else
                {
                    MessageBox.Show("Xoa thanh cong");
                    load2();
                    clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
    }
}

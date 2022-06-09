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
    public partial class aaa : Form
    {
        public aaa()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        private void frmthanhtoan_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from cthoadon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView2.DataSource = rs.Tables["da"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }

            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from hanghoa";
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
                conn = new SqlConnection(constr);
                string sql = "select * from hoadon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da1");
                dataGridView2.DataSource = rs.Tables["da1"];
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
            catch(Exception ex)
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
        private void loadhanghoa()
        {
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from hanghoa";
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
        private void loadhd()
        {
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from hoadon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView2.DataSource = rs.Tables["da"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtmahh.Text = dataGridView1.Rows[i].Cells["mahh"].Value.ToString();
                txttenhh.Text = dataGridView1.Rows[i].Cells["tenhh"].Value.ToString();
                //txtsl.Text = dataGridView1.Rows[i].Cells["soluong"].Value.ToString();
                txtnsx.Text = dataGridView1.Rows[i].Cells["nsx"].Value.ToString();
                dthsd.Value = DateTime.Parse(dataGridView1.Rows[i].Cells["hsd"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtnhapmahd.Text = dataGridView2.Rows[i].Cells["MaHD"].Value.ToString();
                cbbmanv.SelectedValue = dataGridView2.Rows[i].Cells["manv"].Value.ToString();
                cbbmakh.SelectedValue = dataGridView2.Rows[i].Cells["makh"].Value.ToString();
                lbtongtien.Text = dataGridView2.Rows[i].Cells["tongtien"].Value.ToString();
                string mahd = txtnhapmahd.Text;
                conn = new SqlConnection(constr);
                string sql = "select * from cthoadon where mahd=@mahd";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                dta.SelectCommand.Parameters.Add(new SqlParameter("@mahd", mahd));
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView3.DataSource = rs.Tables["da"];
                

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
                string mahd = txtnhapmahd.Text;
                string manv = cbbmanv.SelectedValue.ToString();
                string makh = cbbmakh.SelectedValue.ToString();
                Console.WriteLine(manv, makh);
                string tongtien = " ";
                string trangthai = "No";
                DateTime nghd = DateTime.Now;
                string sl = numericUpDown1.Value.ToString();
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
                conn = new SqlConnection(constr);
                string mahd = txtnhapmahd.Text;
                string manv = cbbmanv.ValueMember;
                string makh = cbbmakh.ValueMember;
                string mahh = txtmahh.Text;
                string sl = numericUpDown1.Value.ToString();
                string sql = "insert into cthoadon values(@mahd,@mahh,@sl)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.Parameters.Add(new SqlParameter("@mahh", mahh));
                cmd.Parameters.Add(new SqlParameter("@sl", sl));
                cmd.ExecuteNonQuery();
                load2();
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
                string mahd = txtnhapmahd.Text;
                conn = new SqlConnection(constr);
                string sql = "select * from cthoadon where mahd=@mahd";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                dta.SelectCommand.Parameters.Add(new SqlParameter("@mahd",mahd));
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView3.DataSource = rs.Tables["da"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }

            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from hoadon";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da1");
                dataGridView2.DataSource = rs.Tables["da1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtnhapmahd.Text;
                conn = new SqlConnection(constr);
                string sql = "select * from cthoadon where mahd=@mahd";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                dta.SelectCommand.Parameters.Add(new SqlParameter("@mahd", mahd));
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView3.DataSource = rs.Tables["da"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void lbtongtien_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd=txtnhapmahd.Text;
                conn = new SqlConnection(constr);
                conn.Open();
                string sql = "update hoadon set trangthai='Yes' where mahd=@mahd";
                SqlCommand cmd=new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
                cmd.ExecuteNonQuery();
                load2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string tenhh = txttenhh.Text;
                conn = new SqlConnection(constr);
                conn.Open();
                string sql = "select *from hanghoa where tenhh like N'%"+ @tenhh + "%'";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                dta.SelectCommand.Parameters.Add(new SqlParameter("@tenhh", tenhh));
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView1.DataSource = rs.Tables["da"];

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadhanghoa();
            loadhd();
            load2();
            txtmahh.Text = "";
            txtnhapmahd.Text = "";
            txtnsx.Text = "";
            txttenhh.Text = "";
            numericUpDown1.Value = 0;
            dthsd.Value = DateTime.Now;
        }

        private void txttenhh_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string tenhh = txttenhh.Text;
            //    conn = new SqlConnection(constr);
            //    conn.Open();
            //    string sql = "select *from hanghoa where tenhh like N'%" + @tenhh + "%'";
            //    SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
            //    dta.SelectCommand.Parameters.Add(new SqlParameter("@tenhh", tenhh));
            //    DataSet rs = new DataSet();
            //    dta.Fill(rs, "da");
            //    dataGridView1.DataSource = rs.Tables["da"];


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Loi " + ex.Message);
            //}
        }
    }
}

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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select *from nhanvien";
                conn = new SqlConnection(constr);
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView1.DataSource = rs.Tables["da"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanv.Text = dataGridView1.Rows[i].Cells["manv"].Value.ToString();
            txttennv.Text = dataGridView1.Rows[i].Cells["tennv"].Value.ToString();
            txtque.Text = dataGridView1.Rows[i].Cells["quequan"].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells["sdt"].Value.ToString();
            txtchucvu.Text = dataGridView1.Rows[i].Cells["chucvu"].Value.ToString();
            txthsl.Text = dataGridView1.Rows[i].Cells["hsl"].Value.ToString();
            if(dataGridView1.Rows[i].Cells["gioitinh"].Value.ToString()=="Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string que = txtque.Text;
                string sdt = txtsdt.Text;
                string hsl = txthsl.Text;
                string chucvu = txtchucvu.Text;
                string gioitinh = radioButton1.Checked ? "Nam" : "Nu";
                string sql = "insert into nhanvien values(@manv,@tennv,@gioitinh,@que,@sdt,@chucvu,@hsl)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@tennv", tennv));
                cmd.Parameters.Add(new SqlParameter("@que", que));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@hsl", hsl));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
                int ck = (int)cmd.ExecuteNonQuery();
                if (ck == 0)
                {
                    MessageBox.Show("Them moi that bai");
                }
                else
                {
                    load();
                    clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string que = txtque.Text;
                string sdt = txtsdt.Text;
                string hsl = txthsl.Text;
                string chucvu = txtchucvu.Text;
                string gioitinh = radioButton1.Checked ? "Nam" : "Nu";
                string sql = "update nhanvien set manv=@manv,tennv=@tennv,gioitinh=@gioitinh,quequan=@que,sdt=@sdt,chucvu=@chucvu,hsl=@hsl where manv=@manv";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //List<SqlParameter>=
                cmd.Parameters.Add(new SqlParameter("@manv", manv));
                cmd.Parameters.Add(new SqlParameter("@tennv", tennv));
                cmd.Parameters.Add(new SqlParameter("@que", que));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@hsl", hsl));
                cmd.Parameters.Add(new SqlParameter("@chucvu", chucvu));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
                int ck = (int)cmd.ExecuteNonQuery();
                if (ck == 0)
                {
                    MessageBox.Show("Sua moi that bai");
                }
                else
                {
                    load();
                    clear();
                }
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
                conn.Open();
                string ma = txtmanv.Text;
                string sql = "delete from nhanvien where manv=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@ma", ma));
                int ck = (int)cmd.ExecuteNonQuery();
                conn.Close();
                if (ck == 0)
                {
                    MessageBox.Show("Xoa that bai");
                }
                else
                {
                    MessageBox.Show("Xoa thanh cong");
                    load();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void load()
        {
            try
            {
                string sql = "select *from nhanvien";
                conn = new SqlConnection(constr);
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
        private void clear()
        {
            txtchucvu.Text = " ";
            txthsl.Text = " ";
            txtmanv.Text = " ";
            txtque.Text = " ";
            txtsdt.Text = " ";
            txttennv.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
    }
}

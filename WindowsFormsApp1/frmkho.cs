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
    public partial class frmkho : Form
    {
        public frmkho()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmkho_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from kho";
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView1.DataSource = rs.Tables["da"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi "+ ex.Message);
            }
        }

        private void load()
        {
            try
            {
                conn = new SqlConnection(constr);
                string sql = "select * from kho";
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
                string mahh = txtmahh.Text;
                string tenhh = txttenhh.Text;
                int sl = Convert.ToInt32(txtsl.Text);
                string nsx = txtnsx.Text;
                DateTime hsd = dthsd.Value;
                string sql = "insert into kho values(@mahh,@tenhh,@sl,@nsx,@hsd)";
                conn = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add(new SqlParameter("@mahh", mahh));
                cmd.Parameters.Add(new SqlParameter("@tenhh", tenhh));
                cmd.Parameters.Add(new SqlParameter("@sl", sl));
                cmd.Parameters.Add(new SqlParameter("@nsx", nsx));
                cmd.Parameters.Add(new SqlParameter("@hsd", hsd));
                int ck = (int)cmd.ExecuteNonQuery();
                if(ck==0)
                {
                    MessageBox.Show("Them moi that bai");
                }
                else
                {
                    //MessageBox.Show("Them moi thanh cong");
                    load();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mahh = txtmahh.Text;
            string tenhh = txttenhh.Text;
            int sl = Convert.ToInt32(txtsl.Text);
            string nsx = txtnsx.Text;
            DateTime hsd = dthsd.Value;
            conn = new SqlConnection(constr);
            string sql = "update kho set mahh = @mahh, tenhh = @tenhh, soluong = @sl, nsx = @nsx, hsd = @hsd where mahh = @mahh";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahh", mahh));
            cmd.Parameters.Add(new SqlParameter("@tenhh", tenhh));
            cmd.Parameters.Add(new SqlParameter("@sl", sl));
            cmd.Parameters.Add(new SqlParameter("@nsx", nsx));
            cmd.Parameters.Add(new SqlParameter("@hsd", hsd));
            int ck = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if(ck==0)
            {
                MessageBox.Show("Update that bai");
            }
            else
            {
                //MessageBox.Show("Update thanh cong");
                load();
                setspace();
            }
        }
        private void setspace()
        {
            txtmahh.Text = "";
            txttenhh.Text = "";
            txtsl.Text = "";
            txtnsx.Text = "";
            dthsd.Value = DateTime.Today;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtmahh.Text = dataGridView1.Rows[i].Cells["mahh"].Value.ToString();
                txttenhh.Text = dataGridView1.Rows[i].Cells["tenhh"].Value.ToString();
                txtsl.Text = dataGridView1.Rows[i].Cells["sl"].Value.ToString();
                txtnsx.Text = dataGridView1.Rows[i].Cells["nsx"].Value.ToString();
                dthsd.Value = DateTime.Parse(dataGridView1.Rows[i].Cells["hsd"].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setspace();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                string ma = txtmahh.Text;
                string sql = "delete from kho where mahh=@ma";
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
                    //MessageBox.Show("Xoa thanh cong");
                    load();
                    setspace();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
    }
}

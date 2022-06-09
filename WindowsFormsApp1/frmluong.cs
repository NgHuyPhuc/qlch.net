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
    public partial class frmluong : Form
    {
        public frmluong()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        private void frmnsx_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            conn = new SqlConnection(constr);
            string sql = "select * from nhanvien where chucvu='nv'";
            SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
            DataSet rs = new DataSet();
            dta.Fill(rs, "da");
            dataGridView1.DataSource = rs.Tables["da"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                lbten.Text= dataGridView1.Rows[i].Cells["tennv"].Value.ToString();
                lbhsl.Text= dataGridView1.Rows[i].Cells["hsl"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hsl = lbhsl.Text;
            int hslx = int.Parse(hsl);
            int ngay = int.Parse(textBox1.Text);
            int luong = hslx * ngay*200000;
            lbluong.Text = luong.ToString();
        }
    }
}

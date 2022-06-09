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
    public partial class thanhtoan : Form
    {
        public thanhtoan()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        EExecl excel = new EExecl();
        private void thanhtoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                string sql = "select *from hoadon where ngayhd>@dt1 and ngayhd<@dt2";
                conn = new SqlConnection(constr);
                SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                dta.SelectCommand.Parameters.Add(new SqlParameter("@dt1", dt1));
                dta.SelectCommand.Parameters.Add(new SqlParameter("@dt2", dt2));
                DataSet rs = new DataSet();
                dta.Fill(rs, "da");
                dataGridView1.DataSource = rs.Tables["da"];


                string sql2 = "select SUM (tongtien)as doanhthu from HoaDon where trangthai='yes' and ngayhd>@dt1 and ngayhd<@dt2 ";
                conn.Open();
                SqlDataAdapter dta2 = new SqlDataAdapter(sql2, conn);
                dta2.SelectCommand.Parameters.Add(new SqlParameter("@dt1", dt1));
                dta2.SelectCommand.Parameters.Add(new SqlParameter("@dt2", dt2));
                DataSet rs2 = new DataSet();
                dta2.Fill(rs2, "da2");
                lbdoanhthu.Text = rs2.Tables["da2"].Rows[0]["doanhthu"].ToString();
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

                List<String> ValueName = new List<string>();
                DataTable dataTable = (DataTable)(dataGridView1.DataSource);
                DataSet rs = new DataSet();
                rs.Merge(dataTable);
                dataGridView1.DataSource = rs.Tables[0];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    ValueName.Add(dataGridView1.Columns[i].HeaderText);
                }

                excel.CreateExcelFile(ValueName, rs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*try
            {
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                string sql2 = "select SUM (tongtien) from HoaDon where trangthai='yes' and ngayhd>@dt1 and ngayhd<@dt2 ";
                conn.Open();
                SqlDataAdapter dta2 = new SqlDataAdapter(sql2, conn);
                dta2.SelectCommand.Parameters.Add(new SqlParameter("@dt1", dt1));
                dta2.SelectCommand.Parameters.Add(new SqlParameter("@dt2", dt2));
                DataSet rs2 = new DataSet();
                dta2.Fill(rs2, "da2");
                lbdoanhthu.Text = rs2.Tables["da2"].Rows[0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }*/
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bieudo frm = new bieudo();
            frm.Show();
        }
    }
}

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
    public partial class bieudo : Form
    {
        public bieudo()
        {
            InitializeComponent();
        }
        string constr = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456";
        SqlConnection conn = null;
        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void bieudo_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= 12; i++)
                {
                    string sql = "select sum(tongtien) as tongtien from hoadon where month(ngayhd)=@month and trangthai='yes' ";
                    conn = new SqlConnection(constr);
                    SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
                    dta.SelectCommand.Parameters.Add(new SqlParameter("month", i));
                    DataSet rs = new DataSet();
                    dta.Fill(rs, "da");
                    chart1.DataSource = rs;
                    chart1.Series["Doanhthu"].Points.AddXY("T" + i, rs.Tables["da"].Rows[0]["tongtien"].ToString());


                    //string sql = "Select sum(TongTien*1) as Tong from HoaDon Where MONTH(NgayHD) = @month";
                    //List<SqlParameter> dt = new List<SqlParameter>();
                    //dt.Add(new SqlParameter("@month", i));
                    //DataSet rs = conn.getData(sql, "HD", dt);
                    //chart1.DataSource = rs;
                    //chart1.Series["DoanhThu"].Points.AddXY("T" + i, rs.Tables["HD"].Rows[0]["Tong"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
    }
}
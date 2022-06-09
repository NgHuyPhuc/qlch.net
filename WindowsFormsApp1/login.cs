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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456 ";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string tk = txttk.Text;
                string mk = txtmk.Text;
                string sql = "select count(*) from nguoidung where taikhoan=@tk and matkhau=@mk";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                int check = (int)cmd.ExecuteScalar();
                conn.Close();
                if(check==1)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    frmmain frm = new frmmain();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("LOI!" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string con_str = "data source=LAPTOP-QQM98R2J;initial catalog=qlcht1;user=sa;password=123456 ";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string tk = txttk.Text;
                string mk = txtmk.Text;
                string sql = "select count(*) from nguoidung where taikhoan=@tk and matkhau=@mk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                int check = (int)cmd.ExecuteScalar();
                conn.Close();
                if (check == 1)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    frmmain frm = new frmmain();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI!" + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

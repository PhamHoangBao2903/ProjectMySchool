using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH
{
    public partial class LOGIN : Form
    {
        SqlConnection connect;
        public LOGIN()
        {
            connect = new SqlConnection("Data Source = DESKTOP-LS17S4E\\SQLEXPRESS;Initial Catalog = QL_SANBONG;Integrated Security =True");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "SELECT * FROM NHANVIEN WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlParameter parataikhoan = new SqlParameter("@TAIKHOAN", textTAIKHOAN.Text);
                SqlParameter paraMatKhau = new SqlParameter("@MATKHAU", textMATKHAU.Text);
                cmd.Parameters.Add(parataikhoan);
                cmd.Parameters.Add(paraMatKhau);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        this.Hide();
                        main form = new main();
                        form.ShowDialog();
                        this.Close();
                    }
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Tài khoản không đúng. Vui lòng gọi hỗ trợ","Thông Báo");
            }
            finally
            {
                if(connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình ?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       
    }
}

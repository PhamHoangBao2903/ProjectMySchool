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

namespace ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH
{
    public partial class DICHVU : Form
    {
        SqlConnection connect;
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];

        public DICHVU()
        {
            connect = new SqlConnection("Data Source = DESKTOP-LS17S4E\\SQLEXPRESS;Initial Catalog = QL_SANBONG;Integrated Security =True");
            InitializeComponent();
        }

        public void LOAD_DATA()
        {
            string sql = "SELECT * FROM DICHVU";
            da = new SqlDataAdapter(sql, connect);
            ds = new DataSet();
            da.Fill(ds, "DICHVU");
            key[0] = ds.Tables["DICHVU"].Columns[0];
            ds.Tables["DICHVU"].PrimaryKey = key;
            dataGridView1.DataSource = ds.Tables["DICHVU"];
        }
      
        private void DICHVU_Load(object sender, EventArgs e)
        {
            LOAD_DATA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "SELECT * FROM DICHVU WHERE MADV = @MADV";
                SqlCommand cmd = new SqlCommand(sql,connect);
                cmd.CommandType = CommandType.Text;
                SqlParameter paraMADV = new SqlParameter("@MADV", textMADICHVU.Text);
                SqlParameter paraTENDV = new SqlParameter("@TENDV", textTENDICHVU.Text);
                SqlParameter paraDONGIA = new SqlParameter("@DONGIA", textDONGIA.Text);
                cmd.Parameters.Add(paraMADV);
                cmd.Parameters.Add(paraTENDV);
                cmd.Parameters.Add(paraDONGIA);
                var reader = cmd.ExecuteReader();
                if(string.IsNullOrEmpty(textMADICHVU.Text) || string.IsNullOrEmpty(textTENDICHVU.Text)||string.IsNullOrEmpty(textDONGIA.Text))
                {
                    return;
                }
                while(reader.HasRows)
                {
                    MessageBox.Show("Dịch vụ này đã tồn tại");
                    return;
                }
                reader.Close();
                cmd.CommandText = "INSERT INTO DICHVU (MADV,TENDV,DONGIA) VALUES (@MADV,@TENDV,@DONGIA)";
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm Thành Công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thể thêm","Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm", "Thông báo");
            }
            finally
            {
                if(connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                LOAD_DATA();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
            {
                textDONGIA.Text = dataGridView1.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString();
                textMADICHVU.Text = dataGridView1.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                textTENDICHVU.Text = dataGridView1.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "DELETE DICHVU WHERE MADV = @MADICHVU";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlParameter paraMADICHVU = new SqlParameter("@MADICHVU", textMADICHVU.Text);
                cmd.Parameters.Add(paraMADICHVU);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("DELETE THÀNH CÔNG", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("KHÔNG DELETE ĐƯỢC", "LỖI");
                }

            }
            catch
            {
                MessageBox.Show("Không thể xóa bảng này", "Thông Báo");
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                LOAD_DATA();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "UPDATE DICHVU SET TENDV = @TENDV,DONGIA = @DONGIA where MADV = @MADV";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlParameter paraMADV = new SqlParameter("@MADV", textMADICHVU.Text);
                SqlParameter paraTENDV = new SqlParameter("@TENDV", textTENDICHVU.Text);
                SqlParameter paraDONGIA = new SqlParameter("@DONGIA", textDONGIA.Text);
                cmd.Parameters.Add(paraMADV);
                cmd.Parameters.Add(paraTENDV);
                cmd.Parameters.Add(paraDONGIA);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("UPDATE THÀNH CÔNG", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhập bảng này", "Thông Báo");
                }

            }
            catch
            {
                MessageBox.Show("Không thể cập nhập bảng này", "Thông Báo");
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                LOAD_DATA();
            }
        }
    }
}

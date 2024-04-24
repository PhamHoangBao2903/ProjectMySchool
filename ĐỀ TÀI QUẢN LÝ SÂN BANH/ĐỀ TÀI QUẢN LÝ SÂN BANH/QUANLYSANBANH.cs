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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH
{
    public partial class QUANLYSANBANH : Form
    {
        SqlConnection connect;
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];

        public QUANLYSANBANH()
        {
            connect = new SqlConnection("Data Source = DESKTOP-LS17S4E\\SQLEXPRESS;Initial Catalog = QL_SANBONG;Integrated Security =True");
            InitializeComponent();
        }

        public void LOAD_FROM()
        {
            string sql = "SELECT * FROM SANBONG";
            da = new SqlDataAdapter(sql, connect);
            ds = new DataSet();
            da.Fill(ds, "SANBONG");
            key[0] = ds.Tables["SANBONG"].Columns[0];
            ds.Tables["SANBONG"].PrimaryKey = key;
            dataGridView1.DataSource = ds.Tables["SANBONG"];   
        }

       

        public void LOAD_COMBOBOX()
        {

           
            string sql = "SELECT * FROM LOAISAN";
            da = new SqlDataAdapter(sql,connect);
            ds = new DataSet();
            da.Fill(ds,"LOAISAN");
            comboBox1.DataSource = ds.Tables["LOAISAN"];
            comboBox1.DisplayMember = ("TENLOAI");
            comboBox1.ValueMember = ("MALOAI");
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LOAD_FROM();
            LOAD_COMBOBOX();
           
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sqlt = "SELECT * FROM SANBONG WHERE MASAN = @MASAN";
                SqlCommand cmd = new SqlCommand(sqlt, connect);
                SqlParameter paraMASAN = new SqlParameter("@MASAN", textMASAN.Text);
                SqlParameter paraTENSAN = new SqlParameter("@TENSAN", textTENSAN.Text);
                SqlParameter paraGIATHUE = new SqlParameter("@GIATHUE", textGIA.Text);
                SqlParameter paraMALOAI = new SqlParameter("@MALOAI", comboBox1.SelectedValue.ToString());
                cmd.Parameters.Add(paraMALOAI);
                cmd.Parameters.Add(paraTENSAN);
                cmd.Parameters.Add(paraGIATHUE);
                cmd.Parameters.Add(paraMASAN);
                var reader = cmd.ExecuteReader();
                if(string.IsNullOrEmpty(textTENSAN.Text) || string.IsNullOrEmpty(textTENSAN.Text) || string.IsNullOrEmpty(textGIA.Text))
                {
                    MessageBox.Show("Không được để trống", "Thông Báo");
                    return;
                }
                while (reader.HasRows)
                {
                    MessageBox.Show("Không thể thêm sân","Thông Báo");
                    return;
                }
                reader.Close();
                cmd.CommandText = "INSERT INTO SANBONG(MASAN,TENSAN,GIATHUE,MALOAI) VALUES (@MASAN,@TENSAN,@GIATHUE,@MALOAI)";
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("THÊM SÂN THÀNH CÔNG", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("không thể thêm sân");
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm sân");
            }
            finally
            {
                if(connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                LOAD_FROM();
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "DELETE SANBONG WHERE MASAN = @MASAN";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlParameter paraMASAN = new SqlParameter("@MASAN", textMASAN.Text);
                cmd.Parameters.Add(paraMASAN);
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
                if(connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                LOAD_FROM();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "UPDATE SANBONG SET TENSAN = @TENSAN,GIATHUE = @GIATHUE,MALOAI = @MALOAI where MASAN = @MASAN";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlParameter paraMASAN = new SqlParameter("@MASAN", textMASAN.Text);
                SqlParameter paraTENSAN = new SqlParameter("@TENSAN", textTENSAN.Text);
                SqlParameter paraGIATHUE = new SqlParameter("@GIATHUE", textGIA.Text);
                SqlParameter paraMALOAI = new SqlParameter("@MALOAI", comboBox1.SelectedValue.ToString());
                cmd.Parameters.Add(paraMALOAI);
                cmd.Parameters.Add(paraTENSAN);
                cmd.Parameters.Add(paraGIATHUE);
                cmd.Parameters.Add(paraMASAN);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sân Đã Được Sữa", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Không thể sửa bảng này", "Thông Báo");
                }

            }
            catch
            {
                MessageBox.Show("Không thể sửa bảng này", "Thông Báo");
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
                LOAD_FROM();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                dataGridView1.CurrentCell.Selected = true;
                textMASAN.Text = dataGridView1.Rows[e.RowIndex].Cells["MASAN"].Value.ToString();
                textTENSAN.Text = dataGridView1.Rows[e.RowIndex].Cells["TENSAN"].Value.ToString();
                textGIA.Text = dataGridView1.Rows[e.RowIndex].Cells["GIATHUE"].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["MALOAI"].Value.ToString();
               
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.Selected = true;
            textMASAN.Text = dataGridView1.Rows[e.RowIndex].Cells["MASAN"].Value.ToString();
            textTENSAN.Text = dataGridView1.Rows[e.RowIndex].Cells["TENSAN"].Value.ToString();
            textGIA.Text = dataGridView1.Rows[e.RowIndex].Cells["GIATHUE"].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["MALOAI"].Value.ToString();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SANBONG WHERE MASAN = @MASAN";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlParameter paraMALOP = new SqlParameter("@MASAN", textMASAN.Text);
            cmd.Parameters.Add(paraMALOP);
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}

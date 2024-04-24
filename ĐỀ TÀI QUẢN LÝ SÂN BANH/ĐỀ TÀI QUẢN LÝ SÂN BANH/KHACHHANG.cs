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
    public partial class KHACHHANG : Form
    {
        SqlConnection connect;
        SqlDataAdapter da;
        DataSet ds;
        DataTable tb;
        public KHACHHANG()
        {
            connect = new SqlConnection("Data Source = DESKTOP-LS17S4E\\SQLEXPRESS;Initial Catalog = QL_SANBONG;Integrated Security =True");
            InitializeComponent();
        }

        public void LOAD_DATA()
        {
            string sql = "SELECT * FROM KHACHHANG";
            da = new SqlDataAdapter(sql, connect);
            ds = new DataSet();
            da.Fill(ds, "KHACHHANG");
            dataGridView1.DataSource = ds.Tables["KHACHHANG"];
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            LOAD_DATA();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            string MAKH = dataGridView1.Rows[rowIndex].Cells["MAKH"].Value.ToString();
            string TENKH = dataGridView1.Rows[rowIndex].Cells["TENKH"].Value.ToString();
            string DIACHI = dataGridView1.Rows[rowIndex].Cells["DIACHI"].Value.ToString();
            string SDT = dataGridView1.Rows[rowIndex].Cells["SODIENTHOAI"].Value.ToString();

            if (radioButton1.Checked == true)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMAKH = new SqlParameter("@MAKH",MAKH);
                    SqlParameter paraTENKH = new SqlParameter("@TENKH", TENKH);
                    SqlParameter paraDIACHI = new SqlParameter("@DIACHI", DIACHI);
                    SqlParameter paraSDT = new SqlParameter("@SODIENTHOAI", SDT);
                    cmd.Parameters.Add(paraMAKH);
                    cmd.Parameters.Add(paraTENKH);
                    cmd.Parameters.Add(paraDIACHI);
                    cmd.Parameters.Add(paraSDT);

                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            MessageBox.Show("Khách hàng này đã tồn tại.");
                            return;
                        }
                    }
                    reader.Close();
                    cmd.CommandText = "INSERT KHACHHANG (MAKH,TENKH,DIACHI,SODIENTHOAI) VALUES (@MAKH,@TENKH,@DIACHI,@SODIENTHOAI)";
                    var result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        MessageBox.Show("Đã thêm thành công.","Thông báo");
                    }
                    else
                    {
                        MessageBox.Show ("Không thể thêm khách hàng.","Thông báo");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Không thể thêm khách hàng.", "Thông báo");
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
            else if(radioButton2.Checked == true)
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE KHACHHANG WHERE MAKH = @MAKH";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlParameter paraMAKH = new SqlParameter("@MAKH", MAKH);
                    cmd.Parameters.Add(paraMAKH);
                    var result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        MessageBox.Show("XÓA THÀNH CÔNG","Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng", "Thông báo");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Không thể xóa khách hàng", "Thông báo");
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
            else if(radioButton3.Checked == true)
            {
                try
                {
                    connect.Open();
                    string sql = "UPDATE KHACHHANG SET TENKH = @TENKH,DIACHI = @DIACHI,SODIENTHOAI = @SODIENTHOAI WHERE MAKH = @MAKH";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMAKH = new SqlParameter("@MAKH", MAKH);
                    SqlParameter paraTENKH = new SqlParameter("@TENKH", TENKH);
                    SqlParameter paraDIACHI = new SqlParameter("@DIACHI", DIACHI);
                    SqlParameter paraSDT = new SqlParameter("@SODIENTHOAI", SDT);
                    cmd.Parameters.Add(paraMAKH);
                    cmd.Parameters.Add(paraTENKH);
                    cmd.Parameters.Add(paraDIACHI);
                    cmd.Parameters.Add(paraSDT);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("UPDATE THÀNH CÔNG", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể update", "Thông báo");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Không thể update", "Thông báo");
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.ReadOnly = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE TENKH LIKE '%'+@TENKH+'%'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlParameter paraTENKH = new SqlParameter("@TENKH", textBox1.Text);
            cmd.Parameters.Add(paraTENKH);
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

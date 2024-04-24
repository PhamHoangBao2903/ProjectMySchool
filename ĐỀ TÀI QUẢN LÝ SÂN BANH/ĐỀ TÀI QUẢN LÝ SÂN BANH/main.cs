using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChilForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_formSANBANH_Click(object sender, EventArgs e)
        {
            OpenChilForm(new QUANLYSANBANH());
            label1.Text = button_formSANBANH.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void button_formDV_Click(object sender, EventArgs e)
        {
            OpenChilForm(new DICHVU());
            label1.Text = button_formDV.Text;
        }

        private void button_formKH_Click(object sender, EventArgs e)
        {
            OpenChilForm(new KHACHHANG());
            label1.Text = button_formKH.Text;
        }
    }
}

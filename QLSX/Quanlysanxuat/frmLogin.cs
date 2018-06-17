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

namespace Quanlysanxuat
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DataConnection dt = new DataConnection();
        private void tbtendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KiemTra";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = tbtendangnhap.Text;
            cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = tbmatkhau.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                frmTRANGCHU f = new frmTRANGCHU();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            reader.Close();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

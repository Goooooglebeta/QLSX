using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysanxuat
{
    public partial class frmTRANGCHU : Form
    {
        public frmTRANGCHU()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            tmp.Dispose();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDONSANXUAT f = new frmDONSANXUAT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSANPHAM f = new frmSANPHAM();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmXUONGSANXUAT f = new frmXUONGSANXUAT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKEHOACHSX f = new frmKEHOACHSX();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmKHO f = new frmKHO();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

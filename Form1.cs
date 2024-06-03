using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double toan, van, tb;
            toan = Convert.ToDouble(txtToan.Text);
            van = Convert.ToDouble(txtVan.Text);

            tb = (toan + van) / 2;
            txtTrungbinh.Text = tb.ToString();
            if (tb < 5)
            {
                txtXeploai.Text = "yếu";
            }
            else if (tb <= 6)
            {
                txtXeploai.Text = "TB";
            }
            else if (tb < 8)
            {
                txtXeploai.Text = "Khá";
            }
            else
            {
                txtXeploai.Text = "Giỏi";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

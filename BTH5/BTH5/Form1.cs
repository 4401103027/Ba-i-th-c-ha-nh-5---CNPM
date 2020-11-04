using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double csc, csm;
            csc = double.Parse(txtcu.Text);
            csm = double.Parse(txtMoi.Text);
            TieuThu(csc, csm);
            ThanhTien(txtdntt.Text);
            VAT(txtdntt.Text, txtTong.Text);
        }

        private void VAT(string t1, string t2)
        {
            double TieuThu = double.Parse(t1.ToString());
            double ThanhTien = double.Parse(t2.ToString());
            if (TieuThu >= 0 && TieuThu <= 100)
                txtVat.Text = ((double)ThanhTien * 1.1).ToString();
            else if (TieuThu > 100 && TieuThu <= 150)
                txtVat.Text = ((double)ThanhTien * 1.1).ToString();
            else if (TieuThu > 150 && TieuThu <= 200)
                txtVat.Text = ((double)ThanhTien * 1.1).ToString();
            else if (TieuThu > 200 && TieuThu <= 300)
                txtVat.Text = ((double)ThanhTien * 1.1).ToString();
            else if (TieuThu > 300 && TieuThu <= 400)
                txtVat.Text = ((double)ThanhTien * 1.1).ToString();
            else
                txtVat.Text = ((double)ThanhTien * 1.1).ToString();

        }

        private void ThanhTien(string T)
        {
            double TieuThu = double.Parse(T.ToString());
            if (TieuThu >= 0 && TieuThu <= 100)
                txtTong.Text = (TieuThu * 1418).ToString();
            else if (TieuThu > 100 && TieuThu <= 150)
                txtTong.Text = (100 * 1418 + (TieuThu - 100) * 1622).ToString();
            else if (TieuThu > 150 && TieuThu <= 200)
                txtTong.Text = (100 * 1418 + 50 * 1622 + (TieuThu - 150) * 2044).ToString();
            else if   (TieuThu > 200 && TieuThu <= 300)
                txtTong.Text = (100 * 1418 + 50 * 1622 + 50 * 2044 + (TieuThu - 200) * 2210).ToString();
            else if    (TieuThu > 300 && TieuThu <= 400)
                txtTong.Text = (100 * 1418 + 50 * 1622 + 50 * 2044 + 100 * 2210 + (TieuThu - 300) * 2361).ToString();
            else
                txtTong.Text = (100 * 1418 + 50 * 1622 + 50 * 2044 + 100 * 2210 + 100 * 2361 + (TieuThu - 400) * 2420).ToString();
        }
        

        private void TieuThu(double csc, double csm)
        {
            txtdntt.Text = (csm - csc).ToString();
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            txtcu.Clear();
            txtMoi.Clear();
            txtdntt.Clear();
            txtTong.Clear();
            txtVat.Clear();
        }
    }
}

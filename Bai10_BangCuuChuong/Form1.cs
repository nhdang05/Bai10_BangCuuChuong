using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lsbBCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
           
int so_nhan;
int so = Convert.ToInt32(txtSo.Text);
so = 2;
do
{
    so_nhan = 1;
    do
    {
        lbCC.Items.Add(so + "x" + so_nhan + "=" + so * so_nhan);
        so_nhan++;
    }
    while (so_nhan <= 10);
    lbCC.Items.Add(so + "x" + so_nhan + "=" + so * so_nhan);
    {
    }
    so_nhan++;
} while (so <= 9);
        }
    }
}

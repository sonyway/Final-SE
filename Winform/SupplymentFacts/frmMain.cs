using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;

namespace SupplymentFacts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void frmlogin()
        {
            Form frm = new frmLogin();
            frm.ShowDialog();
        }
        public void xemdanhmuc(int intDanhMuc)
        {
            Form frm = new frmCatalog();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {
            frmlogin();  
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmlogin();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(1);
        }

        private void danhMụcVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(2);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(3);
        }

        private void danhMụcPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(4);
        }

        private void danhMụcPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(5);
        }

        private void danhMụcDòngPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(2);
        }

        private void dAnhMụcDòngPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhmuc(7);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAgentManagement();
            frm.ShowDialog();

        }
        private void quảnLýVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmOrderManagement();
            frm.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEmployeeManagement();
            frm.ShowDialog();
        }

        private void quảnLýPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmImportManagement();
            frm.ShowDialog();
        }

        private void quảnLýPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmExportManagement();
            frm.ShowDialog();
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmHelp();
            frm.ShowDialog();
        }

        private void statiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bestSellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBestSelling();
            frm.ShowDialog();
        }

        private void stockinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmStockIn();
            frm.ShowDialog();
        }

        private void stockOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmStockOut();
            frm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPrintDeliverySlip();
            frm.ShowDialog();
        }

        private void revenueReportMonthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRevenue();
            frm.ShowDialog();
        }

        private void pendingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Pending();
            frm.ShowDialog();
        }

        //private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm = new frmWarehouseManagement();
        //    frm.ShowDialog();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupplymentFacts
{
    public partial class frmImportManagement : Form
    {
        public frmImportManagement()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbSoImport.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgayNhap.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtItemID.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Import VALUES('" + txtbSoImport.Text + "','" + txtEID.Text + "','" + txtFullName.Text + "','" + dtpNgayNhap.Text + "','" + txtItemID.Text + "','" + txtItemName.Text + "','" + txtQuantity.Text + "')";
            DateTime dtt = DateTime.Now;
            if (txtbSoImport.Text == "")
            {
                MessageBox.Show("Import ID cann't be left blank", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (dtpNgayNhap.Value >= dtt)
                MessageBox.Show("Did you enter the correct import date? ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                kn.capnhat(sql);
                frmQuanLyImport_Load(sender, e);
                MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Import SET EmployeeID = '" + txtEID.Text + "',EmployeeName = '" + txtFullName.Text + "',ImportDate = '" + dtpNgayNhap.Text + "',ItemID = '" + txtItemID.Text + "',ItemName = '" + txtItemName.Text + "',Quantity = '" + txtQuantity.Text + "' WHERE ImportID = '" + txtbSoImport.Text + "'";
            DateTime dtt = DateTime.Now;
            if (txtbSoImport.Text == "") MessageBox.Show("Import ID cann't be left blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpNgayNhap.Value >= dtt)
                MessageBox.Show("Did you enter the correct import date?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to edit it?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyImport_Load(sender, e);
                }
                else
                {
                    kn.capnhat(sql);
                    frmQuanLyImport_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Import WHERE IID='" + txtbSoImport.Text + "'";
            if (txtbSoImport.Text == "") MessageBox.Show("Import ID cann't be left blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Did you want to delete it?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyImport_Load(sender, e);
                }
                else
                {
                    kn.capnhat(sql);
                    frmQuanLyImport_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyImport_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM Import";
            dataGridView1.DataSource = kn.show(sql);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

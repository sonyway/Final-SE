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
    public partial class frmExportManagement : Form
    {
        public frmExportManagement()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbSoExport.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbEID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgayXuat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void frmQuanLyExport_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Export";
            dataGridView1.DataSource = kn.show(sql);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Export VALUES('" + txtbSoExport.Text + "','" + txtbEID.Text + "','" + txtFullName.Text + "','" + dtpNgayXuat.Text + "','" + txtItemName.Text + "','" + txtQuantity.Text + "')";
            DateTime dtt = DateTime.Now;
            if (txtbSoExport.Text == "" || dtpNgayXuat.Text == "" || txtbEID.Text == "" || txtItemName.Text == "" || txtQuantity.Text == "")
                MessageBox.Show("You have not filled in all the information cần thêm.Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpNgayXuat.Value >= dtt)
                MessageBox.Show("Did you choose the correct date?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                kn.capnhat(sql);
                frmQuanLyExport_Load(sender,e);
                MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Export SET SoExport = '" + txtbSoExport.Text + "', EID = '" + txtbEID.Text + "', FullName = '" + txtFullName.Text + "', NgayXuat = '" + dtpNgayXuat.Text + "', ItemName = '" + txtItemName.Text + "', Quantity = '" + txtQuantity.Text + "' WHERE SoExport = '" + txtbSoExport.Text + "'";
            DateTime dtt = DateTime.Now;
            if (txtbSoExport.Text == "" || dtpNgayXuat.Text == "" || txtbEID.Text == "" || txtItemName.Text == "")
                MessageBox.Show("Are you sure you have filled in all the details?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpNgayXuat.Value >= dtt)
                MessageBox.Show("Did you choose the correct date?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to edit it?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyExport_Load(sender, e);
                }
                else
                {
                    kn.capnhat(sql);
                    frmQuanLyExport_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Export WHERE ExID='" + txtbSoExport.Text + "'";
            DateTime dtt = DateTime.Now;
            if (txtbSoExport.Text == "") MessageBox.Show("You have to choose Export ID to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpNgayXuat.Value >= dtt) MessageBox.Show("Did you choose the correct date?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to delete?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyExport_Load(sender, e);
                }
                else
                {
                    kn.capnhat(sql);
                    frmQuanLyExport_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

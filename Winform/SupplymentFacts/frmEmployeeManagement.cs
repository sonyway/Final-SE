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
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
       
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employee";
            dataGridView1.DataSource = kn.show(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbMaNhanVien.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbTenNhanVien.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime dtt = DateTime.Now;

            if (txtbMaNhanVien.Text == "" || txtbTenNhanVien.Text == "" || txtbDiaChi.Text == "")
            {
                MessageBox.Show("You have not filled in all the information. Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbMaNhanVien.Focus();
            }
            else if (dtpNgaySinh.Value >= dtt) MessageBox.Show("Did you enter the correct date of birth?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string sql1 = "INSERT INTO Employee VALUES('" + txtbMaNhanVien.Text + "','" + txtbTenNhanVien.Text + "','" + dtpNgaySinh.Text + "','" + txtbDiaChi.Text + "','" + txtbSoDienThoai.Text + "')";
                kn.capnhat(sql1);
                frmQuanLyNhanVien_Load(sender, e); 
                MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime dtt = DateTime.Now;

            if (txtbMaNhanVien.Text == "" || txtbTenNhanVien.Text == "" || txtbDiaChi.Text == "")
                MessageBox.Show("You have not filled in all the information. Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dtpNgaySinh.Value >= dtt)
                MessageBox.Show("Did you choose the correct date?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to edit it?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    string sql = "UPDATE Employee SET EmployeeName='" + txtbTenNhanVien.Text + "',DateofBirth='" + dtpNgaySinh.Text + "',Address='" + txtbDiaChi.Text + "',Telephone='" + txtbSoDienThoai.Text + "' WHERE EID='" + txtbMaNhanVien.Text + "'";
                    kn.capnhat(sql);
                    frmQuanLyNhanVien_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtbMaNhanVien.Text == "") MessageBox.Show("You have not filled in all the information to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to delete it?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    string sql = "DELETE FROM Employee WHERE EID='" + txtbMaNhanVien.Text + "'";
                    kn.capnhat(sql);
                    frmQuanLyNhanVien_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

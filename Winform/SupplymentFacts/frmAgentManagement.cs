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
    public partial class frmAgentManagement : Form
    {
        public frmAgentManagement()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void frmQuanLyAgent_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Agent";
            dataGridView1.DataSource = kn.show(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbMaKhach.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbTenKhach.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtbMaKhach.Text == "" || txtbTenKhach.Text == "" || txtbDiaChi.Text == "")
                MessageBox.Show("You have not filled in all the information/Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string sql = "INSERT INTO Agent VALUES('" + txtbMaKhach.Text + "','" + txtbTenKhach.Text + "','" + txtbDienThoai.Text + "','" + txtbDiaChi.Text + "','" + txtbEmail.Text + "')";
                kn.capnhat(sql);
                frmQuanLyAgent_Load(sender,e);
                MessageBox.Show("Agent have been added to database", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtbMaKhach.Text == "")
            {
                MessageBox.Show("Please enter the customer code you  want to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbMaKhach.Focus();
            }
            else
            {               
                DialogResult traloi;
                string sql = "DELETE FROM Agent WHERE AgentID='" + txtbMaKhach.Text + "'";
                traloi = MessageBox.Show("Are you want to delete?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyAgent_Load(sender, e);        
                }
                else
                {
                    kn.capnhat(sql);
                    frmQuanLyAgent_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtbMaKhach.Text == "" || txtbTenKhach.Text == "" || txtbDiaChi.Text == "")
                MessageBox.Show("You have not filled in all the information cần sửa / Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn sửa không", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmQuanLyAgent_Load(sender, e);
                }
                else
                {
                    string sql = "UPDATE Agent SET AgentName='" + txtbTenKhach.Text + "',Telephone='" + txtbDienThoai.Text + "',Address='" + txtbDiaChi.Text + "',Email='" + txtbEmail.Text + "'";
                    kn.capnhat(sql);
                    frmQuanLyAgent_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }       
            
        
}

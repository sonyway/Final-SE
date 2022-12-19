using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupplymentFacts
{
    public partial class frmOrderManagement : Form
    {
        public frmOrderManagement()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [Order]";
            dataGridView1.DataSource = kn.show(sql);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbEmployeeName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbOrderCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbAgentName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbAgentID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbPayment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtbItemID.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtbEmployeeID.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtbEmployeeName.Text == "" || txtbOrderCode.Text == "" || txtbAgentName.Text == "" || txtbAgentID.Text == "" || txtbPayment.Text == "" || txtbQuantity.Text == "" || txtbItemName.Text == "" || txtbItemID.Text == "" || txtbEmployeeID.Text == "")
                MessageBox.Show("You have not filled in all the information/Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string sql = "INSERT INTO [Order] VALUES('" + txtbEmployeeName.Text + "','" + txtbOrderCode.Text + "','" + txtbAgentName.Text + "','" + txtbAgentID.Text + "','" + txtbPayment.Text + "','" + txtbQuantity.Text + "','" + txtbItemName.Text + "','" + txtbItemID.Text + "','" + txtbEmployeeID.Text + "')";
                kn.capnhat(sql);
                frmOrderManagement_Load(sender, e);
                MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {           
            if (txtbOrderCode.Text == "")
            {
                MessageBox.Show("You have not filled in the Order Code", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbEmployeeName.Focus();
            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to edit it?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmOrderManagement_Load(sender, e);
                }
                else
                {
                    string sql = "UPDATE Order SET EmployeeName = '" + txtbEmployeeName.Text + "', AgentName = '" + txtbAgentName.Text + "', AgentID = '" + txtbAgentID.Text + "', Payment = '" + txtbPayment.Text + "', Quantity = '" + txtbQuantity.Text + "', ItemName = '" + txtbItemName.Text + "', ItemID = '" + txtbItemID.Text + "', EmployeeID = '" + txtbEmployeeID.Text + "' WHERE OrderCode = '" + txtbOrderCode.Text + "'";
                    kn.capnhat(sql);
                    frmOrderManagement_Load(sender, e);
                    MessageBox.Show("Done", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            if (txtbEmployeeName.Text == "")
            {
                MessageBox.Show("Order code should not left blank / Please re-enter", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbEmployeeName.Focus();
            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Do you want to delete it?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Cancel)
                {
                    frmOrderManagement_Load(sender, e);
                }
                else
                {
                    string sql = "DELETE FROM [Order] WHERE OrderCode='" + txtbOrderCode.Text + "'";
                    kn.capnhat(sql);
                    frmOrderManagement_Load(sender, e);
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

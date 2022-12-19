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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
                           
           
            if ((textBox1.Text == "admin") && (textBox2.Text == "admin")) this.Close();
            else
            {
                MessageBox.Show("Username/Password incorrect!!!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            
            if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Login";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (e is KeyEventArgs && ((KeyEventArgs)e).KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}

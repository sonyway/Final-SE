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
    public partial class frmCatalog : Form
    {
        public frmCatalog()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        private void frmXemDanhMuc_Load(object sender, EventArgs e)
        {
            int intDM = Convert.ToInt32(this.Text);
            switch (intDM)
            {
                
                case 1:
                    lblDM.Text = "Agent List";
                    string sql = "SELECT* FROM Agent";
                    dataGridView1.DataSource = kn.show(sql);
                    break;
                case 2: lblDM.Text = "Order List";
                    string sql1 = "SELECT* FROM [Order]";
                    dataGridView1.DataSource = kn.show(sql1);
                    break;
                case 3: lblDM.Text = "Employee List";
                    string sql2 = "SELECT* FROM Employee";
                    dataGridView1.DataSource = kn.show(sql2);
                    break;
                case 4:
                    lblDM.Text = "Import List";
                    string sql3 = "SELECT* FROM Import";
                    dataGridView1.DataSource = kn.show(sql3);
                    break;
                case 5:
                    lblDM.Text = "Export List";
                    string sql4 = "SELECT* FROM Export";
                    dataGridView1.DataSource = kn.show(sql4);
                    break;
                case 6:
                    lblDM.Text = "Warehouse List";
                    string sql5 = "SELECT* FROM Warehouse";
                    dataGridView1.DataSource = kn.show(sql5);
                    break;

            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

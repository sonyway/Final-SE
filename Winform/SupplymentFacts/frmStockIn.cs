using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplymentFacts
{
    public partial class frmStockIn : Form
    {
        public frmStockIn()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();

        private void frmStockIn_Load(object sender, EventArgs e)
        {
            string sql = "select * from [Import]";
            dataGridView1.DataSource = kn.show(sql);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}

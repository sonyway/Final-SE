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
    public partial class frmStockOut : Form
    {
        public frmStockOut()
        {
            InitializeComponent();
        }
         Connection kn = new Connection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmStockOut_Load(object sender, EventArgs e)
        {
            string sql = "select * from [Export]";
            dataGridView1.DataSource = kn.show(sql);
        }
    }
}

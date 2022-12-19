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
    public partial class Pending : Form
    {
        public Pending()
        {
            InitializeComponent();
        }

        private void frmPending_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCartDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.eCartDBDataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

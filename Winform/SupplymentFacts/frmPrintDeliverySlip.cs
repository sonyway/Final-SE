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
    public partial class frmPrintDeliverySlip : Form
    {
        public frmPrintDeliverySlip()
        {
            InitializeComponent();
        }
        Bitmap bmp;
/*        Connection kn = new Connection();
*/        
        private void frmPrintDeliverySlip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eCartDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.eCartDBDataSet.Orders);
            // TODO: This line of code loads data into the 'sFPDataSet.Export' table. You can move, or remove it, as needed.
            this.exportTableAdapter.Fill(this.sFPDataSet.Export);

     /*       string sql = "select ExID, DateExport, ItemID, ItemName, QuantityOut from Export";
            dataGridView1.DataSource = kn.show(sql);*/

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlBox = false;
            button1.Hide();
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            button1.Show();
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            
        }
    }
}

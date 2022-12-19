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
    public partial class frmRevenue : Form
    {
        public frmRevenue()
        {
            InitializeComponent();
        }

        Connection kn = new Connection();
        


        private void frmRevenue_Load_1(object sender, EventArgs e)
        {
            string sql = "select * from Revenue";
            dataGridView.DataSource = kn.show(sql);
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartRevenue.Series["Revenue"].XValueMember = "Month";
            chartRevenue.Series["Revenue"].YValueMembers = "Revenue";
            chartRevenue.Series["Revenue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartRevenue.Series["Revenue"].IsValueShownAsLabel = true;
            chartRevenue.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chartRevenue.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chartRevenue.DataSource = kn.show("select * from Revenue");
            chartRevenue.DataBind();


        }
    }
}

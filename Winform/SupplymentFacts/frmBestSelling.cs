using LiveCharts;
using LiveCharts.Wpf;
using SupplymentFacts;
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
    public partial class frmBestSelling : Form
    {
        public frmBestSelling()
        {
            InitializeComponent();
        }
        Connection kn = new Connection();
        Func<ChartPoint, string> label = chartpoint =>
            string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);


        private void frmBestSelling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sFPDataSet.Export' table. You can move, or remove it, as needed.
            this.exportTableAdapter.Fill(this.sFPDataSet.Export);
            string sql = "select top 5 ItemName, QuantityOut  " +
                "from [Export] " +
                "group by QuantityOut, ItemName " +
                "order by QuantityOut desc";

            dataGridView1.DataSource = kn.show(sql);

            SeriesCollection series = new SeriesCollection();

                series.Add(new PieSeries
                {
                    Title = dataGridView1.Rows[0].Cells[0].Value.ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) },
                    DataLabels = true,
                    LabelPoint = label
                });
                
                series.Add(new PieSeries
                {
                    Title = dataGridView1.Rows[1].Cells[0].Value.ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) },
                    DataLabels = true,
                    LabelPoint = label
                });

            series.Add(new PieSeries
            {
                Title = dataGridView1.Rows[2].Cells[0].Value.ToString(),
                Values = new ChartValues<int> { Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) },
                DataLabels = true,
                LabelPoint = label
            });

            series.Add(new PieSeries
            {
                Title = dataGridView1.Rows[3].Cells[0].Value.ToString(),
                Values = new ChartValues<int> { Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) },
                DataLabels = true,
                LabelPoint = label
            });

            series.Add(new PieSeries
            {
                Title = dataGridView1.Rows[4].Cells[0].Value.ToString(),
                Values = new ChartValues<int> { Convert.ToInt32(dataGridView1.Rows[4].Cells[1].Value) },
                DataLabels = true,
                LabelPoint = label
            });



            pieChart1.Series = series;
        

        pieChart1.LegendLocation = LiveCharts.LegendLocation.Bottom;
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}

namespace SupplymentFacts
{
    partial class frmBestSelling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFPDataSet = new SupplymentFacts.SFPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.exportTableAdapter = new SupplymentFacts.SFPDataSetTableAdapters.ExportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.quantityOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(680, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityOutDataGridViewTextBoxColumn
            // 
            this.quantityOutDataGridViewTextBoxColumn.DataPropertyName = "QuantityOut";
            this.quantityOutDataGridViewTextBoxColumn.HeaderText = "QuantityOut";
            this.quantityOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityOutDataGridViewTextBoxColumn.Name = "quantityOutDataGridViewTextBoxColumn";
            this.quantityOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // exportBindingSource
            // 
            this.exportBindingSource.DataMember = "Export";
            this.exportBindingSource.DataSource = this.sFPDataSet;
            // 
            // sFPDataSet
            // 
            this.sFPDataSet.DataSetName = "SFPDataSet";
            this.sFPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top 5 Best-Selling Products";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(12, 63);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(662, 516);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // exportTableAdapter
            // 
            this.exportTableAdapter.ClearBeforeFill = true;
            // 
            // frmBestSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 686);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBestSelling";
            this.Text = "Best Selling Product";
            this.Load += new System.EventHandler(this.frmBestSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private SFPDataSet sFPDataSet;
        private System.Windows.Forms.BindingSource exportBindingSource;
        private SFPDataSetTableAdapters.ExportTableAdapter exportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOutDataGridViewTextBoxColumn;
    }
}
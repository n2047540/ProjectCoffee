
namespace DemoNorthwind
{
    partial class FormReport
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
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeReportDataSet = new DemoNorthwind.CoffeeReportDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.order_DetailsTableAdapter = new DemoNorthwind.CoffeeReportDataSetTableAdapters.Order_DetailsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noOrderdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noOrderdetailsDataGridViewTextBoxColumn,
            this.noOrderDataGridViewTextBoxColumn,
            this.iDStockDataGridViewTextBoxColumn,
            this.priceStockDataGridViewTextBoxColumn,
            this.amountstockDataGridViewTextBoxColumn,
            this.totalOrderDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.pointDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order_Details";
            this.orderDetailsBindingSource.DataSource = this.coffeeReportDataSet;
            // 
            // coffeeReportDataSet
            // 
            this.coffeeReportDataSet.DataSetName = "CoffeeReportDataSet";
            this.coffeeReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(113)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(267, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "รายงานยอดขาย";
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(251, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 76);
            this.panel1.TabIndex = 22;
            // 
            // noOrderdetailsDataGridViewTextBoxColumn
            // 
            this.noOrderdetailsDataGridViewTextBoxColumn.DataPropertyName = "No_Orderdetails";
            this.noOrderdetailsDataGridViewTextBoxColumn.HeaderText = "No_Orderdetails";
            this.noOrderdetailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOrderdetailsDataGridViewTextBoxColumn.Name = "noOrderdetailsDataGridViewTextBoxColumn";
            this.noOrderdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOrderdetailsDataGridViewTextBoxColumn.Visible = false;
            this.noOrderdetailsDataGridViewTextBoxColumn.Width = 125;
            // 
            // noOrderDataGridViewTextBoxColumn
            // 
            this.noOrderDataGridViewTextBoxColumn.DataPropertyName = "No_Order";
            this.noOrderDataGridViewTextBoxColumn.FillWeight = 75.86705F;
            this.noOrderDataGridViewTextBoxColumn.HeaderText = "ออเดอร์ที่";
            this.noOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOrderDataGridViewTextBoxColumn.Name = "noOrderDataGridViewTextBoxColumn";
            this.noOrderDataGridViewTextBoxColumn.Width = 60;
            // 
            // iDStockDataGridViewTextBoxColumn
            // 
            this.iDStockDataGridViewTextBoxColumn.DataPropertyName = "ID_Stock";
            this.iDStockDataGridViewTextBoxColumn.FillWeight = 86.47926F;
            this.iDStockDataGridViewTextBoxColumn.HeaderText = "รหัสสินค้า";
            this.iDStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDStockDataGridViewTextBoxColumn.Name = "iDStockDataGridViewTextBoxColumn";
            this.iDStockDataGridViewTextBoxColumn.Width = 85;
            // 
            // priceStockDataGridViewTextBoxColumn
            // 
            this.priceStockDataGridViewTextBoxColumn.DataPropertyName = "Price_Stock";
            this.priceStockDataGridViewTextBoxColumn.FillWeight = 96.45795F;
            this.priceStockDataGridViewTextBoxColumn.HeaderText = "ราคา";
            this.priceStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceStockDataGridViewTextBoxColumn.Name = "priceStockDataGridViewTextBoxColumn";
            this.priceStockDataGridViewTextBoxColumn.Width = 96;
            // 
            // amountstockDataGridViewTextBoxColumn
            // 
            this.amountstockDataGridViewTextBoxColumn.DataPropertyName = "Amount_stock";
            this.amountstockDataGridViewTextBoxColumn.FillWeight = 91.56891F;
            this.amountstockDataGridViewTextBoxColumn.HeaderText = "จำนวน";
            this.amountstockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountstockDataGridViewTextBoxColumn.Name = "amountstockDataGridViewTextBoxColumn";
            this.amountstockDataGridViewTextBoxColumn.Width = 60;
            // 
            // totalOrderDataGridViewTextBoxColumn
            // 
            this.totalOrderDataGridViewTextBoxColumn.DataPropertyName = "Total_Order";
            this.totalOrderDataGridViewTextBoxColumn.FillWeight = 115.6566F;
            this.totalOrderDataGridViewTextBoxColumn.HeaderText = "ราคารวม";
            this.totalOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalOrderDataGridViewTextBoxColumn.Name = "totalOrderDataGridViewTextBoxColumn";
            this.totalOrderDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "Date_Order";
            this.dateOrderDataGridViewTextBoxColumn.FillWeight = 131.3338F;
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "วันที่สั่ง";
            this.dateOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.Width = 75;
            // 
            // pointDataGridViewTextBoxColumn
            // 
            this.pointDataGridViewTextBoxColumn.DataPropertyName = "Point";
            this.pointDataGridViewTextBoxColumn.FillWeight = 102.6364F;
            this.pointDataGridViewTextBoxColumn.HeaderText = "แต้ม";
            this.pointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
            this.pointDataGridViewTextBoxColumn.Width = 45;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(176)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(869, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายงานผลประกอบการ";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeReportDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private CoffeeReportDataSet coffeeReportDataSet;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private CoffeeReportDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOrderdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
    }
}
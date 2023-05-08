
namespace DemoNorthwind
{
    partial class FormStock
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
            this.coffeestockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeStockDataSet = new DemoNorthwind.CoffeeStockDataSet();
            this.coffeestockTableAdapter = new DemoNorthwind.CoffeeStockDataSetTableAdapters.CoffeestockTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coffeestockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeStockDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // coffeestockBindingSource
            // 
            this.coffeestockBindingSource.DataMember = "Coffeestock";
            this.coffeestockBindingSource.DataSource = this.coffeeStockDataSet;
            this.coffeestockBindingSource.CurrentChanged += new System.EventHandler(this.coffeestockBindingSource_CurrentChanged);
            // 
            // coffeeStockDataSet
            // 
            this.coffeeStockDataSet.DataSetName = "CoffeeStockDataSet";
            this.coffeeStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeestockTableAdapter
            // 
            this.coffeestockTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(436, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "สต็อกสินค้า";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDStockDataGridViewTextBoxColumn,
            this.nameStockDataGridViewTextBoxColumn,
            this.priceStockDataGridViewTextBoxColumn,
            this.amountstockDataGridViewTextBoxColumn,
            this.instockDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.coffeestockBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(961, 502);
            this.dataGridView2.TabIndex = 38;
            // 
            // coffeestockBindingSource1
            // 
            this.coffeestockBindingSource1.DataMember = "Coffeestock";
            this.coffeestockBindingSource1.DataSource = this.coffeeStockDataSetBindingSource;
            // 
            // coffeeStockDataSetBindingSource
            // 
            this.coffeeStockDataSetBindingSource.DataSource = this.coffeeStockDataSet;
            this.coffeeStockDataSetBindingSource.Position = 0;
            // 
            // iDStockDataGridViewTextBoxColumn
            // 
            this.iDStockDataGridViewTextBoxColumn.DataPropertyName = "ID_Stock";
            this.iDStockDataGridViewTextBoxColumn.HeaderText = "รหัสสินค้า";
            this.iDStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDStockDataGridViewTextBoxColumn.Name = "iDStockDataGridViewTextBoxColumn";
            this.iDStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameStockDataGridViewTextBoxColumn
            // 
            this.nameStockDataGridViewTextBoxColumn.DataPropertyName = "Name_Stock";
            this.nameStockDataGridViewTextBoxColumn.HeaderText = "ชื่อสินค้า";
            this.nameStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameStockDataGridViewTextBoxColumn.Name = "nameStockDataGridViewTextBoxColumn";
            this.nameStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceStockDataGridViewTextBoxColumn
            // 
            this.priceStockDataGridViewTextBoxColumn.DataPropertyName = "Price_Stock";
            this.priceStockDataGridViewTextBoxColumn.HeaderText = "ราคา";
            this.priceStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceStockDataGridViewTextBoxColumn.Name = "priceStockDataGridViewTextBoxColumn";
            this.priceStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountstockDataGridViewTextBoxColumn
            // 
            this.amountstockDataGridViewTextBoxColumn.DataPropertyName = "Amount_stock";
            this.amountstockDataGridViewTextBoxColumn.HeaderText = "จำนวนสินค้า";
            this.amountstockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountstockDataGridViewTextBoxColumn.Name = "amountstockDataGridViewTextBoxColumn";
            this.amountstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instockDataGridViewTextBoxColumn
            // 
            this.instockDataGridViewTextBoxColumn.DataPropertyName = "In_stock";
            this.instockDataGridViewTextBoxColumn.HeaderText = "วันที่เข้า";
            this.instockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instockDataGridViewTextBoxColumn.Name = "instockDataGridViewTextBoxColumn";
            this.instockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(157)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(961, 502);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Name = "FormStock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CoffeeStockDataSet coffeeStockDataSet;
        private System.Windows.Forms.BindingSource coffeestockBindingSource;
        private CoffeeStockDataSetTableAdapters.CoffeestockTableAdapter coffeestockTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource coffeeStockDataSetBindingSource;
        private System.Windows.Forms.BindingSource coffeestockBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instockDataGridViewTextBoxColumn;
    }
}
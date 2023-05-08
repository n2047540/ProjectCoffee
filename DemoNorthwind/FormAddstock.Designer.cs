
namespace DemoNorthwind
{
    partial class FormAddstock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_Stock = new System.Windows.Forms.TextBox();
            this.coffeestockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeStockDataSet = new DemoNorthwind.CoffeeStockDataSet();
            this.Amount_stock = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnadd_Click = new System.Windows.Forms.Button();
            this.btn_Update_Click_Click = new System.Windows.Forms.Button();
            this.btn_Delete_Click_Click = new System.Windows.Forms.Button();
            this.Name_Stock = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeestockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Point_stock = new System.Windows.Forms.TextBox();
            this.coffeestockTableAdapter = new DemoNorthwind.CoffeeStockDataSetTableAdapters.CoffeestockTableAdapter();
            this.coffeeStockDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeestockTableAdapter1 = new DemoNorthwind.CoffeeStockDataSetTableAdapters.CoffeestockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(462, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "สต็อกสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "รหัสสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "ชื่อสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "วันที่เข้า";
            // 
            // ID_Stock
            // 
            this.ID_Stock.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.coffeestockBindingSource, "ID_Stock", true));
            this.ID_Stock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeestockBindingSource, "ID_Stock", true));
            this.ID_Stock.Location = new System.Drawing.Point(137, 38);
            this.ID_Stock.Multiline = true;
            this.ID_Stock.Name = "ID_Stock";
            this.ID_Stock.Size = new System.Drawing.Size(266, 36);
            this.ID_Stock.TabIndex = 1;
            this.ID_Stock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Stock_KeyDown);
            // 
            // coffeestockBindingSource
            // 
            this.coffeestockBindingSource.DataMember = "Coffeestock";
            this.coffeestockBindingSource.DataSource = this.coffeeStockDataSet;
            // 
            // coffeeStockDataSet
            // 
            this.coffeeStockDataSet.DataSetName = "CoffeeStockDataSet";
            this.coffeeStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Amount_stock
            // 
            this.Amount_stock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeestockBindingSource, "Amount_stock", true));
            this.Amount_stock.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.coffeestockBindingSource, "Amount_stock", true));
            this.Amount_stock.Location = new System.Drawing.Point(137, 150);
            this.Amount_stock.Multiline = true;
            this.Amount_stock.Name = "Amount_stock";
            this.Amount_stock.Size = new System.Drawing.Size(264, 36);
            this.Amount_stock.TabIndex = 3;
            this.Amount_stock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Amount_stock_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeestockBindingSource, "In_stock", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.coffeestockBindingSource, "In_stock", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.coffeestockBindingSource, "In_stock", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 27);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // btnadd_Click
            // 
            this.btnadd_Click.BackColor = System.Drawing.Color.White;
            this.btnadd_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnadd_Click.Location = new System.Drawing.Point(35, 415);
            this.btnadd_Click.Name = "btnadd_Click";
            this.btnadd_Click.Size = new System.Drawing.Size(107, 50);
            this.btnadd_Click.TabIndex = 33;
            this.btnadd_Click.Text = "เพิ่ม";
            this.btnadd_Click.UseVisualStyleBackColor = false;
            this.btnadd_Click.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update_Click_Click
            // 
            this.btn_Update_Click_Click.BackColor = System.Drawing.Color.White;
            this.btn_Update_Click_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Update_Click_Click.Location = new System.Drawing.Point(163, 415);
            this.btn_Update_Click_Click.Name = "btn_Update_Click_Click";
            this.btn_Update_Click_Click.Size = new System.Drawing.Size(107, 50);
            this.btn_Update_Click_Click.TabIndex = 34;
            this.btn_Update_Click_Click.Text = "แก้ไข";
            this.btn_Update_Click_Click.UseVisualStyleBackColor = false;
            this.btn_Update_Click_Click.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete_Click_Click
            // 
            this.btn_Delete_Click_Click.BackColor = System.Drawing.Color.Red;
            this.btn_Delete_Click_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Delete_Click_Click.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Click_Click.Location = new System.Drawing.Point(288, 415);
            this.btn_Delete_Click_Click.Name = "btn_Delete_Click_Click";
            this.btn_Delete_Click_Click.Size = new System.Drawing.Size(107, 50);
            this.btn_Delete_Click_Click.TabIndex = 36;
            this.btn_Delete_Click_Click.Text = "ลบ";
            this.btn_Delete_Click_Click.UseVisualStyleBackColor = false;
            this.btn_Delete_Click_Click.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Name_Stock
            // 
            this.Name_Stock.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.coffeestockBindingSource, "Name_Stock", true));
            this.Name_Stock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeestockBindingSource, "Name_Stock", true));
            this.Name_Stock.Location = new System.Drawing.Point(137, 93);
            this.Name_Stock.Multiline = true;
            this.Name_Stock.Name = "Name_Stock";
            this.Name_Stock.Size = new System.Drawing.Size(266, 36);
            this.Name_Stock.TabIndex = 2;
            this.Name_Stock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_Stock_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(113)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDStockDataGridViewTextBoxColumn,
            this.nameStockDataGridViewTextBoxColumn,
            this.amountstockDataGridViewTextBoxColumn,
            this.instockDataGridViewTextBoxColumn,
            this.Point,
            this.priceStockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coffeestockBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(460, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 341);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDStockDataGridViewTextBoxColumn
            // 
            this.iDStockDataGridViewTextBoxColumn.DataPropertyName = "ID_Stock";
            this.iDStockDataGridViewTextBoxColumn.HeaderText = "รหัสสินค้า";
            this.iDStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDStockDataGridViewTextBoxColumn.Name = "iDStockDataGridViewTextBoxColumn";
            this.iDStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDStockDataGridViewTextBoxColumn.Width = 95;
            // 
            // nameStockDataGridViewTextBoxColumn
            // 
            this.nameStockDataGridViewTextBoxColumn.DataPropertyName = "Name_Stock";
            this.nameStockDataGridViewTextBoxColumn.HeaderText = "ชื่อสินค้า";
            this.nameStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameStockDataGridViewTextBoxColumn.Name = "nameStockDataGridViewTextBoxColumn";
            this.nameStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountstockDataGridViewTextBoxColumn
            // 
            this.amountstockDataGridViewTextBoxColumn.DataPropertyName = "Amount_stock";
            this.amountstockDataGridViewTextBoxColumn.HeaderText = "จำนวนสินค้า";
            this.amountstockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountstockDataGridViewTextBoxColumn.Name = "amountstockDataGridViewTextBoxColumn";
            this.amountstockDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountstockDataGridViewTextBoxColumn.Width = 125;
            // 
            // instockDataGridViewTextBoxColumn
            // 
            this.instockDataGridViewTextBoxColumn.DataPropertyName = "In_stock";
            this.instockDataGridViewTextBoxColumn.HeaderText = "วันที่เข้า";
            this.instockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instockDataGridViewTextBoxColumn.Name = "instockDataGridViewTextBoxColumn";
            this.instockDataGridViewTextBoxColumn.ReadOnly = true;
            this.instockDataGridViewTextBoxColumn.Width = 125;
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "แต้ม";
            this.Point.MinimumWidth = 6;
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.Width = 70;
            // 
            // priceStockDataGridViewTextBoxColumn
            // 
            this.priceStockDataGridViewTextBoxColumn.DataPropertyName = "Price_Stock";
            this.priceStockDataGridViewTextBoxColumn.HeaderText = "Price_Stock";
            this.priceStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceStockDataGridViewTextBoxColumn.Name = "priceStockDataGridViewTextBoxColumn";
            this.priceStockDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceStockDataGridViewTextBoxColumn.Visible = false;
            this.priceStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // coffeestockBindingSource1
            // 
            this.coffeestockBindingSource1.DataMember = "Coffeestock";
            this.coffeestockBindingSource1.DataSource = this.coffeeStockDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(190)))), ((int)(((byte)(113)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Point_stock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ID_Stock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Name_Stock);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Amount_stock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 296);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "แต้ม";
            // 
            // Point_stock
            // 
            this.Point_stock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeestockBindingSource, "Amount_stock", true));
            this.Point_stock.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.coffeestockBindingSource, "Amount_stock", true));
            this.Point_stock.Location = new System.Drawing.Point(137, 203);
            this.Point_stock.Multiline = true;
            this.Point_stock.Name = "Point_stock";
            this.Point_stock.Size = new System.Drawing.Size(264, 36);
            this.Point_stock.TabIndex = 25;
            // 
            // coffeestockTableAdapter
            // 
            this.coffeestockTableAdapter.ClearBeforeFill = true;
            // 
            // coffeeStockDataSetBindingSource
            // 
            this.coffeeStockDataSetBindingSource.DataSource = this.coffeeStockDataSet;
            this.coffeeStockDataSetBindingSource.Position = 0;
            // 
            // coffeestockTableAdapter1
            // 
            this.coffeestockTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(176)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1264, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete_Click_Click);
            this.Controls.Add(this.btn_Update_Click_Click);
            this.Controls.Add(this.btnadd_Click);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAddstock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มข้อมูลสินค้า";
            this.Activated += new System.EventHandler(this.FormAddstock_Load);
            this.Load += new System.EventHandler(this.FormAddstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeestockBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeStockDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_Stock;
        private System.Windows.Forms.TextBox Amount_stock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnadd_Click;
        private System.Windows.Forms.Button btn_Update_Click_Click;
        private System.Windows.Forms.Button btn_Delete_Click_Click;
        private System.Windows.Forms.TextBox Name_Stock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeStockDataSet coffeeStockDataSet;
        private System.Windows.Forms.BindingSource coffeestockBindingSource;
        private CoffeeStockDataSetTableAdapters.CoffeestockTableAdapter coffeestockTableAdapter;
        private System.Windows.Forms.BindingSource coffeeStockDataSetBindingSource;
        private CoffeeStockDataSetTableAdapters.CoffeestockTableAdapter coffeestockTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Point_stock;
        private System.Windows.Forms.BindingSource coffeestockBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceStockDataGridViewTextBoxColumn;
    }
}
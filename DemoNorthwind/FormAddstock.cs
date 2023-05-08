using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoNorthwind
{
    public partial class FormAddstock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Coffee;User ID=sa;Password=Modtanoy");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public FormAddstock()
        {
            InitializeComponent();
            DisplayData();
        }
        CoffeeEntities4 ce = new CoffeeEntities4();
        private void FormAddstock_Load(object sender, EventArgs e) //โหลดฟอร์ม
        {
            // TODO: This line of code loads data into the 'coffeeStockDataSet.Coffeestock' table. You can move, or remove it, as needed.
            this.coffeestockTableAdapter.Fill(this.coffeeStockDataSet.Coffeestock);
            ClearData();
            ID_Stock.Focus();
        }
        private void ID_Stock_KeyDown(object sender, KeyEventArgs e) //กดEnterรหัสสินค้า
        {
            if (e.KeyCode == Keys.Enter)
            {
                Name_Stock.Focus();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e) //ปุ่มเพิ่ม
        {
            string Query = "insert into Coffeestock (ID_Stock,Name_Stock,Amount_stock,In_Stock,Point)" +
            "values('" + this.ID_Stock.Text + "','" + this.Name_Stock.Text + "','" + this.Amount_stock.Text + "' , '" + this.dateTimePicker1.Text + "' , '" + this.Point_stock.Text + "' ) ;";
            cmd = new SqlCommand(Query, con);
            SqlDataReader reader;
            if (ID_Stock.Text != "" && Amount_stock.Text != "" && Name_Stock.Text != "" && dateTimePicker1.Text != "" && Point_stock.Text != "")
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("เพิ่มสินค้าสำเร็จ");
                    DisplayData();
                    ClearData();
                    ID_Stock.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
            {
                MessageBox.Show("โปรดใส่ข้อมูลสินค้าเพื่อทำการเพิ่ม!");
            }
            
        }
        private void DisplayData() //แสดงข้อมูล
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Coffeestock", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData() //ล้างข้อมูล
        {
            ID_Stock.Text = "";
            Name_Stock.Text = "";
            Amount_stock.Text = "";
            Point_stock.Text = "";
        }

        private void btn_Update_Click(object sender, EventArgs e) //ปุ่มแก้ไขข้อมูล
        {
            if (Amount_stock.Text != "" && Name_Stock.Text != "" && dateTimePicker1.Text != "" && Point_stock.Text != "")
            {
                cmd = new SqlCommand("update Coffeestock set Name_Stock=@name,Amount_stock=@amount,In_stock=@in,Point=@point where Id_Stock=@id", con);
                con.Open(); 
                cmd.Parameters.AddWithValue("@id", ID_Stock.Text);
                cmd.Parameters.AddWithValue("@name", Name_Stock.Text);
                cmd.Parameters.AddWithValue("@amount", Amount_stock.Text);
                cmd.Parameters.AddWithValue("@in", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@point", Point_stock.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขสินค้าสำเร็จ");
                con.Close();
                DisplayData();
                ClearData();
                ID_Stock.Focus();
            }
            else
            {
                MessageBox.Show("โปรดเลือกสินค้าเพื่อทำการแก้ไข!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e) //ปุ่มลบข้อมูล
        {
            if (ID_Stock.Text != "")
            {
                cmd = new SqlCommand("delete Coffeestock where ID_Stock=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID_Stock.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ลบสินค้าสำเร็จ");
                DisplayData();
                ClearData();
                ID_Stock.Focus();
            }
            else
            {
                MessageBox.Show("โปรดเลือกสินค้าเพื่อทำการลบ!");
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) //เลือกแถวDataGridview
        {
            ID_Stock.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Name_Stock.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Amount_stock.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Point_stock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Name_Stock_KeyDown(object sender, KeyEventArgs e) //กดEnterชื่อสินค้า
        {
            if (e.KeyCode == Keys.Enter)
            {
                Amount_stock.Focus();
            }
        }

        private void Amount_stock_KeyDown(object sender, KeyEventArgs e) //กดEnterจำนวนสินค้า
        {
            if (e.KeyCode == Keys.Enter)
            {
                Point_stock.Focus();
            }
        }
    }
}
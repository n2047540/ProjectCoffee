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
    public partial class FormLoginCus : Form
    {
        public FormLoginCus()
        {
            InitializeComponent();
        }
        CoffeeEntities4 db = new CoffeeEntities4();

        private void FormLoginCus_Load(object sender, EventArgs e)
        {
            Username_mem.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Coffee;User ID=sa;Password=Modtanoy");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Member WHERE Username_member='" + Username_mem.Text + "' AND Password_member ='" + Password_mem.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("ยินดีต้อนรับ!", "ผลการทำงาน", MessageBoxButtons.OK);
                this.Hide();
                new FormMember().Show();
            }
            else
                MessageBox.Show("กรุณาตรวจสอบชื่อและรหัสอีกครั้ง", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Username_mem_KeyDown(object sender, KeyEventArgs e)
        {
            if (Username_mem.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Password_mem.Focus();
                }
            }
        }

        private void Password_mem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Coffee;User ID=sa;Password=Modtanoy");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Member WHERE Username_member='" + Username_mem.Text + "' AND Password_member ='" + Password_mem.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("ยินดีต้อนรับ!", "ผลการทำงาน", MessageBoxButtons.OK);
                    this.Hide();
                    new FormMember().Show();
                }
                else
                    MessageBox.Show("กรุณาตรวจสอบชื่อและรหัสอีกครั้ง", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

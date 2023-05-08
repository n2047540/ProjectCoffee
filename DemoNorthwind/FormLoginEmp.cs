using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNorthwind
{
    public partial class FormLoginEmp : Form
    {
        public FormLoginEmp()
        {
            InitializeComponent();
        }
        private void ButtonLoginEmp_Click(object sender, EventArgs e)
        {
            if ((Username.Text == "admin") && (Password.Text == "1234"))
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ!", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuEmp fme = new FormMenuEmp();
                this.Hide();
                fme.Show();

            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบชื่อและรหัสอีกครั้ง", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormLoginEmp_Load(object sender, EventArgs e)
        {
            Username.Focus();
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (Username.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Password.Focus();
                }
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((Username.Text == "admin") && (Password.Text == "1234"))
                {
                    MessageBox.Show("เข้าสู่ระบบสำเร็จ!", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenuEmp fme = new FormMenuEmp();
                    this.Hide();
                    fme.Show();
                }
                else
                {
                    MessageBox.Show("กรุณาตรวจสอบชื่อและรหัสอีกครั้ง", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}

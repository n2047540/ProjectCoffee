using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoNorthwind
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }
        CoffeeEntities4 ce = new CoffeeEntities4();

        private void FormSignup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeMemberDataSet.Member' table. You can move, or remove it, as needed.
            //this.memberTableAdapter.Fill(this.coffeeMemberDataSet.Member);
            ClearData();
            Username_mem.Focus();
        }
        private void Register() //การลงทะเบียน
        {
            if (Username_mem.Text == "" || Password_mem.Text == "" || CPassword_mem.Text == "" || Name__mem.Text == "" || Lastname_mem.Text == "" || Email_mem.Text == "" || Phone_mem.Text == "")
            {
                MessageBox.Show("โปรดใส่ข้อมูล", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Password_mem.Text != CPassword_mem.Text)
            {
                MessageBox.Show("รหัสผ่านและยืนยันรหัสผ่านไม่ตรงกัน", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Username_mem.Text != "")
            {
                var cs = (from c in ce.Member
                          select new
                          {

                              Usermem = c.Username_member,
                          }).Where(w => w.Usermem == Username_mem.Text.Trim());
                if (cs.Count() > 0)
                {
                    MessageBox.Show("ชื่อผู้ใช้นี้ถูกใช้ไปแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (Email_mem.Text != "")
                {
                    var ds = (from c in ce.Member
                              select new
                              {
                                  Emailmem = c.Email_member
                              }).Where(w => w.Emailmem == Email_mem.Text.Trim());
                    if (ds.Count() > 0)
                    {
                        MessageBox.Show("อีเมลนี้ถูกใช้ไปแล้ว", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Member m = new Member();
                        m.Username_member = Username_mem.Text.Trim();
                        m.Password_member = Password_mem.Text.Trim();
                        m.Name_member = Name__mem.Text.Trim();
                        m.Lastname_member = Lastname_mem.Text.Trim();
                        m.Email_member = Email_mem.Text.Trim();
                        m.Phone_member = Phone_mem.Text.Trim();
                        ce.Member.Add(m);
                        ce.SaveChanges();
                        MessageBox.Show("ลงทะเบียนสำเร็จ!", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoginCus flc = new FormLoginCus();
                        this.Hide();
                        flc.Show();
                    }
                }
            }
        }
        private void SUConfirm_Click(object sender, EventArgs e) //ปุ่มยืนยัน
        {
            Register();
        }
        private void SUCancel_Click(object sender, EventArgs e) //ปุ่มยกเลิก
        {
            this.Hide();

        }
        private void ClearData() //ล้างข้อมูล
        {
            Username_mem.Text = "";
            Password_mem.Text = "";
            Name__mem.Text = "";
            Lastname_mem.Text = "";
            Email_mem.Text = "";
            Phone_mem.Text = "";
        }
        private void Username_mem_KeyDown(object sender, KeyEventArgs e) //โฟกัสบรรทัดถัดไป
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password_mem.Focus();
            }
        }
        private void Password_mem_KeyDown(object sender, KeyEventArgs e) //โฟกัสบรรทัดถัดไป
        {
            if (e.KeyCode == Keys.Enter)
            {
                CPassword_mem.Focus();
            }
        }
        private void CPassword_mem_KeyDown(object sender, KeyEventArgs e) //โฟกัสบรรทัดถัดไป
        {
            if (e.KeyCode == Keys.Enter)
            {
                Name__mem.Focus();
            }
        }
        private void Name__mem_KeyDown(object sender, KeyEventArgs e) //โฟกัสบรรทัดถัดไป
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lastname_mem.Focus();
            }
        }
        private void Lastname_mem_KeyDown(object sender, KeyEventArgs e) //โฟกัสบรรทัดถัดไป
        {
            if (e.KeyCode == Keys.Enter)
            {
                Email_mem.Focus();
            }
        }
        private void Email_mem_KeyDown(object sender, KeyEventArgs e) //โฟกัสบรรทัดถัดไป
        {
            if (e.KeyCode == Keys.Enter)
            {
                Phone_mem.Focus();
            }
        }
        private void Phone_mem_KeyDown(object sender, KeyEventArgs e) //ลงทะเบียน
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }
    }
}

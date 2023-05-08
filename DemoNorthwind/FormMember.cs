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
    public partial class FormMember : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Coffee;User ID=sa;Password=Modtanoy");
        public FormMember()
        {
            InitializeComponent();
        }
        CoffeeEntities4 ce = new CoffeeEntities4();

        private void FormMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeMemberDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.coffeeMemberDataSet.Member);
        }

        private void FormMember_Activated(object sender, EventArgs e)
        {
            Uname_mem.Focus();
        }
        private void Uname_mem_KeyDown(object sender, KeyEventArgs e)
        {
            if (Uname_mem.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var cs = (from s in ce.Member
                              select new
                              {
                                  UN = s.Username_member,
                                  MID = s.ID_member,
                                  MN = s.Name_member,
                                  MLN = s.Lastname_member,
                                  MPh = s.Phone_member,
                                  MP = s.Point_member
                              }).Where(w => w.UN.ToString() == Uname_mem.Text.Trim());
                    if (cs.Count() > 0)
                    {
                        Uname_mem.Text = cs.FirstOrDefault().UN.ToString();
                        ID_mem.Text = cs.FirstOrDefault().MID.ToString();
                        Name_mem.Text = cs.FirstOrDefault().MN.ToString();
                        Last_mem.Text = cs.FirstOrDefault().MLN.ToString();
                        Phone_mem.Text = cs.FirstOrDefault().MPh.ToString();
                        Point_mem.Text = cs.FirstOrDefault().MP.ToString();
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้ที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Uname_mem.Text = "";
                        Uname_mem.Focus();
                    }
                }
            }
        }
    }
}

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
    public partial class coffeeshopsys : Form
    {
        public coffeeshopsys()
        {
            InitializeComponent();
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.MdiParent = this;
            fm.Show();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginCus fl = new FormLoginCus();
            fl.MdiParent = this;
            fl.Show();
        }
        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSignup fs = new FormSignup();
            fs.MdiParent = this;
            fs.Show();
        }

        private void LoginEmpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLoginEmp fle = new FormLoginEmp();
            fle.MdiParent = this;
            fle.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReport fr = new FormReport();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}

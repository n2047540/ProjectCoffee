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
    public partial class FormMenuEmp : Form
    {
        public FormMenuEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddstock fas = new FormAddstock();
            fas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStock fs = new FormStock();
            fs.Show();
        }

        private void FormMenuEmp_Load(object sender, EventArgs e)
        {

        }
    }
}

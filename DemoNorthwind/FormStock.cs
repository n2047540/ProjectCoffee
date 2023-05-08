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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeStockDataSet.Coffeestock' table. You can move, or remove it, as needed.
            this.coffeestockTableAdapter.Fill(this.coffeeStockDataSet.Coffeestock);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void coffeestockBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

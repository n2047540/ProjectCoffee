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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        CoffeeEntities4 ce = new CoffeeEntities4();

        private void FormMenu_Load_1(object sender, EventArgs e) //listview
        {
            ListViewItem.Columns.Add("รหัสสินค้า", 0);
            ListViewItem.Columns.Add("รหัสสมาชิก", 70);
            ListViewItem.Columns.Add("ชื่อสินค้า", 110);
            ListViewItem.Columns.Add("ราคา", 80);
            ListViewItem.Columns.Add("จำนวน", 50);
            ListViewItem.Columns.Add("ราคารวม", 80);
            ListViewItem.Columns.Add("วันที่", 80);
            ListViewItem.Columns.Add("แต้ม", 0);
            ListViewItem.Columns.Add("แต้มรวม", 70);
            ListViewItem.View = View.Details;
            ListViewItem.GridLines = true;
            ListViewItem.FullRowSelect = true;
        }
        private void ID_mem_KeyDown(object sender, KeyEventArgs e) //กรอกรหัสสมาชิก
        {
            if (ID_mem.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var mb = (from m in ce.Member
                              select new
                              {
                                  ID_mem = m.ID_member,
                                  Name_mem = m.Name_member
                              }).Where(w => w.ID_mem.ToString() == ID_mem.Text.Trim());

                    if (mb.Count() > 0)
                    {
                        ID_mem.Text = mb.FirstOrDefault().ID_mem.ToString();
                        Name_mem.Text = mb.FirstOrDefault().Name_mem.Trim();
                        ID_Sto.Focus();
                    }
                    else
                    {
                        MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ID_mem.Text = "";
                        ID_mem.Focus();
                    }
                }
            }
        }
        private void ID_Stock_KeyDown(object sender, KeyEventArgs e) //กรอกรหัสสินค้า
        {
            if (ID_Sto.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var cs = (from s in ce.Coffeestock
                              select new
                              {
                                  SID = s.ID_Stock,
                                  SN = s.Name_Stock,
                                  SP = s.Price_Stock,
                                  SPO = s.Point
                              }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
                    if (cs.Count() > 0)
                    {
                        ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                        Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                        Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                        Point.Text = cs.FirstOrDefault().SPO.ToString();
                        Amount_Sto.Focus();
                    }
                    else
                    {
                        MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ID_Sto.Text = "";
                        ID_Sto.Focus();
                    }
                }
            }
        }
        private void Amount_Sto_TextChanged(object sender, EventArgs e) //ตั้งค่าจำนวน
        {
            if (Amount_Sto.Text.Trim() == "")
            {
                Amount_Sto.Text = "0";
            }
            CalculatePrice();
        }
        private void CalculatePrice() //คำนวณราคา+แต้ม
        {
            if ((Price_Sto.Text.Trim() == "") || (Amount_Sto.Text.Trim() == ""))
            {
                return;
            }
            else
            {
                decimal Total;
                Total = (Decimal.Parse(Price_Sto.Text)) * Decimal.Parse(Amount_Sto.Text);
                AllPrice.Text = Total.ToString("#,##0.00");

                int Totalp;
                Totalp = (int.Parse(Point.Text)) * int.Parse(Amount_Sto.Text);
                AllPoint.Text = Totalp.ToString("##0");
            }
        }
        private void ClearProduct() //ล้างกล่องText
        {
            ID_Sto.Text = "";
            Name_Sto.Text = "";
            Price_Sto.Text = "";
            Amount_Sto.Text = "";
            AllPrice.Text = "";
            Point.Text = "";
            AllPoint.Text = "";
        }
        private void AddProduct() //เพิ่มสินค้า
        {
            if (ID_mem.Text.Trim() == "")
            {
                MessageBox.Show("โปรดใส่รหัสสมาชิก", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_mem.Focus();
                return;
            }
            if ((ID_Sto.Text.Trim() == "") || (Name_Sto.Text.Trim() == "" ))
            {
                MessageBox.Show("โปรดเลือกสินค้า", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Focus();
                return;
            }
            if ((Amount_Sto.Text.Trim() == ""))
            {
                MessageBox.Show("โปรดใส่จำนวน", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Amount_Sto.Focus();
                return;
            }
            else
            {
                int a = 0;
                ListViewItem lv1;
                int tmpID_Stock = 0;
                for (a = 0; a <= ListViewItem.Items.Count - 1; a++)
                {
                    tmpID_Stock = int.Parse(ListViewItem.Items[a].SubItems[0].Text);
                    if (int.Parse(ID_Sto.Text.Trim()) == tmpID_Stock)
                    {
                        MessageBox.Show("เพิ่มรายการเรียบร้อย");
                        ID_Sto.Focus();
                        return;
                    }
                }
                string[] anyData;
                anyData = new string[]
                {
                    ID_Sto.Text,
                    ID_mem.Text,
                    Name_Sto.Text,
                    Price_Sto.Text,
                    Amount_Sto.Text,
                    AllPrice.Text,
                    dateTimePicker1.Text,
                    Point.Text,
                    AllPoint.Text
                };
                lv1 = new ListViewItem(anyData);
                ListViewItem.Items.Add(lv1);
                CalculateTotalNet();
                ClearProduct();
            }
        }
        private void CalculateTotalNet() //คำนวณสินค้าโดยรวม
        {
            int i = 0;
            decimal tmpTotal_Order = 0;
            int tmpTotalp_Order = 0;
            for (i = 0; i <= ListViewItem.Items.Count - 1; i++)
            {
                tmpTotal_Order += decimal.Parse(ListViewItem.Items[i].SubItems[4].Text);
                tmpTotalp_Order += int.Parse(ListViewItem.Items[i].SubItems[4].Text);
            }
            AllPrice.Text = tmpTotal_Order.ToString("#,##0.00");
            AllPoint.Text = tmpTotalp_Order.ToString("##0");
        }
        private void btnClear_Click(object sender, EventArgs e) //ปุ่มล้างรายการ
        {
            ListViewItem.Items.Clear();
            AllPrice.Text = "";
            AllPoint.Text = "";
            ID_Sto.Focus();
        }
        private void Amount_Sto_KeyDown(object sender, KeyEventArgs e) //กดEnterจำนวน
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddProduct();
            }
        }
        private void btnSave_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อ
        {
            if ((ID_mem.Text.Trim() == "") || (Name_mem.Text.Trim() == ""))
            {
                MessageBox.Show("กรุณากรอกข้อมูลลูกค้าให้ครบถ้วน", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_mem.Focus();
                return;
            }

            if (ListViewItem.Items.Count <= 0)
            {
                MessageBox.Show("กรุณาเลือกรายการสินค้าให้ครบถ้วน", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("ต้องการบันทึกรายการสินค้านี้ใช่หรือไม่", "ผลการทำงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Order o = new Order();
                    o.ID_member = int.Parse(ID_mem.Text.Trim());
                    int i;
                    Order_Details od;
                    for (i = 0; i <= ListViewItem.Items.Count - 1; i++)
                    {
                        qtysend.Text = ListViewItem.Items[i].SubItems[0].Text.Trim();
                        var bb = (from b in ce.Coffeestock
                                  where b.ID_Stock.ToString() == qtysend.Text.Trim()
                                  select b).FirstOrDefault();
                        if (bb != null)
                        {
                            qtyget.Text = bb.Amount_stock.ToString();
                            int a = int.Parse(qtyget.Text.Trim());
                            int b = int.Parse(ListViewItem.Items[i].SubItems[4].Text);
                            a = a - b;
                            qtyget.Text = a.ToString();
                            bb.Amount_stock = int.Parse(qtyget.Text.Trim());
                            if (a > 0)
                            {
                                od = new Order_Details();
                                od.No_Order = o.No_Order;
                                od.ID_Stock = ListViewItem.Items[i].SubItems[0].Text;
                                od.Price_Stock = decimal.Parse(ListViewItem.Items[i].SubItems[3].Text);
                                od.Amount_stock = int.Parse(ListViewItem.Items[i].SubItems[4].Text);
                                od.Total_Order = decimal.Parse(ListViewItem.Items[i].SubItems[5].Text);
                                od.Date_Order = DateTime.Parse(ListViewItem.Items[i].SubItems[6].Text);
                                od.Point = int.Parse(ListViewItem.Items[i].SubItems[8].Text);
                                o.Order_Details.Add(od);
                                using (var tr = ce.Database.BeginTransaction())
                                {
                                    ce.Order.Add(o);
                                    ce.SaveChanges();
                                    tr.Commit();
                                    MessageBox.Show("บันทึกข้อมูลเสร็จเรียบร้อย", "ผลการทำงาน");
                                    ListViewItem.Clear();
                                    ClearProduct();
                                    AllPrice.Text = "0.00";
                                    ID_mem.Text = "";
                                    Name_mem.Text = "";
                                    ID_mem.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("สินค้าไม่เพียงพอ", "ผลการทำงาน", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e) //ปิดฟอร์ม
        {
            ce.Dispose();
        }
        private void btnADD_Click(object sender, EventArgs e) //ปุ่มเพิ่มรายการ
        {
            AddProduct();
        }
        private void FormMenu_Load(object sender, EventArgs e) //โหลดฟอร์ม
        {
            ID_mem.Focus();
        }
        private void button1_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อกาแฟ
        {
            ID_Sto.Text = "C0001";
            var cs = (from s in ce.Coffeestock
                      select new
                      {
                          SID = s.ID_Stock,
                          SN = s.Name_Stock,
                          SP = s.Price_Stock,
                          SPO = s.Point
                      }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
            if (cs.Count() > 0)
            {
                ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                Point.Text = cs.FirstOrDefault().SPO.ToString();
                Amount_Sto.Focus();
            }
            else
            {
                MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Text = "";
                ID_Sto.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อกาแฟ
        {
            ID_Sto.Text = "C0005";
            var cs = (from s in ce.Coffeestock
                      select new
                      {
                          SID = s.ID_Stock,
                          SN = s.Name_Stock,
                          SP = s.Price_Stock,
                          SPO = s.Point
                      }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
            if (cs.Count() > 0)
            {
                ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                Point.Text = cs.FirstOrDefault().SPO.ToString();
                Amount_Sto.Focus();
            }
            else
            {
                MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Text = "";
                ID_Sto.Focus();
            }
        }
        private void button3_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อกาแฟ
        {
            ID_Sto.Text = "C0004";
            var cs = (from s in ce.Coffeestock
                      select new
                      {
                          SID = s.ID_Stock,
                          SN = s.Name_Stock,
                          SP = s.Price_Stock,
                          SPO = s.Point
                      }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
            if (cs.Count() > 0)
            {
                ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                Point.Text = cs.FirstOrDefault().SPO.ToString();
                Amount_Sto.Focus();
            }
            else
            {
                MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Text = "";
                ID_Sto.Focus();
            }
        }
        private void button6_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อกาแฟ
        {
            ID_Sto.Text = "C0002";
            var cs = (from s in ce.Coffeestock
                      select new
                      {
                          SID = s.ID_Stock,
                          SN = s.Name_Stock,
                          SP = s.Price_Stock,
                          SPO = s.Point
                      }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
            if (cs.Count() > 0)
            {
                ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                Point.Text = cs.FirstOrDefault().SPO.ToString();
                Amount_Sto.Focus();
            }
            else
            {
                MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Text = "";
                ID_Sto.Focus();
            }
        }
        private void button5_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อกาแฟ
        {
            ID_Sto.Text = "C0003";
            var cs = (from s in ce.Coffeestock
                      select new
                      {
                          SID = s.ID_Stock,
                          SN = s.Name_Stock,
                          SP = s.Price_Stock,
                          SPO = s.Point
                      }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
            if (cs.Count() > 0)
            {
                ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                Point.Text = cs.FirstOrDefault().SPO.ToString();
                Amount_Sto.Focus();
            }
            else
            {
                MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Text = "";
                ID_Sto.Focus();
            }
        }
        private void button4_Click(object sender, EventArgs e) //ปุ่มสั่งซื้อกาแฟ
        {
            ID_Sto.Text = "C0006";
            var cs = (from s in ce.Coffeestock
                      select new
                      {
                          SID = s.ID_Stock,
                          SN = s.Name_Stock,
                          SP = s.Price_Stock,
                          SPO = s.Point
                      }).Where(w => w.SID.ToString() == ID_Sto.Text.Trim());
            if (cs.Count() > 0)
            {
                ID_Sto.Text = cs.FirstOrDefault().SID.ToString();
                Name_Sto.Text = cs.FirstOrDefault().SN.ToString();
                Price_Sto.Text = cs.FirstOrDefault().SP.ToString();
                Point.Text = cs.FirstOrDefault().SPO.ToString();
                Amount_Sto.Focus();
            }
            else
            {
                MessageBox.Show("รหัสที่ป้อนไม่มีอยู่ในระบบ", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ID_Sto.Text = "";
                ID_Sto.Focus();
            }
        }

        private void coffeeMenuDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
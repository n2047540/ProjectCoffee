
namespace DemoNorthwind
{
    partial class coffeeshopsys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coffeeshopsys));
            this.menucoffeesys = new System.Windows.Forms.MenuStrip();
            this.coffeesysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginEmpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.membersysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logincusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menucoffeesys.SuspendLayout();
            this.SuspendLayout();
            // 
            // menucoffeesys
            // 
            this.menucoffeesys.BackColor = System.Drawing.Color.White;
            this.menucoffeesys.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menucoffeesys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coffeesysToolStripMenuItem,
            this.employeesysToolStripMenuItem,
            this.membersysToolStripMenuItem});
            this.menucoffeesys.Location = new System.Drawing.Point(0, 0);
            this.menucoffeesys.Name = "menucoffeesys";
            this.menucoffeesys.Size = new System.Drawing.Size(1920, 68);
            this.menucoffeesys.TabIndex = 0;
            this.menucoffeesys.Text = "menuStrip1";
            // 
            // coffeesysToolStripMenuItem
            // 
            this.coffeesysToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.coffeesysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.coffeesysToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeesysToolStripMenuItem.Image = global::DemoNorthwind.Properties.Resources.Home;
            this.coffeesysToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.coffeesysToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.coffeesysToolStripMenuItem.Name = "coffeesysToolStripMenuItem";
            this.coffeesysToolStripMenuItem.Size = new System.Drawing.Size(119, 64);
            this.coffeesysToolStripMenuItem.Text = "ระบบร้านกาแฟ";
            this.coffeesysToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Image = global::DemoNorthwind.Properties.Resources.proicon;
            this.menuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.menuToolStripMenuItem.Text = "เมนูสินค้า";
            this.menuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // employeesysToolStripMenuItem
            // 
            this.employeesysToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.employeesysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginEmpToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.employeesysToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesysToolStripMenuItem.Image = global::DemoNorthwind.Properties.Resources.Emp;
            this.employeesysToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeesysToolStripMenuItem.Name = "employeesysToolStripMenuItem";
            this.employeesysToolStripMenuItem.Size = new System.Drawing.Size(113, 64);
            this.employeesysToolStripMenuItem.Text = "ระบบพนักงาน";
            this.employeesysToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.employeesysToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // LoginEmpToolStripMenuItem1
            // 
            this.LoginEmpToolStripMenuItem1.Image = global::DemoNorthwind.Properties.Resources.emplo;
            this.LoginEmpToolStripMenuItem1.Name = "LoginEmpToolStripMenuItem1";
            this.LoginEmpToolStripMenuItem1.Size = new System.Drawing.Size(239, 28);
            this.LoginEmpToolStripMenuItem1.Text = "เข้าสู่ระบบพนักงาน";
            this.LoginEmpToolStripMenuItem1.Click += new System.EventHandler(this.LoginEmpToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DemoNorthwind.Properties.Resources.Report;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 28);
            this.toolStripMenuItem1.Text = "รายงานผลประกอบการ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // membersysToolStripMenuItem
            // 
            this.membersysToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.membersysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logincusToolStripMenuItem,
            this.signupToolStripMenuItem});
            this.membersysToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersysToolStripMenuItem.Image = global::DemoNorthwind.Properties.Resources.Member;
            this.membersysToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membersysToolStripMenuItem.Name = "membersysToolStripMenuItem";
            this.membersysToolStripMenuItem.Size = new System.Drawing.Size(104, 64);
            this.membersysToolStripMenuItem.Text = "ระบบสมาชิก";
            this.membersysToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.membersysToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // logincusToolStripMenuItem
            // 
            this.logincusToolStripMenuItem.Image = global::DemoNorthwind.Properties.Resources.SignUp;
            this.logincusToolStripMenuItem.Name = "logincusToolStripMenuItem";
            this.logincusToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.logincusToolStripMenuItem.Text = "เข้าสู่ระบบ";
            this.logincusToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // signupToolStripMenuItem
            // 
            this.signupToolStripMenuItem.Image = global::DemoNorthwind.Properties.Resources.Add;
            this.signupToolStripMenuItem.Name = "signupToolStripMenuItem";
            this.signupToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.signupToolStripMenuItem.Text = "สมัครสมาชิกใหม่";
            this.signupToolStripMenuItem.Click += new System.EventHandler(this.signupToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // coffeeshopsys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::DemoNorthwind.Properties.Resources.unknown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.menucoffeesys);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menucoffeesys;
            this.MaximizeBox = false;
            this.Name = "coffeeshopsys";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบร้านกาแฟ";
            this.menucoffeesys.ResumeLayout(false);
            this.menucoffeesys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menucoffeesys;
        private System.Windows.Forms.ToolStripMenuItem coffeesysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logincusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signupToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginEmpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


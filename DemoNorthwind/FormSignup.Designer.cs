
namespace DemoNorthwind
{
    partial class FormSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignup));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SUConfirm = new System.Windows.Forms.Button();
            this.SUCancel = new System.Windows.Forms.Button();
            this.Username_mem = new System.Windows.Forms.TextBox();
            this.Phone_mem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_mem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CPassword_mem = new System.Windows.Forms.TextBox();
            this.Name__mem = new System.Windows.Forms.TextBox();
            this.Lastname_mem = new System.Windows.Forms.TextBox();
            this.Email_mem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coffeeMemberDataSet = new DemoNorthwind.CoffeeMemberDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new DemoNorthwind.CoffeeMemberDataSetTableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeMemberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ชื่อผู้ใช้";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(24, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "เบอร์โทรศัพท์";
            // 
            // SUConfirm
            // 
            this.SUConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SUConfirm.Location = new System.Drawing.Point(122, 388);
            this.SUConfirm.Name = "SUConfirm";
            this.SUConfirm.Size = new System.Drawing.Size(122, 57);
            this.SUConfirm.TabIndex = 30;
            this.SUConfirm.Text = "ยืนยัน";
            this.SUConfirm.UseVisualStyleBackColor = true;
            this.SUConfirm.Click += new System.EventHandler(this.SUConfirm_Click);
            // 
            // SUCancel
            // 
            this.SUCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SUCancel.Location = new System.Drawing.Point(323, 388);
            this.SUCancel.Name = "SUCancel";
            this.SUCancel.Size = new System.Drawing.Size(122, 57);
            this.SUCancel.TabIndex = 31;
            this.SUCancel.Text = "ยกเลิก";
            this.SUCancel.UseVisualStyleBackColor = true;
            this.SUCancel.Click += new System.EventHandler(this.SUCancel_Click);
            // 
            // Username_mem
            // 
            this.Username_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Username_mem.Location = new System.Drawing.Point(173, 38);
            this.Username_mem.Name = "Username_mem";
            this.Username_mem.Size = new System.Drawing.Size(401, 27);
            this.Username_mem.TabIndex = 32;
            this.Username_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_mem_KeyDown);
            // 
            // Phone_mem
            // 
            this.Phone_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phone_mem.Location = new System.Drawing.Point(173, 307);
            this.Phone_mem.Name = "Phone_mem";
            this.Phone_mem.Size = new System.Drawing.Size(401, 27);
            this.Phone_mem.TabIndex = 35;
            this.Phone_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phone_mem_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "รหัสผ่าน";
            // 
            // Password_mem
            // 
            this.Password_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Password_mem.Location = new System.Drawing.Point(173, 84);
            this.Password_mem.Name = "Password_mem";
            this.Password_mem.Size = new System.Drawing.Size(401, 27);
            this.Password_mem.TabIndex = 37;
            this.Password_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_mem_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "ยืนยันรหัสผ่าน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(24, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "ชื่อ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(24, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "นามสกุล";
            // 
            // CPassword_mem
            // 
            this.CPassword_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CPassword_mem.Location = new System.Drawing.Point(173, 127);
            this.CPassword_mem.Name = "CPassword_mem";
            this.CPassword_mem.Size = new System.Drawing.Size(401, 27);
            this.CPassword_mem.TabIndex = 41;
            this.CPassword_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPassword_mem_KeyDown);
            // 
            // Name__mem
            // 
            this.Name__mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name__mem.Location = new System.Drawing.Point(173, 173);
            this.Name__mem.Name = "Name__mem";
            this.Name__mem.Size = new System.Drawing.Size(401, 27);
            this.Name__mem.TabIndex = 42;
            this.Name__mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name__mem_KeyDown);
            // 
            // Lastname_mem
            // 
            this.Lastname_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Lastname_mem.Location = new System.Drawing.Point(173, 218);
            this.Lastname_mem.Name = "Lastname_mem";
            this.Lastname_mem.Size = new System.Drawing.Size(401, 27);
            this.Lastname_mem.TabIndex = 43;
            this.Lastname_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lastname_mem_KeyDown);
            // 
            // Email_mem
            // 
            this.Email_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Email_mem.Location = new System.Drawing.Point(173, 261);
            this.Email_mem.Name = "Email_mem";
            this.Email_mem.Size = new System.Drawing.Size(401, 27);
            this.Email_mem.TabIndex = 45;
            this.Email_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_mem_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(24, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "อีเมล";
            // 
            // coffeeMemberDataSet
            // 
            this.coffeeMemberDataSet.DataSetName = "CoffeeMemberDataSet";
            this.coffeeMemberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.coffeeMemberDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(176)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(646, 497);
            this.Controls.Add(this.Email_mem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lastname_mem);
            this.Controls.Add(this.Name__mem);
            this.Controls.Add(this.CPassword_mem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_mem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phone_mem);
            this.Controls.Add(this.Username_mem);
            this.Controls.Add(this.SUCancel);
            this.Controls.Add(this.SUConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSignup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สมัครสมาชิก";
            this.Activated += new System.EventHandler(this.FormSignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeMemberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SUConfirm;
        private System.Windows.Forms.Button SUCancel;
        private System.Windows.Forms.TextBox Username_mem;
        private System.Windows.Forms.TextBox Phone_mem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_mem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CPassword_mem;
        private System.Windows.Forms.TextBox Name__mem;
        private System.Windows.Forms.TextBox Lastname_mem;
        private System.Windows.Forms.TextBox Email_mem;
        private System.Windows.Forms.Label label7;
        private CoffeeMemberDataSet coffeeMemberDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CoffeeMemberDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
    }
}
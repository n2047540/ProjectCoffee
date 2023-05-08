
namespace DemoNorthwind
{
    partial class FormMember
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
            this.label0 = new System.Windows.Forms.Label();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeMemberDataSet = new DemoNorthwind.CoffeeMemberDataSet();
            this.memberTableAdapter = new DemoNorthwind.CoffeeMemberDataSetTableAdapters.MemberTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_mem = new System.Windows.Forms.TextBox();
            this.Name_mem = new System.Windows.Forms.TextBox();
            this.Phone_mem = new System.Windows.Forms.TextBox();
            this.Last_mem = new System.Windows.Forms.TextBox();
            this.Point_mem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Uname_mem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeMemberDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label0.Location = new System.Drawing.Point(192, 24);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(311, 38);
            this.label0.TabIndex = 17;
            this.label0.Text = "ตรวจสอบข้อมูลสมาชิก";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.coffeeMemberDataSet;
            // 
            // coffeeMemberDataSet
            // 
            this.coffeeMemberDataSet.DataSetName = "CoffeeMemberDataSet";
            this.coffeeMemberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(98, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(98, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "นามสกุล";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(98, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "เบอร์โทร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(98, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "แต้มสะสม";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(98, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "รหัสเมมเบอร์";
            // 
            // ID_mem
            // 
            this.ID_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ID_mem.Location = new System.Drawing.Point(233, 149);
            this.ID_mem.Name = "ID_mem";
            this.ID_mem.Size = new System.Drawing.Size(348, 30);
            this.ID_mem.TabIndex = 33;
            // 
            // Name_mem
            // 
            this.Name_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name_mem.Location = new System.Drawing.Point(233, 191);
            this.Name_mem.Name = "Name_mem";
            this.Name_mem.Size = new System.Drawing.Size(348, 30);
            this.Name_mem.TabIndex = 34;
            // 
            // Phone_mem
            // 
            this.Phone_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phone_mem.Location = new System.Drawing.Point(233, 273);
            this.Phone_mem.Name = "Phone_mem";
            this.Phone_mem.Size = new System.Drawing.Size(348, 30);
            this.Phone_mem.TabIndex = 37;
            // 
            // Last_mem
            // 
            this.Last_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Last_mem.Location = new System.Drawing.Point(233, 231);
            this.Last_mem.Name = "Last_mem";
            this.Last_mem.Size = new System.Drawing.Size(348, 30);
            this.Last_mem.TabIndex = 38;
            // 
            // Point_mem
            // 
            this.Point_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Point_mem.Location = new System.Drawing.Point(233, 313);
            this.Point_mem.Name = "Point_mem";
            this.Point_mem.Size = new System.Drawing.Size(348, 30);
            this.Point_mem.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(98, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "ชื่อผู้ใช้";
            // 
            // Uname_mem
            // 
            this.Uname_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Uname_mem.Location = new System.Drawing.Point(233, 102);
            this.Uname_mem.Name = "Uname_mem";
            this.Uname_mem.Size = new System.Drawing.Size(348, 30);
            this.Uname_mem.TabIndex = 42;
            this.Uname_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Uname_mem_KeyDown);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(176)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(717, 447);
            this.Controls.Add(this.Uname_mem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Point_mem);
            this.Controls.Add(this.Last_mem);
            this.Controls.Add(this.Phone_mem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name_mem);
            this.Controls.Add(this.ID_mem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Name = "FormMember";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบสะสมแต้ม";
            this.Activated += new System.EventHandler(this.FormMember_Activated);
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeMemberDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label0;
        private CoffeeMemberDataSet coffeeMemberDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private CoffeeMemberDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_mem;
        private System.Windows.Forms.TextBox Name_mem;
        private System.Windows.Forms.TextBox Phone_mem;
        private System.Windows.Forms.TextBox Last_mem;
        private System.Windows.Forms.TextBox Point_mem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Uname_mem;
    }
}
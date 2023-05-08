
namespace DemoNorthwind
{
    partial class FormLoginCus
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username_mem = new System.Windows.Forms.TextBox();
            this.Password_mem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(120, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "เข้าสู่ระบบ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(67, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "ชื่อผู้ใช้";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "รหัสผ่าน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(94, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "ระบบสมาชิกร้านกาแฟ";
            // 
            // Username_mem
            // 
            this.Username_mem.Location = new System.Drawing.Point(164, 117);
            this.Username_mem.Name = "Username_mem";
            this.Username_mem.Size = new System.Drawing.Size(367, 22);
            this.Username_mem.TabIndex = 26;
            this.Username_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_mem_KeyDown);
            // 
            // Password_mem
            // 
            this.Password_mem.Location = new System.Drawing.Point(164, 176);
            this.Password_mem.Name = "Password_mem";
            this.Password_mem.Size = new System.Drawing.Size(367, 22);
            this.Password_mem.TabIndex = 27;
            this.Password_mem.UseSystemPasswordChar = true;
            this.Password_mem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_mem_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(322, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormLoginCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(176)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(567, 352);
            this.Controls.Add(this.Password_mem);
            this.Controls.Add(this.Username_mem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "FormLoginCus";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าสู่ระบบ";
            this.Activated += new System.EventHandler(this.FormLoginCus_Load);
            this.Load += new System.EventHandler(this.FormLoginCus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username_mem;
        private System.Windows.Forms.TextBox Password_mem;
        private System.Windows.Forms.Button button2;
    }
}

namespace DemoNorthwind
{
    partial class FormLoginEmp
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
            this.ButtonLoginEmp = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLoginEmp
            // 
            this.ButtonLoginEmp.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLoginEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ButtonLoginEmp.Location = new System.Drawing.Point(138, 211);
            this.ButtonLoginEmp.Name = "ButtonLoginEmp";
            this.ButtonLoginEmp.Size = new System.Drawing.Size(186, 71);
            this.ButtonLoginEmp.TabIndex = 23;
            this.ButtonLoginEmp.Text = "เข้าสู่ระบบ";
            this.ButtonLoginEmp.UseVisualStyleBackColor = false;
            this.ButtonLoginEmp.Click += new System.EventHandler(this.ButtonLoginEmp_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Password.Location = new System.Drawing.Point(138, 140);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(273, 24);
            this.Password.TabIndex = 24;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Username.Location = new System.Drawing.Point(138, 82);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(273, 24);
            this.Username.TabIndex = 25;
            this.Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(43, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "ชื่อผู้ใช้";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(43, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "รหัสผ่าน";
            // 
            // FormLoginEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(176)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(508, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ButtonLoginEmp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginEmp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าสู่ระบบพนักงาน";
            this.Activated += new System.EventHandler(this.FormLoginEmp_Load);
            this.Load += new System.EventHandler(this.FormLoginEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonLoginEmp;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
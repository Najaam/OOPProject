namespace OOPProject
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.Rolebox = new System.Windows.Forms.ComboBox();
            this.Forgetpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(171, 139);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(337, 43);
            this.txtmail.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(171, 209);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(337, 43);
            this.txtpass.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(236, 310);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(113, 44);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Newuser don\'t have account";
            // 
            // btnreg
            // 
            this.btnreg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(236, 384);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(113, 44);
            this.btnreg.TabIndex = 7;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // Rolebox
            // 
            this.Rolebox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolebox.FormattingEnabled = true;
            this.Rolebox.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.Rolebox.Location = new System.Drawing.Point(387, 258);
            this.Rolebox.Name = "Rolebox";
            this.Rolebox.Size = new System.Drawing.Size(121, 37);
            this.Rolebox.TabIndex = 8;
            this.Rolebox.Text = "Select";
            // 
            // Forgetpass
            // 
            this.Forgetpass.AutoSize = true;
            this.Forgetpass.Font = new System.Drawing.Font("Calibri", 10F);
            this.Forgetpass.Location = new System.Drawing.Point(177, 255);
            this.Forgetpass.Name = "Forgetpass";
            this.Forgetpass.Size = new System.Drawing.Size(165, 24);
            this.Forgetpass.TabIndex = 9;
            this.Forgetpass.Text = "Forget Password??";
            this.Forgetpass.Click += new System.EventHandler(this.label5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 440);
            this.Controls.Add(this.Forgetpass);
            this.Controls.Add(this.Rolebox);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.ComboBox Rolebox;
        private System.Windows.Forms.Label Forgetpass;
    }
}
namespace OOPProject
{
    partial class Otpforget
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
            this.label2 = new System.Windows.Forms.Label();
            this.rolebox = new System.Windows.Forms.ComboBox();
            this.txtotp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.btnverify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "OTP Verification code sent to your Email Address";
            // 
            // rolebox
            // 
            this.rolebox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolebox.FormattingEnabled = true;
            this.rolebox.Items.AddRange(new object[] {
            "Seller",
            "Buyer"});
            this.rolebox.Location = new System.Drawing.Point(428, 157);
            this.rolebox.Name = "rolebox";
            this.rolebox.Size = new System.Drawing.Size(138, 32);
            this.rolebox.TabIndex = 8;
            this.rolebox.Text = "Select Role";
            // 
            // txtotp
            // 
            this.txtotp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotp.Location = new System.Drawing.Point(167, 151);
            this.txtotp.Multiline = true;
            this.txtotp.Name = "txtotp";
            this.txtotp.Size = new System.Drawing.Size(242, 38);
            this.txtotp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "OTP";
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(198, 222);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(88, 44);
            this.Backbtn.TabIndex = 9;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // btnverify
            // 
            this.btnverify.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.Location = new System.Drawing.Point(321, 222);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(88, 44);
            this.btnverify.TabIndex = 10;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // Otpforget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 327);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.rolebox);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Otpforget";
            this.Text = "ECOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rolebox;
        private System.Windows.Forms.TextBox txtotp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button btnverify;
    }
}
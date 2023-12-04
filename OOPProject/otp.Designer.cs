namespace OOPProject
{
    partial class otp
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
            this.txtotp = new System.Windows.Forms.TextBox();
            this.btnverify = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.rolebox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTP Verification code sent to your Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "OTP";
            // 
            // txtotp
            // 
            this.txtotp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotp.Location = new System.Drawing.Point(225, 174);
            this.txtotp.Multiline = true;
            this.txtotp.Name = "txtotp";
            this.txtotp.Size = new System.Drawing.Size(193, 38);
            this.txtotp.TabIndex = 2;
            // 
            // btnverify
            // 
            this.btnverify.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.Location = new System.Drawing.Point(330, 244);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(88, 44);
            this.btnverify.TabIndex = 3;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(225, 244);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(88, 44);
            this.Backbtn.TabIndex = 4;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // rolebox
            // 
            this.rolebox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolebox.FormattingEnabled = true;
            this.rolebox.Items.AddRange(new object[] {
            "Seller",
            "Buyer"});
            this.rolebox.Location = new System.Drawing.Point(459, 179);
            this.rolebox.Name = "rolebox";
            this.rolebox.Size = new System.Drawing.Size(121, 32);
            this.rolebox.TabIndex = 5;
            this.rolebox.Text = "Select";
            // 
            // otp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 351);
            this.Controls.Add(this.rolebox);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "otp";
            this.Text = "ECOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtotp;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ComboBox rolebox;
    }
}
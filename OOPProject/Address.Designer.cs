namespace OOPProject
{
    partial class Address
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
            this.statebox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcodetxt = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.savedata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Billing Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(64, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "State";
            // 
            // statebox
            // 
            this.statebox.Font = new System.Drawing.Font("Calibri", 12F);
            this.statebox.FormattingEnabled = true;
            this.statebox.Items.AddRange(new object[] {
            "Sindh",
            "Punjab",
            "KPK",
            "Balochistan",
            "Kashmir"});
            this.statebox.Location = new System.Drawing.Point(234, 194);
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(210, 37);
            this.statebox.TabIndex = 2;
            this.statebox.Text = "Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Postal Code";
            // 
            // pcodetxt
            // 
            this.pcodetxt.Font = new System.Drawing.Font("Calibri", 12F);
            this.pcodetxt.Location = new System.Drawing.Point(234, 132);
            this.pcodetxt.Multiline = true;
            this.pcodetxt.Name = "pcodetxt";
            this.pcodetxt.Size = new System.Drawing.Size(210, 40);
            this.pcodetxt.TabIndex = 4;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Calibri", 12F);
            this.city.Location = new System.Drawing.Point(234, 248);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(210, 40);
            this.city.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(64, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Calibri", 12F);
            this.add.Location = new System.Drawing.Point(234, 314);
            this.add.Multiline = true;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(304, 40);
            this.add.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(64, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // savedata
            // 
            this.savedata.Font = new System.Drawing.Font("Calibri", 12F);
            this.savedata.Location = new System.Drawing.Point(390, 386);
            this.savedata.Name = "savedata";
            this.savedata.Size = new System.Drawing.Size(117, 38);
            this.savedata.TabIndex = 9;
            this.savedata.Text = "Save";
            this.savedata.UseVisualStyleBackColor = true;
            this.savedata.Click += new System.EventHandler(this.savedata_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.Location = new System.Drawing.Point(70, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Calibri", 12F);
            this.update.Location = new System.Drawing.Point(234, 386);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 38);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savedata);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pcodetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Address";
            this.Text = "Address";
            this.Load += new System.EventHandler(this.Address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pcodetxt;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update;
    }
}
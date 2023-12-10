namespace OOPProject
{
    partial class ViewProduct
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.pdes = new System.Windows.Forms.TextBox();
            this.pprice = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.pid = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Products";
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(-1, 457);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 62;
            this.dataView.RowTemplate.Height = 28;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(805, 143);
            this.dataView.TabIndex = 1;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectData);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(157, 606);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(91, 49);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pdes
            // 
            this.pdes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdes.Location = new System.Drawing.Point(332, 256);
            this.pdes.Multiline = true;
            this.pdes.Name = "pdes";
            this.pdes.Size = new System.Drawing.Size(351, 125);
            this.pdes.TabIndex = 12;
            // 
            // pprice
            // 
            this.pprice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pprice.Location = new System.Drawing.Point(332, 400);
            this.pprice.Multiline = true;
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(227, 41);
            this.pprice.TabIndex = 11;
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(332, 193);
            this.pname.Multiline = true;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(252, 43);
            this.pname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(646, 606);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(91, 49);
            this.Updatebtn.TabIndex = 13;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(332, 133);
            this.pid.Multiline = true;
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(252, 43);
            this.pid.TabIndex = 15;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(94, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 29);
            this.label.TabIndex = 14;
            this.label.Text = "Product ID";
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.pdes);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label1);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox pdes;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label;
    }
}
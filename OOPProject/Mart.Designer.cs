namespace OOPProject
{
    partial class Mart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Qbox = new System.Windows.Forms.TextBox();
            this.Pprice = new System.Windows.Forms.TextBox();
            this.Pname = new System.Windows.Forms.TextBox();
            this.addtocart = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.sreachbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mart";
            // 
            // dataview
            // 
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeight = 34;
            this.dataview.ColumnHeadersVisible = false;
            this.dataview.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataview.GridColor = System.Drawing.Color.Black;
            this.dataview.Location = new System.Drawing.Point(139, 347);
            this.dataview.Name = "dataview";
            this.dataview.RowHeadersWidth = 62;
            this.dataview.RowTemplate.Height = 28;
            this.dataview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataview.Size = new System.Drawing.Size(455, 292);
            this.dataview.TabIndex = 1;
            this.dataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // Qbox
            // 
            this.Qbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qbox.Location = new System.Drawing.Point(610, 160);
            this.Qbox.Multiline = true;
            this.Qbox.Name = "Qbox";
            this.Qbox.Size = new System.Drawing.Size(100, 39);
            this.Qbox.TabIndex = 7;
            // 
            // Pprice
            // 
            this.Pprice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pprice.Location = new System.Drawing.Point(388, 160);
            this.Pprice.Multiline = true;
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(168, 39);
            this.Pprice.TabIndex = 8;
            // 
            // Pname
            // 
            this.Pname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.Location = new System.Drawing.Point(80, 160);
            this.Pname.Multiline = true;
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(268, 39);
            this.Pname.TabIndex = 9;
            // 
            // addtocart
            // 
            this.addtocart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocart.Location = new System.Drawing.Point(610, 216);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(113, 45);
            this.addtocart.TabIndex = 10;
            this.addtocart.Text = "Add Cart";
            this.addtocart.UseVisualStyleBackColor = true;
            this.addtocart.Click += new System.EventHandler(this.addtocart_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(80, 216);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(113, 45);
            this.Backbtn.TabIndex = 11;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // sreachbox
            // 
            this.sreachbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreachbox.Location = new System.Drawing.Point(284, 291);
            this.sreachbox.Multiline = true;
            this.sreachbox.Name = "sreachbox";
            this.sreachbox.Size = new System.Drawing.Size(229, 39);
            this.sreachbox.TabIndex = 12;
            this.sreachbox.TextChanged += new System.EventHandler(this.sreachbox_TextChanged);
            // 
            // Mart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 663);
            this.Controls.Add(this.sreachbox);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.Pprice);
            this.Controls.Add(this.Qbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.label1);
            this.Name = "Mart";
            this.Text = "Mart";
            this.Load += new System.EventHandler(this.Mart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Qbox;
        private System.Windows.Forms.TextBox Pprice;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox sreachbox;
    }
}
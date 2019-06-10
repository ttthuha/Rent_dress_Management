namespace GUI
{
    partial class Rent
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDressName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rentQuant = new System.Windows.Forms.NumericUpDown();
            this.GridViewOrderLine = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOkOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrderLine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEmpName.Location = new System.Drawing.Point(160, 85);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(188, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // txtCName
            // 
            this.txtCName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCName.Location = new System.Drawing.Point(455, 89);
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(187, 20);
            this.txtCName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dress Name";
            // 
            // cbxDressName
            // 
            this.cbxDressName.FormattingEnabled = true;
            this.cbxDressName.Location = new System.Drawing.Point(160, 155);
            this.cbxDressName.Name = "cbxDressName";
            this.cbxDressName.Size = new System.Drawing.Size(188, 21);
            this.cbxDressName.TabIndex = 8;
            this.cbxDressName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxDressName_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // rentQuant
            // 
            this.rentQuant.Location = new System.Drawing.Point(455, 155);
            this.rentQuant.Name = "rentQuant";
            this.rentQuant.Size = new System.Drawing.Size(187, 20);
            this.rentQuant.TabIndex = 10;
            // 
            // GridViewOrderLine
            // 
            this.GridViewOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOrderLine.Location = new System.Drawing.Point(17, 257);
            this.GridViewOrderLine.Name = "GridViewOrderLine";
            this.GridViewOrderLine.Size = new System.Drawing.Size(764, 244);
            this.GridViewOrderLine.TabIndex = 11;
            this.GridViewOrderLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewOrderLine_CellClick);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(273, 205);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 12;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(542, 205);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOkOrder
            // 
            this.btnOkOrder.Location = new System.Drawing.Point(419, 205);
            this.btnOkOrder.Name = "btnOkOrder";
            this.btnOkOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOkOrder.TabIndex = 16;
            this.btnOkOrder.Text = "OK";
            this.btnOkOrder.UseVisualStyleBackColor = true;
            this.btnOkOrder.Click += new System.EventHandler(this.btnOkOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "RENT DRESS";
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(787, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOkOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.GridViewOrderLine);
            this.Controls.Add(this.rentQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDressName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label1);
            this.Name = "Rent";
            this.Text = "Rent";
            ((System.ComponentModel.ISupportInitialize)(this.rentQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrderLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDressName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rentQuant;
        private System.Windows.Forms.DataGridView GridViewOrderLine;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOkOrder;
        private System.Windows.Forms.Label label5;
    }
}
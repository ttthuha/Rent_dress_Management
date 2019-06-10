namespace GUI
{
    partial class Payment
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
            this.GridViewPayment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOKPaymenr = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewPayment
            // 
            this.GridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPayment.Location = new System.Drawing.Point(12, 161);
            this.GridViewPayment.Name = "GridViewPayment";
            this.GridViewPayment.Size = new System.Drawing.Size(380, 190);
            this.GridViewPayment.TabIndex = 0;
            this.GridViewPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPayment_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAYMENT";
            // 
            // BtnOKPaymenr
            // 
            this.BtnOKPaymenr.Location = new System.Drawing.Point(303, 90);
            this.BtnOKPaymenr.Name = "BtnOKPaymenr";
            this.BtnOKPaymenr.Size = new System.Drawing.Size(75, 23);
            this.BtnOKPaymenr.TabIndex = 2;
            this.BtnOKPaymenr.Text = "OK";
            this.BtnOKPaymenr.UseVisualStyleBackColor = true;
            this.BtnOKPaymenr.Click += new System.EventHandler(this.BtnOKPaymenr_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(114, 67);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(123, 20);
            this.txtPayment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payment Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(114, 111);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(123, 20);
            this.txtChange.TabIndex = 6;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(404, 363);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.BtnOKPaymenr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewPayment);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOKPaymenr;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChange;
    }
}
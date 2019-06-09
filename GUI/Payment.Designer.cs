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
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewPayment
            // 
            this.GridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPayment.Location = new System.Drawing.Point(12, 55);
            this.GridViewPayment.Name = "GridViewPayment";
            this.GridViewPayment.Size = new System.Drawing.Size(331, 87);
            this.GridViewPayment.TabIndex = 0;
            this.GridViewPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPayment_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAYMENT";
            // 
            // BtnOKPaymenr
            // 
            this.BtnOKPaymenr.Location = new System.Drawing.Point(219, 12);
            this.BtnOKPaymenr.Name = "BtnOKPaymenr";
            this.BtnOKPaymenr.Size = new System.Drawing.Size(75, 23);
            this.BtnOKPaymenr.TabIndex = 2;
            this.BtnOKPaymenr.Text = "OK";
            this.BtnOKPaymenr.UseVisualStyleBackColor = true;
            this.BtnOKPaymenr.Click += new System.EventHandler(this.BtnOKPaymenr_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 148);
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
    }
}
namespace GUI
{
    partial class OrderHistory
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
            this.GridViewOrderHistory = new System.Windows.Forms.DataGridView();
            this.btnBackHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewOrderHistory
            // 
            this.GridViewOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOrderHistory.Location = new System.Drawing.Point(12, 69);
            this.GridViewOrderHistory.Name = "GridViewOrderHistory";
            this.GridViewOrderHistory.Size = new System.Drawing.Size(723, 371);
            this.GridViewOrderHistory.TabIndex = 0;
            this.GridViewOrderHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewOrderHistory_CellClick);
            // 
            // btnBackHistory
            // 
            this.btnBackHistory.Location = new System.Drawing.Point(23, 12);
            this.btnBackHistory.Name = "btnBackHistory";
            this.btnBackHistory.Size = new System.Drawing.Size(75, 31);
            this.btnBackHistory.TabIndex = 1;
            this.btnBackHistory.Text = "Back";
            this.btnBackHistory.UseVisualStyleBackColor = true;
            this.btnBackHistory.Click += new System.EventHandler(this.btnBackHistory_Click);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 452);
            this.Controls.Add(this.btnBackHistory);
            this.Controls.Add(this.GridViewOrderHistory);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewOrderHistory;
        private System.Windows.Forms.Button btnBackHistory;
    }
}
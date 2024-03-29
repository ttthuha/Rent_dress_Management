﻿namespace GUI
{
    partial class Main
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
            this.btnCusManage = new System.Windows.Forms.Button();
            this.btnStockManage = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCusManage
            // 
            this.btnCusManage.BackColor = System.Drawing.Color.Coral;
            this.btnCusManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCusManage.Location = new System.Drawing.Point(90, 86);
            this.btnCusManage.Name = "btnCusManage";
            this.btnCusManage.Size = new System.Drawing.Size(277, 46);
            this.btnCusManage.TabIndex = 0;
            this.btnCusManage.Text = "Customer Management";
            this.btnCusManage.UseVisualStyleBackColor = false;
            this.btnCusManage.Click += new System.EventHandler(this.btnCusManage_Click);
            // 
            // btnStockManage
            // 
            this.btnStockManage.BackColor = System.Drawing.Color.Coral;
            this.btnStockManage.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockManage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStockManage.Location = new System.Drawing.Point(90, 174);
            this.btnStockManage.Name = "btnStockManage";
            this.btnStockManage.Size = new System.Drawing.Size(277, 46);
            this.btnStockManage.TabIndex = 1;
            this.btnStockManage.Text = "Stock Management";
            this.btnStockManage.UseVisualStyleBackColor = false;
            this.btnStockManage.Click += new System.EventHandler(this.btnStockManage_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.BackColor = System.Drawing.Color.Coral;
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(90, 267);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(277, 46);
            this.btnEmployeeManagement.TabIndex = 3;
            this.btnEmployeeManagement.Text = "Employee Management";
            this.btnEmployeeManagement.UseVisualStyleBackColor = false;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "WEDDING DRESS MANAGEMENT";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(473, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.btnStockManage);
            this.Controls.Add(this.btnCusManage);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCusManage;
        private System.Windows.Forms.Button btnStockManage;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Label label1;
    }
}
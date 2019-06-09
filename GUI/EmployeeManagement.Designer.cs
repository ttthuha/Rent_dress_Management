namespace GUI
{
    partial class EmployeeManagement
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
            this.btnShowEmp = new System.Windows.Forms.Button();
            this.txtEPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbERole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtSearchEmp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.Location = new System.Drawing.Point(500, 58);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(107, 23);
            this.btnShowEmp.TabIndex = 69;
            this.btnShowEmp.Text = "Show all";
            this.btnShowEmp.UseVisualStyleBackColor = true;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // txtEPass
            // 
            this.txtEPass.Location = new System.Drawing.Point(124, 179);
            this.txtEPass.Name = "txtEPass";
            this.txtEPass.Size = new System.Drawing.Size(263, 20);
            this.txtEPass.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Password";
            // 
            // cbERole
            // 
            this.cbERole.FormattingEnabled = true;
            this.cbERole.Items.AddRange(new object[] {
            "employee",
            "admin"});
            this.cbERole.Location = new System.Drawing.Point(557, 137);
            this.cbERole.Margin = new System.Windows.Forms.Padding(2);
            this.cbERole.Name = "cbERole";
            this.cbERole.Size = new System.Drawing.Size(152, 21);
            this.cbERole.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Role";
            // 
            // cbEStatus
            // 
            this.cbEStatus.FormattingEnabled = true;
            this.cbEStatus.Items.AddRange(new object[] {
            "Work",
            "Quit"});
            this.cbEStatus.Location = new System.Drawing.Point(557, 174);
            this.cbEStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbEStatus.Name = "cbEStatus";
            this.cbEStatus.Size = new System.Drawing.Size(152, 21);
            this.cbEStatus.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "EMPLOYEE MANAGEMENT";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(500, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 23);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(339, 246);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(107, 23);
            this.btnUpdateEmp.TabIndex = 62;
            this.btnUpdateEmp.Text = "Update";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(171, 246);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(107, 23);
            this.btnAddEmp.TabIndex = 61;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Employee Name";
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(124, 142);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(263, 20);
            this.txtEName.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 236);
            this.dataGridView1.TabIndex = 64;
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(378, 58);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(85, 23);
            this.btnSearchEmp.TabIndex = 55;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // txtSearchEmp
            // 
            this.txtSearchEmp.Location = new System.Drawing.Point(150, 60);
            this.txtSearchEmp.Name = "txtSearchEmp";
            this.txtSearchEmp.Size = new System.Drawing.Size(191, 20);
            this.txtSearchEmp.TabIndex = 54;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnShowEmp);
            this.Controls.Add(this.txtEPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbERole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.txtSearchEmp);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowEmp;
        private System.Windows.Forms.TextBox txtEPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbERole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtSearchEmp;
    }
}
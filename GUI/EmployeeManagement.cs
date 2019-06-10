using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmployeeManagement : Form
    {
        Thread th;
        EmpBUS emp_BUS = new EmpBUS();

        public EmployeeManagement()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            txtEmpID.Text = "";
            txtEName.Text = "";
            txtEPass.Text = "";
            cbERole.Text = "";
            cbEStatus.Text = "";
        }


        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            DataTable tblCustomer = new DataTable();
            tblCustomer = emp_BUS.Display("Select * from Employee where EmployeeName like +'%" + txtSearchEmp.Text + "%'");
            dataGridView1.DataSource = tblCustomer;
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            EmployeeManagement_Load(sender, e);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (txtEName.Text != "" && txtEPass.Text != "" && cbERole.Text != "" && cbEStatus.Text != "")
            {
                EmpDTO emp_DTO = new EmpDTO() {EmployeeName = txtEName.Text, password=txtEPass.Text,Status=cbEStatus.Text, IsAdmin=cbERole.Text };
                if (emp_BUS.InsertEmp(emp_DTO))
                {
                    MessageBox.Show("Adding success");
                }
                else
                    MessageBox.Show("Adding fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }

            EmployeeManagement_Load(sender, e);
            ClearData();
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if ( txtEName.Text != "" && cbERole.Text != "" && cbEStatus.Text != "")
            {
                int EmployeeID = int.Parse(txtEmpID.Text);
                string EmployeeName = txtEName.Text;
                string Password = txtEPass.Text;
                string Status = cbEStatus.Text;
                string IsAdmin = cbERole.Text;

                //EmpDTO emp_DTO = new EmpDTO() { EmployeeName = txtEName.Text, password = txtEPass.Text, Status = cbEStatus.Text, Role = cbERole.Text };

                if (emp_BUS.UpdateEmp(EmployeeID, EmployeeName, Password, Status, IsAdmin))
                {
                    MessageBox.Show("Updated successfully");
                }
                else
                    MessageBox.Show("Updating fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }

            EmployeeManagement_Load(sender, e);
            ClearData();
        }
        private void openMainForm(object obj)
        {
            Application.Run(new Main());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            DataTable tblemp = new DataTable();
            tblemp = emp_BUS.Display("Select * from Employee ");
            dataGridView1.DataSource = tblemp;
            dataGridView1.AllowUserToAddRows = false;
            if (tblemp.Rows.Count == 0)
            {
                MessageBox.Show("Don't have any employees in the table!");
            }
            else
            {
                txtEmpID.Text = dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString();
                txtEName.Text = dataGridView1.CurrentRow.Cells["EmployeeName"].Value.ToString();
                txtEPass.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                cbEStatus.Text = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
                cbERole.Text = dataGridView1.CurrentRow.Cells["IsAdmin"].Value.ToString();
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpID.Text = dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString();
            txtEName.Text = dataGridView1.CurrentRow.Cells["EmployeeName"].Value.ToString();
            txtEPass.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            cbEStatus.Text = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
            cbERole.Text = dataGridView1.CurrentRow.Cells["IsAdmin"].Value.ToString();
        }
    }
}

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
    public partial class EmployeeMainForm : Form
    {
        Thread th;
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void openCusForm(object obj)
        {
            Application.Run(new CustomerManagement());
        }

        private void btnCusManage_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCusForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

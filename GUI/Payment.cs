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
   
    public partial class Payment : Form
    {
        Thread th;

        CustomerBUS Customer_BUS = new CustomerBUS();
        int CustomerID;
        public Payment(CustomerDTO customerDTO)
        {
            InitializeComponent();
            CustomerID = customerDTO.CustomerID;
            DisplayPayment();
        }

        private void DisplayPayment()
        {
            DataTable tblCustomer = new DataTable();
            tblCustomer = new CustomerBUS().Display(@"
SELECT        [Order].CustomerID AS[CUSTOMER ID], SUM(OrderLine.Sum) AS [TOTAL]
FROM            [Order] INNER JOIN
                         OrderLine ON [Order].OrderID = OrderLine.OrderID INNER JOIN
                         dress ON OrderLine.DressID = dress.DressID
WHERE        ( [Order].CustomerID = " + CustomerID + @")
GROUP BY [Order].CustomerID ");

            GridViewPayment.DataSource = tblCustomer;
            GridViewPayment.AllowUserToAddRows = false;

        }

        private void GridViewPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnOKPaymenr_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCusForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openCusForm(object obj)
        {

            Application.Run(new CustomerManagement());
        }
    }
}

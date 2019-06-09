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
    public partial class OrderHistory : Form
    {
        Thread th;
        CustomerBUS Customer_BUS = new CustomerBUS();

        public OrderHistory()
        {
            
            InitializeComponent();
            DisplayHistory();

        }

        private void DisplayHistory()
        {
            DataTable tblHistory = new DataTable();
            tblHistory = new CustomerBUS().Display(@"
SELECT        [Order].CustomerID AS [CUSTOMER ID],[Order].OrderID,[Order].EmployeeID, [Order].OrderDate as [OrderDate], dress.DressName AS [Dress Name], dress.DressDecription AS [Dress Decription], dress.Price, OrderLine.Quantity
                
FROM            [Order] INNER JOIN
                         OrderLine ON [Order].OrderID = OrderLine.OrderID INNER JOIN
                         dress ON OrderLine.DressID = dress.DressID
order BY  [Order].CustomerID ");

            GridViewOrderHistory.DataSource = tblHistory;
            GridViewOrderHistory.AllowUserToAddRows = false;
        }

            private void GridViewOrderHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBackHistory_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRentForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openRentForm(object obj)
        {

            Application.Run(new CustomerManagement());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Dapper;
namespace GUI
{
    public partial class Rent : Form
    {
        Thread th;

        OrderLineBUS OrderLine_BUS = new OrderLineBUS();
        CustomerBUS Customer_BUS = new CustomerBUS();
        EmpBUS Employee_BUS = new EmpBUS();
        int CustomerID;
        int EmployeeID;
        public Rent(CustomerDTO customerDTO)
        {

            InitializeComponent();
            txtCName.Text = customerDTO.CustomerName;
            txtEmpName.Text = Session.instance.Emp.EmployeeName;
            CustomerID = customerDTO.CustomerID;
            EmployeeID = Session.instance.Emp.EmployeeID;

            DisplayRent();
        }
        

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            int dressID = OrderLine_BUS.GetDressID(cbxDressName.Text);


            if (rentQuant.Value > OrderLine_BUS.GetStockQuant(dressID))
            {
                MessageBox.Show("Not enough dress");
            }
            else
            {
                DressDTO dressDTO = new DressDTO(dressID, cbxDressName.Text);
                OrderLine_BUS.ReduceStockQuant(dressID);
                var item = (DressDTO)cbxDressName.SelectedItem;
                var orderId = OrderLine_BUS.InsertOrder(CustomerID, EmployeeID, (int)rentQuant.Value, item.DressID, DateTime.Now);
                int rentQuantity = Convert.ToInt32(rentQuant.Value);
                OrderLine_BUS.InsertOrderLine(orderId, dressID, rentQuantity);

                DisplayRent();
            }
        }

        private void DisplayRent()
        {
            DataTable tblRent = new DataTable();
            tblRent = new CustomerBUS().Display(@"
SELECT        [Order].OrderID, dress.DressName AS [Dress Name], dress.DressDecription AS [Dress Decription], dress.Price, OrderLine.Quantity, OrderLine.Quantity * dress.Price AS [Sum],
                [Order].OrderDate AS [Order Date]
FROM            [Order] INNER JOIN
                         OrderLine ON [Order].OrderID = OrderLine.OrderID INNER JOIN
                         dress ON OrderLine.DressID = dress.DressID
WHERE        (OrderLine.Quantity > 0 AND [Order].CustomerID = " + CustomerID + @")");
            GridViewOrderLine.DataSource = tblRent;
            GridViewOrderLine.AllowUserToAddRows = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void cbxDressName_MouseClick(object sender, MouseEventArgs e)
        {
            cbxDressName.ValueMember = "DressID";
            cbxDressName.DisplayMember = "DressName";
            cbxDressName.Items.Clear();
            using (SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-96O2KIS\SQLEXPRESS;Initial Catalog=RentDressManagement;Integrated Security=True"))
            {
                connect.Open();
                var dressItems = connect.Query<DressDTO>("SELECT DressId, DressName FROM dress");
                foreach(var dress in dressItems)
                {
                    cbxDressName.Items.Add(dress);

                }
                    
                connect.Close();
            }
        }

        private void GridViewOrderLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOkOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openPaymentForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
       
        private void openPaymentForm(object obj)
        {
            CustomerDTO customer = new CustomerBUS().Get(CustomerID);
            var PaymentForm = new Payment(customer);
            Application.Run(PaymentForm);
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
           
        }
    }
}

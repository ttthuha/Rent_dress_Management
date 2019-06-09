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

namespace GUI
{
    public partial class Rent : Form
    {
        Thread th;

        OrderLineBUS OrderLine_BUS;

        public Rent()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int dressID = OrderLine_BUS.GetDressID(cbxDressName.Text);

            if (rentQuant.Value < OrderLine_BUS.GetStockQuant(dressID))
            {
                MessageBox.Show("Not enough dress");
            }
            else
            {
                DressDTO dressDTO = new DressDTO(dressID, cbxDressName.Text);
                OrderLine_BUS.ReduceStockQuant(dressID);
                int rentQuantity = Convert.ToInt32(rentQuant.Value);
                OrderLine_BUS.InsertOrderLine(dressID, rentQuantity);
            }
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
            using (SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-96O2KIS\SQLEXPRESS;Initial Catalog=RentDressManagement;Integrated Security=True"))
            {
                connect.Open();
                SqlCommand comd = new SqlCommand("SELECT DISTINCT DressName FROM dress", connect);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string DName = dr["DressName"].ToString();
                    if (!cbxDressName.Items.Contains(DName))
                        cbxDressName.Items.Add(DName);
                }
                connect.Close();
            }
        }
    }
}

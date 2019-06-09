using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DTO;
using BUS;

namespace GUI
{
    public partial class DressManagement : Form
    {
        Thread th;
        DressBUS dressBUS = new DressBUS();
        StockBUS stockBUS = new StockBUS();
        public DressManagement()
        {
            InitializeComponent();
        }

        private void openMainForm(object obj)
        {
            Application.Run(new Main());
        }
        private void ClearData()
        {
            txtDressID.Text = "";
            txtDressName.Text = "";
            txtPriceDress.Text = "";
            txtDressDesc.Text = "";

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DressDTO dressDTO = new DressDTO(txtDressName.Text, txtDressDesc.Text, int.Parse(txtPriceDress.Text));
            StockDTO stockDTO = new StockDTO(Convert.ToInt32(quantity.Value));
            dressBUS.InsertDress(dressDTO);
            stockBUS.Import(stockDTO);
            DressManagement_Load(sender, e);
            ClearData();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dressBUS.ShowAllDress();
            GridViewDress.DataSource = dt;
        }

        private void btnUpdateDress_Click(object sender, EventArgs e)
        {
            if (txtDressName.Text == "" || txtPriceDress.Text == "")
            {
                MessageBox.Show("Please enter value");
            }
            else
            {
                int DressID = Convert.ToInt32(txtDressID.Text);
                string DressName = txtDressName.Text;
                string DressDecription = txtDressDesc.Text;
                float DressPrice = (float)Convert.ToDouble(txtPriceDress.Text);

                if (dressBUS.UpdateDress(DressID, DressName, DressPrice, DressDecription))
                {
                    MessageBox.Show("Editing success");
                    DressManagement_Load(sender, e);
                    ClearData();
                }
                else
                    MessageBox.Show("Editing fail");
            }
            
        }

        private void DressManagement_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dressBUS.ShowAllDress();
            GridViewDress.DataSource = dt;
        }

        private void btnSearchDress_Click(object sender, EventArgs e)
        {
            DataTable tblDress = new DataTable();
            tblDress = dressBUS.Display("select dress.DressID, dress.DressName, dress.DressDecription, dress.Price, Stock.DressQuant from Stock join dress on Stock.DressID = dress.DressID where dress.DressName like +'%" + txtSearchDress.Text + "%'");
            GridViewDress.DataSource = tblDress;
        }

        private void GridViewDress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDressID.Text = GridViewDress.CurrentRow.Cells["DressID"].Value.ToString();
            txtDressName.Text = GridViewDress.CurrentRow.Cells["DressName"].Value.ToString();
            txtDressDesc.Text = GridViewDress.CurrentRow.Cells["DressDecription"].Value.ToString();
            txtPriceDress.Text = GridViewDress.CurrentRow.Cells["Price"].Value.ToString();
            string quant = GridViewDress.CurrentRow.Cells["DressQuant"].Value.ToString();
            quantity.Value = (int) Convert.ToInt32(quant);
        }
    }
}

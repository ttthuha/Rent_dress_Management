using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderLineDAL :DBconnection
    {

        public int GetStockQuant(int dressID)
        {
            int stockQuant;
            con.Open();
            string SQL = string.Format("Select DressQuant from Stock where DressID = '{0}'", dressID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            stockQuant = Convert.ToInt32(rd["DressQuant"].ToString());
            con.Close();
            return stockQuant;
        }

        public DataTable InsertOrderLine(int orderId, int DressID, int Quantity)
        {
            DataTable dtOrderLine = new DataTable();
            con.Open();
            con.Execute(@"Insert into OrderLine(
            [OrderID]
           ,[DressID]
           ,[Quantity]
           ,[Sum]) values (@OrderID, @DressID, @Quantity, @Sum )", new
            {
                OrderID = orderId,
                DressID = DressID,
                Quantity = Quantity,
                Sum = 0
            });
            con.Close();
            return dtOrderLine;

        }

        public int InsertOrder (int CustomerID,
                int EmployeeID, int Total, DateTime OrderDate)
        {
            con.Open();
            var orderid = con.QueryFirst<int>(@"
        Insert into [Order](CustomerID, EmployeeID, OrderDate, Total) Values (@CustomerID, @EmployeeID, @OrderDate, @Total);
        Select cast(scope_identity() as int)", new
            {
                CustomerID,
                EmployeeID,
                OrderDate,
                Total
            });
            con.Close();
            return orderid;
        }

        public int GetDressID(string dressName)
        {

            int dressID;
            con.Open();
            string SQL = string.Format("select DressID from dress where DressName = '{0}'", dressName);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            dressID = Convert.ToInt32(rd["DressID"].ToString());
            con.Close();
            return dressID;
        }

        public void ReduceStockQuant(int dressID)
        {
            con.Open();
            string SQL = string.Format("update Stock set DressQuant = DressQuant - 1 where DressID = '{0}'", dressID);
            SqlCommand cmd = new SqlCommand(SQL, con);
            int obj = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderLineBUS
    {
        OrderLineDAL dal = new OrderLineDAL();
        public int GetStockQuant(int dressID)
        {
            return dal.GetStockQuant(dressID);
        }

        public int GetDressID(string dressName)
        {
            return dal.GetDressID(dressName);
        }

        public void ReduceStockQuant(int dressID)
        {
            dal.ReduceStockQuant(dressID);
        }

        public DataTable InsertOrderLine(int dressID, int quant)
        {
            return dal.InsertOrderLine(dressID,quant);
        }
    }
}

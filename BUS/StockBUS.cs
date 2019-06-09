using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StockBUS
    {
        StockDAL stockDAL = new StockDAL();
        public DataTable Import(StockDTO stockDTO)
        {
            return stockDAL.Import(stockDTO);
        }
    }
}

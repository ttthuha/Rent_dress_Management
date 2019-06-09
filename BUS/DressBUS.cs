using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class DressBUS
    {
        DressDAL dal = new DressDAL();
        public DataTable InsertDress(DressDTO dress)
        {
            return dal.InsertDress(dress);
        }

        public bool UpdateDress(int DressID, string DressName, float DressPrice, string DressDecription)
        {
            return  dal.UpdateDress( DressID, DressName, DressPrice, DressDecription);
        }

        public DataTable ShowAllDress()
        {
            return dal.ShowAllDress();
        }
        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}


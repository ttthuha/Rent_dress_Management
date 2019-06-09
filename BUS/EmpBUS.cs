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
    public class EmpBUS
    {
        EmpDAL dal = new EmpDAL();
        public int CheckAccount(EmpDTO emp)
        {
            return dal.CheckAccount(emp);
        }
        public bool InsertEmp(EmpDTO emp)
        {
            return dal.InsertEmp(emp);
        }

        public bool UpdateEmp(int EmployeeID, string EmployeeName, string Password, string Status, string IsAdmin)
        {
            return dal.UpdateEmp(EmployeeID, EmployeeName, Password, Status, IsAdmin);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }

        public EmpDTO Get(int empID)
        {
            return dal.Get(empID);
        }
    }
}

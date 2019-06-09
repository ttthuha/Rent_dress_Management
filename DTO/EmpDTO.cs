using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmpDTO
    {

        public int EmployeeID { get; set; }
        public string password  { get; set; }
        public string EmployeeName { get; set; }
        public string IsAdmin { get; set; }
        public string Status { get; set; }


        public EmpDTO() { }

       
    }
}

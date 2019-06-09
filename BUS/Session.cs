using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Session
    {
        public static Session instance { get; set; } = new Session();

        public EmpDTO Emp { get; set; }
        


    }
}

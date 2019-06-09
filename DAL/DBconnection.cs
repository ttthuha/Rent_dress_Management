using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL
{
    public class DBconnection
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-96O2KIS\SQLEXPRESS;Initial Catalog=RentDressManagement;Integrated Security=True");
    }
}

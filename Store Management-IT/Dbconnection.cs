using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Store_Management_IT
{
     class Dbconnection
    {
        public  SqlConnection conn;
        public void  GetConnection()
        {
            conn =new SqlConnection( "Data Source=GHL_SRV-PC;Initial Catalog=Store Management-IT;User ID=sa;Password=Adminghl");
        }
    }
}

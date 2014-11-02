using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace log_in
{
    class DBHelper
    {
        public static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}

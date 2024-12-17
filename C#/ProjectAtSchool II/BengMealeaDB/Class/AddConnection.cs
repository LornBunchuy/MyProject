using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BengMealeaDB.Class
{
    internal class AddConnection
    {
        public static string GetConnection() => ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
    }
}

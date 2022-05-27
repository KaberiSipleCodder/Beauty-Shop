using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class ProductType
    {
       public string _ProductTypeName;

        public string ProductTypeName { get => _ProductTypeName; set => _ProductTypeName = value; }
    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class InsertProductDeatalisDate
    {
        private int productId;
        private string mFGDate;
        private string expDate;

        public int ProductId { get => productId; set => productId = value; }
        public string MFGDate { get => mFGDate; set => mFGDate = value; }
        public string ExpDate { get => expDate; set => expDate = value; }
    }
}

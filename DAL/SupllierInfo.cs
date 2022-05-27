using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class SupllierInfo
    {
        string _supplierName;
        string _supplierContactNumber;
        string _supplierEmail;
        string _Village;
        string _PostOffice;
        string _District;
        string _Pincode;

        public string SupplierName { get => _supplierName; set => _supplierName = value; }
        public string SupplierContactNumber { get => _supplierContactNumber; set => _supplierContactNumber = value; }
        public string SupplierEmail { get => _supplierEmail; set => _supplierEmail = value; }
        public string Village { get => _Village; set => _Village = value; }
        public string PostOffice { get => _PostOffice; set => _PostOffice = value; }
        public string District { get => _District; set => _District = value; }
        public string Pincode { get => _Pincode; set => _Pincode = value; }

        public bool InsertSupplierInfo()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            bool RowsEffected = false;
            
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertSupplierInfo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@supplierName", SupplierName);
                cmd.Parameters.AddWithValue("@supplierContactNumber", SupplierContactNumber);
                cmd.Parameters.AddWithValue("@supplierEmail", SupplierEmail);
                cmd.Parameters.AddWithValue("@Village",Village );
                cmd.Parameters.AddWithValue("@PostOffice", PostOffice);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@PinCode", Pincode);
                con.Open();
                RowsEffected = Convert.ToBoolean(cmd.ExecuteNonQuery());

                return RowsEffected;

            }
            catch (Exception ex)
            {
                return RowsEffected;
                 
        

            }
            finally
            {
                con.Close();
            }
        }   
    }
}

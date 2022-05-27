using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class SupplierInfoCheack
   {
        public string supplierName { get; set; }
        public string supplierConactNumber { get; set; }
        public string supplierEmail { get; set; }
        public string Village { get; set; }
        public string PostOffice { get; set; }
        public string District { get; set; }
        public string Pincode { get; set; }

        public bool SuppllierInsertCheack()
        {
            SupllierInfo supllierInfo = new SupllierInfo();
            supllierInfo.SupplierName = this.supplierName;
            supllierInfo.SupplierContactNumber = this.supplierConactNumber;
            supllierInfo.SupplierEmail = this.supplierEmail;
            supllierInfo.Village = this.Village;
            supllierInfo.PostOffice = this.PostOffice;
            supllierInfo.District = this.District;
            supllierInfo.Pincode = this.Pincode;
            return supllierInfo.InsertSupplierInfo();

        }

   }
}

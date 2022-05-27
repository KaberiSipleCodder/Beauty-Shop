using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InsertProductCheack
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductDescription { get; set; }
        public int SupplierId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductQuantity { get; set; }
        public float ProductPrice { get; set; }
        public float ProductDiscountPrice { get; set; }
        public float ProductTotalPrice { get; set; }
        

        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class InsertProduct
    {
        private string productName;
        private string productBrand;
        private string productDescription;
        private int supplierId;
        private int productTypeId;
        private int productQuantity;
        private float productPrice;
        private float productDiscountPrice;
        private float productTotalPrice;

        public string ProductName { get => productName; set => productName = value; }
        public string ProductBrand { get => productBrand; set => productBrand = value; }
        public string ProductDescription { get => productDescription; set => productDescription = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int ProductTypeId { get => productTypeId; set => productTypeId = value; }
        public int ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public float ProductPrice { get => productPrice; set => productPrice = value; }
        public float ProductDiscountPrice { get => productDiscountPrice; set => productDiscountPrice = value; }
        public float ProductTotalPrice { get => productTotalPrice; set => productTotalPrice = value; }
    }
}

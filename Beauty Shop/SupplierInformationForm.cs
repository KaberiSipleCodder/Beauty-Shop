using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Beauty_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          bool insertInfo=  InsertSupllier();
            if (insertInfo)
            {
                MessageBox.Show("Succesfully insert");
            }
            else
            {
                MessageBox.Show("Not Succesful");
            }
        }
        public bool InsertSupllier()
        {
             SupplierInfoCheack supplierInfoCheack  = new SupplierInfoCheack  ();
            supplierInfoCheack.supplierName=txtsupplierName.Text;
            supplierInfoCheack.supplierConactNumber=txtsupplierContactName.Text;
            supplierInfoCheack.supplierEmail=txtsupplierEmail.Text;
            supplierInfoCheack.Village=txtVillage.Text;
            supplierInfoCheack.PostOffice = txtPostOffice.Text;
            supplierInfoCheack.District = txtDistrict.Text;
            supplierInfoCheack.Pincode = txtPincode.Text;
            return supplierInfoCheack.SuppllierInsertCheack();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblsupplierEmailId_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FreeComplaints.BAL
{
    public class productbal
    {
        DAL.productdal objuserdal = new DAL.productdal();
        private string Product_name;
        private string Product_address;
        private int Product_id;
       
        
        public int productid
        {
            get
            {
                return Product_id;
            }
            set
            {
                Product_id = value;
            }
        }
        public string productname
        {
            get
            {
                return Product_name;
            }
            set
            {
                Product_name = value;
            }
        }
       
        public string productaddress
        {
            get
            {
                return Product_address;
            }
            set
            {
                Product_address = value;
            }
        }
        public int productinsert()
        {
            return objuserdal.PRODUCTnsert(this);
        }
        public DataTable viewproduct()
        {
            return objuserdal.viewProduct();
        }
        public int updateproduct()
        {
            return objuserdal.productupdate(this);
        }
        public int Deleteproduct()
        {
            return objuserdal.productdelete(this);
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FreeComplaints.BAL
{
    public class complaintbal
    {
        DAL.complaintdal objcomplaintdal = new DAL.complaintdal();
        private int Product_id;
        private int User_id;
        private string Complaint;
        private string C_status;
        private int _complaintid;
        public int ComplaintId
        {
            get
            {
                return _complaintid;
            }
            set
            {
                _complaintid = value;
            }
        }
        public int user_id
        {
            get
            {
                return User_id;
            }
            set
            {
                User_id = value;
            }
        }
        public string complaint
        {
            get
            {
                return Complaint;
            }
            set
            {
                Complaint = value;
            }
        }
        public string cstatus
        {
            get
            {
                return C_status;
            }
            set
            {
                C_status = value;
            }
        }
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
        public DataTable ProductValues()
        {
            return objcomplaintdal.Product_list();

        }
        public int complaint_reg()
        {
            return objcomplaintdal.complaintReg(this);
        }
        public DataTable viewcomplaint()
        {
            return objcomplaintdal.complaintview(this);
        }
        public int changecmpltstatus()
        {
            return objcomplaintdal.Changecmpltstatus(this);
        }

        public DataTable viewcomplaintstatus()
        {
            return objcomplaintdal.Viewcomplaintstatus(this);
        }
    }
}
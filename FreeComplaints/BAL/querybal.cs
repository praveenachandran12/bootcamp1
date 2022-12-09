using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FreeComplaints.BAL
{
    public class querybal
    {
        DAL.querydal objcomplaintdal = new DAL.querydal();
        private int Product_id;
        private int User_id;
        private int Query_id;
        private string Query;
        private string Reply;
        public string reply
        {
            get
            {
                return Reply;
            }
            set
            {
                Reply = value;
            }
        }
        public string query
        {
            get
            {
                return Query;
            }
            set
            {
                Query = value;
            }
        }
        public int query_id
        {
            get
            {
                return Query_id;
            }
            set
            {
                Query_id = value;
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
        public int add_query()
        {
            return objcomplaintdal.addquery(this);
        }
        public DataTable viewquery()
        {
            return objcomplaintdal.queryview(this);
        }
    }
    
}
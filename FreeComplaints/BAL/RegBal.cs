using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FreeComplaints.BAL
{
    public class RegBal
    {
        DAL.userRegistrationDal objuserdal = new DAL.userRegistrationDal();
        private string User_name;
        private string User_address;
        private string User_phone;
        private string User_email;
        private string Username;
        private string Password;
        private object Login_id;
        private int User_id;
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
        public string UserName
        {
            get
            {
                return User_name;
            }
            set
            {
                User_name = value;
            }
        }
        public string Useraddress
        {
            get
            {
                return User_address;
            }
            set
            {
                User_address = value;
            }
        }
        public string Userphone
        {
            get
            {
                return User_phone;
            }
            set
            {
                User_phone = value;
            }
        }
        public string useremail
        {
            get
            {
                return User_email;
            }
            set
            {
                User_email = value;
            }
        }
        public string Username1
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }
        public string Password1
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public object Loginid
        {
            get
            {
                return Login_id;
            }
            set
            {
                Login_id = value;
            }
        }

        public DataTable LoginCheck()
        {
            return objuserdal.logincheck(this);
        }

        public int userdepartment()
        {
            return objuserdal.USERInsert(this);
        }
        public object user_login_insert()
        {
            return objuserdal.userlogin(this);
        }
        public object UserLogin()
        {
            return objuserdal.User_login(this);
        }
        public DataTable viewusers()
        {
            return objuserdal.viewUSER();
        }
        public int Confirmuser()
        {
            return objuserdal.userconfirm(this);
        }
        //public DataTable view_users()
        //{
        //   // return objuserdal.view_USER();
        //}
    }
}
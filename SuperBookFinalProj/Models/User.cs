using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBookFinalProj.Models
{
    abstract class User
    {
        private string fullName;
        private string userName;
        private string password;

        public User(string fullName, string userName, string password)
        {
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
        }
        public abstract bool validateLogin(string userName, string password);
        public abstract string getFullName();
    }

    class Admin : User
    {
        private string department;

        public Admin(string fullName, string deparment, string userName, string password) : base(fullName, userName, password) 
        {
            department = "Admin";
        }
        public override bool validateLogin(string userName, string password)
        {
            if (userName == "admin" && password == "superbook") return true;
            return false;
        }
        public override string getFullName()
        {
            return this.getFullName();
        }
    }

}

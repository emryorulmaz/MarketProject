using MyProject.enumaration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.model
{
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string authority { get; set; }
        public string emailAdress { get; set; }
        public string securityQuestion { get; set; }
        public string securityAnswer { get; set; }
        public LoginStatus status { get; set; }


    }
}

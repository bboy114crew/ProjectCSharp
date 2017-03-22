using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop.Model
{
    class Accounts
    {
        public string username { get; set; }
        public string password { get; set; }
        public int customerID { get; set; }
        public Accounts(string username,string pass,int cid)
        {
            this.username = username;
            this.password = pass;
            this.customerID = cid;
        }
    }
}

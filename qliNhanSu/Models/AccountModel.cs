using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entity;

namespace Models
{
    public class AccountModel
    {
        private QLNS context = null;
        public AccountModel()
        {
            context = new QLNS();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams = 
            {
                new SqlParameter("@Nameaccount",userName),
                new SqlParameter("@Password",password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @Nameaccount,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}

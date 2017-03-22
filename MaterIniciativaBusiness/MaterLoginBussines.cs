using MaterIniciativaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaData;

namespace MaterIniciativaBusiness
{
    public class MaterLoginBussines : BaseBusiness
    {
        public User ValidateLogin(User user)
        {
            var data  =  new UserData();
            User userdb = data.Get(user.UserName);
            if (userdb != null && user.Password == userdb.Password)
            {
                return userdb;
            }
            return null;
        }
        
    }
}

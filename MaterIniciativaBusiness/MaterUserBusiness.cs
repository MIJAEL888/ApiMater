using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaData;
using MaterIniciativaEntity;

namespace MaterIniciativaBusiness
{
    public class MaterUserBusiness : BaseBusiness
    {
        public User Save(User user)
        {
            var data = new UserData();
            if (data.Get(user.UserName) != null)
            {
                throw new Exception("El nombre de usuario ya existe.");
            }
            if (string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.UserName))
            {
                throw new Exception("El nombre de usuario y la contraseña no puede ser vacio.");
            }
           
            user.IdUser = data.Save(user);
            return user;
        }

        public User Get(string userName)
        {
            var data = new UserData();
            return data.Get(userName);
        }
    }
}

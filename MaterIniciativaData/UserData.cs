using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaEntity;

namespace MaterIniciativaData
{
    public class UserData
    {
        public User Get(string userName)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                User user = null;
                var tmp = dc.UserGet(userName).FirstOrDefault();
                if (tmp != null)
                {
                    user = new User()
                    {
                        IdUser = tmp.IdUser,
                        UserName = tmp.UserName,
                        Password = tmp.Password,
                        Email = tmp.Email,
                        Active = tmp.Active,
                        AppMenber = tmp.AppMember,
                        Name = tmp.Name,
                        SurName = tmp.SurName
                    };
                }
                return user;
            }
        }

        public int Save(User user)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                int? insertedId = 0;
                dc.UserUpdate(user.IdUser, user.UserName, user.Password, user.Email, user.Active,
                    user.AppMenber, user.Name, user.UserName, ref insertedId);
                return insertedId.GetValueOrDefault();
            }
        }
    }
}


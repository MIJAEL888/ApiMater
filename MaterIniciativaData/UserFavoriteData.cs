using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaEntity;

namespace MaterIniciativaData
{
    public class UserFavoriteData
    {
      
        public void Save(UserFavorite userFavorite)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                dc.UserFavoriteUpdate(userFavorite.IdUser, userFavorite.IdPlant);
            }
        }
    }
}

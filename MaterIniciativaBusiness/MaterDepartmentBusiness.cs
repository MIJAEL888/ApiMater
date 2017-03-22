using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaData;
using MaterIniciativaEntity;

namespace MaterIniciativaBusiness
{
    public class MaterDepartmentBusiness : BaseBusiness
    {
        public List<Department> ListAll()
        {
            var data = new DepartmentData();
            return data.List();
        }

        public List<Department> List(int idPlant)
        {
            var data = new DepartmentData();
            return data.List(idPlant);
        }
    }
}

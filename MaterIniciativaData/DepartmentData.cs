using MaterIniciativaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterIniciativaData
{
    public class DepartmentData
    {
        public List<Department> List()
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Department> departments = new List<Department>();
                var list = dc.DepartmentList();
                foreach (var tmp in list)
                {
                    var department = new Department()
                    {
                        IdDetapartment = tmp.IdDepartment,
                        Name = tmp.Name,
                        Description = tmp.Description,
                        Image = (tmp.Image == null) ? null : tmp.Image.ToArray(),
                        ImagePath = tmp.IimagePath
                    };
                    departments.Add(department);
                }
                return departments;
            }
        }

        public List<Department> List(int idPlant)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Department> departments = new List<Department>();
                var list = dc.DepartmentPlantList(idPlant);
                foreach (var tmp in list)
                {
                    var department = new Department()
                    {
                        IdDetapartment = tmp.IdDepartment,
                        Name = tmp.Name,
                        Description = tmp.Description,
                        Image = (tmp.Image == null) ? null : tmp.Image.ToArray(),
                        ImagePath = tmp.IimagePath
                    };
                    departments.Add(department);
                }
                return departments;
            }
        }
        public Department Get(int idDepartment)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                Department department = null;
                var tmp = dc.DepartmentGet(idDepartment).FirstOrDefault();
                if (tmp != null)
                {
                    department = new Department()
                    {
                        IdDetapartment = tmp.IdDepartment,
                        Name = tmp.Name,
                        Description = tmp.Description,
                        Image = (tmp.Image == null) ? null : tmp.Image.ToArray(),
                        ImagePath = tmp.IimagePath
                    };
                }
                return department;
            }
        }

        public void Save(int idDepartment, int idPlant)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                dc.PlantDepartmentUpdate(idDepartment, idPlant);
            }
        }
    }
}

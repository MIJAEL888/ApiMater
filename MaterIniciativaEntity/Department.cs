using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterIniciativaEntity
{
    public class Department
    {
        public int IdDetapartment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string ImagePath { get; set; }

        public List<Plant> Plants { get; set; }
    }
}

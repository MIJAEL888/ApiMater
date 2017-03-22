using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaterIniciativa.Areas.MaterIniciativa.Models
{
    public class OutDepartmentModel
    {
        public int IdDetapartment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string ImagePath { get; set; }
    }
}
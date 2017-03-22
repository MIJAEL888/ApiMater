using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaterIniciativa.Areas.MaterIniciativa.Models
{
    public class OutLoginModel
    {
        public bool status { get; set; }
        public OutUserModel User { get; set; }
    }
}
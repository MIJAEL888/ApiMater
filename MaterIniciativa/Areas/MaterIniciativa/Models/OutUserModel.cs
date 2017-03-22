using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaterIniciativa.Areas.MaterIniciativa.Models
{
    public class OutUserModel
    {
        public int IdUser { get; set; }
        public int IdPerson { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Active { get; set; }
        public int AppMenber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
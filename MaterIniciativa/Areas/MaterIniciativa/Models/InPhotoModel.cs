using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaterIniciativa.Areas.MaterIniciativa.Models
{
    public class InPhotoModel
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Path { get; set; }
    }
}
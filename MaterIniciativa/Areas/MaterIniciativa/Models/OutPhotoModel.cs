using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaterIniciativa.Areas.MaterIniciativa.Models
{
    public class OutPhotoModel
    {
        public int IdPhoto { get; set; }
        public int IdPlant { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Path { get; set; }
    }
}
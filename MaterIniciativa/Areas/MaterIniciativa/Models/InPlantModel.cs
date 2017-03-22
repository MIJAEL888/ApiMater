using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MaterIniciativa.Areas.MaterIniciativa.Models
{
    public class InPlantModel
    {
        public int IdUser { get; set; }
        public int Status { get; set; }
        public int CountSearch { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Family { get; set; }
        public string Characteristics { get; set; }
        public string Distributions { get; set; }
        public string Uses { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UptoDate { get; set; }
        public string Type { get; set; }
        public string Morphology { get; set; }
        public string Color { get; set; }

        public List<InPhotoModel> Photos { get; set; }
        public List<InDepartmentModel> Departments { get; set; }
        public List<InEcoRegionModel> EcoRegions { get; set; }
    }
}
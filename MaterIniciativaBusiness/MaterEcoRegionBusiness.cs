using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaData;
using MaterIniciativaEntity;

namespace MaterIniciativaBusiness
{
    public class MaterEcoRegionBusiness : BaseBusiness
    {
        public List<EcoRegion> ListAll()
        {
            var data = new EcoregionData();
            return data.List();
        }

        public List<EcoRegion> List(int idPlant)
        {
            var data = new EcoregionData();
            return data.List(idPlant);
        }
    }
}

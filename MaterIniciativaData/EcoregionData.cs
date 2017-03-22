using MaterIniciativaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterIniciativaData
{
    public class EcoregionData
    {
        public List<EcoRegion> List()
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<EcoRegion> ecoRegions = new List<EcoRegion>();
                var list = dc.EcoregionList();
                foreach (var tmp in list)
                {
                    var ecoregion = new EcoRegion();

                    ecoregion.IdEcoRegion = tmp.IdEcoregion;
                    ecoregion.Name = tmp.Name;
                    ecoregion.Description = tmp.Description;
                    ecoregion.Image = (tmp.Image  == null) ? null :tmp.Image.ToArray();
                    ecoregion.ImagePath = tmp.ImagePath;
                    
                    ecoRegions.Add(ecoregion);
                }
                return ecoRegions;
            }
        }
        public List<EcoRegion> List(int idPlant)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<EcoRegion> ecoRegions = new List<EcoRegion>();
                var list = dc.EcoRegionPlantList(idPlant);
                foreach (var tmp in list)
                {
                    var ecoregion = new EcoRegion()
                    {
                        IdEcoRegion = tmp.IdEcoregion,
                        Name = tmp.Name,
                        Description = tmp.Description,
                        Image = (tmp.Image == null) ? null : tmp.Image.ToArray(),
                        ImagePath = tmp.ImagePath
                    };
                    ecoRegions.Add(ecoregion);
                }
                return ecoRegions;
            }
        }
        public EcoRegion Get(int idEcoRegion)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                EcoRegion ecoregion = null;
                var tmp = dc.EcoregionGet(idEcoRegion).FirstOrDefault();
                if (tmp != null)
                {
                    ecoregion = new EcoRegion()
                    {
                        IdEcoRegion = tmp.IdEcoregion,
                        Name = tmp.Name,
                        Description = tmp.Description,
                        Image = (tmp.Image == null) ? null : tmp.Image.ToArray(),
                        ImagePath = tmp.ImagePath
                    };
                }
                return ecoregion;
            }
        }

        public void Save(int idEcoRegion, int idPlant)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                dc.PlantEcoRegionUpdate(idEcoRegion, idPlant);
            }
        }
    }
}

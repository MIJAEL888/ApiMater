using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaEntity;

namespace MaterIniciativaData
{
    public class PlantData
    {
        public Plant Get(int? idPlant, string commonName)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                Plant plant = null;
                var tmp = dc.PlantGet(idPlant, commonName).FirstOrDefault();
                if (tmp != null)
                {
                    plant = new Plant()
                    {
                        IdPlant = tmp.IdPlant,
                        IdUser = tmp.IdUser,
                        Status = tmp.Status.GetValueOrDefault(),
                        CountSearch = tmp.CountSearchs.GetValueOrDefault(),
                        CommonName = tmp.CommonName,
                        ScientificName = tmp.ScientificName,
                        Family = tmp.Family,
                        Characteristics = tmp.Characteristics,
                        Distributions = tmp.Distributions,
                        Uses = tmp.Uses,
                        CreationDate = tmp.CreationDate.GetValueOrDefault(),
                        UptoDate = tmp.UptoDate.GetValueOrDefault(),
                        Type = tmp.Type,
                        Morphology = tmp.Morphology,
                        Color = tmp.Color
                    };
                }
                return plant;
            }
        }

       public List<Plant> ListFavorite(int idUser)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Plant> userFavorites = new List<Plant>();
                var list = dc.UserFavoriteList(idUser);
                foreach (var tmp in list)
                {
                    userFavorites.Add(new Plant()
                    {
                        IdPlant = tmp.IdPlant,
                        IdUser = tmp.IdUser,
                        Status = tmp.Status.GetValueOrDefault(),
                        CountSearch = tmp.CountSearchs.GetValueOrDefault(),
                        CommonName = tmp.CommonName,
                        ScientificName = tmp.ScientificName,
                        Family = tmp.Family,
                        Characteristics = tmp.Characteristics,
                        Distributions = tmp.Distributions,
                        Uses = tmp.Uses,
                        CreationDate = tmp.CreationDate.GetValueOrDefault(),
                        UptoDate = tmp.UptoDate.GetValueOrDefault(),
                        Type = tmp.Type,
                        Morphology = tmp.Morphology,
                        Color = tmp.Color
                    });
                }
                return userFavorites;
            }
        }
        public List<Plant> ListByUser(int idUser)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Plant> plants = new List<Plant>();
                var list = dc.PlantUserList(idUser);
                foreach (var tmp in list)
                {
                    plants.Add(new Plant()
                    {
                        IdPlant = tmp.IdPlant,
                        IdUser = tmp.IdUser,
                        Status = tmp.Status.GetValueOrDefault(),
                        CountSearch = tmp.CountSearchs.GetValueOrDefault(),
                        CommonName = tmp.CommonName,
                        ScientificName = tmp.ScientificName,
                        Family = tmp.Family,
                        Characteristics = tmp.Characteristics,
                        Distributions = tmp.Distributions,
                        Uses = tmp.Uses,
                        CreationDate = tmp.CreationDate.GetValueOrDefault(),
                        UptoDate = tmp.UptoDate.GetValueOrDefault(),
                        Type = tmp.Type,
                        Morphology = tmp.Morphology,
                        Color = tmp.Color
                    });
                }
                return plants;
            }
        }

        public List<Plant> ListByDepartment(int idDepartment)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Plant> plants = new List<Plant>();
                var list = dc.PlantDepartmentList(idDepartment);
                foreach (var tmp in list)
                {
                    plants.Add(new Plant()
                    {
                        IdPlant = tmp.IdPlant,
                        IdUser = tmp.IdUser,
                        Status = tmp.Status.GetValueOrDefault(),
                        CountSearch = tmp.CountSearchs.GetValueOrDefault(),
                        CommonName = tmp.CommonName,
                        ScientificName = tmp.ScientificName,
                        Family = tmp.Family,
                        Characteristics = tmp.Characteristics,
                        Distributions = tmp.Distributions,
                        Uses = tmp.Uses,
                        CreationDate = tmp.CreationDate.GetValueOrDefault(),
                        UptoDate = tmp.UptoDate.GetValueOrDefault(),
                        Type = tmp.Type,
                        Morphology = tmp.Morphology,
                        Color = tmp.Color
                    });
                }
                return plants;
            }
        }

        public List<Plant> ListByEcoRegion(int idEcoRegion)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                List<Plant> plants = new List<Plant>();
                var list = dc.PlantEcoRegionList(idEcoRegion);
                foreach (var tmp in list)
                {
                    plants.Add(new Plant()
                    {
                        IdPlant = tmp.IdPlant,
                        IdUser = tmp.IdUser,
                        Status = tmp.Status.GetValueOrDefault(),
                        CountSearch = tmp.CountSearchs.GetValueOrDefault(),
                        CommonName = tmp.CommonName,
                        ScientificName = tmp.ScientificName,
                        Family = tmp.Family,
                        Characteristics = tmp.Characteristics,
                        Distributions = tmp.Distributions,
                        Uses = tmp.Uses,
                        CreationDate = tmp.CreationDate.GetValueOrDefault(),
                        UptoDate = tmp.UptoDate.GetValueOrDefault(),
                        Type = tmp.Type,
                        Morphology = tmp.Morphology,
                        Color = tmp.Color
                    });
                }
                return plants;
            }
        }
        public int Save(Plant plant)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                int? insertedId = 0;
                dc.PlantUpdate(plant.IdPlant, plant.IdUser, plant.Status, plant.CountSearch, plant.CommonName, 
                    plant.ScientificName, plant.Family, plant.Characteristics, plant.Distributions, plant.Uses, 
                    plant.CreationDate, plant.UptoDate, plant.Type, plant.Morphology, plant.Color, ref insertedId);
                return insertedId.GetValueOrDefault();
            }
        }

        public void SavePlantDepartment(int idPlant, int idDepartment)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
               dc.PlantDepartmentUpdate(idDepartment, idPlant);
               
            }
        }

        public void SavePlantEcoRegion(int idPlant, int idEcoRegion)
        {
            using (DataMaterDataContext dc = new DataMaterDataContext())
            {
                dc.PlantEcoRegionUpdate(idEcoRegion, idPlant);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterIniciativaData;
using MaterIniciativaEntity;

namespace MaterIniciativaBusiness
{
    public class MaterPlantBusiness : BaseBusiness
    {
        public Plant Save(Plant plant)
        {
            var data = new PlantData();
            if (data.Get(null, plant.CommonName) != null)
            {
                throw new Exception("El nombre comun del insumo ya existe.");
            }

            plant.IdPlant = data.Save(plant);

            foreach (var plantEcoRegion in plant.EcoRegions)
            {
                data.SavePlantEcoRegion(plant.IdPlant, plantEcoRegion.IdEcoRegion);
            }

            foreach (var plantDepartment in plant.Departments)
            {
                data.SavePlantDepartment(plant.IdPlant, plantDepartment.IdDetapartment);
            }

            var dataPhoto = new PhotoData();
            foreach (var photo in plant.Photos)
            {
                photo.IdPlant = plant.IdPlant;
                dataPhoto.Save(photo);
            }

            return plant;
        }

        public Plant Get(int idPlant)
        {
            var data = new PlantData();
            var dataPhoto = new PhotoData();
            var dataDepartment = new DepartmentData();
            var dataEcoRegion = new EcoregionData();

            Plant plant = data.Get(idPlant, null);
            if (plant != null)
            {
                plant.Departments = dataDepartment.List(plant.IdPlant);
                plant.EcoRegions = dataEcoRegion.List(plant.IdPlant);
                plant.Photos = dataPhoto.List(plant.IdPlant);
            }
            // Convertir el Array bytes en archivo y guardar en una carpeta o repositorio

            return plant;
        }

        public List<Plant> ListByUser(int idUser)
        {
            var data = new PlantData();
            var dataPhoto = new PhotoData();
            var dataDepartment = new DepartmentData();
            var dataEcoRegion = new EcoregionData();

            List<Plant> plants = data.ListByUser(idUser);
            foreach (var plant in plants)
            {
                if (plant != null)
                {
                    plant.Departments = dataDepartment.List(plant.IdPlant);
                    plant.EcoRegions = dataEcoRegion.List(plant.IdPlant);
                    plant.Photos = dataPhoto.List(plant.IdPlant);
                }
            }
            return plants;
        }
    }
}

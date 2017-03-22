using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MaterIniciativa.Areas.MaterIniciativa.Models;
using MaterIniciativaBusiness;
using MaterIniciativaEntity;

namespace MaterIniciativa.Areas.MaterIniciativa.Controllers
{
    public class MaterPlantController : ApiController
    {
        private readonly MaterPlantBusiness _materPlantBusiness = new MaterPlantBusiness();
        /// <summary>
        /// Envia una nueva planta para ser registrada. 
        /// </summary>
        /// <param name="model">Datos de la planta relacionado </param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Plant")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]InPlantModel model)
        {
            try
            {
                var entidad = Mapper.Map<Plant>(model);
                _materPlantBusiness.Save(entidad);
                return Json("ok");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retorna las planta segun su clave unica
        /// </summary>
        /// <param name="IdPlant">El codigo de la planta</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Plant/{IdPlant}")]
        public IHttpActionResult Get(int IdPlant)
        {
            try
            {
                Dictionary<string, Object> plant = new Dictionary<string, Object>();
                plant.Add("Plant", Mapper.Map<OutPlantModel>(_materPlantBusiness.Get(IdPlant)));
                return Json(plant);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retorna las planta segun su clave unica
        /// </summary>
        /// <param name="IdPlant">El codigo de la planta</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Plant/User/{IdUser}")]
        public IHttpActionResult GetByUser(int IdUser)
        {
            try
            {
                Dictionary<string, Object> plants = new Dictionary<string, Object>();
                plants.Add("Plants", Mapper.Map<List<Plant>, List<OutPlantModel>>(_materPlantBusiness.ListByUser(IdUser)));
                return Json(plants);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retorna las planta segun su clave unica
        /// </summary>
        /// <param name="IdPlant">El codigo de la planta</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Plant")]
        public IHttpActionResult Get()
        {
            try
            {
                return Json("");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retorna las planta que estan dentro de un determinado Departamento
        /// </summary>
        /// <param name="IdDepartment">El codigo del departamento</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Plant/Department/{IdDepartment}")]
        public IHttpActionResult GetByDepartment(int IdDepartment)
        {
            try
            {
                return Json("Under construction");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Retorna las planta que estan dentro de un determinado Departamento
        /// </summary>
        /// <param name="IdDepartment">El codigo del departamento</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Plant/EcoRegion/{IdEcoregion}")]
        public IHttpActionResult GetByEcoRegion(int IdEcoregion)
        {
            try
            {
                return Json("Hello");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

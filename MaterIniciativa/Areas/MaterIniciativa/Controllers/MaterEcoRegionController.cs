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
    public class MaterEcoRegionController : ApiController
    {
        private readonly MaterEcoRegionBusiness _materEcoRegionBusiness = new MaterEcoRegionBusiness();
        /// <summary>
        /// Retorna list de las ecoregiones
        /// </summary>
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/EcoRegion")]
        public IHttpActionResult Get()
        {
            try
            {
                Dictionary<string, Object> listEcoRegion = new Dictionary<string, Object>();
                List<OutEcoRegionModel> list = Mapper.Map<List<EcoRegion>, List<OutEcoRegionModel>>(_materEcoRegionBusiness.ListAll());
                listEcoRegion.Add("EcoRegions", list );
                return Json(listEcoRegion);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

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
    public class MaterDepartmentController : ApiController
    {
        private readonly MaterDepartmentBusiness _departmentBusiness = new MaterDepartmentBusiness();
        /// <summary>
        /// Retorna lista de los departamentos
        /// </summary>      
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        [Route("Mater/Department")]
        public IHttpActionResult Get()
        {
            try
            {
                Dictionary<string, Object> listDepartments = new Dictionary<string, Object>();
                List<OutDepartmentModel> list = Mapper.Map<List<Department>, List<OutDepartmentModel>>(_departmentBusiness.ListAll());
                listDepartments.Add("Departments", list);
                return Json(listDepartments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

using AutoMapper;
using MaterIniciativa.Areas.MaterIniciativa.Models;
using MaterIniciativaBusiness;
using System;
using System.Web.Http;
using MaterIniciativaEntity;

namespace MaterIniciativa.Areas.MaterIniciativa.Controllers
{
    public class MaterLoginController : ApiController
    {
        private readonly MaterLoginBussines _loginMaterBussines = new MaterLoginBussines();

        /// <summary>
        /// Método para validar el login de un usuario
        /// </summary>
        /// <param name="model">LoginInModel</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        /// <remarks> remark </remarks>
        /// <example>  </example>
        [Route("Mater/Login")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]InLoginModel model)
        {
            try
            {
                OutLoginModel outLoginModel = new OutLoginModel();
                var entidad = Mapper.Map<User>(model);
                var user = _loginMaterBussines.ValidateLogin(entidad);
                if (user == null)
                {
                    outLoginModel.status = false;
                }
                else
                {
                    outLoginModel.status = true;
                    outLoginModel.User = Mapper.Map<OutUserModel>(user);
                } 

                return Json(outLoginModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Método de prueba
        /// </summary>
        /// <param name="username">El nombre del usuario que se desea consultar</param>        
        /// <returns>HTTP 200 : Ok(JSON) | HTTP 400 : BadRequest(ERROR)</returns>
        /// <remarks> remark </remarks>
        /// <example > codigoISO=PE tipoIdentificacion=01 numeroDocumento=25667911 </example>
        [Route("Mater/Login/")]
        public IHttpActionResult Get()
        {
            try
            {
                return Json("Hello Mijael ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

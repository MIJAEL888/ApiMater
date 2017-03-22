using System.Web.Mvc;

namespace MaterIniciativa.Areas.MaterIniciativa
{
    public class MaterIniciativaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MaterIniciativa";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MaterIniciativa_default",
                "MaterIniciativa/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
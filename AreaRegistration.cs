using System.Web.Mvc;

namespace SoftSupply.Help.Areas.Reseller
{
    public class ResellerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Reseller";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                AreaName,
                AreaName + "/{controller}/{action}/{id}",
                new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
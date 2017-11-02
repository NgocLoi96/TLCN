using System.Web.Mvc;

namespace Webstie_BDS.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "HomeAd", id = UrlParameter.Optional } // them doan default vao de tu dong dan den trang chu Admin
            );
        }
    }
}
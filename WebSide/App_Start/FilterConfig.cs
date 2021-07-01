using System.Web;
using System.Web.Mvc;

namespace WebSide
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.VerificaSesion());
            ///filters.Add(new Filters.AuthorizeUser());
        }
    }
}

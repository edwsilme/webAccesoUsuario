using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSide.Models;

namespace WebSide.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorizeUser : AuthorizeAttribute
    {
        private Usuarios oUsuario;
        private Database db = new Database();
        private int idrolUsuario;

        public AuthorizeUser(int idrolUsuario = 0)
        {
            this.idrolUsuario = idrolUsuario;
        }


        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            String nombreOperacion = "";
            String nombreModulo = "";
            try
            {
                oUsuario = (Usuarios)HttpContext.Current.Session["User"];
                var lstMisOperaciones = from m in db.rolUsuarios
                                        where m.idrolUsuario == oUsuario.rolUsuario
                                            && m.idrolUsuario == idrolUsuario
                                        select m;

                
                if (lstMisOperaciones.ToList().Count() == 0)
                {
                    filterContext.Result = new RedirectResult("~/Error/UnauthorizedOperation?operacion=" + nombreOperacion + "&modulo=" + nombreModulo + "&msjeErrorExcepcion=");
                }
            }
            catch (Exception ex)
            {
                filterContext.Result = new RedirectResult("~/Error/UnauthorizedOperation?operacion=" + nombreOperacion + "&modulo=" + nombreModulo + "&msjeErrorExcepcion=" + ex.Message);
            }
        }
    }
}
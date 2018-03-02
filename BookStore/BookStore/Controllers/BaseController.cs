using BookStore.DAO;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class BaseController: Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (User)Session["USER_SESSION"];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new
                {
                    controller = "Admin",
                    action = "Login",
                }));
            }
        }
    }
}
using BookStore.Models;
using System.Web.Mvc;
using BookStore.Common;
using BookStore.DAO;
using BookStore.BLL;

namespace BookStore.Controllers
{
    /// <summary>
    /// this is controller for admin area
    /// </summary>
    public class AdminController:BaseController
    {


        /// <summary>
        /// GET: Login
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// POST: Login
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            bool statusLogin = new UserBLL().Login(model.UserName, model.Password);
            if (statusLogin == true)
            {
                //đưa vào Session
                LoginModel sessionUser = new LoginModel();
                sessionUser.UserName = model.UserName;
                sessionUser.Password = model.Password;
                Session.Add("USER_SESSION", sessionUser);

                return Redirect("/Admin/Category");
            }

            return Redirect("/Admin");
          
    }
        /// <summary>
        /// POST: Logout method
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Logout()
        {
            Session.Clear();
            return View("Admin/Login");
        }
    }
}
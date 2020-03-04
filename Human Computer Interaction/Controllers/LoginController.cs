using Human_Computer_Interaction.Models.ETModel;
using Human_Computer_Interaction.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Human_Computer_Interaction.Controllers
{
    public class LoginController : Controller
    {
        AdminLoginEntities db = new AdminLoginEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LogInViewModel logInViewModel )
        {

            if(logInViewModel.UserName!=null && logInViewModel.Password!=null)
            {

                var userExists = db.UserLogins.Where(i => i.UserName == logInViewModel.UserName && i.UserPassword == logInViewModel.Password).FirstOrDefault();
                if (userExists != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            //var formdata = HttpContext.Request.Form;
            //var name =  formdata.Get("username");
            //var pass = formdata.Get("password");
            
            return RedirectToAction("Index","Login");


        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using Test123.Models;


namespace Test123.Controllers
{
    public class UserController : ApiController
    {
        // GET: User
        //public ActionResult Index()
        //{
        //    return View();
        //}

        List<UserInformation> UserInformations = new List<UserInformation>();

        [HttpGet] //GET api/userInformation
        public IEnumerable<UserInformation> GetAllUserInformations()
        {
            GetUserInformations();
            return UserInformations;
        }

        private void GetUserInformations()
        {
            UserInformations.Add(new UserInformation {  userName = "Robert", address = "NewYork", age = "30" });
            UserInformations.Add(new UserInformation { userName = "William", address = "NewYork", age = "31" });
            UserInformations.Add(new UserInformation { userName = "Eric", address = "Texas", age = "32" });
            UserInformations.Add(new UserInformation { userName = "Pauline", address = "Texas", age = "33" });
            UserInformations.Add(new UserInformation { userName = "Chris", address = "Dallas", age = "34" });
           
        }
        [HttpGet] //GET api/GetUserInformations
        public IEnumerable<UserInformation> GetUserInformations(string selectedUserName)
        {
            if (UserInformations.Count() > 0)
            {
                return UserInformations.Where(p => p.userName == selectedUserName);
            }
            else
            {
                GetUserInformations();
                return UserInformations.Where(p => p.userName == selectedUserName);
            }
        }

    }
}
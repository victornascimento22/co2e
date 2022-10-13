using co2e.Repository;
using co2e.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Controllers
{
    public class UserController : Controller
    {

        public UserRepository userrepo = new UserRepository();
        public IActionResult SaveUser(viewModelUser viewmodeluser)
        {
            var resultado = userrepo.UserCreate(viewmodeluser.user);
            return Ok();
        }
    }
}

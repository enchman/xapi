using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XAPI.Models;

namespace XAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
        public object Get()
        {
            List<Profile> profiles = Data.DataContext.Instance.AspNetUsers.ToList();
            return profiles;
        }
    }
}
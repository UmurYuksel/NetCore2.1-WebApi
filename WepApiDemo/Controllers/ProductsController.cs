using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepApiDemo.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/")]
        public string Get()
        {
            return "Product1";
        }

        [HttpGet]
        [Route("api/[controller]/getUserList/")]
        public string[] MyCon(int id)
        {
            return new string[] { "User1", "User2" };
        }
    }
}
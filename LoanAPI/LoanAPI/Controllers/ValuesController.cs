using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "values 1", "values2", "values3" };



        }


        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "The value is " + id;
        }





    }
}

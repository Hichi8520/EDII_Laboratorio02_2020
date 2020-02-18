using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab02_EDII.Models;

namespace Lab02_EDII.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpPost]
        public void Post([FromBody]Soda ssoda)
        {
            Data.Instance.tree.AddSoda(ssoda);
        }

        [HttpGet]
        public void Get()
        {
            Tree tree = new Tree();
        }
    }
}

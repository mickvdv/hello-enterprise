using System.Collections.Generic;
using HelloEnterprise.WebContract;
using Microsoft.AspNetCore.Mvc;

namespace HelloEnterprise.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        public DataController()
        {
        }

        [HttpGet(Name = "GetData")]
        public IEnumerable<WebModel> Get()
        {
            return new List<WebModel>
            {
                new WebModel
                {
                    Data = "Test"
                }
            };
        }
    }
}
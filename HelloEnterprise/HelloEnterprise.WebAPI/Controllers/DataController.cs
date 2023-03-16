using WebContract;

namespace WebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;

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
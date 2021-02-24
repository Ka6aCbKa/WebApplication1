using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringReturnController : ControllerBase
    {
        private readonly ILogger<StringReturnController> _logger;
        public StringReturnController(ILogger<StringReturnController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get(int limit = 5)
        {
            _logger.LogInformation($"{DateTime.Now}: Got {limit} elements");
            return StringReturn.GetLast(limit);
        }

        [HttpPost]
        public String AddString(Product prod)
        {
            StringReturn.AddString(prod.Name);
            _logger.LogInformation($"{DateTime.Now}: Added \"{prod.Name}\"");
            return StringReturn.GetLast(1);
        }
    }
}

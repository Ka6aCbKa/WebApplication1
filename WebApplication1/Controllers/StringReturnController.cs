﻿using Microsoft.AspNetCore.Mvc;
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
        //пока хз зачем это
        private readonly ILogger<StringReturnController> _logger;
        //пока хз зачем это
        public StringReturnController(ILogger<StringReturnController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get(int limit = 5)
        {
            return StringReturn.GetLast(limit);
        }

        [HttpPost]
        public String AddString(Product prod)
        {
            StringReturn.AddString(prod.Name);
            return StringReturn.GetLast(1);
        }
    }
}

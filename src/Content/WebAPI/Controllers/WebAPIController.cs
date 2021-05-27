using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebAPIController : ControllerBase
    {
        private readonly ILogger<WebAPIController> _logger;
        private readonly IWrapper _wrapper;

        public WebAPIController(ILogger<WebAPIController> logger, IWrapper wrapper)
        {
            this._logger = logger;
            this._wrapper = wrapper;
        }
    }
}

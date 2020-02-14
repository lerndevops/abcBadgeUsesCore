using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace abcBadgeGenAPI_Kubernetes.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AddingDecimalsController : ControllerBase   // : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly ILogger<AddingDecimalsController> _logger;

        public AddingDecimalsController(ILogger<AddingDecimalsController> logger)
        {
            _logger = logger;
        }


    }
}
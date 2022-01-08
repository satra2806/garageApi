using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using garageApi.Services;
using Microsoft.AspNetCore.Cors;

namespace garageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class GarageController : ControllerBase
    {
        private readonly IGarageService _garageService;

        public GarageController (IGarageService garageService)
        {
            _garageService = garageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _garageService.GetAllAsync());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityReport.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityReportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityReportController : ControllerBase
    {
        readonly ICityReportService _cityReportService;
        public CityReportController(ICityReportService cityReportService)
        {
            _cityReportService = cityReportService;
        }

        [HttpGet]
        [Route("location/{name}")]
        public async Task<ActionResult> GetLocation(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return BadRequest("No name provided, please support Arsenal");
            }
            else
            {
                var location = await _cityReportService.GetLocation(name);
                return Ok(location);
            }
        }

        [HttpGet]
        [Route("current/{name}")]
        public async Task<ActionResult> GetCurrent(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("No name provided, please support Arsenal");
            }
            else
            {
                var location = await _cityReportService.GetCurrent(name);
                return Ok(location);
            }
        }

        [HttpGet]
        [Route("astronomy/{name}")]
        public async Task<ActionResult> GetAstronomy(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("No name provided, please support Arsenal");
            }
            else
            {
                var location = await _cityReportService.GetAstronomy(name);
                return Ok(location);
            }
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Train.ApplicationCore.Entity;
using Train.ApplicationCore.Interface.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train.WebAPI.Controllers
{
    [Route("[controller]")]
    public class StationController : Controller
    {
		readonly IStationService _stationService;

		public StationController(IStationService stationService)
		{
			_stationService = stationService;
		}

        // GET: api/values
        [HttpGet]
		public IEnumerable<Station> Get()
        {
			return _stationService.GetStations();
        }
    }
}

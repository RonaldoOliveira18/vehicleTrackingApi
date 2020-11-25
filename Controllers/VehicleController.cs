using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Services;

namespace vehicleTrackingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehiclesService;
        public VehicleController(IVehicleService vehicleService) {
            _vehiclesService = vehicleService;
        }

        // GET api/placeinfo/id
        [HttpGet("{id}", Name = nameof(GetVehicle))]
        public IActionResult GetVehicle(string id)
        {
            //PlaceInfo placeInfo = _placeInfoService.Find(id);
            //if (placeInfo == null)
            //    return NotFound();
            //else
            //    return new ObjectResult(placeInfo);
            var vechile = new ObjectResult(_vehiclesService.Get(id));
            return vechile;
            //return NotFound();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;
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

        [HttpGet("{VehicleIdentification}", Name = nameof(GetVehicle))]
        public IActionResult GetVehicle(string VehicleIdentification)
        {
            var vehile = _vehiclesService.Get(VehicleIdentification);
            if (vehile == null)
                return NotFound();
            else
                return new ObjectResult(vehile);
        }

        [HttpGet("GetHistory/{VehicleIdentification}", Name = nameof(GetVehicleHistory))]
        public IActionResult GetVehicleHistory(string VehicleIdentification)
        {
            var vehile = _vehiclesService.GetHistory(VehicleIdentification);
            if (vehile == null)
                return NotFound();
            else
                return new ObjectResult(vehile);
        }

        [HttpGet("getPeriod", Name = nameof(GetVehicleHistoryBetweenPeriod))]
        public IActionResult GetVehicleHistoryBetweenPeriod(DateTime VehicleIdentificationDe, DateTime VehicleIdentificationUntil)
        {
            var vehile = _vehiclesService.GetVehicleHistoryBetweenPeriod(VehicleIdentificationDe, VehicleIdentificationUntil);
            if (vehile == null)
                return NotFound();
            else
                return new ObjectResult(vehile);
        }

        [HttpPost("Tracking", Name = nameof(Tracking))]
        public IActionResult Tracking(Vehicles vehicle)
        {
            var vehile = _vehiclesService.Tracking(vehicle);
            if (vehile == null)
                return StatusCode(200);
            else
                return StatusCode(200);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Services.Interfaces;

namespace vehicleTrackingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService AddressService)
        {
            _addressService = AddressService;
        }

        [HttpGet("{VehicleIdentification}", Name = nameof(GetLocationVehicle))]
        public IActionResult GetLocationVehicle(string VehicleIdentification)
        {
            var vehile = _addressService.getLocationVehicle(VehicleIdentification);
            if (vehile == null)
                return NotFound();
            else
                return new ObjectResult(vehile);
        }
    }
}

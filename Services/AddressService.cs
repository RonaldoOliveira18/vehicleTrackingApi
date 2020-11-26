
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;
using vehicleTrackingApi.Services.Interfaces;

namespace vehicleTrackingApi.Services
{
    public class AddressService : IAddressService
    {
        private readonly IVehicleRepository _vehiclesRepository;
        private readonly IAddressRepository _addressRepository;
        public AddressService(IVehicleRepository vehicleRepository, IAddressRepository addressRepository)
        {
            _vehiclesRepository = vehicleRepository;
            _addressRepository = addressRepository;
        }

        public Address getLocationVehicle(string VehicleIdentification)
        {
            var vehicle = _vehiclesRepository.Get(VehicleIdentification);

            return _addressRepository.getAdress(vehicle.LastLatitude, vehicle.LastLongitude);
        }
    }
}

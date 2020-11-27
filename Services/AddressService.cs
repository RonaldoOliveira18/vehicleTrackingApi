
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;
using vehicleTrackingApi.Services.Interfaces;

namespace vehicleTrackingApi.Services
{
    public class AddressService : IAddressService
    {
        private readonly IVehicleRepository _vehiclesRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IAddressCordinatesRepository _addressCordinatesRepository;
        public AddressService(IVehicleRepository vehicleRepository, IAddressRepository addressRepository, IAddressCordinatesRepository addressCordinatesRepository)
        {
            _vehiclesRepository = vehicleRepository;
            _addressRepository = addressRepository;
            _addressCordinatesRepository = addressCordinatesRepository;
        }

        public Address getLocationVehicle(string VehicleIdentification)
        {
            var vehicle = _vehiclesRepository.Get(VehicleIdentification);
            var AddresInDataBase = existsInDatabase(vehicle.LastLatitude, vehicle.LastLongitude);

            if (AddresInDataBase == null)
            {

                var addresAPI = _addressRepository.getAdress(vehicle.LastLatitude, vehicle.LastLongitude);
                AddressCordinates addressCordinates = new AddressCordinates();
                addressCordinates.Address = addresAPI;
                addressCordinates.Latitude = vehicle.LastLatitude;
                addressCordinates.Longitude = vehicle.LastLongitude;
                _addressCordinatesRepository.insert(addressCordinates);
                return addresAPI;
            }
            else
            {
                return AddresInDataBase.Address;
            }            
        }

        public AddressCordinates existsInDatabase(decimal lat, decimal longi)
        {
            var addressDataBase = _addressCordinatesRepository.Get(lat, longi);
            if (addressDataBase == null)
                return null;
            else
                return addressDataBase;
        }
    }
}

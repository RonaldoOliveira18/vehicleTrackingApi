using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Repository.Interfaces
{
    public interface IAddressRepository
    {
        public Address getAdress(decimal lat, decimal lon);
    }
}

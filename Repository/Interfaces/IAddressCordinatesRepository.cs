using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicleTrackingApi.Models;

namespace vehicleTrackingApi.Repository.Interfaces
{
    public interface IAddressCordinatesRepository
    {
        public void insert(AddressCordinates addressCordinates);
        public AddressCordinates Get(decimal lat, decimal longi);
    }
}

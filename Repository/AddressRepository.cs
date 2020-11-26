using ServiceStack;
using System;
using System.Collections.Generic;
using System.Configuration;
using vehicleTrackingApi.Models;
using vehicleTrackingApi.Repository.Interfaces;

namespace vehicleTrackingApi.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly string _urlApiLocation;
        private readonly string _urlKey;
        public AddressRepository(IConfigMap settings)
        {
            _urlApiLocation = settings.AddressAPI;
            _urlKey = settings.AddressAPIKey;
        }        
        public Address getAdress(decimal lat, decimal lon)
        {
            var param = "&format=json&lat=" + lat.ToString() + "&lon=" + lon.ToString();
            string callAPI = _urlApiLocation + _urlKey + param;

            return callAPI.GetJsonFromUrl().FromJson<Address>();
        }
    }
}

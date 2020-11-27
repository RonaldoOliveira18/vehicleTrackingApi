
# Vehicle Tracking
> API's developed in .NET Core 3.1 with MongoDB.
> The API's were designed to receive a certain position and store them in MongoDB and also through the location (Longitude and Latitude) to identify the address.


## Prerequisites for executing the code

Install Mongo DB:

```sh
https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/
```

Install Visual Studio:

```sh
https://visualstudio.microsoft.com/downloads/
```

Configure your mongoDB:

```sh
Create database with name = Vehicle
Create 3 collections with names:
  1. Vehicles
  2. VehicleHistory
  3. AddressCordinates
```

Validate your appsettings:

```sh
{
  "ConfigMap": {
    "VehicleCollectionName": "Vehicles",
    "VehicleHistoryCollectionName": "VehicleHistory",
    "AddressCordinatesCollectionName": "AddressCordinates",
    "ConnectionString": "mongodb://localhost:27017", --Validate your ConnectionString
    "DatabaseName": "Vehicle",
    "AddressAPI": "https://us1.locationiq.com/v1/reverse.php?key=",
    "AddressAPIKey": "pk.2a079af928e21ecf32a160cfd05323bb"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}

```

Let's go!:
```sh
If you are using visual studio, just rebuild the solution to install the dependencies and start the project
```


Point of attention when using the Tracking API:
```sh
In the tracking API (POST) it is not necessary to insert the ID attribute
```

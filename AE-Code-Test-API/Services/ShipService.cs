using AE_Code_Test_API.Context;
using AE_Code_Test_API.Entities;
using AE_Code_Test_API.Models;
using System.Device.Location;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace AE_Code_Test_API.Services
{
    public class ShipService : IShipService
    {
        private AEContext aeContext;

        public ShipService(AEContext context)
        {
            aeContext = context;
        }
        public void AddNewShip(List<ShipInputModel> shipInputList)
        {
            #region Validation
            {
                if (shipInputList is null)
                    throw new ArgumentNullException(nameof(shipInputList));

                Regex re = new Regex("[A-Za-z0-9]{2,100}");

                var invalidNameLength = shipInputList.Where(x => !re.IsMatch(x.Name.Trim())).ToList();

                if (invalidNameLength.Count > 0)
                    throw new ArgumentException($"Invalid Ship's Name [{string.Join("], [", invalidNameLength.Select(x => x.Name.Trim()).ToArray())}].");

                var invalidGeoLocation = shipInputList.Where(x => x.Longitude > GeoLocationHelper.MAX_LON
                                                               || x.Longitude < GeoLocationHelper.MIN_LON
                                                               || x.Latitude > GeoLocationHelper.MAX_LAT
                                                               || x.Latitude < GeoLocationHelper.MIN_LAT
                                                             ).ToList();

                if (invalidGeoLocation.Count > 0)
                    throw new ArgumentException($"GeoLocation of ships [{string.Join("], [", invalidGeoLocation.Select(x => x.Name.Trim()).ToArray())}] is/are invalid.");

            }
            #endregion

            aeContext.Ships.AddRange(shipInputList.Select(x => new Ship()
            {
                Name = x.Name.Trim(),
                Latitude = x.Latitude,
                Longitude = x.Longitude,
                VelocityKmh = x.VelocityKmh
            }).ToList());

            aeContext.SaveChanges();
        }
        public List<Ship> GetFullShipList()
        {
            return aeContext.Ships.ToList();
        }
        public void UpdateVelocity(ShipUpdateModel shipUpdateModel)
        {
            if (shipUpdateModel.VelocityKmh < 0)
                throw new ArgumentException($"Velocity must larger than 0");

            var ship = aeContext.Ships.Where(x => x.ShipId == shipUpdateModel.ShipId).FirstOrDefault();
            if (ship != null)
            {
                ship.VelocityKmh = shipUpdateModel.VelocityKmh;
                aeContext.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"ShipId[{shipUpdateModel.ShipId}] not found.");
            }
            return;
        }
        public ShipPortOutputModel GetClosestPortOfShip(int ShipId)
        {
            ShipPortOutputModel shipPortOutpu = new ShipPortOutputModel();

            shipPortOutpu.ShipDetail = aeContext.Ships.Where(x => x.ShipId.Equals(ShipId)).First();

            if (shipPortOutpu.ShipDetail.VelocityKmh == 0)
            {
                shipPortOutpu.Remarks = "Ship is not moving";
            }
            else
            {
                var shipLocation = new GeoCoordinate(shipPortOutpu.ShipDetail.Latitude, shipPortOutpu.ShipDetail.Longitude);

                var ClosestPort = aeContext.Ports.Select(x => new
                {
                    Port = x,
                    Distance = (new GeoCoordinate(x.Latitude, x.Longitude)).GetDistanceTo(shipLocation)
                }).AsEnumerable().OrderBy(x => x.Distance).First();

                shipPortOutpu.PortDetail = ClosestPort.Port;
                shipPortOutpu.TimeToPort = DateTime.Now.AddHours(((ClosestPort.Distance / 1000.0) / decimal.ToDouble(shipPortOutpu.ShipDetail.VelocityKmh)));
            }


            return shipPortOutpu;
        }
    }
}

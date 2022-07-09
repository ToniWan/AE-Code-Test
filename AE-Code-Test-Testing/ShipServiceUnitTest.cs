using AE_Code_Test_API.Context;
using AE_Code_Test_API.Entities;
using AE_Code_Test_API.Models;
using AE_Code_Test_API.Services;
using Microsoft.EntityFrameworkCore;

namespace AE_Code_Test_Testing
{
    public class ShipServiceUnitTest
    {
        private ShipService _shipService;
        private static DbContextOptions<AEContext> dbContextOptions = new DbContextOptionsBuilder<AEContext>().UseInMemoryDatabase(databaseName: "AEDB.Test").Options;

        AEContext aeContext;

        [OneTimeSetUp]
        public void Setup()
        {
            aeContext = new AEContext(dbContextOptions);
            aeContext.Database.EnsureCreated();
            _shipService = new ShipService(aeContext);
            SeedDatabase();
        }

        private void SeedDatabase()
        {
            aeContext.Ports.RemoveRange(aeContext.Ports);
            aeContext.Ports.AddRange(new List<Port>() {
                new Port(){Name = "Port01" ,Longitude=  64.8137855199256  ,Latitude = -17.3750948938721 } ,
                new Port(){Name = "Port02" ,Longitude=- 105.655977722527  ,Latitude = 52.8280490057629 } ,
                new Port(){Name = "Port03" ,Longitude=  153.539141534651  ,Latitude = 58.3505331429055 },
                new Port(){Name = "Port04" ,Longitude=- 140.916940145062  ,Latitude = 19.5440011317666 } ,
                new Port(){Name = "Port05" ,Longitude=  138.051328662722  ,Latitude = 40.1996082475736 },
                new Port(){Name = "Port06" ,Longitude=  98.330554994109   ,Latitude = 37.7761256034312 }    ,
                new Port(){Name = "Port07" ,Longitude=  81.1979811613046  ,Latitude = -82.9288846594017 } ,
                new Port(){Name = "Port08" ,Longitude=  75.6476804912944  ,Latitude = -81.1924631099406 } ,
                new Port(){Name = "Port09" ,Longitude=  29.5086013053247  ,Latitude = -7.80981163612081 } ,
                new Port(){Name = "Port10" ,Longitude= - 159.084547596632 ,Latitude =  26.6105381585176 } ,
            });

            aeContext.SaveChanges();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            aeContext.Database.EnsureDeleted();
        }


        [Test]
        [Order(0)]
        public void AddNewShipTest()
        {
            #region init Data
            String TestShipName1 = "Ship A";
            String TestShipName2 = "Ship B";

            var TestShip1 = new ShipInputModel()
            {
                Name = TestShipName1,
                Latitude = 22.4,
                Longitude = 114,
                VelocityKmh = 100
            };

            var TestShip2 = new ShipInputModel()
            {
                Name = TestShipName2,
                Latitude = -22.4,
                Longitude = -114,
                VelocityKmh = 150
            };
            #endregion init Data

            List<ShipInputModel> shipInputList = new List<ShipInputModel>() { TestShip1, TestShip2 };
            _shipService.AddNewShip(shipInputList);

            var ship1After = aeContext.Ships.Where(x => x.Name.Equals(TestShipName1)).First();
            var ship2After = aeContext.Ships.Where(x => x.Name.Equals(TestShipName2)).First();

            if (TestShip1.Latitude == ship1After.Latitude
             && TestShip1.Longitude == ship1After.Longitude
             && TestShip1.VelocityKmh == ship1After.VelocityKmh
             && TestShip2.Latitude == ship2After.Latitude
             && TestShip2.Longitude == ship2After.Longitude
             && TestShip2.VelocityKmh == ship2After.VelocityKmh
             )
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        [Order(1)]
        public void GetFullShipListTest()
        {
            int serviceShipListCount = _shipService.GetFullShipList().Count();
            int shipListCount = aeContext.Ships.Count();

            if (serviceShipListCount.Equals(shipListCount))
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        [Order(2)]
        public void UpdateVelocityTest()
        {

            int testingShipid = aeContext.Ships.First().ShipId;
            decimal newVelocityKmh = 999;

            ShipUpdateModel shipUpdateModel = new ShipUpdateModel() { ShipId = testingShipid, VelocityKmh = newVelocityKmh };
            _shipService.UpdateVelocity(shipUpdateModel);

            if (aeContext.Ships.Where(x => x.ShipId.Equals(testingShipid)).First().VelocityKmh == newVelocityKmh)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [Test]
        [Order(3)]
        public void GetClosestPortOfShipTest()
        {
            int testingShipid = aeContext.Ships.Where(x => x.Name.Equals("Ship A")).First().ShipId;
            var result = _shipService.GetClosestPortOfShip(testingShipid);

            if (result == null)
            {
                Assert.Fail();
            }

            if (result.PortDetail.PortId.Equals(105)
             && result.ShipDetail.ShipId.Equals(testingShipid)
                )
                Assert.Pass();
            else
                Assert.Fail();

        }
    }
}
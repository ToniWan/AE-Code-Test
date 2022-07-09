using AE_Code_Test_API.Context;
using AE_Code_Test_API.Entities;
using AE_Code_Test_API.Models;

namespace AE_Code_Test_API.Services
{
    public interface IShipService
    {

        public void AddNewShip(List<ShipInputModel> shipInputList);
        
        public List<Ship> GetFullShipList();

        public void UpdateVelocity(ShipUpdateModel shipUpdateModel);

        public ShipPortOutputModel GetClosestPortOfShip(int ShipId);
    }
}

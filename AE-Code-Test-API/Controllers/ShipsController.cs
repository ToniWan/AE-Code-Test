using AE_Code_Test_API.Entities;
using AE_Code_Test_API.Models;
using AE_Code_Test_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AE_Code_Test_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipsController : ControllerBase
    {

        private readonly ILogger<ShipsController> _logger;
        private IShipService _shipService;

        public ShipsController(ILogger<ShipsController> logger, IShipService shipService)
        {
            _logger = logger;
            _shipService = shipService;
        }

        //function to add new ship
        [HttpPost(Name = "AddShips")]
        public ActionResult AddShips([FromBody] List<ShipInputModel> shipInputList)
        {
            _logger.LogInformation(System.Reflection.MethodBase.GetCurrentMethod().Name + " called", shipInputList);
            try
            {
                _shipService.AddNewShip(shipInputList);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.Message);
                throw;
            }
        }

        //function to returm all existsing ships
        [HttpGet(Name = "ViewAllShips")]
        public IEnumerable<Ship> ViewAllShips()
        {
            _logger.LogInformation(System.Reflection.MethodBase.GetCurrentMethod().Name + " called");
            try
            {
                return _shipService.GetFullShipList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.Message);
                throw;
            }
        }

        //function to update ships velocity
        [HttpPut(Name = "UpdateVelocity")]
        public ActionResult UpdateVelocity([FromBody] ShipUpdateModel shipUpdateModel)
        {
            _logger.LogInformation(System.Reflection.MethodBase.GetCurrentMethod().Name + " called", shipUpdateModel);
            try
            {
                _shipService.UpdateVelocity(shipUpdateModel);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.Message);
                throw;
            }

        }
    }
}
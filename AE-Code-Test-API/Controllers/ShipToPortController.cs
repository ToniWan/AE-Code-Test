using AE_Code_Test_API.Models;
using AE_Code_Test_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace AE_Code_Test_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipToPortController : ControllerBase
    {

        private readonly ILogger<ShipsController> _logger;
        private IShipService _shipService;

        public ShipToPortController(ILogger<ShipsController> logger, IShipService shipService)
        {
            _logger = logger;
            _shipService = shipService;
        }

        //function to return ship, cloest port and expected arrival time
        [HttpPost(Name = "ShipToClosestPort")]
        public ShipPortOutputModel ShipToClosestPort([FromBody] int ShipId)
        {
            try
            {
                return _shipService.GetClosestPortOfShip(ShipId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.Message);
                throw;
            }
        }
    }
}
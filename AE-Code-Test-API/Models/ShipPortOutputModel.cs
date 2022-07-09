using AE_Code_Test_API.Entities;

namespace AE_Code_Test_API.Models
{
    public class ShipPortOutputModel
    {
        public ShipPortOutputModel() {
            ShipDetail = null;
            PortDetail = null;
            TimeToPort = null;
            Remarks = String.Empty;
        }

        public Ship? ShipDetail { get; set; }

        public Port? PortDetail { get; set; }

        public DateTime? TimeToPort { get; set; }

        public String Remarks { get; set; }

    }
}

namespace AE_Code_Test_API.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Ship")]
    public class Ship : BaseTable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public decimal VelocityKmh { get; set; }
    }
}

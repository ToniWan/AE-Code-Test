namespace AE_Code_Test_API.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Port")]
    public class Port : BaseTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PortId { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}

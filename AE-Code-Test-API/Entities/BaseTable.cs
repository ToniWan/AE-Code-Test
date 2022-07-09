namespace AE_Code_Test_API.Entities
{
    public class BaseTable
    {
        public BaseTable()
        {
            CreateDate = DateTime.Now;
            ModifyDate = DateTime.Now;
        }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}

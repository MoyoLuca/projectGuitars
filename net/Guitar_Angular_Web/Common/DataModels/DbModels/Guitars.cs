using DataModels.Interfaces;

namespace DataModels.DbModels
{
    public class Guitars : IModelEntity
    {
        public Guitars()
        {

        }

        public long Id { get; set; } = 0;
        public string GUID { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public DateTime? CreatedAt { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public DateTime? UpdatedAt { get; set; }

    }
}

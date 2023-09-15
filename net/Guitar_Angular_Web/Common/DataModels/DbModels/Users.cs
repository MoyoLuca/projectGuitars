using DataModels.Interfaces;

namespace DataModels.DbModels
{
    public class Users : IModelEntity
    {
        public Users()
        {

        }

        public long Id { get; set; } = 0;
        public string GUID { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public DateTime? CreatedAt { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }

    }
}
using DataModels.DbModels;

namespace DataModels.ViewModels
{
    public class UserInfo
    {
        public UserInfo()
        {

        }

        public UserInfo(Users user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Email = user.EmailAddress;
            FirstName = user.FirstName;
            LastName = user.LastName;
        }

        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

    }
}

using JWTTokenAuth.Models;
namespace JWTTokenAuth.Constants
{
    public class ListOfUsers
    {
        public static List<User> Users = new()
        {
            new User() { Username = "Admin", Password = "Admin123", Role = "Admin" }
        };
    }
}

using SporTucMobile.Models;

namespace SporTucMobile.Services.Controllers
{
    public class UserController : EntityController<User>
    {
        public UserController()
            : base(App.SqlConnection)
        {
            App.SqlConnection.CreateTableAsync<User>();
        }
    }
}

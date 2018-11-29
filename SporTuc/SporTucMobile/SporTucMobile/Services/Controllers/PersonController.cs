using SporTucMobile.Models;

namespace SporTucMobile.Services.Controllers
{
    public class PersonController : EntityController<Person>
    {
        public PersonController() 
            : base(App.SqlConnection)
        {
            App.SqlConnection.CreateTableAsync<Person>();
        }
    }
}

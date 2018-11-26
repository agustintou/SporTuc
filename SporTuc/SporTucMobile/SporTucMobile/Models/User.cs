using SporTucMobile.Models.Base;

namespace SporTucMobile.Models
{
    public class User : DtoBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Locked { get; set; }

        //Navigations properties
        public Person Person { get; set; }

    }
}

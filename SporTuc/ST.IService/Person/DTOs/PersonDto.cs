using ST.Service.Base.DTOs;

namespace ST.IService.Complex.DTOs
{
    public class PersonDto : DtoBase
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }
    }
}

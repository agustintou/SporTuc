using ST.Service.Base.DTOs;

namespace ST.IService.Complex.DTOs
{
    public class TeamDto : DtoBase
    {
        public string TeamName { get; set; }

        public string Alias { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public int Points { get; set; }
    }
}

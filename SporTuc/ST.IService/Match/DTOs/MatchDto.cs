using ST.Service.Base.DTOs;
using System;

namespace ST.IService.Complex.DTOs
{
    public class MatchDto : DtoBase
    {
        public int NumMatch { get; set; }

        public DateTime Date { get; set; }

        public long SportId { get; set; }

        public long TeamId { get; set; }

        public long DestinationTeamId { get; set; }

        public long StateMatchId { get; set; }

    }
}

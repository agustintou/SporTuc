using ST.Service.Base.DTOs;
using System;

namespace ST.IService.Complex.DTOs
{
    public class RankingDto : DtoBase
    {
        public int Score { get; set; }

        public DateTime Date { get; set; }

        public long ComplexId { get; set; }

        public long PersonId { get; set; }

    }
}

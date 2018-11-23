using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Ranking
{
    public interface IRankingService
    {
        IEnumerable<RankingDto> Get(string cadenaBuscar);

        void Add(RankingDto entity);

        void Update(RankingDto entity);

        void Delete(long entityId);
    }
}

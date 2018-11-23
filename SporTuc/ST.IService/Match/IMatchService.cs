using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Match
{
    public interface IMatchService
    {
        IEnumerable<MatchDto> Get(string cadenaBuscar);

        void Add(MatchDto entity);

        void Update(MatchDto entity);

        void Delete(long entityId);
    }
}

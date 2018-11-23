using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Team
{
    public interface ITeamService
    {
        IEnumerable<TeamDto> Get(string cadenaBuscar);

        void Add(TeamDto entity);

        void Update(TeamDto entity);

        void Delete(long entityId);
    }
}

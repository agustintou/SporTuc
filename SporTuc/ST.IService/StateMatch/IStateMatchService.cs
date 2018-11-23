using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.StateMatch
{
    public interface IStateMatchService
    {
        IEnumerable<StateMatchDto> Get(string cadenaBuscar);

        void Add(StateMatchDto entity);

        void Update(StateMatchDto entity);

        void Delete(long entityId);
    }
}

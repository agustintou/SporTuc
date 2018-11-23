using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Sport
{
    public interface ISportService
    {
        IEnumerable<SportDto> Get(string cadenaBuscar);

        void Add(SportDto entity);

        void Update(SportDto entity);

        void Delete(long entityId);
    }
}

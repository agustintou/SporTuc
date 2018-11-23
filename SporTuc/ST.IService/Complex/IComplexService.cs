using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Complex
{
    public interface IComplexService
    {
        IEnumerable<ComplexDto> Get(string cadenaBuscar);

        void Add(ComplexDto entity);

        void Update(ComplexDto entity);

        void Delete(long entityId);
    }
}

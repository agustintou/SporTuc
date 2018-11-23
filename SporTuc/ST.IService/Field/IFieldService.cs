using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Field
{
    public interface IFieldService
    {
        IEnumerable<FieldDto> Get(string cadenaBuscar);

        void Add(FieldDto entity);

        void Update(FieldDto entity);

        void Delete(long entityId);
    }
}

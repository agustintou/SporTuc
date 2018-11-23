using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Person
{
    public interface IPersonService
    {
        IEnumerable<PersonDto> Get(string cadenaBuscar);

        void Add(PersonDto entity);

        void Update(PersonDto entity);

        void Delete(long entityId);
    }
}

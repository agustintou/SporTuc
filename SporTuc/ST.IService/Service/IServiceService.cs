using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.Service
{
    public interface IServiceService
    {
        IEnumerable<ServiceDto> Get(string cadenaBuscar);

        void Add(ServiceDto entity);

        void Update(ServiceDto entity);

        void Delete(long entityId);
    }
}

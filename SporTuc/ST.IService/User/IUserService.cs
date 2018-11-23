using ST.IService.Complex.DTOs;
using System.Collections.Generic;

namespace ST.IService.User
{
    public interface IUserService
    {
        IEnumerable<UserDto> Get(string cadenaBuscar);

        void Add(UserDto entity);

        void Update(UserDto entity);

        void Delete(long entityId);
    }
}

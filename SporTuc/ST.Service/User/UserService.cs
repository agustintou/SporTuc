using System.Collections.Generic;
using System.Linq;
using ST.Domain.Repository.Person;
using ST.Domain.Repository.User;
using ST.Infrastructure.Repository.Person;
using ST.IService.Complex.DTOs;
using ST.IService.User;

namespace ST.Service.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPersonRepository _personRepository;

        public UserService(IUserRepository userRepository,
            IPersonRepository personRepository)
        {
            _userRepository = userRepository;
            _personRepository = personRepository;
        }

        public void Add(UserDto entity)
        {

            _userRepository.Add(new Domain.Entities.User
            {
                Locked = false,
                Password = entity.Password,
                
            })
        }

        public void Delete(long entityId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserDto> Get(string cadenaBuscar)
        {
            return _userRepository
                .GetByFilter(x => x.UserName.Contains(cadenaBuscar))
                .Select(x => new UserDto
                {
                    Id = x.Id,
                    RowVersion = x.RowVersion,
                    Locked = x.Locked,
                    Password = x.Password,
                    PersonId = x.Person.Id,
                    UserName = x.UserName
                }).OrderBy(x=> x.UserName)
                .ToList();
        }

        public void Update(UserDto entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

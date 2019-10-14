using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessRepository;
using DataServicesLayer.Models;

namespace DataServicesLayer.Services
{
    public class UsersService : IUsersService
    {
        private readonly IGenericRepository<User> _userRepository;

        public UsersService(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.Insert(user);
        }

        public void DeleteUser(User user)
        {
            if (user == null)
                throw new Exception("User not exists");
            _userRepository.Delete(user);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void UpdateUser(User user)
        {
            if (user == null)
                throw new Exception("User not exists");
            _userRepository.Update(user);
        }
    }
}

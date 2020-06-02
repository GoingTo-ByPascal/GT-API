﻿using GoingTo_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoingTo_API.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        Task AddAsync(User user);

        Task<User> FindById(int id);
        void Update(User user);

        void Remove(User user);
    }
}

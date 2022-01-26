﻿using Bileciki_ecommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bileciki_ecommerce.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor Update(int id , Actor newActor);
        void Delete(int id);
    }
}
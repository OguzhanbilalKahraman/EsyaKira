using EsyaKira.Application.Interfaces.AppUserInterfaces;
using EsyaKira.Domain.Entities;
using EsyaKira.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Persistance.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly EsyaKiraContext _context;

        public AppUserRepository(EsyaKiraContext context)
        {
            _context = context;
        }

        public async Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}

using KonBase.Data;
using KonBase.Models;
using KonBase.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Services
{
    public class CondominiumService : ICondominiumService
    {

        private ApplicationDbContext _context;

        public CondominiumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationCondominium>> GetCondominiumByIdAsync(Guid id)
        {
            try
            {
                var result = await _context.Condominium.Where(x => x.User.Id == id).ToListAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

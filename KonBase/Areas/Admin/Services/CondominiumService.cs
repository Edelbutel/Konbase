using KonBase.Areas.Admin.Interfaces;
using KonBase.Areas.Admin.Models;
using KonBase.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Services
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
            catch (Exception ex)
            {
                throw;
            }

        }

        public async Task<ApplicationCondominium> CheckCNPJAsync(string cnpj)
        {
            try
            {
                var result = await _context.Condominium.Where(x => x.Cnpj == cnpj && x.Cnpj != null)
                                                       .FirstOrDefaultAsync();

                return result;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<ApplicationCondominium> CreateCondominiumAsync(ApplicationCondominium condominium)
        {
            try
            {
                var result = await _context.Condominium.AddAsync(condominium);

                if (result.State == EntityState.Added)
                {
                    await _context.SaveChangesAsync();
                }

                return result.Entity;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ApplicationCondominiumPhone> CreateCondominiumPhoneAsync(ApplicationCondominiumPhone condominiumPhone)
        {
            try
            {
                var result = await _context.CondominiumPhone.AddAsync(condominiumPhone);

                if (result.State == EntityState.Added)
                {
                    await _context.SaveChangesAsync();
                }

                return result.Entity;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ApplicationCondominiumEmail> CreateCondominiumEmailAsync(ApplicationCondominiumEmail condominiumEmail)
        {
            try
            {
                var result = await _context.CondominiumEmail.AddAsync(condominiumEmail);

                if (result.State == EntityState.Added)
                {
                    await _context.SaveChangesAsync();
                }

                return result.Entity;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ApplicationCondominium>> GetAllCondominiumAsync(Guid user)
        {
            try
            {
                var result = await _context.Condominium
                                                    .Where(x => x.User.Id == user)
                                                    .OrderBy(x => x.FantasyName)
                                                    .ToListAsync();

                return result;
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}

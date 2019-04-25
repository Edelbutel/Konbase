using KonBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Services.Interfaces
{
    public interface ICondominiumService
    {
        Task<List<ApplicationCondominium>> GetCondominiumByIdAsync(Guid id);
    }
}

using KonBase.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Interfaces
{
    public interface ICondominiumService
    {
        Task<List<ApplicationCondominium>> GetCondominiumByIdAsync(Guid id);
        Task<ApplicationCondominium> CheckCNPJAsync(string cnpj);
        Task<ApplicationCondominium> CreateCondominiumAsync(ApplicationCondominium condominium);
        Task<ApplicationCondominiumPhone> CreateCondominiumPhoneAsync(ApplicationCondominiumPhone condominiumPhone);
        Task<ApplicationCondominiumEmail> CreateCondominiumEmailAsync(ApplicationCondominiumEmail condominiumEmail);

        Task<List<ApplicationCondominium>> GetAllCondominiumAsync(Guid user);

    }
}

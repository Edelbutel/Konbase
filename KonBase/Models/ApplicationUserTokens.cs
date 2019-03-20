using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Models
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
    }
}

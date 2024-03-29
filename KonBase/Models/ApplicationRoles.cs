﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Models
{
    public class ApplicationRoles : IdentityRole<Guid>
    {
        public ApplicationRoles() : base() { }

        public ApplicationRoles(string roleName) : base(roleName) { }
    }
}

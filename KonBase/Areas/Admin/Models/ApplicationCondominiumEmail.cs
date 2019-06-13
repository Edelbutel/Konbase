using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models
{
    public class ApplicationCondominiumEmail
    {
        [Key]
        public long Id { get; set; }

        public string Email { get; set; }

        public virtual ApplicationCondominium Condominium { get; set; }

    }
}

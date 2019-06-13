using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models
{
    public class ApplicationCondominiumPhone
    {
        [Key]
        public long Id { get; set; }

        public string Phone { get; set; }

        public virtual ApplicationCondominium Condominium { get; set; }
    }
}

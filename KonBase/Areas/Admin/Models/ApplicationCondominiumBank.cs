using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models
{
    public class ApplicationCondominiumBank
    {
        [Key]
        public long Id { get; set; }

        public int Agency { get; set; }

        public int AccountCurrent { get; set; }

        public virtual ApplicationCondominium Condominium { get; set; }

        public virtual ApplicationBank Bank { get; set; }
    }
}

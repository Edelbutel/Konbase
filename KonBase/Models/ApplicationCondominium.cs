using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Models
{
    public class ApplicationCondominium
    {
        [Key]
        public long Id { get; set; }

        public virtual ApplicationUsers User { get; set; }
    }
}

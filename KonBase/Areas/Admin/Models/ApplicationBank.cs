using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models
{
    public class ApplicationBank
    {
        [Key]
        public long Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }
    }
}

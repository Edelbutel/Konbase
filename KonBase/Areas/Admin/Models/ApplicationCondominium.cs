using KonBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models
{
    public class ApplicationCondominium
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public String CompanyName { get; set; }

        [Required]
        public String FantasyName { get; set; }

        [Required]
        public string Cnpj { get; set; }

        public Nullable<DateTime> ConstructionDate { get; set; }

        public string CondominiumType { get; set; }

        public string Cep { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Uf { get; set; }

        public int Number { get; set; }

        public string Complement { get; set; }

        public string Note { get; set; }

        public virtual ICollection<ApplicationCondominiumBank> Bank { get; set; }

        public virtual ICollection<ApplicationCondominiumPhone> Phone { get; set; }

        public virtual ICollection<ApplicationCondominiumEmail> Email { get; set; }

        public virtual ApplicationUsers User { get; set; }

    }
}

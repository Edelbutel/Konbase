using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models.ApplicationCondominiumViewModels
{
    public class AddCondominiumViewModel
    {
        [Required(ErrorMessage = "Razão Social é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Razão Social")]
        public String CompanyName { get; set; }

        [Required(ErrorMessage = "Nome Fantasia é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Nome Fantasia")]
        public String FantasyName { get; set; }

        [Required(ErrorMessage = "CNPJ é um campo obrigatório")]
        [Display(Name = "CNPJ")]
        [RegularExpression(@"\d{2,3}.?\d{3}.?\d{3}/?\d{4}-?\d{2}", ErrorMessage = "CNPJ está em um formato inválido.")]
        public string Cnpj { get; set; }

        [Display(Name = "Data de Construação")]
        public Nullable<DateTime> ConstructionDate { get; set; }

        [Display(Name = "Tipo de Condomínio")]
        public string CondominiumType { get; set; }

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP está em um formato inválido.")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Display(Name = "Bairro")]
        public string District { get; set; }

        [Display(Name = "UF")]
        public string Uf { get; set; }

        [Display(Name = "Número")]
        public int Number { get; set; }

        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Display(Name = "Observação")]
        public string Note { get; set; }

        public List<EmailViewModel> Emails { get; set; } = new List<EmailViewModel>();

        public List<PhoneViewModel> Phones { get; set; } = new List<PhoneViewModel>();
    }
}

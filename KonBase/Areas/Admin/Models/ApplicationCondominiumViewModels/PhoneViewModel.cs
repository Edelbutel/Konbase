using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Admin.Models.ApplicationCondominiumViewModels
{
    public class PhoneViewModel
    {
        [Display(Name = "Telefone")]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Telefone está em um formato inválido.")]
        public string Phone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using N1Project.Entities.Tables;

namespace N1Project.Entities.Validations
{
    public class DepoValidator : AbstractValidator<Depo>

    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu alanı boş geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo Adı alanı boş geçilemez.");

        }
    }

}

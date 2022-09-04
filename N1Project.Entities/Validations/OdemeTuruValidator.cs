using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using N1Project.Entities.Tables;

namespace N1Project.Entities.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>

    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Türü Kodu alanı boş geçilemez.");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü Adı alanı boş geçilemez.");

        }
    }

}

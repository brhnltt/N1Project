using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using N1Project.Entities.Tables;

namespace N1Project.Entities.Validations
{
    public class CariValidator : AbstractValidator<Cari>

    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu alanı boş geçilemez.");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı alanı boş geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi alanı boş geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı alanı boş geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz E-mail adresi geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı alanı 0' küçük olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti alanı 0'dan küçük olamaz.");
        }
    }

}

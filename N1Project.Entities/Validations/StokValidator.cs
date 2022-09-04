using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using N1Project.Entities.Tables;

namespace N1Project.Entities.Validations
{
   public class StokValidator: AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu alanı boş geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı alanı boş geçilemez.").Length(5, 50).WithMessage("Stok Adı alanı 5 ile 50 karakter arasında olabilir.");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod Alanı boş geçilemez.");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 1 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 2 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı - 3 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 1 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 2 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı - 3 alanı 0'dan büyük olmalıdır.");

        }


    }
}

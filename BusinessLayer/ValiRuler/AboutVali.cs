using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValiRuler
{
    public class AboutVali : AbstractValidator<About>
    {
        public AboutVali()
        {
            RuleFor(x => x.Des).NotEmpty().WithMessage("Açıklama Kısmı Boş Geçilemez");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen Görsel Seçiniz");

            RuleFor(x => x.Des).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Veri Girişi Yapın");

            RuleFor(x => x.Des).MaximumLength(150).WithMessage("Lütfen En Fazla 120 Karakter Veri Girişi Yapın");

        }
    }
}

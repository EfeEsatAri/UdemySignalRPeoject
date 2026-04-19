using FluentValidation;
using SignalR.DtoLayer.BookingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.ValidationRules.BookingValidations
{
    public class CreateBookingValidation:AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x=>x.Phone).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email Alanı Boş Geçilemez");
            RuleFor(x=>x.PersonCount).NotEmpty().WithMessage("Kişi Sayısı Alanı Boş Geçilemez");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Rezervasyon Tarihi Alanı Boş Geçilemez");

            RuleFor(x=>x.Name).MinimumLength(5).WithMessage("Lütfen İsim Alanına En Az 5 Karakter Giriniz");
            RuleFor(x=>x.Name).MaximumLength(50).WithMessage("Lütfen İsim Alanına En Fazla 50 Karakter Giriniz");

            RuleFor(x=>x.Description).MaximumLength(500).WithMessage("Lütfen Açıklama Alanına En Fazla 500 Karakter Giriniz");

            RuleFor(x=>x.Mail).EmailAddress().WithMessage("Lütfen Geçerli Bir Email Adresi Giriniz");

        }
    }
}

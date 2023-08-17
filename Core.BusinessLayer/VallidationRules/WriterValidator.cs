using Core.Entity.Concrete;
using FluentValidation;

namespace Core.BusinessLayer.VallidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı ve soyadı boş geçilemez");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter giriniz");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en az iki karakter giriniz");
		}
	}
}

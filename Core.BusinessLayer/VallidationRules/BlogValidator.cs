using Core.Entity.Concrete;
using FluentValidation;

namespace Core.BusinessLayer.VallidationRules;

public class BlogValidator : AbstractValidator<Blog>
{
    public BlogValidator()
    {
        RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
        RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");
        RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
        RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("150 karaterden daha az bir giriş yapınız");
        RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("En az 5 karakter girişi yapmalısınız");
    }
}

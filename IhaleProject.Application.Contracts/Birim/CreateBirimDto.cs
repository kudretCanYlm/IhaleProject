using FluentValidation;

namespace IhaleProject.Application.Contracts.Birim
{
    public class CreateBirimDto
    {   
        public string BirimAdi { get; set; }
    }

    public class CreateBirimDtoValidator: AbstractValidator<CreateBirimDto>
    {
        public CreateBirimDtoValidator()
        {
            RuleFor(x => x.BirimAdi)
                .NotEmpty().WithMessage("Birim Adı boş olamaz")
                .NotNull().WithMessage("Birim Adı boş olamaz")
                .Length(1, 50).WithMessage("Birim Adı uzunluğu 1-50 karakter arası olmalı");
        }
    }
}

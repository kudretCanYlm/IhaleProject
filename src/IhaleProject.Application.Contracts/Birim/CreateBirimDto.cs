using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

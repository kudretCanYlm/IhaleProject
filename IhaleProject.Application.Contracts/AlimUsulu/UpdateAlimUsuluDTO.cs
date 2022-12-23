using FluentValidation;

namespace IhaleProject.Application.Contracts.AlimUsulu
{
	public class UpdateAlimUsuluDTO
	{
		public string AlimUsulu { get; set; }
	}

	public class UpdateAlimUsuluDTOValidator : AbstractValidator<UpdateAlimUsuluDTO>
	{
		public UpdateAlimUsuluDTOValidator()
		{
			RuleFor(x => x.AlimUsulu)
				.NotEmpty().WithMessage("Alım Usulu boş olamaz")
				.NotNull().WithMessage("Alım Usulu boş olamaz")
				.Length(1, 50).WithMessage("Alım Usulu uzunluğu 1-50 karakter arası olmalı");
		}
	}
}

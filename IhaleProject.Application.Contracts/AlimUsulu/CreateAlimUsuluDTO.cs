using FluentValidation;

namespace IhaleProject.Application.Contracts.AlimUsulu
{
	public class CreateAlimUsuluDTO
	{
		public string AlimUsulu { get; set; }
	}

	public class CreateAlimUsuluDTOValidator : AbstractValidator<CreateAlimUsuluDTO>
	{
		public CreateAlimUsuluDTOValidator()
		{
			RuleFor(x => x.AlimUsulu)
				.NotEmpty().WithMessage("Alım Usulu boş olamaz")
				.NotNull().WithMessage("Alım Usulu boş olamaz")
				.Length(1, 50).WithMessage("Alım Usulu boş olamaz");
		}
	}
}

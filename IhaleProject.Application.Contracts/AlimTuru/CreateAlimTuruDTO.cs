using FluentValidation;

namespace IhaleProject.Application.Contracts.AlimTuru
{
	public class CreateAlimTuruDTO
	{
		public string AlimTuru { get; set; }
	}

	public class CreateAlimTuruDTOValidator : AbstractValidator<CreateAlimTuruDTO>
	{
		public CreateAlimTuruDTOValidator()
		{
			RuleFor(x => x.AlimTuru)
				.NotEmpty().WithMessage("Alım Türü boş olamaz")
				.NotNull().WithMessage("Alım Türü boş olamaz")
				.Length(1, 50).WithMessage("Alım Türü uzunluğu 1-50 karakter arası olmalı");
		}
	}
}

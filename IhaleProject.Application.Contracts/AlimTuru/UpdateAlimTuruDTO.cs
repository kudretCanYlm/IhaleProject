using FluentValidation;

namespace IhaleProject.Application.Contracts.AlimTuru
{
	public class UpdateAlimTuruDTO
	{
		public string AlimTuru { get; set; }
	}

	public class UpdateAlimTuruDTOValidator : AbstractValidator<UpdateAlimTuruDTO>
	{
		public UpdateAlimTuruDTOValidator()
		{
			RuleFor(x => x.AlimTuru)
				.NotEmpty().WithMessage("Alim Türü boş olamaz")
				.NotNull().WithMessage("Alim Türü boş olamaz")
				.Length(1, 50).WithMessage("Alim Türü uzunluğu 1-50 karakter arası olmalı");
		}
	}
}

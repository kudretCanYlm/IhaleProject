using FluentValidation.Results;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
    public class BirimController : IhaleProjectControllerBase
    {
        private readonly IBirimAppService birimAppService;
		//will access with ICreateBirimDtoValidator interface
		private readonly CreateBirimDtoValidator birimValidator = new CreateBirimDtoValidator();


        public BirimController(IBirimAppService birimAppService)
        {
            this.birimAppService = birimAppService;
        }

        public async Task<IActionResult> Index()
        {
            //will add short fluent validation control
            var birimler = await birimAppService.GetAllAsync();

            return View(birimler);

        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateBirimDto birimDto)
        {
            var result = birimValidator.Validate(birimDto);

            if (result.IsValid)

            {
                await birimAppService.CreateAsync(birimDto);

                //will change
                return View();
            }

            else
            {
                foreach (ValidationFailure failer in result.Errors)
                {

                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);

                }

                //will change
                return View();
            }
        }
    }
}
using FluentValidation.Results;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Controllers;
using IhaleProject.Web.Models.Birim;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
    //[AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class BirimController : IhaleProjectControllerBase
    {
        private readonly IBirimAppService birimAppService;
        //will access with ICreateBirimDtoValidator interface
        private readonly CreateBirimDtoValidator createBirimValidator = new CreateBirimDtoValidator();
        private readonly UpdateBirimDtoValidator updateBirimValidator = new UpdateBirimDtoValidator();

        public BirimController(IBirimAppService birimAppService)
        {
            this.birimAppService = birimAppService;
        }

        public  IActionResult Index()
        {
            //will add short fluent validation control

            return View();

        }

        [HttpGet]
        public async Task<JsonResult> GetBirimler()
        {
            var birimler = await birimAppService.GetAllAsync();

            return Json(new BirimListViewModel()
            {
                Birims = birimler
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid Id)
        {
            await birimAppService.DeleteAsync(Id);

            return RedirectToAction(L(nameof(Index)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBirimDto createBirimDto)
        {
            //add vaidations
            var result = createBirimValidator.Validate(createBirimDto);

            if (result.IsValid)
            {
                await birimAppService.CreateAsync(createBirimDto);
            }

            else
            {
                foreach (ValidationFailure failer in result.Errors)
                {

                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);

                }

            }

            return RedirectToAction("Index");

        }
    }
}
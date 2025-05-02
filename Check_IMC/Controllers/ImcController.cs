using Check_IMC.Interfaces;
using Check_IMC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Check_IMC.Controllers
{
    public class ImcController : Controller
    {
        private readonly IImcService _imcService;

        public ImcController(IImcService imcService)
        {
            _imcService = imcService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ImcCalculator(ImcModel model)
        {
            var calculationResult = _imcService.CalculatingIMC(model);
            var imcResult = _imcService.ImcResult(calculationResult);

            return View("Result", imcResult);
        }
    }
}

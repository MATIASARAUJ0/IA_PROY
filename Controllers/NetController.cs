using Microsoft.AspNetCore.Mvc;
using MyMLApp;

namespace IA_PROY.Controllers
{
    public class NetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Analizar(string text)
        {
            Console.WriteLine(text);
            //Load sample data
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = text,
            };

            //Load model and predict output
            var result = SentimentModel.Predict(sampleData);

            Console.WriteLine(result.PredictedLabel);
            return View("Index", result);
        }

    }
}

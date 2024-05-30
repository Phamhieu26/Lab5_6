using Microsoft.AspNetCore.Mvc;

namespace TestWebAPI.Controllers
{
    public class PhuongTrinhBac2Controller : Controller
    {
        public IActionResult SolveTheX(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (a == 0 && b == 0 && c == 0)
                ViewData["result"] = "Phương trình vô số nghiệm";
            else if (discriminant < 0)
                ViewData["result"] = "Phương trình vô nghiệm";
            else
            {
                string requestUrl = @$"https://localhost:7126/api/Cau2/SolveQuadraticEquation?a={a}&b={b}&c={c}";

                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(requestUrl).Result;
                ViewData["result"] = response;
            }

            return View();
        }

    }
}

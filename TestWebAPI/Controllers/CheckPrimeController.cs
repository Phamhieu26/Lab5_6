using Microsoft.AspNetCore.Mvc;

namespace TestWebAPI.Controllers
{
    public class CheckPrimeController : Controller
    {
        public IActionResult Index(string listNumbers)
        {
            if (listNumbers==null)
            {
                ViewData["result"] = "chưa nhập giá trị";
            }
            else
            {
                string[] numbers = listNumbers.Split(" ");

                string requestUrl = @$"https://localhost:7126/api/Cau3/CheckPrimeNumbers?";
                foreach (var item in numbers)
                {
                    requestUrl += $"numbers={item}&";
                }

                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(requestUrl).Result;
                ViewData["result"] = response;

            }
            return View();
        }
    }
}

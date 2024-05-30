using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace TestWebAPI.Controllers
{
    public class CalInterestMonthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CalInterest(int months, long moneyFirst, double rateMonths)
        {
            if (months <= 0 || moneyFirst <= 0 || rateMonths <= 0)
                ViewData["result"] = "Invalid input. Please provide positive values.";

            else
            {
                string requestUrl = @$"https://localhost:7126/api/Cau1/CalculateCompoundInterest?months={months}&moneyFirst={moneyFirst}&rateMonths={rateMonths}";

                HttpClient client = new HttpClient();
                var response = client.GetStringAsync(requestUrl).Result;
                ViewData["result"] = response;
            }
            return View();
        }
    }
}
